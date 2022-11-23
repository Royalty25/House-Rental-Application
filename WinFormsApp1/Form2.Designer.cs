namespace WinFormsApp1
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dashboard = new System.Windows.Forms.TabPage();
            this.viewLeaseFromDashboard = new System.Windows.Forms.Button();
            this.createLeaseFromDashboard = new System.Windows.Forms.Button();
            this.viewApartmentFromDashboard = new System.Windows.Forms.Button();
            this.viewTenantFromDashboard = new System.Windows.Forms.Button();
            this.createApartmentFromDashboard = new System.Windows.Forms.Button();
            this.createTenantFromDashboard = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalLease = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.leasedApartments = new System.Windows.Forms.Label();
            this.totalApartments = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalTenants = new System.Windows.Forms.Label();
            this.tenants = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.apartments = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.refreshApartmentBtn = new System.Windows.Forms.Button();
            this.createApartmentBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lease = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.leaseRefreshBtn = new System.Windows.Forms.Button();
            this.leaseCreateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.dashboard.SuspendLayout();
            this.tenants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.apartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.lease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dashboard);
            this.tabControl1.Controls.Add(this.tenants);
            this.tabControl1.Controls.Add(this.apartments);
            this.tabControl1.Controls.Add(this.lease);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 15);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1144, 625);
            this.tabControl1.TabIndex = 0;
            // 
            // dashboard
            // 
            this.dashboard.Controls.Add(this.viewLeaseFromDashboard);
            this.dashboard.Controls.Add(this.createLeaseFromDashboard);
            this.dashboard.Controls.Add(this.viewApartmentFromDashboard);
            this.dashboard.Controls.Add(this.viewTenantFromDashboard);
            this.dashboard.Controls.Add(this.createApartmentFromDashboard);
            this.dashboard.Controls.Add(this.createTenantFromDashboard);
            this.dashboard.Controls.Add(this.label14);
            this.dashboard.Controls.Add(this.label13);
            this.dashboard.Controls.Add(this.label10);
            this.dashboard.Controls.Add(this.label11);
            this.dashboard.Controls.Add(this.totalLease);
            this.dashboard.Controls.Add(this.label12);
            this.dashboard.Controls.Add(this.label9);
            this.dashboard.Controls.Add(this.label6);
            this.dashboard.Controls.Add(this.leasedApartments);
            this.dashboard.Controls.Add(this.totalApartments);
            this.dashboard.Controls.Add(this.label4);
            this.dashboard.Controls.Add(this.totalTenants);
            this.dashboard.Location = new System.Drawing.Point(4, 48);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.dashboard.Size = new System.Drawing.Size(1136, 573);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            // 
            // viewLeaseFromDashboard
            // 
            this.viewLeaseFromDashboard.BackColor = System.Drawing.SystemColors.Highlight;
            this.viewLeaseFromDashboard.FlatAppearance.BorderSize = 0;
            this.viewLeaseFromDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewLeaseFromDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewLeaseFromDashboard.Location = new System.Drawing.Point(882, 423);
            this.viewLeaseFromDashboard.Name = "viewLeaseFromDashboard";
            this.viewLeaseFromDashboard.Size = new System.Drawing.Size(104, 33);
            this.viewLeaseFromDashboard.TabIndex = 11;
            this.viewLeaseFromDashboard.Text = "View All";
            this.viewLeaseFromDashboard.UseVisualStyleBackColor = false;
            this.viewLeaseFromDashboard.Click += new System.EventHandler(this.viewLeaseFromDashboard_Click_1);
            // 
            // createLeaseFromDashboard
            // 
            this.createLeaseFromDashboard.BackColor = System.Drawing.SystemColors.Highlight;
            this.createLeaseFromDashboard.FlatAppearance.BorderSize = 0;
            this.createLeaseFromDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createLeaseFromDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createLeaseFromDashboard.Location = new System.Drawing.Point(755, 423);
            this.createLeaseFromDashboard.Name = "createLeaseFromDashboard";
            this.createLeaseFromDashboard.Size = new System.Drawing.Size(104, 33);
            this.createLeaseFromDashboard.TabIndex = 10;
            this.createLeaseFromDashboard.Text = "Create New";
            this.createLeaseFromDashboard.UseVisualStyleBackColor = false;
            this.createLeaseFromDashboard.Click += new System.EventHandler(this.createLeaseFromDashboard_Click_1);
            // 
            // viewApartmentFromDashboard
            // 
            this.viewApartmentFromDashboard.BackColor = System.Drawing.SystemColors.Highlight;
            this.viewApartmentFromDashboard.FlatAppearance.BorderSize = 0;
            this.viewApartmentFromDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewApartmentFromDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewApartmentFromDashboard.Location = new System.Drawing.Point(563, 423);
            this.viewApartmentFromDashboard.Name = "viewApartmentFromDashboard";
            this.viewApartmentFromDashboard.Size = new System.Drawing.Size(104, 33);
            this.viewApartmentFromDashboard.TabIndex = 9;
            this.viewApartmentFromDashboard.Text = "View All";
            this.viewApartmentFromDashboard.UseVisualStyleBackColor = false;
            this.viewApartmentFromDashboard.Click += new System.EventHandler(this.viewApartmentFromDashboard_Click_1);
            // 
            // viewTenantFromDashboard
            // 
            this.viewTenantFromDashboard.BackColor = System.Drawing.SystemColors.Highlight;
            this.viewTenantFromDashboard.FlatAppearance.BorderSize = 0;
            this.viewTenantFromDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTenantFromDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewTenantFromDashboard.Location = new System.Drawing.Point(230, 423);
            this.viewTenantFromDashboard.Name = "viewTenantFromDashboard";
            this.viewTenantFromDashboard.Size = new System.Drawing.Size(104, 33);
            this.viewTenantFromDashboard.TabIndex = 8;
            this.viewTenantFromDashboard.Text = "View All";
            this.viewTenantFromDashboard.UseVisualStyleBackColor = false;
            this.viewTenantFromDashboard.Click += new System.EventHandler(this.viewTenantFromDashboard_Click_1);
            // 
            // createApartmentFromDashboard
            // 
            this.createApartmentFromDashboard.BackColor = System.Drawing.SystemColors.Highlight;
            this.createApartmentFromDashboard.FlatAppearance.BorderSize = 0;
            this.createApartmentFromDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createApartmentFromDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createApartmentFromDashboard.Location = new System.Drawing.Point(430, 423);
            this.createApartmentFromDashboard.Name = "createApartmentFromDashboard";
            this.createApartmentFromDashboard.Size = new System.Drawing.Size(104, 33);
            this.createApartmentFromDashboard.TabIndex = 7;
            this.createApartmentFromDashboard.Text = "Create New";
            this.createApartmentFromDashboard.UseVisualStyleBackColor = false;
            this.createApartmentFromDashboard.Click += new System.EventHandler(this.createApartmentFromDashboard_Click_1);
            // 
            // createTenantFromDashboard
            // 
            this.createTenantFromDashboard.BackColor = System.Drawing.SystemColors.Highlight;
            this.createTenantFromDashboard.FlatAppearance.BorderSize = 0;
            this.createTenantFromDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTenantFromDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createTenantFromDashboard.Location = new System.Drawing.Point(92, 423);
            this.createTenantFromDashboard.Name = "createTenantFromDashboard";
            this.createTenantFromDashboard.Size = new System.Drawing.Size(104, 33);
            this.createTenantFromDashboard.TabIndex = 5;
            this.createTenantFromDashboard.Text = "Create New";
            this.createTenantFromDashboard.UseVisualStyleBackColor = false;
            this.createTenantFromDashboard.Click += new System.EventHandler(this.createTenantFromDashboard_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(727, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 37);
            this.label14.TabIndex = 4;
            this.label14.Text = "Lease Records";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(401, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 37);
            this.label13.TabIndex = 4;
            this.label13.Text = "Apartments";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(859, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(92, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 37);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tenants";
            // 
            // totalLease
            // 
            this.totalLease.AutoSize = true;
            this.totalLease.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLease.Location = new System.Drawing.Point(847, 276);
            this.totalLease.Name = "totalLease";
            this.totalLease.Size = new System.Drawing.Size(77, 89);
            this.totalLease.TabIndex = 1;
            this.totalLease.Text = "0";
            this.totalLease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(216, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(665, 37);
            this.label12.TabIndex = 2;
            this.label12.Text = "House Rental Management App by Patience Nkom";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(596, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Leased";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(442, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leasedApartments
            // 
            this.leasedApartments.AutoSize = true;
            this.leasedApartments.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leasedApartments.Location = new System.Drawing.Point(590, 276);
            this.leasedApartments.Name = "leasedApartments";
            this.leasedApartments.Size = new System.Drawing.Size(77, 89);
            this.leasedApartments.TabIndex = 1;
            this.leasedApartments.Text = "0";
            this.leasedApartments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalApartments
            // 
            this.totalApartments.AutoSize = true;
            this.totalApartments.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalApartments.Location = new System.Drawing.Point(430, 276);
            this.totalApartments.Name = "totalApartments";
            this.totalApartments.Size = new System.Drawing.Size(77, 89);
            this.totalApartments.TabIndex = 1;
            this.totalApartments.Text = "0";
            this.totalApartments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(201, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTenants
            // 
            this.totalTenants.AutoSize = true;
            this.totalTenants.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalTenants.Location = new System.Drawing.Point(191, 276);
            this.totalTenants.Name = "totalTenants";
            this.totalTenants.Size = new System.Drawing.Size(77, 89);
            this.totalTenants.TabIndex = 1;
            this.totalTenants.Text = "0";
            this.totalTenants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenants
            // 
            this.tenants.Controls.Add(this.dataGridView1);
            this.tenants.Controls.Add(this.button3);
            this.tenants.Controls.Add(this.label1);
            this.tenants.Controls.Add(this.button1);
            this.tenants.Location = new System.Drawing.Point(4, 48);
            this.tenants.Name = "tenants";
            this.tenants.Padding = new System.Windows.Forms.Padding(3);
            this.tenants.Size = new System.Drawing.Size(1136, 573);
            this.tenants.TabIndex = 1;
            this.tenants.Text = "Tenants";
            this.tenants.UseVisualStyleBackColor = true;
            this.tenants.Click += new System.EventHandler(this.tenants_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1073, 409);
            this.dataGridView1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(880, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tenants";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(997, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // apartments
            // 
            this.apartments.Controls.Add(this.dataGridView2);
            this.apartments.Controls.Add(this.refreshApartmentBtn);
            this.apartments.Controls.Add(this.createApartmentBtn);
            this.apartments.Controls.Add(this.label2);
            this.apartments.Location = new System.Drawing.Point(4, 48);
            this.apartments.Name = "apartments";
            this.apartments.Padding = new System.Windows.Forms.Padding(3);
            this.apartments.Size = new System.Drawing.Size(1136, 573);
            this.apartments.TabIndex = 2;
            this.apartments.Text = "Apartments";
            this.apartments.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 87);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(1076, 456);
            this.dataGridView2.TabIndex = 8;
            // 
            // refreshApartmentBtn
            // 
            this.refreshApartmentBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.refreshApartmentBtn.FlatAppearance.BorderSize = 0;
            this.refreshApartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshApartmentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshApartmentBtn.Location = new System.Drawing.Point(884, 33);
            this.refreshApartmentBtn.Name = "refreshApartmentBtn";
            this.refreshApartmentBtn.Size = new System.Drawing.Size(109, 33);
            this.refreshApartmentBtn.TabIndex = 7;
            this.refreshApartmentBtn.Text = "Refresh";
            this.refreshApartmentBtn.UseVisualStyleBackColor = false;
            this.refreshApartmentBtn.Click += new System.EventHandler(this.refreshApartmentBtn_Click);
            // 
            // createApartmentBtn
            // 
            this.createApartmentBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.createApartmentBtn.FlatAppearance.BorderSize = 0;
            this.createApartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createApartmentBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createApartmentBtn.Location = new System.Drawing.Point(1001, 33);
            this.createApartmentBtn.Name = "createApartmentBtn";
            this.createApartmentBtn.Size = new System.Drawing.Size(104, 33);
            this.createApartmentBtn.TabIndex = 5;
            this.createApartmentBtn.Text = "Create New";
            this.createApartmentBtn.UseVisualStyleBackColor = false;
            this.createApartmentBtn.Click += new System.EventHandler(this.createApartmentBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apartments";
            // 
            // lease
            // 
            this.lease.Controls.Add(this.dataGridView3);
            this.lease.Controls.Add(this.leaseRefreshBtn);
            this.lease.Controls.Add(this.leaseCreateBtn);
            this.lease.Controls.Add(this.label3);
            this.lease.Location = new System.Drawing.Point(4, 48);
            this.lease.Name = "lease";
            this.lease.Padding = new System.Windows.Forms.Padding(3);
            this.lease.Size = new System.Drawing.Size(1136, 573);
            this.lease.TabIndex = 3;
            this.lease.Text = "Lease Records";
            this.lease.UseVisualStyleBackColor = true;
            this.lease.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(29, 87);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 40;
            this.dataGridView3.Size = new System.Drawing.Size(1076, 454);
            this.dataGridView3.TabIndex = 12;
            // 
            // leaseRefreshBtn
            // 
            this.leaseRefreshBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.leaseRefreshBtn.FlatAppearance.BorderSize = 0;
            this.leaseRefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaseRefreshBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leaseRefreshBtn.Location = new System.Drawing.Point(884, 33);
            this.leaseRefreshBtn.Name = "leaseRefreshBtn";
            this.leaseRefreshBtn.Size = new System.Drawing.Size(109, 33);
            this.leaseRefreshBtn.TabIndex = 11;
            this.leaseRefreshBtn.Text = "Refresh";
            this.leaseRefreshBtn.UseVisualStyleBackColor = false;
            this.leaseRefreshBtn.Click += new System.EventHandler(this.leaseRefreshBtn_Click);
            // 
            // leaseCreateBtn
            // 
            this.leaseCreateBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.leaseCreateBtn.FlatAppearance.BorderSize = 0;
            this.leaseCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaseCreateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.leaseCreateBtn.Location = new System.Drawing.Point(1001, 33);
            this.leaseCreateBtn.Name = "leaseCreateBtn";
            this.leaseCreateBtn.Size = new System.Drawing.Size(104, 33);
            this.leaseCreateBtn.TabIndex = 9;
            this.leaseCreateBtn.Text = "Create New";
            this.leaseCreateBtn.UseVisualStyleBackColor = false;
            this.leaseCreateBtn.Click += new System.EventHandler(this.leaseCreateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lease Records";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1144, 625);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House Rental Management App by Patience Nkom";
            this.tabControl1.ResumeLayout(false);
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            this.tenants.ResumeLayout(false);
            this.tenants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.apartments.ResumeLayout(false);
            this.apartments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.lease.ResumeLayout(false);
            this.lease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage dashboard;
        private TabPage tenants;
        private TabPage apartments;
        private TabPage lease;
        private Label label1;
        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button refreshApartmentBtn;
        private Button createApartmentBtn;
        private Label label2;
        private DataGridView dataGridView3;
        private Button leaseRefreshBtn;
        private Button leaseCreateBtn;
        private Label label3;
        private Label label6;
        private Label label9;
        private Label leasedApartments;
        private Label totalApartments;
        private Label label12;
        private Label label10;
        private Label totalLease;
        private Label label14;
        private Label label13;
        private Button createTenantFromDashboard;
        private Label label11;
        private Label label4;
        private Label totalTenants;
        private Button createApartmentFromDashboard;
        private Button viewTenantFromDashboard;
        private Button viewApartmentFromDashboard;
        private Button viewLeaseFromDashboard;
        private Button createLeaseFromDashboard;
    }
}