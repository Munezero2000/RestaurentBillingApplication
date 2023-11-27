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
using System.Collections;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class SDashboard : Form
    {
        public SDashboard()
        {
            InitializeComponent();
        }
        DataTable billTable;
        DataTable ReportTable;
        SqlConnection Conn = new SqlConnection(@"Data Source=MAG\SQLEXPRESS;Initial Catalog=RestaurentDB;Integrated Security=True");
        private void SDashboard_Load(object sender, EventArgs e)
        {
            FillCombo("goods", "name", "id", products);
            FillGrid();
            FillGridOld();
        }

        public void FillCombo(string table, string column, string id, ComboBox comboName)
        {
            string queryI = $"SELECT * FROM {table} ORDER BY EXPDATE ASC";

            SqlDataAdapter dsa = new SqlDataAdapter(queryI, Conn);
            DataTable dt = new DataTable();
            dsa.Fill(dt);
            comboName.DataSource = dt;
            comboName.DisplayMember = $"{column}";
            comboName.ValueMember = $"{id}";

        }

        private void addtobillbtn_Click(object sender, EventArgs e)
        {
            if (billgrid.DataSource == null)
            {
                billTable = new DataTable();
                billTable.Columns.Add("Product Name");
                billTable.Columns.Add("Price");
                billTable.Columns.Add("Amount");
                billgrid.DataSource = billTable;
            }
            else
            {
                billTable = (DataTable)billgrid.DataSource;
            }

            string productName = products.Text;
            int quantity = int.Parse(quantiny.Text);

            {
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM goods where name = @ProductName", Conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", productName);

                    using (SqlDataAdapter dsa = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        dsa.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            DataRow productRow = dt.Rows[0];
                            if(quantity > int.Parse(dt.Rows[0]["quantity"].ToString()))
                            {
                                MessageBox.Show("The selected quanity is not available", "add failure");
                                return;
                            }
                            string price = productRow["price"].ToString();
                            int amountbt = int.Parse(price) * quantity;
                            double amount = amountbt - (amountbt * 0.18);
                            SqlCommand cd = new SqlCommand($"Update goods set quantity = {int.Parse(dt.Rows[0]["quantity"].ToString()) - quantity}", Conn);
                            Conn.Open();
                            cd.ExecuteNonQuery();
                            Conn.Close();
                            // Create a new DataRow for the billTable
                            DataRow newRow = billTable.NewRow();
                            newRow["Product Name"] = productName;
                            newRow["Price"] = price;
                            newRow["Amount"] = amount;

                            // Add the new row to the billTable
                            billTable.Rows.Add(newRow);
                            SqlCommand repo = new SqlCommand($"Insert into Soldgood values('{productName}', {quantity}, {amount}, SYSDATETIME())", Conn);
                            Conn.Open();
                            repo.ExecuteNonQuery();
                            Conn.Close();
                            FillGrid();
                        }
                        else
                        {

                        }
                    }
                }
                Conn.Close();
            }
        }

        public void FillGrid()
        {
            SqlDataAdapter dsa = new SqlDataAdapter($"SELECT * FROM SOLDGOOD", Conn);
            DataTable dt = new DataTable();
            dsa.Fill(dt);
            ActGrid.DataSource = dt;
        }

        public void FillGridOld()
        {
            SqlDataAdapter dsa = new SqlDataAdapter($"SELECT * FROM goods Where expdate=DATEADD(day, 5, GETDATE())", Conn);
            DataTable dt = new DataTable();
            dsa.Fill(dt);
            OldGrid.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Define a PDF file name for the bill
            string pdfFileName = "Bill8.pdf";

            // Check if there are items in the bill
            if (billTable.Rows.Count == 0)
            {
                MessageBox.Show("No items in the bill to generate a PDF.", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new PDF document
            using (FileStream fs = new FileStream(pdfFileName, FileMode.Create))
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                doc.Open();

                PdfPTable pdfTable = new PdfPTable(billTable.Columns.Count);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                // Add column headers to the PDF table
                foreach (DataColumn column in billTable.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                    pdfTable.AddCell(cell);
                }

                // Add bill items to the PDF table
                foreach (DataRow row in billTable.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        pdfTable.AddCell(item.ToString());
                    }
                }

                doc.Add(pdfTable);

                // Calculate the total amount to pay
                decimal totalAmount = billTable.AsEnumerable().Sum(row => Convert.ToDecimal(row.Field<string>("Amount")));

                // Add the total amount to the PDF
                doc.Add(new Paragraph("Total Amount to Pay: $" + totalAmount.ToString()));

                doc.Close();
            }

            // Display or open the generated PDF
            System.Diagnostics.Process.Start(pdfFileName);
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ds = new SqlDataAdapter("Select * from soldgood", Conn);
            ReportTable = new DataTable();
            ds.Fill(ReportTable);
            
            string pdfFileNames = "ReportI.pdf";


            if (ReportTable.Rows.Count == 0)
            {
                MessageBox.Show("No items in the bill to generate a PDF.", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FileStream fs = new FileStream(pdfFileNames, FileMode.Create))
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                doc.Open();

                PdfPTable pdfTable = new PdfPTable(ReportTable.Columns.Count);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                
                foreach (DataColumn column in ReportTable.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                    pdfTable.AddCell(cell);
                }

                foreach (DataRow row in ReportTable.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        pdfTable.AddCell(item.ToString());
                    }
                }

                doc.Add(pdfTable);
                System.Diagnostics.Process.Start(pdfFileNames);
            }
        }
    }
}