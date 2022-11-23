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
    public partial class ViewApartment : Form
    {
        Apartment.ApartmentInfo? apartment;
        public ViewApartment(int id)
        {
            InitializeComponent();
            this.Enabled = false;
            this.apartment = Apartment.FetchById(id);
            if (this.apartment == null)
            {
                this.Close();
                MessageBox.Show("Apartment not found");
                return;
            }
            apartmentName.Text = this.apartment.Name;
            apartmentNumber.Text = this.apartment.ApartmentNo;
            apartmentStatus.Text = this.apartment.status;
            this.Enabled = true;
        }

        private void editTenant_Click_1(object sender, EventArgs e)
        {
            EditApartment form = new(apartment.Id);
            form.ShowDialog();
            this.Close();
        }
    }
}
