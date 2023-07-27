namespace Connect_Four_Client.View
{
    partial class AllRecordedGamesForm
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
            this.buttonsGamesPanel = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonsGamesPanel
            // 
            this.buttonsGamesPanel.Location = new System.Drawing.Point(12, 34);
            this.buttonsGamesPanel.Name = "buttonsGamesPanel";
            this.buttonsGamesPanel.Size = new System.Drawing.Size(671, 353);
            this.buttonsGamesPanel.TabIndex = 0;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(22, 18);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(179, 13);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "All The Recoreded Games of Player:";
            // 
            // AllRecordedGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 399);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.buttonsGamesPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AllRecordedGamesForm";
            this.Text = "AllRecordedGamesForm";
            this.Load += new System.EventHandler(this.AllRecordedGamesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel buttonsGamesPanel;
        private System.Windows.Forms.Label titleLbl;
    }
}