namespace STS
{
    partial class sentalert
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1330, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 600);
            this.panel3.TabIndex = 40;
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
            this.panel1.TabIndex = 38;
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
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::STS.Properties.Resources.Adobe_Express_2024_05_06_13_26_17;
            this.btnBack.Location = new System.Drawing.Point(39, 106);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 39;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 600);
            this.panel4.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 670);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1310, 30);
            this.panel2.TabIndex = 42;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(26, 163);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(1298, 475);
            this.dataGridView6.TabIndex = 43;
            this.dataGridView6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellContentClick);
            // 
            // sentalert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sentalert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sentalert";
            this.Load += new System.EventHandler(this.sentalert_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView6;
    }
}