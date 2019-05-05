using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2002807_Maeda_MailOrder12;

namespace _2002807_Maeda_MailOrder12
{
    public partial class customerInformation : Form
    {
        public customerInfo SelectedCustomer { get; set; }

        public customerInformation()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerInformation_Activated(object sender, EventArgs e)
        {
            orderInfo.Text = SelectedCustomer.ToString();
        }
    }
}
