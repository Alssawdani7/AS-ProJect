using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSystem.PL
{
    public partial class ucMeter : UserControl
    {
        public ucMeter()
        {
            InitializeComponent();
        }

        private void btnAddMeter_Click(object sender, EventArgs e)
        {
            formMeter = new FormMeter();
            formMeter.ShowDialog();


        }
    }
}
