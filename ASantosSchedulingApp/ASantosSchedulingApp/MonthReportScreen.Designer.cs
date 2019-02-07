namespace ASantosSchedulingApp
{
    partial class MonthReportScreen
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
            this.monthReportScreenTitleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.monthReportScreenTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthReportScreenTitleLabel
            // 
            this.monthReportScreenTitleLabel.AutoSize = true;
            this.monthReportScreenTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthReportScreenTitleLabel.Location = new System.Drawing.Point(98, 9);
            this.monthReportScreenTitleLabel.Name = "monthReportScreenTitleLabel";
            this.monthReportScreenTitleLabel.Size = new System.Drawing.Size(680, 33);
            this.monthReportScreenTitleLabel.TabIndex = 1;
            this.monthReportScreenTitleLabel.Text = "Number of Appointment Types by Month Screen";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 403);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(220, 35);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back to Main Screen";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // monthReportScreenTextBox
            // 
            this.monthReportScreenTextBox.Location = new System.Drawing.Point(12, 45);
            this.monthReportScreenTextBox.Multiline = true;
            this.monthReportScreenTextBox.Name = "monthReportScreenTextBox";
            this.monthReportScreenTextBox.Size = new System.Drawing.Size(776, 352);
            this.monthReportScreenTextBox.TabIndex = 8;
            // 
            // MonthReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthReportScreenTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.monthReportScreenTitleLabel);
            this.Name = "MonthReportScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthReportScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monthReportScreenTitleLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox monthReportScreenTextBox;
    }
}