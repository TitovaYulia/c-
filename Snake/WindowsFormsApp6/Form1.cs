using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        int n = 0, dir, score=0 ;
        bool keypress, gr = false;
        PictureBox[] massPicture = new PictureBox[100];
        
        
        public Form1()
        {
            
            InitializeComponent();
            pictureBox1.BringToFront();
            bStart.Text = "Start";
            pictureBox1.Left = 223;
            pictureBox1.Top = 203;
            timer1.Enabled = false;
            pictureBox2.SendToBack();
            massPicture[0] = pictureBox1;
            label1.BackColor = Color.Transparent;
         
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            
            if (gr == false)
            {
            for (int i = 10; i <= 410; i += 20)
            {
                e.Graphics.DrawLine(System.Drawing.Pens.DarkOliveGreen, 10, i, 410, i);
                e.Graphics.DrawLine(System.Drawing.Pens.DarkOliveGreen, i, 410, i, 10);
            }
                Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
                
                e.Graphics.DrawRectangle(blackPen, 8, 8, 404, 404);
                gr =true;
            }
            

        }



        private void bStart_Click(object sender, EventArgs e)

        {
             if (bStart.Text == "Start")
            {
                bStart.Text = "Restart";
                bStart.BackColor = Color.DarkOliveGreen;

                timer1.Enabled = true;

                randomApple();

                                
            }
            else
            {
                bStart.Text = "Start";
                bStart.BackColor = Color.Olive;
                timer1.Enabled = false;
                pictureBox1.Left = 223;
                pictureBox1.Top = 203;
                dir = 0;
                for (int i = 1; i <= n; i++)
                {
                 massPicture[i].Dispose();
                 massPicture[i] = null;
                 
                    label1.Text = "Score: 0";
                    score = 0;
                }
                   
                
                n = 0;
            }
            
        }

        private void bStart_KeyDown(object sender, KeyEventArgs e)
        //set direction
        {
            {
                if (e.KeyCode == Keys.W && dir != 2 && keypress == false)
                {
                    dir = 1;
                    keypress = true;
                };
                if (e.KeyCode == Keys.S && dir != 1 && keypress == false)
                {
                    dir = 2;
                    keypress = true;
                };
                if (e.KeyCode == Keys.D && dir != 4 && keypress == false)
                {
                    dir = 3;
                    keypress = true;
                };
                if (e.KeyCode == Keys.A && dir != 3 && keypress == false)

                {
                    dir = 4;
                    keypress = true;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           
            Image bmp = Image.FromFile("C:\\Users\\Администратор\\source\\repos\\Snake\\picture\\snake2.png");
            {
                
                int x = massPicture[n].Top;
                int y = massPicture[n].Left;
                for (int i=n; i>0; i--)
                    {
                    overFromTail(i);
                    overFromBorder();
                    massPicture[i].BringToFront();
                    //move
                    massPicture[i].Top = massPicture[i-1].Top;
                    massPicture[i].Left = massPicture[i-1].Left;
                    if (massPicture[i].Top == pictureBox3.Top && massPicture[i].Left == pictureBox3.Left)
                        do
                            randomApple();
                        while (massPicture[i].Top == pictureBox3.Top && massPicture[i].Left == pictureBox3.Left);


                    }



                
                if (dir == 1)
                {
                    pictureBox1.Top -= 20;
                    bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
                    massPicture[0].Image = bmp;
                    keypress = false;


                }
                if (dir == 2)
                {
                    pictureBox1.Top += 20;
                    
                    bmp.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                    massPicture[0].Image = bmp;
                    keypress = false;
                }
                    if (dir == 3) 
                {
                    pictureBox1.Left += 20;
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipX);
                    massPicture[0].Image = bmp;
                    keypress = false;
                }
                if (dir == 4) 
                {
                    pictureBox1.Left -= 20;
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    massPicture[0].Image = bmp;
                    keypress = false;
                }



                if (pictureBox3.Top == pictureBox1.Top && pictureBox1.Left == pictureBox3.Left)
                    //add snakes part 
                {
                    n++;
                    
                    score += 100;
                    
                    label1.Text = "Score:  " + score.ToString();
                    massPicture[n] = new PictureBox();
                    massPicture[n].Top = x;
                    massPicture[n].Left = y;
                    massPicture[n].BackColor = System.Drawing.Color.Orange;
                    massPicture[n].Image = Image.FromFile("C:\\Users\\Администратор\\source\\repos\\Snake\\picture\\snake5.png");
                    massPicture[n].Size = new System.Drawing.Size(19, 19);
                    Controls.Add(massPicture[n]);
                    randomApple();
                }

            }

        }

       

        public void overFromBorder()
        {
            if (pictureBox1.Top < 10 || pictureBox1.Top > 410 || pictureBox1.Left < 10 || pictureBox1.Left > 410)

            {
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER \n yore score:  " + score.ToString());
                bStart.BackColor = Color.Orange;
            }

        }
        
        public void overFromTail(int i)
        {
            
            if (massPicture[0].Left == massPicture[i].Left && massPicture[0].Top == massPicture[i].Top)
            {
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER \n yore score:  " + score.ToString());
                bStart.BackColor = Color.Orange;
            }
        }

        

        public void randomApple()
        {
            Random rand = new Random();
            bool a = false;
            int i = 0;
            

            for (i = 0; i <= n; i++)
            {

                a = false;

                do
                {
                    pictureBox3.Top = 23 + rand.Next(20) * 20;
                    pictureBox3.Left = 23 + rand.Next(20) * 20;
                    if (a == true) i = 0;
                    a = true;
                
                    
                }
                while (massPicture[i].Top == pictureBox3.Top && massPicture[i].Left == pictureBox3.Left); 
            }
                           


        }
    
    }
}
