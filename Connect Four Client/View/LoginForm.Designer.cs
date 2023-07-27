namespace Connect_Four_Client
{
    partial class LoginForm
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
            this.LoginLable = new System.Windows.Forms.Label();
            this.idLable = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.createAccountLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Location = new System.Drawing.Point(342, 102);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(157, 20);
            this.LoginLable.TabIndex = 0;
            this.LoginLable.Text = "Please enter your ID:";
            // 
            // idLable
            // 
            this.idLable.AutoSize = true;
            this.idLable.Location = new System.Drawing.Point(285, 157);
            this.idLable.Name = "idLable";
            this.idLable.Size = new System.Drawing.Size(30, 20);
            this.idLable.TabIndex = 1;
            this.idLable.Text = "ID:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(336, 157);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(163, 26);
            this.IdTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(350, 221);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(131, 39);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // createAccountLable
            // 
            this.createAccountLable.AutoSize = true;
            this.createAccountLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createAccountLable.Location = new System.Drawing.Point(318, 298);
            this.createAccountLable.Name = "createAccountLable";
            this.createAccountLable.Size = new System.Drawing.Size(203, 20);
            this.createAccountLable.TabIndex = 6;
            this.createAccountLable.Text = "New Here? Create Account";
            this.createAccountLable.Click += new System.EventHandler(this.CreateAccountLable_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createAccountLable);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.idLable);
            this.Controls.Add(this.LoginLable);
            this.Name = "LoginForm";
            this.Text = "Connect Four  - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Label idLable;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label createAccountLable;
    }
}

