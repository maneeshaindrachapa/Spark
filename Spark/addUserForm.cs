using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace Spark
{
    public partial class addUserForm : Form
    {
        //validations
        bool telValidate = false;
        bool emailValidate = false;
        bool usernameValidate = false;
        bool firstnameValidate = false;
        bool lastnameValidate = false;
        bool typeValidate = false;

        public addUserForm()
        {
            InitializeComponent();
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //setting ms sql connection
                           SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                sqlConn.Open();

                //check that index no is alreadyin db
                string query = "SELECT * FROM tbluser where username='" + usernameTB.Text + "'";
                SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
                DataTable dtbl = new DataTable();
                data.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    usernameVal.Text = "Invaild";
                    usernameVal.ForeColor = System.Drawing.Color.Red;
                    usernameValidate = false;
                }
                else
                {
                    usernameValidate = true;
                    usernameVal.Text = "Valid";
                    usernameVal.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("There is an Error,Conecting to the Database");
            }
        }

        private void firstnameTB_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(firstnameTB.Text, @"^[\p{L}\p{M}']+$").Success)
            {
                firstnameVal.Text = "Invaild";
                firstnameVal.ForeColor = System.Drawing.Color.Red;
                firstnameValidate = false;
            }
            else
            {
                firstnameVal.Text = "Valid";
                firstnameVal.ForeColor = System.Drawing.Color.Green;
                firstnameValidate = true;
            }
        }

        private void lastnameTB_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(lastnameTB.Text, @"^[\p{L}\p{M}']+$").Success)
            {
                lastnameVal.Text = "Invaild";
                lastnameVal.ForeColor = System.Drawing.Color.Red;
                lastnameValidate = false;
            }
            else
            {
                lastnameVal.Text = "Valid";
                lastnameVal.ForeColor = System.Drawing.Color.Green;
                lastnameValidate = true;
            }
        }

        private void emailTB_TextChanged(object sender, EventArgs e)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(emailTB.Text.ToString(), expresion))
            {
                if (Regex.Replace(emailTB.Text.ToString(), expresion, string.Empty).Length == 0)
                {
                    emailValidate = true;
                    emailVal.Text = "Valid";
                    emailVal.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    emailValidate = false;
                    emailVal.Text = "Invalid";
                    emailVal.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                emailValidate = false;
                emailVal.Text = "Invalid";
                emailVal.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void addUserlbl_Click(object sender, EventArgs e)
        {
            if (usernameValidate && emailValidate && firstnameValidate && lastnameValidate && telValidate && typeValidate)
            {
                allValid.Text = "User Added";
                allValid.ForeColor = System.Drawing.Color.Green;
                try
                {
                    string typeUser = "";
                    if (typeCMB.SelectedIndex == 0)
                    {
                        typeUser = "2";
                    }
                    else
                    {
                        typeUser = "1";
                    }

                               SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                    sqlConn.Open();
                    string q1 = "INSERT INTO tbluser(username,password,firstname,lastname,telephone,email,type) values('" + usernameTB.Text.ToString() + "','" + Convert.ToString(123) + "','" + firstnameTB.Text.ToString() + "','" + lastnameTB.Text.ToString() + "','" + telTB.Text.ToString() + "','" + emailTB.Text.ToString() + "','" + typeUser + "')";
                    SqlCommand cmd2 = new SqlCommand(q1, sqlConn);
                    cmd2.ExecuteNonQuery();

                    //reset all the fields
                    usernameTB.ResetText();
                    firstnameTB.ResetText();
                    lastnameTB.ResetText();
                    emailTB.ResetText();
                    telTB.ResetText();
                }
                catch (SqlException)
                {
                    MessageBox.Show("There is an Error,Conecting to the Database");
                }
            }
            else
            {
                allValid.Text = "Please Fill All the Details";
                allValid.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void typeCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeCMB.SelectedIndex > -1)
            {
                typeValidate = true;
                typeSelect.Text = "Valid";
                typeSelect.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                typeValidate = false;
                typeSelect.Text = "Invalid";
                typeSelect.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void telTB_TextChanged(object sender, EventArgs e)
        {
            Regex validator = new Regex("(0|1|2|3|4|5|6|7|8|9){1}[0-9]{9}");
            string match = validator.Match(telTB.Text).Value.ToString();
            if (match.Length == 10)
            {
                telValidate = true;
                telVal.Text = "Valid";
                telVal.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                telValidate = false;
                telVal.Text = "Invalid";
                telVal.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
