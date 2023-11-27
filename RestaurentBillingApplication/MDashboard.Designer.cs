namespace WindowsFormsApplication1
{
    partial class MDashboard
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
            this.addprodBtn = new System.Windows.Forms.Button();
            this.avquantity = new System.Windows.Forms.TextBox();
            this.labellliii = new System.Windows.Forms.Label();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.labelIIII = new System.Windows.Forms.Label();
            this.prodname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIII = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.expdate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addprodBtn
            // 
            this.addprodBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addprodBtn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addprodBtn.ForeColor = System.Drawing.Color.White;
            this.addprodBtn.Location = new System.Drawing.Point(325, 391);
            this.addprodBtn.Name = "addprodBtn";
            this.addprodBtn.Size = new System.Drawing.Size(489, 63);
            this.addprodBtn.TabIndex = 67;
            this.addprodBtn.Text = "Add";
            this.addprodBtn.UseVisualStyleBackColor = false;
            this.addprodBtn.Click += new System.EventHandler(this.addprodBtn_Click);
            // 
            // avquantity
            // 
            this.avquantity.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avquantity.Location = new System.Drawing.Point(20, 302);
            this.avquantity.Name = "avquantity";
            this.avquantity.Size = new System.Drawing.Size(489, 47);
            this.avquantity.TabIndex = 66;
            // 
            // labellliii
            // 
            this.labellliii.AutoSize = true;
            this.labellliii.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellliii.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labellliii.Location = new System.Drawing.Point(13, 251);
            this.labellliii.Name = "labellliii";
            this.labellliii.Size = new System.Drawing.Size(262, 39);
            this.labellliii.TabIndex = 65;
            this.labellliii.Text = "Available Quantity";
            // 
            // pricebox
            // 
            this.pricebox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricebox.Location = new System.Drawing.Point(594, 171);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(489, 47);
            this.pricebox.TabIndex = 64;
            // 
            // labelIIII
            // 
            this.labelIIII.AutoSize = true;
            this.labelIIII.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIIII.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelIIII.Location = new System.Drawing.Point(587, 120);
            this.labelIIII.Name = "labelIIII";
            this.labelIIII.Size = new System.Drawing.Size(256, 39);
            this.labelIIII.TabIndex = 63;
            this.labelIIII.Text = "product unit price";
            // 
            // prodname
            // 
            this.prodname.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodname.Location = new System.Drawing.Point(20, 171);
            this.prodname.Name = "prodname";
            this.prodname.Size = new System.Drawing.Size(489, 47);
            this.prodname.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(414, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Goods";
            // 
            // labelIII
            // 
            this.labelIII.AutoSize = true;
            this.labelIII.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIII.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelIII.Location = new System.Drawing.Point(13, 120);
            this.labelIII.Name = "labelIII";
            this.labelIII.Size = new System.Drawing.Size(211, 39);
            this.labelIII.TabIndex = 61;
            this.labelIII.Text = "Product Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 100);
            this.panel1.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(591, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 39);
            this.label3.TabIndex = 71;
            this.label3.Text = "Expiration date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 72;
            // 
            // expdate
            // 
            this.expdate.Location = new System.Drawing.Point(596, 323);
            this.expdate.Name = "expdate";
            this.expdate.Size = new System.Drawing.Size(489, 26);
            this.expdate.TabIndex = 73;
            // 
            // MDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 490);
            this.Controls.Add(this.expdate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addprodBtn);
            this.Controls.Add(this.avquantity);
            this.Controls.Add(this.labellliii);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.labelIIII);
            this.Controls.Add(this.prodname);
            this.Controls.Add(this.labelIII);
            this.Controls.Add(this.panel1);
            this.Name = "MDashboard";
            this.Text = "MDashboard";
            this.Load += new System.EventHandler(this.MDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addprodBtn;
        private System.Windows.Forms.TextBox avquantity;
        private System.Windows.Forms.Label labellliii;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.Label labelIIII;
        private System.Windows.Forms.TextBox prodname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIII;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker expdate;
    }
}