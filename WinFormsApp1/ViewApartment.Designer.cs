namespace WinFormsApp1
{
    partial class ViewApartment
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
            this.apartmentNumber = new System.Windows.Forms.Label();
            this.apartmentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apartmentStatus = new System.Windows.Forms.Label();
            this.editTenant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apartmentNumber
            // 
            this.apartmentNumber.AutoSize = true;
            this.apartmentNumber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apartmentNumber.Location = new System.Drawing.Point(63, 198);
            this.apartmentNumber.Name = "apartmentNumber";
            this.apartmentNumber.Size = new System.Drawing.Size(247, 30);
            this.apartmentNumber.TabIndex = 6;
            this.apartmentNumber.Text = "--------------------------";
            // 
            // apartmentName
            // 
            this.apartmentName.AutoSize = true;
            this.apartmentName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apartmentName.Location = new System.Drawing.Point(63, 81);
            this.apartmentName.Name = "apartmentName";
            this.apartmentName.Size = new System.Drawing.Size(247, 30);
            this.apartmentName.TabIndex = 7;
            this.apartmentName.Text = "--------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apartment Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // apartmentStatus
            // 
            this.apartmentStatus.AutoSize = true;
            this.apartmentStatus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apartmentStatus.Location = new System.Drawing.Point(63, 307);
            this.apartmentStatus.Name = "apartmentStatus";
            this.apartmentStatus.Size = new System.Drawing.Size(247, 30);
            this.apartmentStatus.TabIndex = 6;
            this.apartmentStatus.Text = "--------------------------";
            // 
            // editTenant
            // 
            this.editTenant.BackColor = System.Drawing.SystemColors.Highlight;
            this.editTenant.FlatAppearance.BorderSize = 0;
            this.editTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTenant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editTenant.Location = new System.Drawing.Point(375, 358);
            this.editTenant.Name = "editTenant";
            this.editTenant.Size = new System.Drawing.Size(104, 33);
            this.editTenant.TabIndex = 9;
            this.editTenant.Text = "Edit";
            this.editTenant.UseVisualStyleBackColor = false;
            this.editTenant.Click += new System.EventHandler(this.editTenant_Click_1);
            // 
            // ViewApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 437);
            this.Controls.Add(this.editTenant);
            this.Controls.Add(this.apartmentStatus);
            this.Controls.Add(this.apartmentNumber);
            this.Controls.Add(this.apartmentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewApartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Apartment Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label apartmentNumber;
        private Label apartmentName;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label apartmentStatus;
        private Button editTenant;
    }
}