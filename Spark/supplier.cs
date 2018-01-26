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
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
            //load adding values
            loadparttypeCB();
            loadBrandnameCB();
        }
        Bitmap bitmap;

        bool additemModel = false;
        bool additemPart = false;

        private void logout_Click(object sender, EventArgs e)
        {
            logoutlbl1.Visible = !(logoutlbl1.Visible);
        }

        private void logoutlbl1_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            this.Dispose();
        }
        public void setUsername(string username) //set username in username label
        {
            this.username.Text = username;
        }
        private void loadparttypeCB()
        {
            try
            {
                //reading data from server and add them to combobox brandname
                           SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                sqlConn.Open();
                string query = "SELECT partName FROM parts";
                SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
                DataTable dtbl = new DataTable();
                data.Fill(dtbl);
                foreach (DataRow row in dtbl.Rows)
                {
                    parttypeCB.Items.Add(row["partName"].ToString());
                }

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void loadBrandnameCB()
        {
            try
            {
                //reading data from server and add them to combobox brandname
                           SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                sqlConn.Open();


                string query = "SELECT carBrand FROM carBrands";
                SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
                DataTable dtbl = new DataTable();
                data.Fill(dtbl);
                sqlConn.Close();
                foreach (DataRow row in dtbl.Rows)
                {
                    brandnameCB.Items.Add(row["carBrand"].ToString());
                }

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void addItemLbl_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
            sqlConn.Open();

            //starting transaction
            string q = "BEGIN TRANSACTION";
            SqlCommand cmd1 = new SqlCommand(q, sqlConn);
            cmd1.ExecuteNonQuery();

            int stock = 0;
            string query = "SELECT * from carParts where carBrand='" + brandnameCB.GetItemText(brandnameCB.SelectedItem.ToString()) + "' and carModel='" + modelnameCB.GetItemText(modelnameCB.SelectedItem.ToString()) + "' and carPartName='" + parttypeCB.GetItemText(parttypeCB.SelectedItem.ToString()) + "'";
            SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
            DataTable dtbl = new DataTable();

            data.Fill(dtbl);


            DateTime date = DateTime.Now;


            if (dtbl.Rows.Count != 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    stock += Convert.ToInt16(row["stock"].ToString());
                }

                //without admin permission to update the car parts
                /*stock += Convert.ToInt16(quantityNUD.Value.ToString());
                string query2 = "UPDATE carParts set stock=" + stock + "where carBrand='" + brandnameCB.GetItemText(brandnameCB.SelectedItem.ToString()) + "'and carModel='" + modelnameCB.GetItemText(modelnameCB.SelectedItem.ToString()) + "'and carPartName='" + parttypeCB.GetItemText(parttypeCB.SelectedItem.ToString()) + "'";
                SqlCommand data2 = new SqlCommand(query2, sqlConn);
                data2.ExecuteNonQuery();*/



                string query3 = "INSERT INTO supplierDetails(username,brandname,modelname,partname,quantity,price,date) values('" + username.Text + "','" + brandnameCB.GetItemText(brandnameCB.SelectedItem.ToString()) + "','" + modelnameCB.GetItemText(modelnameCB.SelectedItem.ToString()) + "','" + parttypeCB.GetItemText(parttypeCB.SelectedItem.ToString()) + "','" + quantityNUD.Value.ToString() + "','" + priceNUD.Value.ToString() + "','" + date.ToShortDateString() + "')";
                SqlCommand data3 = new SqlCommand(query3, sqlConn);
                data3.ExecuteNonQuery();

            }
            else
            {
                //without admin pemission to update carparts
                /*string query5 = "INSERT INTO carParts(carBrand,carModel,carPartName,stock) VALUES('"+ brandnameCB.GetItemText(brandnameCB.SelectedItem.ToString()) + "','" + modelnameCB.GetItemText(modelnameCB.SelectedItem.ToString()) + "','" + parttypeCB.GetItemText(parttypeCB.SelectedItem.ToString()) + "','" + quantityNUD.Value.ToString() + "')";
                SqlCommand data5 = new SqlCommand(query5, sqlConn);
                data5.ExecuteNonQuery();*/

                string query4 = "INSERT INTO supplierDetails(username,brandname,modelname,partname,quantity,price,date) values('" + username.Text + "','" + brandnameCB.GetItemText(brandnameCB.SelectedItem.ToString()) + "','" + modelnameCB.GetItemText(modelnameCB.SelectedItem.ToString()) + "','" + parttypeCB.GetItemText(parttypeCB.SelectedItem.ToString()) + "','" + quantityNUD.Value.ToString() + "','" + priceNUD.Value.ToString() + "','" + date.ToShortDateString() +"')";
                SqlCommand data4 = new SqlCommand(query4, sqlConn);
                data4.ExecuteNonQuery();
            }

            //end transation
            string q1 = "COMMIT";
            SqlCommand cmd2 = new SqlCommand(q1, sqlConn);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Item Added");

            //clear fields
            brandnameCB.ResetText();
            modelnameCB.ResetText();
            parttypeCB.ResetText();
            priceNUD.Value = 0;
            quantityNUD.Value = 0;


            loadGrid();
            //database carParts has to updatade add new table for supplier details and the add to part one*/

            additemModel = false;
            additemPart = false;
            addItemLbl.Visible = false;
            addIteNE.Visible = true;
        }

        private void brandnameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelnameCB.Items.Clear();
            modelnameCB.ResetText();
            try
            {
                //reading data from server and add them to combobox modelname
                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                sqlConn.Open();
                string query = "SELECT * from Modelname where carBrand='" + brandnameCB.GetItemText(brandnameCB.SelectedItem) + "'";
                SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
                DataTable dtbl = new DataTable();
                data.Fill(dtbl);
                foreach (DataRow row in dtbl.Rows)
                {
                    modelnameCB.Items.Add(row["carModel"].ToString());
                }

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        public void loadGrid()
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
            sqlConn.Open();

            string query = "SELECT * from supplierDetails where username='" + username.Text + "'";
            SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
            DataTable dtbl = new DataTable();

            data.Fill(dtbl);
            foreach (DataRow row in dtbl.Rows)
            {
                transactionDG.Rows.Add(row["brandname"], row["modelname"], row["partname"], row["quantity"], row["Date"], row["price"], row["paidValue"]);
            }

        }

        private void modelnameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            additemModel = true;
            if (additemModel && additemPart)
            {
                addIteNE.Visible = false;
                addItemLbl.Visible = true;
            }
        }

        private void parttypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            additemPart = true;
            if (additemModel && additemPart)
            {
                addIteNE.Visible = false;
                addItemLbl.Visible = true;
            }
        }

        private void buyPartslbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            user userform = new user();
            userform.setUsername(username.Text);
            userform.goBacklbl_visible();
            userform.ShowDialog();
            this.Close();
        }

        private void print_Click(object sender, EventArgs e)
        {
            //Data grid view Size
            int height = transactionDG.Height;
            transactionDG.Height = (transactionDG.Rows.Count * transactionDG.RowTemplate.Height) + transactionDG.ColumnHeadersHeight;

            bitmap = new Bitmap(this.transactionDG.Width, this.transactionDG.Height);
            transactionDG.DrawToBitmap(bitmap, new Rectangle(0, 0, this.transactionDG.Width, this.transactionDG.Height));

            //setting height to the normal
            transactionDG.Height = height;

            //print preview
            supplierDetailsPreviewDialog.Document = supplierDetailsPrint;
            supplierDetailsPreviewDialog.PrintPreviewControl.Zoom = 1;
            supplierDetailsPreviewDialog.ShowDialog();
        }

        private void supplierDetailsPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //print page
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void loadDatalbl_Click(object sender, EventArgs e)
        {
            this.transactionDG.Rows.Clear();
            loadGrid();
        }

        private void editUsericon_Click(object sender, EventArgs e)
        {
            edituserlbl.Visible = !(edituserlbl.Visible);
        }

        private void edituserlbl_Click(object sender, EventArgs e)
        {
            EditUserForm edituserform = new EditUserForm();
            edituserform.setUsername(this.username.Text);
            edituserform.userdataload(this.username.Text);
            edituserform.ShowDialog();
        }
    }
}
