namespace ASantosSchedulingApp
{
    partial class ConsultantReportScreen
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
            this.consultantReportScreenTitleLabel = new System.Windows.Forms.Label();
            this.consultantReportScreenTextBox = new System.Windows.Forms.TextBox();
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
            // consultantReportScreenTitleLabel
            // 
            this.consultantReportScreenTitleLabel.AutoSize = true;
            this.consultantReportScreenTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultantReportScreenTitleLabel.Location = new System.Drawing.Point(124, 11);
            this.consultantReportScreenTitleLabel.Name = "consultantReportScreenTitleLabel";
            this.consultantReportScreenTitleLabel.Size = new System.Drawing.Size(534, 33);
            this.consultantReportScreenTitleLabel.TabIndex = 8;
            this.consultantReportScreenTitleLabel.Text = "Schedule for Each Consultant Screen";
            // 
            // consultantReportScreenTextBox
            // 
            this.consultantReportScreenTextBox.Location = new System.Drawing.Point(12, 47);
            this.consultantReportScreenTextBox.Multiline = true;
            this.consultantReportScreenTextBox.Name = "consultantReportScreenTextBox";
            this.consultantReportScreenTextBox.Size = new System.Drawing.Size(776, 352);
            this.consultantReportScreenTextBox.TabIndex = 11;
            // 
            // ConsultantReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.consultantReportScreenTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.consultantReportScreenTitleLabel);
            this.Name = "ConsultantReportScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultantReportScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label consultantReportScreenTitleLabel;
        private System.Windows.Forms.TextBox consultantReportScreenTextBox;
    }
}