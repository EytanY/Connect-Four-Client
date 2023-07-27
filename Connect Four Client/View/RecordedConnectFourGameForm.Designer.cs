namespace Connect_Four_Client.View
{
    partial class RecordedConnectFourGameForm
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
            this.GamePanel = new System.Windows.Forms.Panel();
            this.GameIdLbl = new System.Windows.Forms.Label();
            this.GameIdInputLbl = new System.Windows.Forms.Label();
            this.WinnerGameLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GameDateLbl = new System.Windows.Forms.Label();
            this.GameWinnerInputLbl = new System.Windows.Forms.Label();
            this.startRecordedGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.Location = new System.Drawing.Point(60, 114);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(700, 425);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            // 
            // GameIdLbl
            // 
            this.GameIdLbl.AutoSize = true;
            this.GameIdLbl.Location = new System.Drawing.Point(57, 46);
            this.GameIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameIdLbl.Name = "GameIdLbl";
            this.GameIdLbl.Size = new System.Drawing.Size(63, 16);
            this.GameIdLbl.TabIndex = 1;
            this.GameIdLbl.Text = "Game ID:";
            // 
            // GameIdInputLbl
            // 
            this.GameIdInputLbl.AutoSize = true;
            this.GameIdInputLbl.Location = new System.Drawing.Point(145, 46);
            this.GameIdInputLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameIdInputLbl.Name = "GameIdInputLbl";
            this.GameIdInputLbl.Size = new System.Drawing.Size(44, 16);
            this.GameIdInputLbl.TabIndex = 2;
            this.GameIdInputLbl.Text = "label2";
            // 
            // WinnerGameLbl
            // 
            this.WinnerGameLbl.AutoSize = true;
            this.WinnerGameLbl.Location = new System.Drawing.Point(435, 46);
            this.WinnerGameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WinnerGameLbl.Name = "WinnerGameLbl";
            this.WinnerGameLbl.Size = new System.Drawing.Size(52, 16);
            this.WinnerGameLbl.TabIndex = 3;
            this.WinnerGameLbl.Text = "Winner:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "01.02.2023 16:30";
            // 
            // GameDateLbl
            // 
            this.GameDateLbl.AutoSize = true;
            this.GameDateLbl.Location = new System.Drawing.Point(236, 46);
            this.GameDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameDateLbl.Name = "GameDateLbl";
            this.GameDateLbl.Size = new System.Drawing.Size(39, 16);
            this.GameDateLbl.TabIndex = 2;
            this.GameDateLbl.Text = "Date:";
            // 
            // GameWinnerInputLbl
            // 
            this.GameWinnerInputLbl.AutoSize = true;
            this.GameWinnerInputLbl.Location = new System.Drawing.Point(493, 46);
            this.GameWinnerInputLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameWinnerInputLbl.Name = "GameWinnerInputLbl";
            this.GameWinnerInputLbl.Size = new System.Drawing.Size(47, 16);
            this.GameWinnerInputLbl.TabIndex = 5;
            this.GameWinnerInputLbl.Text = "Server";
            // 
            // startRecordedGameBtn
            // 
            this.startRecordedGameBtn.Location = new System.Drawing.Point(603, 42);
            this.startRecordedGameBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startRecordedGameBtn.Name = "startRecordedGameBtn";
            this.startRecordedGameBtn.Size = new System.Drawing.Size(149, 25);
            this.startRecordedGameBtn.TabIndex = 6;
            this.startRecordedGameBtn.Text = "Start";
            this.startRecordedGameBtn.UseVisualStyleBackColor = true;
            this.startRecordedGameBtn.Click += new System.EventHandler(this.startRecordedGameBtn_Click);
            // 
            // RecordedConnectFourGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 554);
            this.Controls.Add(this.startRecordedGameBtn);
            this.Controls.Add(this.GameWinnerInputLbl);
            this.Controls.Add(this.GameDateLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WinnerGameLbl);
            this.Controls.Add(this.GameIdInputLbl);
            this.Controls.Add(this.GameIdLbl);
            this.Controls.Add(this.GamePanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecordedConnectFourGameForm";
            this.Text = "RecordedConnectFourGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecordedConnectFourGameForm_FormClosed);
            this.Load += new System.EventHandler(this.RecordedConnectFourGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Label GameIdLbl;
        private System.Windows.Forms.Label GameIdInputLbl;
        private System.Windows.Forms.Label WinnerGameLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GameDateLbl;
        private System.Windows.Forms.Label GameWinnerInputLbl;
        private System.Windows.Forms.Button startRecordedGameBtn;
    }
}