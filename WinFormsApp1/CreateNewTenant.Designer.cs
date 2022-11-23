namespace WinFormsApp1
{
    partial class CreateNewTenant
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tenantNameInput = new System.Windows.Forms.TextBox();
            this.tenantGenderInput = new System.Windows.Forms.ComboBox();
            this.createTenantBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender";
            // 
            // tenantNameInput
            // 
            this.tenantNameInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tenantNameInput.Location = new System.Drawing.Point(45, 79);
            this.tenantNameInput.Name = "tenantNameInput";
            this.tenantNameInput.Size = new System.Drawing.Size(390, 36);
            this.tenantNameInput.TabIndex = 0;
            // 
            // tenantGenderInput
            // 
            this.tenantGenderInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tenantGenderInput.FormattingEnabled = true;
            this.tenantGenderInput.ItemHeight = 30;
            this.tenantGenderInput.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.tenantGenderInput.Location = new System.Drawing.Point(45, 180);
            this.tenantGenderInput.MinimumSize = new System.Drawing.Size(390, 0);
            this.tenantGenderInput.Name = "tenantGenderInput";
            this.tenantGenderInput.Size = new System.Drawing.Size(390, 38);
            this.tenantGenderInput.TabIndex = 1;
            // 
            // createTenantBtn
            // 
            this.createTenantBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.createTenantBtn.FlatAppearance.BorderSize = 0;
            this.createTenantBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTenantBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createTenantBtn.Location = new System.Drawing.Point(331, 253);
            this.createTenantBtn.Name = "createTenantBtn";
            this.createTenantBtn.Size = new System.Drawing.Size(104, 33);
            this.createTenantBtn.TabIndex = 2;
            this.createTenantBtn.Text = "Create";
            this.createTenantBtn.UseVisualStyleBackColor = false;
            this.createTenantBtn.Click += new System.EventHandler(this.createTenantBtn_Click_1);
            // 
            // CreateNewTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.createTenantBtn);
            this.Controls.Add(this.tenantGenderInput);
            this.Controls.Add(this.tenantNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewTenant";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Tenant";
            this.Load += new System.EventHandler(this.CreateNewTenant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox tenantNameInput;
        private ComboBox tenantGenderInput;
        private Button createTenantBtn;
    }
}