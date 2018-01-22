using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Spark
{
    public partial class Checkout : Form
    {
        string username = "";
        double total = 0.00;
        double paid = 0.00;
        Bitmap bitmap;
        public Checkout()
        {
            InitializeComponent();
        }

        public void setGrid(DataGridView datagrid)
        {
            for (int i = 0; i < datagrid.Rows.Count - 1; i++)
            {
                checkoutDataGrid.Rows.Add(datagrid.Rows[i].Cells[0].Value.ToString(), datagrid.Rows[i].Cells[1].Value.ToString(), datagrid.Rows[i].Cells[2].Value.ToString(), datagrid.Rows[i].Cells[3].Value.ToString(), datagrid.Rows[i].Cells[4].Value.ToString());
            }
        }
        public void setUsername(string username)
        {
            this.username = username;
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            user userform = new user();
            userform.setUsername(username);
            userform.setDataGrid(this.checkoutDataGrid);
            userform.ShowDialog();
            this.Close();
        }

        private void calPrice_Click(object sender, EventArgs e)
        {
            total = 0.00;
            for (int i = 0; i < checkoutDataGrid.Rows.Count - 1; i++)
            {
                total += Convert.ToDouble(checkoutDataGrid.Rows[i].Cells[3].Value.ToString()) * Convert.ToInt16(checkoutDataGrid.Rows[i].Cells[4].Value.ToString());
            }
            calculatePrice.Text = total.ToString();
            pricePaidCal.Visible = true;
        }

        private void pricePaidCal_Click(object sender, EventArgs e)
        {
            paid = Convert.ToDouble(paidnbx.Value);
            paidLbl.Text = paid.ToString();

            if (paid >= total)
            {
                confirmPay.Visible = true;
                confirmpay1.Visible = false;
            }
            balance.Text = (paid - total).ToString();
        }

        private void confirmPay_Click(object sender, EventArgs e)
        {
            try
            {
                           SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                sqlConn.Open();


                //starting transaction
                string q = "BEGIN TRANSACTION";
                SqlCommand cmd1 = new SqlCommand(q, sqlConn);
                cmd1.ExecuteNonQuery();

                for (int i = 0; i < checkoutDataGrid.Rows.Count - 1; i++)
                {
                    //insert into payments table
                    int stock = 0;
                    string query = "INSERT INTO payments(carBrand, carModel, partName, quantity, price) VALUES('" + checkoutDataGrid.Rows[i].Cells[0].Value.ToString() + "','" + checkoutDataGrid.Rows[i].Cells[1].Value.ToString() + "','" + checkoutDataGrid.Rows[i].Cells[2].Value.ToString() + "','" + checkoutDataGrid.Rows[i].Cells[3].Value.ToString() + "','" + checkoutDataGrid.Rows[i].Cells[4].Value.ToString() + "')";
                    SqlCommand data = new SqlCommand(query, sqlConn);
                    data.ExecuteNonQuery();

                    //updating the stocks after the payments
                    string query1 = "SELECT stock from carParts where carBrand='" + checkoutDataGrid.Rows[i].Cells[0].Value.ToString() + "'and carModel='" + checkoutDataGrid.Rows[i].Cells[1].Value.ToString() + "'and carPartName='" + checkoutDataGrid.Rows[i].Cells[2].Value.ToString() + "'";
                    SqlDataAdapter data1 = new SqlDataAdapter(query1, sqlConn);
                    DataTable dtbl = new DataTable();
                    data1.Fill(dtbl);
                    foreach (DataRow row in dtbl.Rows)
                    {
                        stock = Convert.ToInt16(row["stock"].ToString());

                    }
                    stock -= Convert.ToInt16(checkoutDataGrid.Rows[i].Cells[4].Value.ToString());

                    string query2 = "UPDATE carParts set stock='" + stock + "'where carBrand='" + checkoutDataGrid.Rows[i].Cells[0].Value.ToString() + "'and carModel='" + checkoutDataGrid.Rows[i].Cells[1].Value.ToString() + "'and carPartName='" + checkoutDataGrid.Rows[i].Cells[2].Value.ToString() + "'";
                    SqlCommand data2 = new SqlCommand(query2, sqlConn);
                    data2.ExecuteNonQuery();
                }

                //end transationc
                string q1 = "COMMIT";
                SqlCommand cmd2 = new SqlCommand(q1, sqlConn);
                cmd2.ExecuteNonQuery();

                //print the bill
                //Data grid view Size
                int height = checkoutDataGrid.Height;
                checkoutDataGrid.Height = (checkoutDataGrid.Rows.Count * checkoutDataGrid.RowTemplate.Height) + checkoutDataGrid.ColumnHeadersHeight;

                bitmap = new Bitmap(this.checkoutDataGrid.Width, this.checkoutDataGrid.Height);
                checkoutDataGrid.DrawToBitmap(bitmap, new Rectangle(0, 0, this.checkoutDataGrid.Width, this.checkoutDataGrid.Height));

                //setting height to the normal
                checkoutDataGrid.Height = height;

                //print preview
                checkoutPreviewDialog.Document = checkoutDocument;
                checkoutPreviewDialog.PrintPreviewControl.Zoom = 1;
                checkoutPreviewDialog.ShowDialog();


                this.Hide();
                user userform = new user();
                userform.setUsername(username);
                userform.ShowDialog();
                this.Close();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void checkoutDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
