namespace STS
{
    partial class newdata
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
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNewBuses = new System.Windows.Forms.Button();
            this.btnNewSupervisors = new System.Windows.Forms.Button();
            this.btnNewDrivers = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Transportation System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 670);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 30);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 570);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1330, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 570);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnNewDrivers);
            this.panel5.Location = new System.Drawing.Point(100, 183);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 487);
            this.panel5.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(56, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Drivers";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.btnNewSupervisors);
            this.panel6.Location = new System.Drawing.Point(570, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 487);
            this.panel6.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Supervisors";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.btnNewBuses);
            this.panel7.Location = new System.Drawing.Point(1043, 183);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 487);
            this.panel7.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(53, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Buses";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::STS.Properties.Resources.Adobe_Express_2024_05_06_13_26_17;
            this.btnBack.Location = new System.Drawing.Point(26, 106);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNewBuses
            // 
            this.btnNewBuses.FlatAppearance.BorderSize = 0;
            this.btnNewBuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBuses.Image = global::STS.Properties.Resources.Adobe_Express_2024_05_06_12_44_10;
            this.btnNewBuses.Location = new System.Drawing.Point(3, 3);
            this.btnNewBuses.Name = "btnNewBuses";
            this.btnNewBuses.Size = new System.Drawing.Size(194, 173);
            this.btnNewBuses.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnNewBuses, "Buses");
            this.btnNewBuses.UseVisualStyleBackColor = true;
            this.btnNewBuses.Click += new System.EventHandler(this.btnNewBuses_Click);
            // 
            // btnNewSupervisors
            // 
            this.btnNewSupervisors.FlatAppearance.BorderSize = 0;
            this.btnNewSupervisors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSupervisors.Image = global::STS.Properties.Resources.Adobe_Express_2024_05_06_12_43_16;
            this.btnNewSupervisors.Location = new System.Drawing.Point(3, 263);
            this.btnNewSupervisors.Name = "btnNewSupervisors";
            this.btnNewSupervisors.Size = new System.Drawing.Size(194, 173);
            this.btnNewSupervisors.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnNewSupervisors, "Supervisors");
            this.btnNewSupervisors.UseVisualStyleBackColor = true;
            this.btnNewSupervisors.Click += new System.EventHandler(this.btnNewSupervisors_Click);
            // 
            // btnNewDrivers
            // 
            this.btnNewDrivers.FlatAppearance.BorderSize = 0;
            this.btnNewDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDrivers.Image = global::STS.Properties.Resources.Adobe_Express_2024_05_06_12_43_42;
            this.btnNewDrivers.Location = new System.Drawing.Point(3, 3);
            this.btnNewDrivers.Name = "btnNewDrivers";
            this.btnNewDrivers.Size = new System.Drawing.Size(194, 173);
            this.btnNewDrivers.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnNewDrivers, "Drivers");
            this.btnNewDrivers.UseVisualStyleBackColor = true;
            this.btnNewDrivers.Click += new System.EventHandler(this.btnNewDrivers_Click);
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
            this.btnClose.Click += new System.EventHandler(this.C_Click);
            // 
            // newdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newdata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newdata";
            this.Load += new System.EventHandler(this.newdata_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnNewDrivers;
        private System.Windows.Forms.Button btnNewSupervisors;
        private System.Windows.Forms.Button btnNewBuses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
    }
}