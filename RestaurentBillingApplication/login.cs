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

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=MAG\SQLEXPRESS;Initial Catalog=RestaurentDB;Integrated Security=True");
        private void LoginButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (loginEmailBox.Text == "" || loginPasswordBox.Text == "")
                {
                    MessageBox.Show("email or password field can't be empty", "Fields can't be empty");
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE email=@email", Conn);
                cmd.Parameters.AddWithValue("@email", loginEmailBox.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                int x = ds.Tables[0].Rows.Count;
                string pass = ds.Tables[0].Rows[0]["password"].ToString();
                if (x > 0 && BCrypt.Net.BCrypt.EnhancedVerify(loginPasswordBox.Text, pass))
                {
                    UserInfo.userId = (int)ds.Tables[0].Rows[0]["id"];
                    MessageBox.Show("Login Successfully completed", "Login Success");
                    int role = int.Parse(ds.Tables[0].Rows[0]["roleid"].ToString());
                    switch (role)
                    {
                        case 1:
                            break;
                        case 2:
                            this.Hide();
                            MDashboard form = new MDashboard();
                            form.Show();
                            break;
                        case 3:
                            this.Hide();
                            SDashboard port = new SDashboard();
                            port.Show();
                            break;

                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password, please try again", "Login Failed");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Login Failed");

            }
            Conn.Close();
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signup page = new signup();
            page.Show();
        }
    }
}
