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
    public partial class ucCustomer : UserControl
    {
        //AS_DBEntities dbAS = new AS_DBEntities();

        PL.FormAddCust formAddCust;

        public ucCustomer()
        {
            InitializeComponent();

           this.txtSearch.PlaceholderText = "البحث";

            /*dgvCustomer.DataSource = dbAS.View_Customer.ToList();
            dbAS.SaveChanges();*/
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            formAddCust = new FormAddCust();
            formAddCust.ShowDialog();
            
        }
    }
}
