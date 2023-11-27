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
    public partial class MDashboard : Form
    {
        public MDashboard()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection(@"Data Source=MAG\SQLEXPRESS;Initial Catalog=RestaurentDB;Integrated Security=True");


        private void MDashboard_Load(object sender, EventArgs e)
        {
 
        }

        private void addprodBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = prodname.Text;
                int price = int.Parse(pricebox.Text);
                int availableq = int.Parse(avquantity.Text);
                
                
                if (Name.Length > 2 )
                {
                    string Query = $"INSERT  INTO goods (name, quantity, price, expdate)  VALUES ('{Name}', {availableq}, {price},'{expdate.Value}')";
                    SqlCommand sda = new SqlCommand(Query, Conn);
                    Conn.Open();
                    sda.ExecuteNonQuery();
                    MessageBox.Show($"Product added successfully");
                }
                else
                {
                    MessageBox.Show("Enter valid product details");
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

    }
}
