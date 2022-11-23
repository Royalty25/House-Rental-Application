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
    public partial class ViewTenant : Form
    {
        Tenant.TenantInfo? tenant;
        public ViewTenant(int id)
        {
            InitializeComponent();
            this.Enabled = false;
            this.tenant = Tenant.FetchById(id);
            if (this.tenant == null)
            {
                this.Close();
                MessageBox.Show("Tenant not found");
                return;
            }
            tenantName.Text = this.tenant.Name;
            tenantGender.Text = this.tenant.Gender;
            this.Enabled = true;
        }


        private void editTenant_Click_1(object sender, EventArgs e)
        {
            EditTenant form = new(tenant.Id);
            form.ShowDialog();
            this.Close();
        }
    }
}
