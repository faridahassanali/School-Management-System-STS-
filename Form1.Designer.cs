namespace STS
{
    partial class welcomeform
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnScheduled = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnOtherSystems = new System.Windows.Forms.Button();
            this.btnAlerts = new System.Windows.Forms.Button();
            this.AddData = new System.Windows.Forms.Button();
            this.btnPreviousData = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnRestore
            // 
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Image = global::STS.Properties.Resources.Screenshot_2024_05_05_234310;
            this.btnRestore.Location = new System.Drawing.Point(1236, 12);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(30, 30);
            this.btnRestore.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnRestore, "Restore");
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::STS.Properties.Resources.Screenshot_2024_05_05_234300;
            this.btnMinimize.Location = new System.Drawing.Point(1272, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::STS.Properties.Resources.Screenshot_2024_05_05_2342472;
            this.btnClose.Location = new System.Drawing.Point(1308, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Transportation System";
            // 
            // btnScheduled
            // 
            this.btnScheduled.AutoSize = true;
            this.btnScheduled.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduled.ForeColor = System.Drawing.Color.Black;
            this.btnScheduled.Location = new System.Drawing.Point(20, 106);
            this.btnScheduled.Name = "btnScheduled";
            this.btnScheduled.Size = new System.Drawing.Size(75, 34);
            this.btnScheduled.TabIndex = 5;
            this.btnScheduled.Text = "Scheduled \r\nData";
            this.toolTip1.SetToolTip(this.btnScheduled, "Scheduled Data");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 51);
            this.label5.TabIndex = 5;
            this.label5.Text = "Other School \r\nManagement \r\nSystem";
            this.toolTip1.SetToolTip(this.label5, "Scheduled Data");
            // 
            // btnCalendar
            // 
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Image = global::STS.Properties.Resources.Adobe_Express_2024_05_06_04_111;
            this.btnCalendar.Location = new System.Drawing.Point(3, 315);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(108, 100);
            this.btnCalendar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnCalendar, "Calendar and Activities");
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnOtherSystems
            // 
            this.btnOtherSystems.FlatAppearance.BorderSize = 0;
            this.btnOtherSystems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherSystems.Image = global::STS.Properties.Resources.Adobe_Express_2024_05_06_03_591;
            this.btnOtherSystems.Location = new System.Drawing.Point(3, 3);
            this.btnOtherSystems.Name = "btnOtherSystems";
            this.btnOtherSystems.Size = new System.Drawing.Size(107, 100);
            this.btnOtherSystems.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnOtherSystems, "Other School Management System");
            this.btnOtherSystems.UseVisualStyleBackColor = true;
            this.btnOtherSystems.Click += new System.EventHandler(this.btnOtherSystems_Click);
            // 
            // btnAlerts
            // 
            this.btnAlerts.FlatAppearance.BorderSize = 0;
            this.btnAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlerts.Image = global::STS.Properties.Resources.spam_123727952;
            this.btnAlerts.Location = new System.Drawing.Point(3, 315);
            this.btnAlerts.Name = "btnAlerts";
            this.btnAlerts.Size = new System.Drawing.Size(108, 100);
            this.btnAlerts.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAlerts, "Communication and Alerts");
            this.btnAlerts.UseVisualStyleBackColor = true;
            this.btnAlerts.Click += new System.EventHandler(this.btnAlerts_Click);
            // 
            // AddData
            // 
            this.AddData.FlatAppearance.BorderSize = 0;
            this.AddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddData.Image = global::STS.Properties.Resources.Adobe_Express_2024_05_06_03_432;
            this.AddData.Location = new System.Drawing.Point(3, 3);
            this.AddData.Name = "AddData";
            this.AddData.Size = new System.Drawing.Size(108, 100);
            this.AddData.TabIndex = 4;
            this.toolTip1.SetToolTip(this.AddData, "Scheduled Data");
            this.AddData.UseVisualStyleBackColor = true;
            this.AddData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // btnPreviousData
            // 
            this.btnPreviousData.FlatAppearance.BorderSize = 0;
            this.btnPreviousData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousData.Image = global::STS.Properties.Resources.folder_10921351;
            this.btnPreviousData.Location = new System.Drawing.Point(3, 315);
            this.btnPreviousData.Name = "btnPreviousData";
            this.btnPreviousData.Size = new System.Drawing.Size(108, 100);
            this.btnPreviousData.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnPreviousData, "Previous Data");
            this.btnPreviousData.UseVisualStyleBackColor = true;
            this.btnPreviousData.Click += new System.EventHandler(this.btnPreviousData_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.FlatAppearance.BorderSize = 0;
            this.btnAddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddData.Image = global::STS.Properties.Resources.folder_122694532;
            this.btnAddData.Location = new System.Drawing.Point(3, 3);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(107, 100);
            this.btnAddData.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAddData, "Add New Data");
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 670);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 30);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1330, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 570);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 570);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnAddData);
            this.panel5.Location = new System.Drawing.Point(64, 205);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(113, 465);
            this.panel5.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add New Data";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.btnPreviousData);
            this.panel6.Location = new System.Drawing.Point(273, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(113, 465);
            this.panel6.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "previous Data";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.Controls.Add(this.btnScheduled);
            this.panel7.Controls.Add(this.AddData);
            this.panel7.Location = new System.Drawing.Point(481, 205);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(113, 465);
            this.panel7.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.btnAlerts);
            this.panel8.Location = new System.Drawing.Point(699, 100);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(113, 465);
            this.panel8.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Communication \r\nand Alerts";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.btnOtherSystems);
            this.panel9.Location = new System.Drawing.Point(941, 205);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(113, 465);
            this.panel9.TabIndex = 9;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.btnCalendar);
            this.panel10.Location = new System.Drawing.Point(1172, 100);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(113, 465);
            this.panel10.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Calendar and \r\nActivities";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // welcomeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "welcomeform";
            this.Text = "welcomeform";
            this.toolTip1.SetToolTip(this, "Close");
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPreviousData;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label btnScheduled;
        private System.Windows.Forms.Button AddData;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlerts;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOtherSystems;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalendar;
    }
}

