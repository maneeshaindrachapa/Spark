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
using System.Text.RegularExpressions;

namespace Spark
{
    public partial class EditUserForm : Form
    {
        string username;


        bool telValidate = false;
        bool emailValidate = false;
        bool firstnameValidate = false;
        bool lastnameValidate = false;
        public EditUserForm()
        {
            InitializeComponent();
        }

        public void setUsername(string username)
        {
            this.username = username;
        }
        private void shutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void userdataload(string username)
        {
            try
            {
                //reading data from server and add them to combobox modelname
                           SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                sqlConn.Open();
                string query = "SELECT * FROM tbluser where username='" + username + "'";
                SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
                DataTable dtbl = new DataTable();
                data.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    foreach (DataRow row in dtbl.Rows)
                    {
                        usernameTB.Text = username;
                        firstnameTB.Text = row["firstname"].ToString();
                        lastnameTB.Text = row["lastname"].ToString();
                        emailTB.Text = row["email"].ToString();
                        telTB.Text = row["telephone"].ToString();
                    }
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void EditUserlbl_Click(object sender, EventArgs e)
        {
            if (emailValidate && firstnameValidate && lastnameValidate && telValidate)
            {
                editUserDone.Text = "Details Changed";
                editUserDone.ForeColor = System.Drawing.Color.Green;
                try
                {
                               SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                    sqlConn.Open();
                    string q1 = "UPDATE tbluser set firstname='" + firstnameTB.Text.ToString() + "',lastname='" + lastnameTB.Text.ToString() + "',email='" + emailTB.Text.ToString() + "',telephone='" + telTB.Text.ToString() + "' where username='" + usernameTB.Text.ToString() + "'";
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
                editUserDone.Text = "Please Fill All the Details";
                editUserDone.ForeColor = System.Drawing.Color.Red;
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

        private void editpasswordlbl_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changepassword = new ChangePasswordForm();
            changepassword.setusername(username);
            changepassword.ShowDialog();
        }
    }
}
