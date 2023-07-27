using Connect_Four_Client.Model;

namespace Connect_Four_Client
{
    partial class MenuForm
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
            this.PlayerInfoLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.FirstNameInputLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.LastNameInputLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.PhoneInputLbl = new System.Windows.Forms.Label();
            this.CountryLbl = new System.Windows.Forms.Label();
            this.CountryInputLbl = new System.Windows.Forms.Label();
            this.IDInputLbl = new System.Windows.Forms.Label();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ShowInformationButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PlayerIDLbl = new System.Windows.Forms.Label();
            this.GamesNumberLbl = new System.Windows.Forms.Label();
            this.GamesNumberInputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayerInfoLbl
            // 
            this.PlayerInfoLbl.AutoSize = true;
            this.PlayerInfoLbl.Location = new System.Drawing.Point(23, 31);
            this.PlayerInfoLbl.Name = "PlayerInfoLbl";
            this.PlayerInfoLbl.Size = new System.Drawing.Size(117, 16);
            this.PlayerInfoLbl.TabIndex = 0;
            this.PlayerInfoLbl.Text = "Player Inforamtion:";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(23, 65);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(75, 16);
            this.FirstNameLbl.TabIndex = 1;
            this.FirstNameLbl.Text = "First Name:";
            // 
            // FirstNameInputLbl
            // 
            this.FirstNameInputLbl.AutoSize = true;
            this.FirstNameInputLbl.Location = new System.Drawing.Point(171, 65);
            this.FirstNameInputLbl.Name = "FirstNameInputLbl";
            this.FirstNameInputLbl.Size = new System.Drawing.Size(41, 16);
            this.FirstNameInputLbl.TabIndex = 2;
            this.FirstNameInputLbl.Text = "Eytan";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Location = new System.Drawing.Point(23, 92);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(75, 16);
            this.LastNameLbl.TabIndex = 3;
            this.LastNameLbl.Text = "Last Name:";
            // 
            // LastNameInputLbl
            // 
            this.LastNameInputLbl.AutoSize = true;
            this.LastNameInputLbl.Location = new System.Drawing.Point(171, 92);
            this.LastNameInputLbl.Name = "LastNameInputLbl";
            this.LastNameInputLbl.Size = new System.Drawing.Size(77, 16);
            this.LastNameInputLbl.TabIndex = 4;
            this.LastNameInputLbl.Text = "Yegudayev";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(23, 182);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(49, 16);
            this.PhoneLbl.TabIndex = 5;
            this.PhoneLbl.Text = "Phone:";
            // 
            // PhoneInputLbl
            // 
            this.PhoneInputLbl.AutoSize = true;
            this.PhoneInputLbl.Location = new System.Drawing.Point(171, 182);
            this.PhoneInputLbl.Name = "PhoneInputLbl";
            this.PhoneInputLbl.Size = new System.Drawing.Size(85, 16);
            this.PhoneInputLbl.TabIndex = 6;
            this.PhoneInputLbl.Text = "052-349-2675";
            // 
            // CountryLbl
            // 
            this.CountryLbl.AutoSize = true;
            this.CountryLbl.Location = new System.Drawing.Point(23, 218);
            this.CountryLbl.Name = "CountryLbl";
            this.CountryLbl.Size = new System.Drawing.Size(55, 16);
            this.CountryLbl.TabIndex = 7;
            this.CountryLbl.Text = "Country:";
            // 
            // CountryInputLbl
            // 
            this.CountryInputLbl.AutoSize = true;
            this.CountryInputLbl.Location = new System.Drawing.Point(171, 218);
            this.CountryInputLbl.Name = "CountryInputLbl";
            this.CountryInputLbl.Size = new System.Drawing.Size(40, 16);
            this.CountryInputLbl.TabIndex = 8;
            this.CountryInputLbl.Text = "Israel";
            // 
            // IDInputLbl
            // 
            this.IDInputLbl.AutoSize = true;
            this.IDInputLbl.Location = new System.Drawing.Point(171, 126);
            this.IDInputLbl.Name = "IDInputLbl";
            this.IDInputLbl.Size = new System.Drawing.Size(28, 16);
            this.IDInputLbl.TabIndex = 10;
            this.IDInputLbl.Text = "007";
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(27, 262);
            this.StartGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(125, 38);
            this.StartGameButton.TabIndex = 11;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(461, 46);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(7, 6);
            this.LogoutButton.TabIndex = 12;
            this.LogoutButton.Text = "Logout\r\n";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // ShowInformationButton
            // 
            this.ShowInformationButton.Location = new System.Drawing.Point(197, 262);
            this.ShowInformationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowInformationButton.Name = "ShowInformationButton";
            this.ShowInformationButton.Size = new System.Drawing.Size(140, 38);
            this.ShowInformationButton.TabIndex = 13;
            this.ShowInformationButton.Text = "Recorded Games";
            this.ShowInformationButton.UseVisualStyleBackColor = true;
            this.ShowInformationButton.Click += new System.EventHandler(this.ShowInformationButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(388, 262);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 38);
            this.button3.TabIndex = 15;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // PlayerIDLbl
            // 
            this.PlayerIDLbl.AutoSize = true;
            this.PlayerIDLbl.Location = new System.Drawing.Point(23, 126);
            this.PlayerIDLbl.Name = "PlayerIDLbl";
            this.PlayerIDLbl.Size = new System.Drawing.Size(65, 16);
            this.PlayerIDLbl.TabIndex = 9;
            this.PlayerIDLbl.Text = "Player ID:";
            // 
            // GamesNumberLbl
            // 
            this.GamesNumberLbl.AutoSize = true;
            this.GamesNumberLbl.Location = new System.Drawing.Point(23, 154);
            this.GamesNumberLbl.Name = "GamesNumberLbl";
            this.GamesNumberLbl.Size = new System.Drawing.Size(116, 16);
            this.GamesNumberLbl.TabIndex = 16;
            this.GamesNumberLbl.Text = "Number of Games";
            // 
            // GamesNumberInputLbl
            // 
            this.GamesNumberInputLbl.AutoSize = true;
            this.GamesNumberInputLbl.Location = new System.Drawing.Point(171, 154);
            this.GamesNumberInputLbl.Name = "GamesNumberInputLbl";
            this.GamesNumberInputLbl.Size = new System.Drawing.Size(14, 16);
            this.GamesNumberInputLbl.TabIndex = 17;
            this.GamesNumberInputLbl.Text = "0";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 346);
            this.Controls.Add(this.GamesNumberInputLbl);
            this.Controls.Add(this.GamesNumberLbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ShowInformationButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.IDInputLbl);
            this.Controls.Add(this.PlayerIDLbl);
            this.Controls.Add(this.CountryInputLbl);
            this.Controls.Add(this.CountryLbl);
            this.Controls.Add(this.PhoneInputLbl);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.LastNameInputLbl);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameInputLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.PlayerInfoLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.Text = "Connect Four - Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerInfoLbl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label FirstNameInputLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label LastNameInputLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label PhoneInputLbl;
        private System.Windows.Forms.Label CountryLbl;
        private System.Windows.Forms.Label CountryInputLbl;
        private System.Windows.Forms.Label IDInputLbl;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ShowInformationButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label PlayerIDLbl;
        private System.Windows.Forms.Label GamesNumberLbl;
        private System.Windows.Forms.Label GamesNumberInputLbl;

        private Player Player { get; set; }
    }
}