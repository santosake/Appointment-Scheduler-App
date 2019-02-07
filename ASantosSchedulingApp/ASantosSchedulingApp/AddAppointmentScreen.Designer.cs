namespace ASantosSchedulingApp
{
    partial class AddAppointmentScreen
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addCustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.addAppointmentTypeLabel = new System.Windows.Forms.Label();
            this.addAppointmentScreenTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(257, 403);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 35);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(483, 403);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 35);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addCustomerNameTextBox
            // 
            this.addCustomerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerNameTextBox.Location = new System.Drawing.Point(182, 70);
            this.addCustomerNameTextBox.Name = "addCustomerNameTextBox";
            this.addCustomerNameTextBox.Size = new System.Drawing.Size(226, 31);
            this.addCustomerNameTextBox.TabIndex = 13;
            // 
            // addAppointmentTypeLabel
            // 
            this.addAppointmentTypeLabel.AutoSize = true;
            this.addAppointmentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentTypeLabel.Location = new System.Drawing.Point(108, 73);
            this.addAppointmentTypeLabel.Name = "addAppointmentTypeLabel";
            this.addAppointmentTypeLabel.Size = new System.Drawing.Size(60, 25);
            this.addAppointmentTypeLabel.TabIndex = 12;
            this.addAppointmentTypeLabel.Text = "Type";
            // 
            // addAppointmentScreenTitleLabel
            // 
            this.addAppointmentScreenTitleLabel.AutoSize = true;
            this.addAppointmentScreenTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentScreenTitleLabel.Location = new System.Drawing.Point(251, 9);
            this.addAppointmentScreenTitleLabel.Name = "addAppointmentScreenTitleLabel";
            this.addAppointmentScreenTitleLabel.Size = new System.Drawing.Size(359, 33);
            this.addAppointmentScreenTitleLabel.TabIndex = 11;
            this.addAppointmentScreenTitleLabel.Text = "Add Appointment Screen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Placeholder for link to specific customer record in the database";
            // 
            // AddAppointmentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addCustomerNameTextBox);
            this.Controls.Add(this.addAppointmentTypeLabel);
            this.Controls.Add(this.addAppointmentScreenTitleLabel);
            this.Name = "AddAppointmentScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAppointmentScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox addCustomerNameTextBox;
        private System.Windows.Forms.Label addAppointmentTypeLabel;
        private System.Windows.Forms.Label addAppointmentScreenTitleLabel;
        private System.Windows.Forms.Label label1;
    }
}