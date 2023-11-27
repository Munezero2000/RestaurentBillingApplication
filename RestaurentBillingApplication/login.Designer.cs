namespace WindowsFormsApplication1
{
    partial class login
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.loginPasswordBox = new System.Windows.Forms.TextBox();
            this.loginEmailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginLink = new System.Windows.Forms.LinkLabel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(48, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 100);
            this.panel2.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(150, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 64);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LoginButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(48, 418);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(468, 63);
            this.LoginButton.TabIndex = 48;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // loginPasswordBox
            // 
            this.loginPasswordBox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordBox.ForeColor = System.Drawing.Color.Black;
            this.loginPasswordBox.Location = new System.Drawing.Point(48, 326);
            this.loginPasswordBox.Name = "loginPasswordBox";
            this.loginPasswordBox.PasswordChar = '*';
            this.loginPasswordBox.Size = new System.Drawing.Size(468, 47);
            this.loginPasswordBox.TabIndex = 47;
            // 
            // loginEmailBox
            // 
            this.loginEmailBox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginEmailBox.ForeColor = System.Drawing.Color.Black;
            this.loginEmailBox.Location = new System.Drawing.Point(48, 199);
            this.loginEmailBox.Name = "loginEmailBox";
            this.loginEmailBox.Size = new System.Drawing.Size(468, 47);
            this.loginEmailBox.TabIndex = 45;
            // 
            // passwordBox
            // 
            this.passwordBox.AutoSize = true;
            this.passwordBox.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.passwordBox.Location = new System.Drawing.Point(41, 272);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(149, 39);
            this.passwordBox.TabIndex = 46;
            this.passwordBox.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(41, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 39);
            this.label3.TabIndex = 44;
            this.label3.Text = "Email";
            // 
            // LoginLink
            // 
            this.LoginLink.AutoSize = true;
            this.LoginLink.Location = new System.Drawing.Point(44, 523);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(217, 20);
            this.LoginLink.TabIndex = 58;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "dont have an account sign up";
            this.LoginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLink_LinkClicked);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 577);
            this.Controls.Add(this.LoginLink);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.loginPasswordBox);
            this.Controls.Add(this.loginEmailBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label3);
            this.Name = "login";
            this.Text = "login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox loginPasswordBox;
        private System.Windows.Forms.TextBox loginEmailBox;
        private System.Windows.Forms.Label passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LoginLink;
    }
}