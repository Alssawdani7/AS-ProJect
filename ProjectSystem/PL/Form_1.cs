using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSystem
{
    public partial class FormMain : Form
    {
        AS_DBEntities dbAS = new AS_DBEntities();

        public FormMain()
        {
            InitializeComponent();

            
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            pages.SetPage(((Control)sender).Name);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
