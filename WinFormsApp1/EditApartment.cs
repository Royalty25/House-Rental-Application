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
    public partial class EditApartment : Form
    {
        Apartment.ApartmentInfo? apartment;
        int id;
        public EditApartment(int id)
        {
            InitializeComponent();
            this.id = id;
            this.apartment = Apartment.FetchById(id);
            if(this.apartment == null)
            {
                this.Close();
                MessageBox.Show("Apartment could not be found");
                return;
            }
            apartmentNameInput.Text = this.apartment.Name;
            apartmentNoInput.Text = this.apartment.ApartmentNo;
            if (this.apartment.status == "Available")
            {
                apartmentStatusInput.SelectedIndex = 0;
            }
            else if(this.apartment.status == "Unavailable")
            {
                apartmentStatusInput.SelectedIndex = 1;
            }
            else
            {
                apartmentStatusInput.Text = "Leased";
                apartmentStatusInput.Enabled = false;
            }
        }

        public event EventHandler? onUpdate;

        private void editApartmentBtn_Click_1(object sender, EventArgs e)
        {
            string name = apartmentNameInput.Text.Trim();
            string apartNo = apartmentNoInput.Text.Trim();
            string status = apartmentStatusInput.Text.Trim();
            Apartment apartment = new Apartment(this.id, name, apartNo, status);
            this.Enabled = false;
            if (apartment.Update())
            {
                EventHandler handler = this.onUpdate;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
                MessageBox.Show("Apartment updated successfully!");
            }
            this.Enabled = true;
        }
    }
}
