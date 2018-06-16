using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Calc calc1 = new Calc();
        

        public Form1()
        {
            InitializeComponent();

        }

        private void procNumericButton(object sender, EventArgs e)
        {
            calc1.Pin((sender as Button).Text);
            Print();
        }
      
        private void actNumericButton(object sender, EventArgs e)
        {
            calc1.Act((sender as Button).Text);
            Print();
          

        }
                
         private void bEqually_Click(object sender, EventArgs e)
         {
            calc1.Act(bEqually.AccessibleDescription);
            calc1.Equally(bEqually.AccessibleDescription);
            Print();
            calc1.Null();
        }

        public void Print()
        {
            
            textBox3.Text = calc1.result.ToString();
            if (calc1.result.ToString() == "Ошибка")
            {
                calc1.Null();
            }
        }

        private void bC_Click(object sender, EventArgs e)
        {
            calc1.Null();
            Print();
        }

        
    }



   
}

