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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            //load comboboxes with the part types and car models
            loadBrandnameCB();
            loadparttypeCB();
        }
        bool addBrandNameValidate = false;
        bool addpartValidate = false;
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
        //set username
        public void setUsername(string username)
        {
            usernamelbl.Text = username;
        }

        private void addusericon_Click(object sender, EventArgs e)
        {
            addsuppplierlbl.Visible = !(addsuppplierlbl.Visible);
        }

        private void addsuppplierlbl_Click(object sender, EventArgs e)
        {
            addUserForm adduser = new addUserForm();
            adduser.ShowDialog();
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
                string query = "SELECT carModel FROM carBrands left join carParts on carBrands.carBrand=carParts.carBrand where carParts.carBrand='" + brandnameCB.GetItemText(brandnameCB.SelectedItem) + "'group by carModel";
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
                        priceTB.Text = row["price"].ToString();
                        priceTB.Visible = true;

                        searchResult5.Text = "Stock Size";
                        stocktxt.Text = row["stock"].ToString();
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
                    priceTB.Text = "";
                    priceTB.Visible = false;
                }

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //add a brandname
        private void brandnameaddTB_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
            sqlConn.Open();
            string query = "SELECT * FROM carBrands where carBrand='" + brandnameaddTB.Text + "'";
            SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
            DataTable dtbl = new DataTable();
            data.Fill(dtbl);
            if (dtbl.Rows.Count != 0)
            {
                validBrandname.Text = "Invaild";
                validBrandname.ForeColor = System.Drawing.Color.Red;
                addBrandNameValidate = false;
            }
            else
            {
                addBrandNameValidate = true;
                validBrandname.Text = "Valid";
                validBrandname.ForeColor = System.Drawing.Color.Green;
            }
        }
        //add new brandname to the database
        private void submitBrandname_Click(object sender, EventArgs e)
        {
            if (addBrandNameValidate)
            {
                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                sqlConn.Open();
                string query = "INSERT INTO carBrands(carBrand) values('" + brandnameaddTB.ToString() + "')";
                SqlCommand data = new SqlCommand(query, sqlConn);
                data.ExecuteNonQuery();
                MessageBox.Show("Car Brand Added");
                addBrandNameValidate = false;
            }
            else
            {
                MessageBox.Show("This Brandname Already Added");
            }
        }

        //add part validate 
        private void addpartTB_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
            sqlConn.Open();
            string query = "SELECT * FROM parts where partName='" + addpartTB.Text + "'";
            SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
            DataTable dtbl = new DataTable();
            data.Fill(dtbl);
            if (dtbl.Rows.Count != 0)
            {
                addpartValid.Text = "Invaild";
                addpartValid.ForeColor = System.Drawing.Color.Red;
                addpartValidate = false;
            }
            else
            {
                addpartValidate = true;
                addpartValid.Text = "Valid";
                addpartValid.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}
