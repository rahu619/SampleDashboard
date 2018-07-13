namespace LiveChartsAPI
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLineCharts = new System.Windows.Forms.TabPage();
            this.btnLineChart2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.tabColumnCharts = new System.Windows.Forms.TabPage();
            this.btnColumnChart2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.tabRowCharts = new System.Windows.Forms.TabPage();
            this.btnRowChart2 = new System.Windows.Forms.Button();
            this.btnRowChart1 = new System.Windows.Forms.Button();
            this.cartesianChart3 = new LiveCharts.WinForms.CartesianChart();
            this.tabPieCharts = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.tabAngularCharts = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnAngularChart2 = new System.Windows.Forms.Button();
            this.btnAngular = new System.Windows.Forms.Button();
            this.angularGauge1 = new LiveCharts.WinForms.AngularGauge();
            this.angularGauge2 = new LiveCharts.WinForms.AngularGauge();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tabLineCharts.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabColumnCharts.SuspendLayout();
            this.tabRowCharts.SuspendLayout();
            this.tabPieCharts.SuspendLayout();
            this.tabAngularCharts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 103);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "My Dashboard";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(1145, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(107, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Disconnected";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1019, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(749, 24);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(203, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "HAMILTON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(665, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(430, 24);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "18455242";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(341, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // tabLineCharts
            // 
            this.tabLineCharts.Controls.Add(this.comboBox3);
            this.tabLineCharts.Controls.Add(this.btnLineChart2);
            this.tabLineCharts.Controls.Add(this.button2);
            this.tabLineCharts.Controls.Add(this.cartesianChart1);
            this.tabLineCharts.Location = new System.Drawing.Point(4, 29);
            this.tabLineCharts.Name = "tabLineCharts";
            this.tabLineCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabLineCharts.Size = new System.Drawing.Size(1290, 617);
            this.tabLineCharts.TabIndex = 1;
            this.tabLineCharts.Text = "Line Charts";
            this.tabLineCharts.UseVisualStyleBackColor = true;
            // 
            // btnLineChart2
            // 
            this.btnLineChart2.Location = new System.Drawing.Point(52, 99);
            this.btnLineChart2.Name = "btnLineChart2";
            this.btnLineChart2.Size = new System.Drawing.Size(150, 39);
            this.btnLineChart2.TabIndex = 2;
            this.btnLineChart2.Text = "Line Chart 2";
            this.btnLineChart2.UseVisualStyleBackColor = true;
            this.btnLineChart2.Click += new System.EventHandler(this.btnLineChart2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Line Chart 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(253, 26);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(972, 565);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabLineCharts);
            this.tabControl1.Controls.Add(this.tabColumnCharts);
            this.tabControl1.Controls.Add(this.tabRowCharts);
            this.tabControl1.Controls.Add(this.tabPieCharts);
            this.tabControl1.Controls.Add(this.tabAngularCharts);
            this.tabControl1.Location = new System.Drawing.Point(13, 134);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1298, 650);
            this.tabControl1.TabIndex = 1;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.SteelBlue;
            this.tabMain.Controls.Add(this.dataGridView1);
            this.tabMain.Controls.Add(this.label4);
            this.tabMain.Controls.Add(this.panel2);
            this.tabMain.Location = new System.Drawing.Point(4, 29);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1290, 617);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(245, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 526);
            this.dataGridView1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(275, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Display Data with Data grid View";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.btnProducts);
            this.panel2.Controls.Add(this.btnSuppliers);
            this.panel2.Controls.Add(this.btnCustomers);
            this.panel2.Location = new System.Drawing.Point(26, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 572);
            this.panel2.TabIndex = 0;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(25, 177);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(150, 39);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(25, 110);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(150, 39);
            this.btnSuppliers.TabIndex = 1;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(25, 46);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(150, 39);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // tabColumnCharts
            // 
            this.tabColumnCharts.Controls.Add(this.btnColumnChart2);
            this.tabColumnCharts.Controls.Add(this.button3);
            this.tabColumnCharts.Controls.Add(this.cartesianChart2);
            this.tabColumnCharts.Location = new System.Drawing.Point(4, 29);
            this.tabColumnCharts.Name = "tabColumnCharts";
            this.tabColumnCharts.Size = new System.Drawing.Size(1290, 617);
            this.tabColumnCharts.TabIndex = 2;
            this.tabColumnCharts.Text = "Column Charts";
            this.tabColumnCharts.UseVisualStyleBackColor = true;
            // 
            // btnColumnChart2
            // 
            this.btnColumnChart2.Location = new System.Drawing.Point(87, 162);
            this.btnColumnChart2.Name = "btnColumnChart2";
            this.btnColumnChart2.Size = new System.Drawing.Size(150, 39);
            this.btnColumnChart2.TabIndex = 3;
            this.btnColumnChart2.Text = "Column Chart 2";
            this.btnColumnChart2.UseVisualStyleBackColor = true;
            this.btnColumnChart2.Click += new System.EventHandler(this.btnColumnChart2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Column Chart1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(341, 57);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(865, 513);
            this.cartesianChart2.TabIndex = 0;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // tabRowCharts
            // 
            this.tabRowCharts.Controls.Add(this.btnRowChart2);
            this.tabRowCharts.Controls.Add(this.btnRowChart1);
            this.tabRowCharts.Controls.Add(this.cartesianChart3);
            this.tabRowCharts.Location = new System.Drawing.Point(4, 29);
            this.tabRowCharts.Name = "tabRowCharts";
            this.tabRowCharts.Size = new System.Drawing.Size(1290, 617);
            this.tabRowCharts.TabIndex = 3;
            this.tabRowCharts.Text = "Row Charts";
            this.tabRowCharts.UseVisualStyleBackColor = true;
            // 
            // btnRowChart2
            // 
            this.btnRowChart2.Location = new System.Drawing.Point(34, 137);
            this.btnRowChart2.Name = "btnRowChart2";
            this.btnRowChart2.Size = new System.Drawing.Size(150, 39);
            this.btnRowChart2.TabIndex = 3;
            this.btnRowChart2.Text = "Row Chart 2";
            this.btnRowChart2.UseVisualStyleBackColor = true;
            this.btnRowChart2.Click += new System.EventHandler(this.btnRowChart2_Click);
            // 
            // btnRowChart1
            // 
            this.btnRowChart1.Location = new System.Drawing.Point(34, 67);
            this.btnRowChart1.Name = "btnRowChart1";
            this.btnRowChart1.Size = new System.Drawing.Size(150, 39);
            this.btnRowChart1.TabIndex = 2;
            this.btnRowChart1.Text = "Row Chart 1";
            this.btnRowChart1.UseVisualStyleBackColor = true;
            // 
            // cartesianChart3
            // 
            this.cartesianChart3.Location = new System.Drawing.Point(329, 137);
            this.cartesianChart3.Name = "cartesianChart3";
            this.cartesianChart3.Size = new System.Drawing.Size(919, 452);
            this.cartesianChart3.TabIndex = 0;
            this.cartesianChart3.Text = "cartesianChart3";
            // 
            // tabPieCharts
            // 
            this.tabPieCharts.Controls.Add(this.button4);
            this.tabPieCharts.Controls.Add(this.comboBox1);
            this.tabPieCharts.Controls.Add(this.button5);
            this.tabPieCharts.Controls.Add(this.pieChart1);
            this.tabPieCharts.Location = new System.Drawing.Point(4, 29);
            this.tabPieCharts.Name = "tabPieCharts";
            this.tabPieCharts.Size = new System.Drawing.Size(1290, 617);
            this.tabPieCharts.TabIndex = 4;
            this.tabPieCharts.Text = "Pie Charts";
            this.tabPieCharts.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "Pie Chart 2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(215, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 39);
            this.button5.TabIndex = 2;
            this.button5.Text = "Pie Chart 1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(341, 49);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(640, 302);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // tabAngularCharts
            // 
            this.tabAngularCharts.Controls.Add(this.lblTotal);
            this.tabAngularCharts.Controls.Add(this.label6);
            this.tabAngularCharts.Controls.Add(this.label5);
            this.tabAngularCharts.Controls.Add(this.angularGauge2);
            this.tabAngularCharts.Controls.Add(this.comboBox2);
            this.tabAngularCharts.Controls.Add(this.btnAngularChart2);
            this.tabAngularCharts.Controls.Add(this.btnAngular);
            this.tabAngularCharts.Controls.Add(this.angularGauge1);
            this.tabAngularCharts.Location = new System.Drawing.Point(4, 29);
            this.tabAngularCharts.Name = "tabAngularCharts";
            this.tabAngularCharts.Size = new System.Drawing.Size(1290, 617);
            this.tabAngularCharts.TabIndex = 5;
            this.tabAngularCharts.Text = "Angular";
            this.tabAngularCharts.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(563, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(333, 28);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnAngularChart2
            // 
            this.btnAngularChart2.Location = new System.Drawing.Point(53, 88);
            this.btnAngularChart2.Name = "btnAngularChart2";
            this.btnAngularChart2.Size = new System.Drawing.Size(150, 39);
            this.btnAngularChart2.TabIndex = 3;
            this.btnAngularChart2.Text = "Angular Chart 2";
            this.btnAngularChart2.UseVisualStyleBackColor = true;
            this.btnAngularChart2.Click += new System.EventHandler(this.btnAngularChart2_Click);
            // 
            // btnAngular
            // 
            this.btnAngular.Location = new System.Drawing.Point(53, 43);
            this.btnAngular.Name = "btnAngular";
            this.btnAngular.Size = new System.Drawing.Size(150, 39);
            this.btnAngular.TabIndex = 2;
            this.btnAngular.Text = "Angular Chart 1 ";
            this.btnAngular.UseVisualStyleBackColor = true;
            this.btnAngular.Click += new System.EventHandler(this.btnAngular_Click);
            // 
            // angularGauge1
            // 
            this.angularGauge1.BackColor = System.Drawing.Color.White;
            this.angularGauge1.Location = new System.Drawing.Point(426, 235);
            this.angularGauge1.Name = "angularGauge1";
            this.angularGauge1.Size = new System.Drawing.Size(355, 328);
            this.angularGauge1.TabIndex = 0;
            this.angularGauge1.Text = "angularGauge1";
            // 
            // angularGauge2
            // 
            this.angularGauge2.BackColor = System.Drawing.Color.White;
            this.angularGauge2.Location = new System.Drawing.Point(859, 235);
            this.angularGauge2.Name = "angularGauge2";
            this.angularGauge2.Size = new System.Drawing.Size(355, 328);
            this.angularGauge2.TabIndex = 5;
            this.angularGauge2.Text = "angularGauge2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Units in Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(961, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Units on order";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(48, 235);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 29);
            this.lblTotal.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(52, 247);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 28);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1333, 788);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1355, 700);
            this.Name = "Form1";
            this.Text = "Live Charts";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabLineCharts.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabColumnCharts.ResumeLayout(false);
            this.tabRowCharts.ResumeLayout(false);
            this.tabPieCharts.ResumeLayout(false);
            this.tabAngularCharts.ResumeLayout(false);
            this.tabAngularCharts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabLineCharts;
        private System.Windows.Forms.Button button2;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.TabPage tabColumnCharts;
        private System.Windows.Forms.Button button3;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private System.Windows.Forms.TabPage tabRowCharts;
        private System.Windows.Forms.Button btnRowChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart3;
        private System.Windows.Forms.TabPage tabPieCharts;
        private System.Windows.Forms.Button button5;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.TabPage tabAngularCharts;
        private System.Windows.Forms.Button btnAngular;
        private LiveCharts.WinForms.AngularGauge angularGauge1;
        private System.Windows.Forms.Button btnLineChart2;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnColumnChart2;
        private System.Windows.Forms.Button btnRowChart2;
        private System.Windows.Forms.Button btnAngularChart2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private LiveCharts.WinForms.AngularGauge angularGauge2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

