namespace WinFormsApp1
{
    partial class EditTenant
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
            this.editTenantBtn = new System.Windows.Forms.Button();
            this.tenantGenderInput = new System.Windows.Forms.ComboBox();
            this.tenantNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editTenantBtn
            // 
            this.editTenantBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.editTenantBtn.FlatAppearance.BorderSize = 0;
            this.editTenantBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTenantBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editTenantBtn.Location = new System.Drawing.Point(333, 263);
            this.editTenantBtn.Name = "editTenantBtn";
            this.editTenantBtn.Size = new System.Drawing.Size(104, 33);
            this.editTenantBtn.TabIndex = 2;
            this.editTenantBtn.Text = "Edit";
            this.editTenantBtn.UseVisualStyleBackColor = false;
            this.editTenantBtn.Click += new System.EventHandler(this.editTenantBtn_Click_1);
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
            this.tenantGenderInput.Location = new System.Drawing.Point(47, 190);
            this.tenantGenderInput.MinimumSize = new System.Drawing.Size(390, 0);
            this.tenantGenderInput.Name = "tenantGenderInput";
            this.tenantGenderInput.Size = new System.Drawing.Size(390, 38);
            this.tenantGenderInput.TabIndex = 1;
            // 
            // tenantNameInput
            // 
            this.tenantNameInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tenantNameInput.Location = new System.Drawing.Point(47, 89);
            this.tenantNameInput.Name = "tenantNameInput";
            this.tenantNameInput.Size = new System.Drawing.Size(390, 36);
            this.tenantNameInput.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Full name";
            // 
            // EditTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.editTenantBtn);
            this.Controls.Add(this.tenantGenderInput);
            this.Controls.Add(this.tenantNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditTenant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Tenant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button editTenantBtn;
        private ComboBox tenantGenderInput;
        private TextBox tenantNameInput;
        private Label label2;
        private Label label1;
    }
}