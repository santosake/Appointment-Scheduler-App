namespace ASantosSchedulingApp
{
    partial class MainScreen
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
            this.mainScreenTitleLabel = new System.Windows.Forms.Label();
            this.customerButton = new System.Windows.Forms.Button();
            this.appointmentsButton = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.calendarGroupBox = new System.Windows.Forms.GroupBox();
            this.monthlyRadioButton = new System.Windows.Forms.RadioButton();
            this.weeklyRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.appointmentsByCityRadioButton = new System.Windows.Forms.RadioButton();
            this.scheduleForEachConsultantRadioButton = new System.Windows.Forms.RadioButton();
            this.appointmentsByMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.reportsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calendarGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainScreenTitleLabel
            // 
            this.mainScreenTitleLabel.AutoSize = true;
            this.mainScreenTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenTitleLabel.Location = new System.Drawing.Point(300, 28);
            this.mainScreenTitleLabel.Name = "mainScreenTitleLabel";
            this.mainScreenTitleLabel.Size = new System.Drawing.Size(189, 33);
            this.mainScreenTitleLabel.TabIndex = 0;
            this.mainScreenTitleLabel.Text = "Main Screen";
            // 
            // customerButton
            // 
            this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.Location = new System.Drawing.Point(150, 114);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(161, 35);
            this.customerButton.TabIndex = 1;
            this.customerButton.Text = "Customers";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // appointmentsButton
            // 
            this.appointmentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsButton.Location = new System.Drawing.Point(474, 114);
            this.appointmentsButton.Name = "appointmentsButton";
            this.appointmentsButton.Size = new System.Drawing.Size(161, 35);
            this.appointmentsButton.TabIndex = 2;
            this.appointmentsButton.Text = "Appointments";
            this.appointmentsButton.UseVisualStyleBackColor = true;
            this.appointmentsButton.Click += new System.EventHandler(this.appointmentsButton_Click);
            // 
            // calendarButton
            // 
            this.calendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarButton.Location = new System.Drawing.Point(18, 19);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(125, 35);
            this.calendarButton.TabIndex = 3;
            this.calendarButton.Text = "Calendar";
            this.calendarButton.UseVisualStyleBackColor = true;
            this.calendarButton.Click += new System.EventHandler(this.calendarButton_Click);
            // 
            // calendarGroupBox
            // 
            this.calendarGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calendarGroupBox.Controls.Add(this.monthlyRadioButton);
            this.calendarGroupBox.Controls.Add(this.weeklyRadioButton);
            this.calendarGroupBox.Controls.Add(this.calendarButton);
            this.calendarGroupBox.Location = new System.Drawing.Point(474, 220);
            this.calendarGroupBox.Name = "calendarGroupBox";
            this.calendarGroupBox.Size = new System.Drawing.Size(161, 151);
            this.calendarGroupBox.TabIndex = 4;
            this.calendarGroupBox.TabStop = false;
            // 
            // monthlyRadioButton
            // 
            this.monthlyRadioButton.AutoSize = true;
            this.monthlyRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyRadioButton.Location = new System.Drawing.Point(18, 86);
            this.monthlyRadioButton.Name = "monthlyRadioButton";
            this.monthlyRadioButton.Size = new System.Drawing.Size(72, 20);
            this.monthlyRadioButton.TabIndex = 5;
            this.monthlyRadioButton.TabStop = true;
            this.monthlyRadioButton.Text = "Monthly";
            this.monthlyRadioButton.UseVisualStyleBackColor = true;
            this.monthlyRadioButton.CheckedChanged += new System.EventHandler(this.monthlyRadioButton_CheckedChanged);
            // 
            // weeklyRadioButton
            // 
            this.weeklyRadioButton.AutoSize = true;
            this.weeklyRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyRadioButton.Location = new System.Drawing.Point(18, 60);
            this.weeklyRadioButton.Name = "weeklyRadioButton";
            this.weeklyRadioButton.Size = new System.Drawing.Size(72, 20);
            this.weeklyRadioButton.TabIndex = 4;
            this.weeklyRadioButton.TabStop = true;
            this.weeklyRadioButton.Text = "Weekly";
            this.weeklyRadioButton.UseVisualStyleBackColor = true;
            this.weeklyRadioButton.CheckedChanged += new System.EventHandler(this.weeklyRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.appointmentsByCityRadioButton);
            this.groupBox1.Controls.Add(this.scheduleForEachConsultantRadioButton);
            this.groupBox1.Controls.Add(this.appointmentsByMonthRadioButton);
            this.groupBox1.Controls.Add(this.reportsButton);
            this.groupBox1.Location = new System.Drawing.Point(150, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 151);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // appointmentsByCityRadioButton
            // 
            this.appointmentsByCityRadioButton.AutoSize = true;
            this.appointmentsByCityRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsByCityRadioButton.Location = new System.Drawing.Point(18, 112);
            this.appointmentsByCityRadioButton.Name = "appointmentsByCityRadioButton";
            this.appointmentsByCityRadioButton.Size = new System.Drawing.Size(216, 20);
            this.appointmentsByCityRadioButton.TabIndex = 6;
            this.appointmentsByCityRadioButton.TabStop = true;
            this.appointmentsByCityRadioButton.Text = "Number of Appointments by City";
            this.appointmentsByCityRadioButton.UseVisualStyleBackColor = true;
            this.appointmentsByCityRadioButton.CheckedChanged += new System.EventHandler(this.appointmentsByRegionRadioButton_CheckedChanged);
            // 
            // scheduleForEachConsultantRadioButton
            // 
            this.scheduleForEachConsultantRadioButton.AutoSize = true;
            this.scheduleForEachConsultantRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleForEachConsultantRadioButton.Location = new System.Drawing.Point(18, 86);
            this.scheduleForEachConsultantRadioButton.Name = "scheduleForEachConsultantRadioButton";
            this.scheduleForEachConsultantRadioButton.Size = new System.Drawing.Size(200, 20);
            this.scheduleForEachConsultantRadioButton.TabIndex = 5;
            this.scheduleForEachConsultantRadioButton.TabStop = true;
            this.scheduleForEachConsultantRadioButton.Text = "Schedule for Each Consultant";
            this.scheduleForEachConsultantRadioButton.UseVisualStyleBackColor = true;
            this.scheduleForEachConsultantRadioButton.CheckedChanged += new System.EventHandler(this.scheduleForEachConsultantRadioButton_CheckedChanged);
            // 
            // appointmentsByMonthRadioButton
            // 
            this.appointmentsByMonthRadioButton.AutoSize = true;
            this.appointmentsByMonthRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsByMonthRadioButton.Location = new System.Drawing.Point(18, 60);
            this.appointmentsByMonthRadioButton.Name = "appointmentsByMonthRadioButton";
            this.appointmentsByMonthRadioButton.Size = new System.Drawing.Size(265, 20);
            this.appointmentsByMonthRadioButton.TabIndex = 4;
            this.appointmentsByMonthRadioButton.TabStop = true;
            this.appointmentsByMonthRadioButton.Text = "Number of Appointment Types by Month";
            this.appointmentsByMonthRadioButton.UseVisualStyleBackColor = true;
            this.appointmentsByMonthRadioButton.CheckedChanged += new System.EventHandler(this.appointmentsByMonthRadioButton_CheckedChanged);
            // 
            // reportsButton
            // 
            this.reportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.Location = new System.Drawing.Point(18, 19);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(125, 35);
            this.reportsButton.TabIndex = 3;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(700, 403);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 35);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calendarGroupBox);
            this.Controls.Add(this.appointmentsButton);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.mainScreenTitleLabel);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.calendarGroupBox.ResumeLayout(false);
            this.calendarGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainScreenTitleLabel;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button appointmentsButton;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.GroupBox calendarGroupBox;
        private System.Windows.Forms.RadioButton monthlyRadioButton;
        private System.Windows.Forms.RadioButton weeklyRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton appointmentsByCityRadioButton;
        private System.Windows.Forms.RadioButton scheduleForEachConsultantRadioButton;
        private System.Windows.Forms.RadioButton appointmentsByMonthRadioButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button exitButton;
    }
}