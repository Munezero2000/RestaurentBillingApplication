namespace WindowsFormsApplication1
{
    partial class signup
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
            this.LoginLink = new System.Windows.Forms.LinkLabel();
            this.registerBtn = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.labellliii = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.labelIIII = new System.Windows.Forms.Label();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIII = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rolecombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginLink
            // 
            this.LoginLink.AutoSize = true;
            this.LoginLink.Location = new System.Drawing.Point(70, 657);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(232, 20);
            this.LoginLink.TabIndex = 57;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "Already have an account sign in";
            this.LoginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLink_LinkClicked);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.registerBtn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(74, 547);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(489, 63);
            this.registerBtn.TabIndex = 56;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(74, 367);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(489, 47);
            this.passwordBox.TabIndex = 55;
            // 
            // labellliii
            // 
            this.labellliii.AutoSize = true;
            this.labellliii.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellliii.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labellliii.Location = new System.Drawing.Point(67, 325);
            this.labellliii.Name = "labellliii";
            this.labellliii.Size = new System.Drawing.Size(149, 39);
            this.labellliii.TabIndex = 54;
            this.labellliii.Text = "Password";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(74, 275);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(489, 47);
            this.emailBox.TabIndex = 53;
            // 
            // labelIIII
            // 
            this.labelIIII.AutoSize = true;
            this.labelIIII.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIIII.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelIIII.Location = new System.Drawing.Point(67, 233);
            this.labelIIII.Name = "labelIIII";
            this.labelIIII.Size = new System.Drawing.Size(90, 39);
            this.labelIIII.TabIndex = 52;
            this.labelIIII.Text = "Email";
            // 
            // fullNameBox
            // 
            this.fullNameBox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameBox.Location = new System.Drawing.Point(74, 169);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(489, 47);
            this.fullNameBox.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add User";
            // 
            // labelIII
            // 
            this.labelIII.AutoSize = true;
            this.labelIII.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIII.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelIII.Location = new System.Drawing.Point(67, 118);
            this.labelIII.Name = "labelIII";
            this.labelIII.Size = new System.Drawing.Size(144, 39);
            this.labelIII.TabIndex = 50;
            this.labelIII.Text = "FullName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(74, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 100);
            this.panel1.TabIndex = 49;
            // 
            // rolecombo
            // 
            this.rolecombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolecombo.FormattingEnabled = true;
            this.rolecombo.Location = new System.Drawing.Point(74, 482);
            this.rolecombo.Name = "rolecombo";
            this.rolecombo.Size = new System.Drawing.Size(489, 45);
            this.rolecombo.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(67, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 39);
            this.label2.TabIndex = 59;
            this.label2.Text = "Select user role";
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 709);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rolecombo);
            this.Controls.Add(this.LoginLink);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.labellliii);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.labelIIII);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.labelIII);
            this.Controls.Add(this.panel1);
            this.Name = "signup";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.signup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LoginLink;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label labellliii;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label labelIIII;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIII;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox rolecombo;
        private System.Windows.Forms.Label label2;
    }
}

