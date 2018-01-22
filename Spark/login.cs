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
    public partial class login : Form
    {
        Boolean passwordTextChange = false;
        public login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            passwordTextChange = true;
            this.checkCredentials.Visible = false;
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            //setting ms sql connection
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\Spark\Spark\spark_database.mdf;Integrated Security=True");
            string query = "SELECT * FROM tbluser where username='" + username + "'and password='" + password + "'";
            SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
            DataTable dtbl = new DataTable();
            data.Fill(dtbl);
            if (dtbl.Rows.Count != 0)
            {
                int type = 0;
                foreach (DataRow row in dtbl.Rows)
                {
                    type = Convert.ToInt16(row["type"].ToString());

                }
                if (type == 1)
                {
                    this.Hide();
                    //go to the view userForm
                    user userForm = new user();
                    userForm.setUsername(username);
                    userForm.ShowDialog();
                    this.Close();
                }
                else if (type == 2)
                {
                    //go to supplier
                    this.Hide();
                    supplier supplierform = new supplier();
                    supplierform.setUsername(username);
                    supplierform.ShowDialog();
                    this.Close();
                }
                else if (type == 3)
                {
                    //go to admin
                    this.Hide();
                    admin admin = new admin();
                    admin.setUsername(username);
                    admin.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                this.checkCredentials.Visible = true;
            }

        }

        private void viewPassword_Click(object sender, EventArgs e)
        {
            if (passwordTextChange)
            {
                txtPassword.PasswordChar = '\0';
                passwordTextChange = false;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                passwordTextChange = true;
            }
        }

        private void minimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
