namespace WinFormsApp1
{
    partial class ViewTenant
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
            this.tenantName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tenantGender = new System.Windows.Forms.Label();
            this.editTenant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tenantName
            // 
            this.tenantName.AutoSize = true;
            this.tenantName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tenantName.Location = new System.Drawing.Point(38, 74);
            this.tenantName.Name = "tenantName";
            this.tenantName.Size = new System.Drawing.Size(247, 30);
            this.tenantName.TabIndex = 1;
            this.tenantName.Text = "--------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gender";
            // 
            // tenantGender
            // 
            this.tenantGender.AutoSize = true;
            this.tenantGender.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tenantGender.Location = new System.Drawing.Point(38, 191);
            this.tenantGender.Name = "tenantGender";
            this.tenantGender.Size = new System.Drawing.Size(247, 30);
            this.tenantGender.TabIndex = 1;
            this.tenantGender.Text = "--------------------------";
            // 
            // editTenant
            // 
            this.editTenant.BackColor = System.Drawing.SystemColors.Highlight;
            this.editTenant.FlatAppearance.BorderSize = 0;
            this.editTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTenant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editTenant.Location = new System.Drawing.Point(315, 268);
            this.editTenant.Name = "editTenant";
            this.editTenant.Size = new System.Drawing.Size(104, 33);
            this.editTenant.TabIndex = 10;
            this.editTenant.Text = "Edit";
            this.editTenant.UseVisualStyleBackColor = false;
            this.editTenant.Click += new System.EventHandler(this.editTenant_Click_1);
            // 
            // ViewTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 363);
            this.Controls.Add(this.editTenant);
            this.Controls.Add(this.tenantGender);
            this.Controls.Add(this.tenantName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewTenant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Tenant Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label tenantName;
        private Label label2;
        private Label tenantGender;
        private Button editTenant;
    }
}