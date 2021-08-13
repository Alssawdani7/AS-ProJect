using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSystem.PL
{
    public partial class FormMain : Form
    {
        int x, y;

        public FormMain()
        {
            InitializeComponent();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pages.SetPage(((Control)sender).Name);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("  x = " + x + "      y = " + y);
        }

        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            x = this.Location.X;
            y = this.Location.Y;

            MessageBox.Show("  x = " + x + "      y = " + y);
        }

        private void ucCustomer1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void ucCustomer1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void FormMain_MouseClick(object sender, MouseEventArgs e)
        {

            MessageBox.Show("  x = " + e.X + "      y = " + e.Y);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.WindowState = FormWindowState.Maximized;
        }
    }
}
