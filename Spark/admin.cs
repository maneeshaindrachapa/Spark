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

            //load brandnames to add
            addloadBrandnameCB();
        }
        bool addBrandNameValidate = false;
        bool addpartValidate = false;
        bool addModelNameValidate = false;

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
            pricechangedNotification.Visible = false;
            discountChangedlbl.Visible = false;
            try
            {
                //reading data from server and add them to combobox modelname
                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                sqlConn.Open();
                string query = "SELECT * from Modelname where carBrand='"+ brandnameCB.GetItemText(brandnameCB.SelectedItem) + "'";
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
                        changePricelbl.Visible = true;

                        discountlLBL.Text = "Discount Rate (%)";
                        discountTB.Text = row["discountRate"].ToString();
                        discountTB.Visible = true;
                        changeDiscountbtn.Visible = true;
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
                    discountlLBL.Text = "";
                    discountTB.Visible = false;
                    changePricelbl.Visible = false;
                    changeDiscountbtn.Visible = false;
                    discountChangedlbl.Visible = false;
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
                brandnameaddTB.ResetText();
                addBrandNameValidate = false;

                addloadBrandnameCB(); //to load added brand name to the admin
                loadBrandnameCB();
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
        //add part to the database
        private void addpartSubmit_Click(object sender, EventArgs e)
        {
            if (addpartValidate)
            {
                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                sqlConn.Open();
                string query = "INSERT INTO parts(partName) values('" + addpartTB.ToString() + "')";
                SqlCommand data = new SqlCommand(query, sqlConn);
                data.ExecuteNonQuery();
                addpartTB.ResetText();
                MessageBox.Show("Car Part Added");
                addpartValidate = false;

                loadparttypeCB();//load o the combo boxes the new parts
            }
            else
            {
                MessageBox.Show("This Car Part is Already Added");
            }
        }
        
        //model name brandname combobox load
        private void addloadBrandnameCB()
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
                    modelchangebrandnamecmb.Items.Add(row["carBrand"].ToString());
                }

            }
            catch (SqlException error)
            {
                //MessageBox.Show(error.Message);
            }
        }

        private void addmodelTB_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
            sqlConn.Open();
            string query = "SELECT * from Modelname where carBrand='" + modelchangebrandnamecmb.GetItemText(brandnameCB.SelectedItem) + "'and carModel='"+ addmodelTB.Text.ToString()+ "'";
            SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
            DataTable dtbl = new DataTable();
            data.Fill(dtbl);
            if (dtbl.Rows.Count != 0)
            {
                addmodelValid.Text = "Invaild";
                addmodelValid.ForeColor = System.Drawing.Color.Red;
                addModelNameValidate = false;
            }
            else
            {
                addModelNameValidate = true;
                addmodelValid.Text = "Valid";
                addmodelValid.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void modelSubmit_Click(object sender, EventArgs e)
        {
            if (addModelNameValidate)
            {
                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                sqlConn.Open();
                string query = "INSERT INTO Modelname(carBrand,carModel) values('" + modelchangebrandnamecmb.GetItemText(brandnameCB.SelectedItem) + "','"+addmodelTB.Text.ToString()+"')";
                SqlCommand data = new SqlCommand(query, sqlConn);
                data.ExecuteNonQuery();
                addpartTB.ResetText();
                MessageBox.Show("Car Model Added");
                addModelNameValidate = false;
            }
            else
            {
                MessageBox.Show("This Car Model is Already Added");
            }
        }

        //change price of a perticular part
        private void changePricelbl_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                sqlConn.Open();
                string query = "UPDATE carParts set price='" + priceTB.Text.ToString() + "' where carBrand='" + brandnametxt.Text.ToString() + "'and carModel='" + modelnametxt.Text.ToString() + "' and carPartName='" + parttypetxt.Text.ToString() + "'";
                SqlCommand data = new SqlCommand(query, sqlConn);
                data.ExecuteNonQuery();
                pricechangedNotification.Visible = true;
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        //change discount rate of a perticular part
        private void changeDiscountbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                sqlConn.Open();
                string query = "UPDATE carParts set discountRate='" + discountTB.Text.ToString() + "' where carBrand='" + brandnametxt.Text.ToString() + "'and carModel='" + modelnametxt.Text.ToString() + "' and carPartName='" + parttypetxt.Text.ToString() + "'";
                SqlCommand data = new SqlCommand(query, sqlConn);
                data.ExecuteNonQuery();
                discountChangedlbl.Visible = true;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
