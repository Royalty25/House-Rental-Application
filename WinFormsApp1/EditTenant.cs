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
    public partial class EditTenant : Form
    {
        int id;

        public EditTenant(int id)
        {
            InitializeComponent();
            this.id = id;
            Tenant.TenantInfo? info = Tenant.FetchById(id);
            if(info == null)
            {
                this.Close();
                MessageBox.Show("Tenant not found");
                return;
            }
            tenantNameInput.Text = info.Name;
            if(info.Gender == "Male")
            {
                tenantGenderInput.SelectedIndex = 1;
            }
            else
            {
                tenantGenderInput.SelectedIndex = 2;
            }
            
        }

        public event EventHandler? onUpdate;

        private void editTenantBtn_Click_1(object sender, EventArgs e)
        {
            string fullName = tenantNameInput.Text.Trim();
            string gender = tenantGenderInput.Text.Trim();
            Tenant tenant = new Tenant(id, fullName, gender);
            this.Enabled = false;
            if (tenant.Update())
            {
                EventHandler handler = this.onUpdate;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
                MessageBox.Show("Tenant updated successfully!");
            }
            this.Enabled = true;
        }
    }
}
