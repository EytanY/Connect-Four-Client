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
            this.emailLable = new System.Windows.Forms.Label();
            this.passwordLable = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.createAccountLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Location = new System.Drawing.Point(391, 85);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(48, 20);
            this.LoginLable.TabIndex = 0;
            this.LoginLable.Text = "Login";
            // 
            // emailLable
            // 
            this.emailLable.AutoSize = true;
            this.emailLable.Location = new System.Drawing.Point(231, 145);
            this.emailLable.Name = "emailLable";
            this.emailLable.Size = new System.Drawing.Size(52, 20);
            this.emailLable.TabIndex = 1;
            this.emailLable.Text = "Email:";
            // 
            // passwordLable
            // 
            this.passwordLable.AutoSize = true;
            this.passwordLable.Location = new System.Drawing.Point(231, 204);
            this.passwordLable.Name = "passwordLable";
            this.passwordLable.Size = new System.Drawing.Size(82, 20);
            this.passwordLable.TabIndex = 2;
            this.passwordLable.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(334, 198);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(163, 26);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(334, 139);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(163, 26);
            this.emailTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(349, 259);
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
            this.createAccountLable.Location = new System.Drawing.Point(319, 329);
            this.createAccountLable.Name = "createAccountLable";
            this.createAccountLable.Size = new System.Drawing.Size(203, 20);
            this.createAccountLable.TabIndex = 6;
            this.createAccountLable.Text = "New Here? Create Account";
            this.createAccountLable.Click += new System.EventHandler(this.CreateAccountLable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createAccountLable);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLable);
            this.Controls.Add(this.emailLable);
            this.Controls.Add(this.LoginLable);
            this.Name = "Form1";
            this.Text = "Connect Four  - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Label emailLable;
        private System.Windows.Forms.Label passwordLable;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label createAccountLable;
    }
}

