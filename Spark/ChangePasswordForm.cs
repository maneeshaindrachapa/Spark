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
    public partial class ChangePasswordForm : Form
    {
        string username;
        bool currentpasswordTextChange = false;
        bool newpasswordTextChanged = false;
        bool retypepasswordTextChanged = false;

        public ChangePasswordForm()
        {
            InitializeComponent();
            currentP.PasswordChar = '*';
            newP.PasswordChar = '*';
            retypeP.PasswordChar = '*';

            newpasswordTextChanged = true;
            retypepasswordTextChanged = true;
            currentpasswordTextChange = true;
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewPassword_Click(object sender, EventArgs e)
        {
            if (currentpasswordTextChange)
            {
                currentP.PasswordChar = '\0';
                currentpasswordTextChange = false;
            }
            else
            {
                currentP.PasswordChar = '*';
                currentpasswordTextChange = true;
            }
        }

        private void viewnewpassword_Click(object sender, EventArgs e)
        {
            if (newpasswordTextChanged)
            {
                newP.PasswordChar = '\0';
                newpasswordTextChanged = false;
            }
            else
            {
                newP.PasswordChar = '*';
                newpasswordTextChanged = true;
            }
        }

        private void viewretypepassword_Click(object sender, EventArgs e)
        {
            if (retypepasswordTextChanged)
            {
                retypeP.PasswordChar = '\0';
                retypepasswordTextChanged = false;
            }
            else
            {
                retypeP.PasswordChar = '*';
                retypepasswordTextChanged = true;
            }
        }
        //set username
        public void setusername(string username)
        {
            this.username = username;
        }

        private void changepasswordlbl_Click(object sender, EventArgs e)
        {
            string password = "";
            try
            {
                           SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
                sqlConn.Open();
                string query = "SELECT password from tbluser where username='" + username + "'";
                SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
                DataTable dtbl = new DataTable();
                data.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    foreach (DataRow row in dtbl.Rows)
                    {
                        password = row["password"].ToString();
                    }
                    if (currentP.Text.ToString() == password)
                    {
                        if (newP.Text.Length > 8)
                        {
                            if (newP.Text.ToString() == retypeP.Text.ToString())
                            {
                                string q1 = "UPDATE tbluser SET password='" + newP.Text.ToString() + "'where username='" + username + "'";
                                SqlCommand cmd = new SqlCommand(q1, sqlConn);
                                cmd.ExecuteNonQuery();

                                allValid.Text = "Password Changed Successful";
                                allValid.ForeColor = System.Drawing.Color.Green;
                            }
                            else
                            {
                                allValid.Text = "New Password Doesnot match";
                                allValid.ForeColor = System.Drawing.Color.Red;
                            }
                        }
                        else
                        {
                            allValid.Text = "Password atleast contain 8 characters";
                            allValid.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    else
                    {
                        allValid.Text = "Old Password is Incorrect";
                        allValid.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("There is an Error,Conecting to the Database");
            }
        }
    }
}
