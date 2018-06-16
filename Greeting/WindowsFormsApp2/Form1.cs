using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "приветстввие";
            label1.Text = "Введите ваше имя";
            label2.Text = "";
            button1.Text = "Поприветствовать";
            toolTip1.SetToolTip(textBox1, "введите имя");
            toolTip1.IsBalloon = true;

        }
       
        private void button1_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "Вводи уже";


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label2.Text = "Введите имя";
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.Text = textBox1.Text;
             button1.BackColor = Color.Aqua;
            MessageBox.Show("Привет, " + textBox1.Text, "Приветствие");
            }
            

        }

      
    }
}
