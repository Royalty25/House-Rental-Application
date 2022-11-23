using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class CreateNewTenant : Form
    {
        public CreateNewTenant()
        {
            InitializeComponent();
        }


        private void CreateNewTenant_Load(object sender, EventArgs e)
        {

        }
        public event EventHandler onCreate;

        private void createTenantBtn_Click_1(object sender, EventArgs e)
        {
            string fullName = tenantNameInput.Text.Trim();
            string gender = tenantGenderInput.Text.Trim();
            Tenant tenant = new Tenant(0, fullName, gender);
            this.Enabled = false;
            if (tenant.Create())
            {
                tenantNameInput.Text = "";
                tenantGenderInput.SelectedIndex = 0;
                EventHandler handler = this.onCreate;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
                MessageBox.Show("Tenant created successfully!");
            }
            this.Enabled = true;
        }
    }
}
