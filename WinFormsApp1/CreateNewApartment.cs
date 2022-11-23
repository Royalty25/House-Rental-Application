using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class CreateNewApartment : Form
    {
        public CreateNewApartment()
        {
            InitializeComponent();
        }

        public event EventHandler onCreate;

        private void createApartmentBtn_Click_1(object sender, EventArgs e)
        {
            string name = apartmentNameInput.Text.Trim();
            string apartNo = apartmentNoInput.Text.Trim();
            string status = apartmentStatusInput.Text.Trim();
            Apartment apartment = new Apartment(0, name, apartNo, status);
            this.Enabled = false;
            if (apartment.Create())
            {
                apartmentNameInput.Text = "";
                apartmentNoInput.Text = "";
                apartmentStatusInput.SelectedIndex = 0;
                EventHandler handler = this.onCreate;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
                MessageBox.Show("Apartment created successfully!");
            }
            this.Enabled = true;
        }
    }
}
