using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class QueuingForm : Form
    {
       

        public QueuingForm()
        {
            cashier = new CashierClass();
            InitializeComponent();
        }

        private CashierClass cashier;

        private void Form1_Load(object sender, EventArgs e)
        {
            CashierWindowQueue frm = new CashierWindowQueue();
            frm.Show();
        }
        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
           
        }



    }

}