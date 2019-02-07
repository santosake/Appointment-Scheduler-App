namespace ASantosSchedulingApp
{
    partial class MonthlyCalendarScreen
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
            this.monthlyCalendarScreenTitleLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 405);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(220, 35);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back to Main Screen";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // monthlyCalendarScreenTitleLabel
            // 
            this.monthlyCalendarScreenTitleLabel.AutoSize = true;
            this.monthlyCalendarScreenTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyCalendarScreenTitleLabel.Location = new System.Drawing.Point(219, 11);
            this.monthlyCalendarScreenTitleLabel.Name = "monthlyCalendarScreenTitleLabel";
            this.monthlyCalendarScreenTitleLabel.Size = new System.Drawing.Size(366, 33);
            this.monthlyCalendarScreenTitleLabel.TabIndex = 11;
            this.monthlyCalendarScreenTitleLabel.Text = "Monthly Calendar Screen";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 73);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // MonthlyCalendarScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.monthlyCalendarScreenTitleLabel);
            this.Name = "MonthlyCalendarScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthlyCalendarScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label monthlyCalendarScreenTitleLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}