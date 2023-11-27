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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }
        private void signup_Load(object sender, EventArgs e)
        {
            FillCombo("role", "roleName", "id", rolecombo);

        }

        SqlConnection Conn = new SqlConnection(@"Data Source=MAG\SQLEXPRESS;Initial Catalog=RestaurentDB;Integrated Security=True");

        private void registerBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string FullName = fullNameBox.Text;
                string Email = emailBox.Text;
                string Password = BCrypt.Net.BCrypt.EnhancedHashPassword(passwordBox.Text, 13);
                int role = rolecombo.SelectedIndex + 1;
                if (FullName.Length > 5 && Email.Contains("@") && Email.Contains('.') && Password.Length > 4)
                {
                    //COMMANDS TO ADD DATAS TO DATABASE
                    string Query = $"INSERT  INTO USERS (names, password, roleid, email)  VALUES ('{FullName}','{Password}',{role}, '{Email}' )";
                    SqlCommand sda = new SqlCommand(Query, Conn);
                    Conn.Open();
                    sda.ExecuteNonQuery();
                    MessageBox.Show($"{FullName} succefully Registered");
                }
                else
                {
                    MessageBox.Show("1. Enter a valid Email\n2. FullName must be greater than 5 characters\n3. Password must be greater than 4 charcaters\n4.Select the Department and the Program");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error!!🤷‍♂️😢\n{ex.Message}\nTry Again😢");
            }
        }
        public void FillCombo(string table, string column, string id, ComboBox comboName)
        {
            string queryI = $"SELECT * FROM {table}";
            SqlDataAdapter dsa = new SqlDataAdapter(queryI, Conn);
            DataTable dt = new DataTable();
            dsa.Fill(dt);
            comboName.DataSource = dt;
            comboName.DisplayMember = $"{column}";
            comboName.ValueMember = $"{id}";

        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            login page = new login();
            page.Show();
        }
    }
}
