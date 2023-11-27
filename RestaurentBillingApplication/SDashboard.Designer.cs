namespace WindowsFormsApplication1
{
    partial class SDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addtobillbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.products = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIIII = new System.Windows.Forms.Label();
            this.quantiny = new System.Windows.Forms.TextBox();
            this.billgrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ActGrid = new System.Windows.Forms.DataGridView();
            this.reportbtn = new System.Windows.Forms.Button();
            this.SalesReport = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OldGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addtobillbtn
            // 
            this.addtobillbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addtobillbtn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtobillbtn.ForeColor = System.Drawing.Color.White;
            this.addtobillbtn.Location = new System.Drawing.Point(12, 403);
            this.addtobillbtn.Name = "addtobillbtn";
            this.addtobillbtn.Size = new System.Drawing.Size(489, 63);
            this.addtobillbtn.TabIndex = 78;
            this.addtobillbtn.Text = "Add";
            this.addtobillbtn.UseVisualStyleBackColor = false;
            this.addtobillbtn.Click += new System.EventHandler(this.addtobillbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Processed Food Stock MIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(5, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 39);
            this.label2.TabIndex = 80;
            this.label2.Text = "Products";
            // 
            // products
            // 
            this.products.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products.FormattingEnabled = true;
            this.products.Location = new System.Drawing.Point(12, 191);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(489, 45);
            this.products.TabIndex = 79;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 100);
            this.panel1.TabIndex = 71;
            // 
            // labelIIII
            // 
            this.labelIIII.AutoSize = true;
            this.labelIIII.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIIII.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelIIII.Location = new System.Drawing.Point(5, 263);
            this.labelIIII.Name = "labelIIII";
            this.labelIIII.Size = new System.Drawing.Size(129, 39);
            this.labelIIII.TabIndex = 74;
            this.labelIIII.Text = "quantity";
            // 
            // quantiny
            // 
            this.quantiny.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiny.Location = new System.Drawing.Point(12, 314);
            this.quantiny.Name = "quantiny";
            this.quantiny.Size = new System.Drawing.Size(489, 47);
            this.quantiny.TabIndex = 75;
            // 
            // billgrid
            // 
            this.billgrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.billgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billgrid.Location = new System.Drawing.Point(554, 191);
            this.billgrid.Name = "billgrid";
            this.billgrid.RowTemplate.Height = 28;
            this.billgrid.Size = new System.Drawing.Size(511, 275);
            this.billgrid.TabIndex = 81;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(554, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(511, 63);
            this.button1.TabIndex = 82;
            this.button1.Text = "Create Bill";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(547, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 39);
            this.label3.TabIndex = 83;
            this.label3.Text = "Added 2 Bill";
            // 
            // ActGrid
            // 
            this.ActGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ActGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActGrid.Location = new System.Drawing.Point(12, 585);
            this.ActGrid.Name = "ActGrid";
            this.ActGrid.RowTemplate.Height = 28;
            this.ActGrid.Size = new System.Drawing.Size(1053, 162);
            this.ActGrid.TabIndex = 84;
            // 
            // reportbtn
            // 
            this.reportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.reportbtn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbtn.ForeColor = System.Drawing.Color.White;
            this.reportbtn.Location = new System.Drawing.Point(554, 753);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.Size = new System.Drawing.Size(511, 63);
            this.reportbtn.TabIndex = 85;
            this.reportbtn.Text = "Get sales Report";
            this.reportbtn.UseVisualStyleBackColor = false;
            this.reportbtn.Click += new System.EventHandler(this.reportbtn_Click);
            // 
            // SalesReport
            // 
            this.SalesReport.AutoSize = true;
            this.SalesReport.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SalesReport.Location = new System.Drawing.Point(13, 543);
            this.SalesReport.Name = "SalesReport";
            this.SalesReport.Size = new System.Drawing.Size(220, 39);
            this.SalesReport.TabIndex = 86;
            this.SalesReport.Text = "SALES REPORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(15, 815);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 39);
            this.label4.TabIndex = 87;
            this.label4.Text = "Less Than 5 Days";
            // 
            // OldGrid
            // 
            this.OldGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.OldGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OldGrid.Location = new System.Drawing.Point(22, 873);
            this.OldGrid.Name = "OldGrid";
            this.OldGrid.RowTemplate.Height = 28;
            this.OldGrid.Size = new System.Drawing.Size(1053, 162);
            this.OldGrid.TabIndex = 88;
            // 
            // SDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 957);
            this.Controls.Add(this.OldGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SalesReport);
            this.Controls.Add(this.reportbtn);
            this.Controls.Add(this.ActGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.billgrid);
            this.Controls.Add(this.addtobillbtn);
            this.Controls.Add(this.quantiny);
            this.Controls.Add(this.labelIIII);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.products);
            this.Controls.Add(this.panel1);
            this.Name = "SDashboard";
            this.Text = "SDashboard";
            this.Load += new System.EventHandler(this.SDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addtobillbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox products;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelIIII;
        private System.Windows.Forms.TextBox quantiny;
        private System.Windows.Forms.DataGridView billgrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ActGrid;
        private System.Windows.Forms.Button reportbtn;
        private System.Windows.Forms.Label SalesReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView OldGrid;
    }
}