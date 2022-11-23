namespace WinFormsApp1
{
    partial class EditApartment
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
            this.editApartmentBtn = new System.Windows.Forms.Button();
            this.apartmentStatusInput = new System.Windows.Forms.ComboBox();
            this.apartmentNoInput = new System.Windows.Forms.TextBox();
            this.apartmentNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editApartmentBtn
            // 
            this.editApartmentBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.editApartmentBtn.FlatAppearance.BorderSize = 0;
            this.editApartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editApartmentBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editApartmentBtn.Location = new System.Drawing.Point(333, 315);
            this.editApartmentBtn.Name = "editApartmentBtn";
            this.editApartmentBtn.Size = new System.Drawing.Size(104, 33);
            this.editApartmentBtn.TabIndex = 3;
            this.editApartmentBtn.Text = "Edit";
            this.editApartmentBtn.UseVisualStyleBackColor = false;
            this.editApartmentBtn.Click += new System.EventHandler(this.editApartmentBtn_Click_1);
            // 
            // apartmentStatusInput
            // 
            this.apartmentStatusInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apartmentStatusInput.FormattingEnabled = true;
            this.apartmentStatusInput.ItemHeight = 30;
            this.apartmentStatusInput.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.apartmentStatusInput.Location = new System.Drawing.Point(47, 243);
            this.apartmentStatusInput.MinimumSize = new System.Drawing.Size(390, 0);
            this.apartmentStatusInput.Name = "apartmentStatusInput";
            this.apartmentStatusInput.Size = new System.Drawing.Size(390, 38);
            this.apartmentStatusInput.TabIndex = 2;
            // 
            // apartmentNoInput
            // 
            this.apartmentNoInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apartmentNoInput.Location = new System.Drawing.Point(47, 156);
            this.apartmentNoInput.Name = "apartmentNoInput";
            this.apartmentNoInput.Size = new System.Drawing.Size(390, 36);
            this.apartmentNoInput.TabIndex = 1;
            // 
            // apartmentNameInput
            // 
            this.apartmentNameInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apartmentNameInput.Location = new System.Drawing.Point(47, 67);
            this.apartmentNameInput.Name = "apartmentNameInput";
            this.apartmentNameInput.Size = new System.Drawing.Size(390, 36);
            this.apartmentNameInput.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apartment number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Apartment name";
            // 
            // EditApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 391);
            this.Controls.Add(this.editApartmentBtn);
            this.Controls.Add(this.apartmentStatusInput);
            this.Controls.Add(this.apartmentNoInput);
            this.Controls.Add(this.apartmentNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "EditApartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditApartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button editApartmentBtn;
        private ComboBox apartmentStatusInput;
        private TextBox apartmentNoInput;
        private TextBox apartmentNameInput;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}