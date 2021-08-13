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
    public partial class FormAddCust : Form
    {
        public FormAddCust()
        {
            InitializeComponent();
        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddCust_Load(object sender, EventArgs e)
        {
            ucCustDataCust1.BringToFront();
        }
    }
}
