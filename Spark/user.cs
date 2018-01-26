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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
            //load comboboxes with the part types and car models
            loadBrandnameCB();
            loadparttypeCB();
        }

        public void setUsername(string username) //set username in username label
        {
            this.username.Text = username;
        }
        //select comboboxes brandname,car model, part types
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
                foreach (DataRow row in dtbl.Rows)
                {
                    brandnameCB.Items.Add(row["carBrand"].ToString());
                }

            }
            catch (SqlException error)
            {
                //MessageBox.Show(error.Message);
            }
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
                //MessageBox.Show(error.Message);
            }
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
                string query = "SELECT * from Modelname where carBrand='" + brandnameCB.GetItemText(brandnameCB.SelectedItem) + "'"; SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
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

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                //reading data from server and add them to combobox brandname
                           SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                sqlConn.Open();
                string query = "SELECT * FROM carParts where carBrand='" + brandnameCB.GetItemText(brandnameCB.SelectedItem) + "'and carModel='" + modelnameCB.GetItemText(modelnameCB.SelectedItem) + "'and carPartName='" + parttypeCB.GetItemText(parttypeCB.SelectedItem) + "'";
                SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
                DataTable dtbl = new DataTable();
                data.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    foreach (DataRow row in dtbl.Rows)
                    {

                        searchResult1.Text = "Car Brand";
                        brandnametxt.Text = row["carBrand"].ToString();

                        searchResult2.Text = "Car Model";
                        modelnametxt.Text = row["carModel"].ToString();

                        searchResult3.Text = "Part Type";
                        parttypetxt.Text = row["carPartName"].ToString();

                        searchResult4.Text = "Price";
                        pricetxt.Text = row["price"].ToString();

                        searchResult5.Text = "Stock Size";
                        stocktxt.Text = row["stock"].ToString();
                        addToCart.Visible = true;
                        if (row["stock"].ToString() == "0")
                        {
                            stocktxt.Text = "Not Availble in Stock";
                            addToCart.Visible = false;
                        }

                        noOfParts.Text = "No of Parts";
                        partNumBx.Visible = true;
                        partNumBx.Maximum = Convert.ToInt16(row["stock"].ToString());


                    }
                }
                else
                {
                    searchResult1.Text = "Not Available";
                    brandnametxt.Text = "";
                    searchResult2.Text = "";
                    modelnametxt.Text = "";
                    searchResult3.Text = "";
                    parttypetxt.Text = "";
                    searchResult4.Text = "";
                    stocktxt.Text = "";
                    searchResult5.Text = "";
                    pricetxt.Text = "";
                    noOfParts.Text = "";

                    addToCart.Visible = false;
                    partNumBx.Visible = false;
                }

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //add to cart
        private void addToCart_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt16(partNumBx.Value);
            if (dataGrid.Rows.Count == 1)
            {
                dataGrid.Rows.Add(brandnametxt.Text, modelnametxt.Text, parttypetxt.Text, pricetxt.Text, temp);
                partNumBx.Maximum = Convert.ToInt16(stocktxt.Text) - temp;
                partNumBx.Value = 0;
            }
            else
            {
                for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
                {
                    if (dataGrid.Rows[i].Cells[0].Value.ToString() == brandnametxt.Text && dataGrid.Rows[i].Cells[1].Value.ToString() == modelnametxt.Text && dataGrid.Rows[i].Cells[2].Value.ToString() == parttypetxt.Text)
                    {
                        dataGrid.Rows[i].Cells[4].Value = Convert.ToInt16(dataGrid.Rows[i].Cells[4].Value) + temp;
                        partNumBx.Maximum = Convert.ToInt16(stocktxt.Text) - temp;
                        partNumBx.Value = 0;
                        break;
                    }
                    if (dataGrid.Rows.Count - 1 == i)
                    {
                        MessageBox.Show("ll");
                        dataGrid.Rows.Add(brandnametxt.Text, modelnametxt.Text, parttypetxt.Text, pricetxt.Text, temp);
                        partNumBx.Maximum = Convert.ToInt16(stocktxt.Text) - temp;
                        partNumBx.Value = 0;
                        break;
                    }
                }
            }
        }

        private void deleteRowlbl_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                dataGrid.Rows.RemoveAt(dataGrid.SelectedRows[0].Index);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            logoutlbl1.Visible = !(logoutlbl1.Visible);
        }

        private void logoutlbl1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
            this.Close();
        }

        private void checkoutlbl_Click(object sender, EventArgs e)
        {
            checkout1.Visible = false;
            if (dataGrid.Rows.Count > 1)
            {
                this.Hide();
                Checkout checkout = new Checkout();
                checkout.setGrid(this.dataGrid);
                checkout.setUsername(this.username.Text);
                checkout.ShowDialog();
                this.Close();
            }
            else
            {
                checkout1.Visible = true;
            }
        }

        //set grid
        public void setDataGrid(DataGridView datagrid)
        {
            for (int i = 0; i < datagrid.Rows.Count - 1; i++)
            {
                this.dataGrid.Rows.Add(datagrid.Rows[i].Cells[0].Value.ToString(), datagrid.Rows[i].Cells[1].Value.ToString(), datagrid.Rows[i].Cells[2].Value.ToString(), datagrid.Rows[i].Cells[3].Value.ToString(), datagrid.Rows[i].Cells[4].Value.ToString());
            }
        }

        private void goBacklbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplier supplierform = new supplier();
            this.setUsername(username.Text);
            supplierform.ShowDialog();
            this.Close();
        }

        public void goBacklbl_visible()
        {
            goBacklbl.Visible = true;
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
