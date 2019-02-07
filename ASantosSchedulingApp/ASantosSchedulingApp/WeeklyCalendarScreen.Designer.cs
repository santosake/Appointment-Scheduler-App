namespace ASantosSchedulingApp
{
    partial class WeeklyCalendarScreen
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
            this.backButton = new System.Windows.Forms.Button();
            this.weeklyCalendarScreenTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 405);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(220, 35);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back to Main Screen";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // weeklyCalendarScreenTitleLabel
            // 
            this.weeklyCalendarScreenTitleLabel.AutoSize = true;
            this.weeklyCalendarScreenTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyCalendarScreenTitleLabel.Location = new System.Drawing.Point(219, 11);
            this.weeklyCalendarScreenTitleLabel.Name = "weeklyCalendarScreenTitleLabel";
            this.weeklyCalendarScreenTitleLabel.Size = new System.Drawing.Size(359, 33);
            this.weeklyCalendarScreenTitleLabel.TabIndex = 8;
            this.weeklyCalendarScreenTitleLabel.Text = "Weekly Calendar Screen";
            // 
            // WeeklyCalendarScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.weeklyCalendarScreenTitleLabel);
            this.Name = "WeeklyCalendarScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeeklyCalendarScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label weeklyCalendarScreenTitleLabel;
    }
}