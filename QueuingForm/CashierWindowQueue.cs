using System;
using System.Collections;
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
    public partial class CashierWindowQueue : Form
    {
        CustomerView customerView = new CustomerView();
             
        public CashierWindowQueue()
        {
            InitializeComponent();                    
        }

       private void btnRefresh_Click(object sender, EventArgs e)
        {
           
            DisplayCashierQueue(CashierClass.CashierQueue);
            
        }   

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach(Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
                
            }
        }       
        private void btnNext_Click(object sender, EventArgs e)
        {
           
            try
            {
                string nowServing = CashierClass.CashierQueue.Peek();
                DisplayCashierQueue(CashierClass.CashierQueue.Dequeue());
                customerView.lblServing.Text = nowServing;
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No one is in the queue");
            }

        }     
        private void timer1_Tick(object sender, EventArgs e)
        {       
            DisplayCashierQueue(CashierClass.CashierQueue);
            
        }

        
    }
}
