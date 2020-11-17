using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Form1 : Form
   {
        string[] numbers = new string[4];
        Random rndnum = new Random();
        bool match1 = false;
        bool match2 = false;
        bool match3 = false;
        bool match4 = false;
        int iterations = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
            pictureBox2.BackColor = Color.Red;
            pictureBox3.BackColor = Color.Red;
            pictureBox4.BackColor = Color.Red;
            for (int i = 0; i < 4; i++)
            {
                int num = rndnum.Next(1, 9);
                numbers[i] = Convert.ToString(num);
                
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        void calculate() 
        {
            iterations = 0;
            try
            {
                if (textBox1.TextLength == 4)
                {
                    if ((numbers[0]) == textBox1.Text.Substring(0,1)) 
                    {
                        //pictureBox1.BackColor = Color.Green;
                        iterations++;
                    }
                    if ((numbers[1]) == textBox1.Text.Substring(1, 1))
                    {
                        //pictureBox2.BackColor = Color.Green;
                        iterations++;
                    }
                    if ((numbers[2]) == textBox1.Text.Substring(2, 1))
                    {
                        //pictureBox3.BackColor = Color.Green;
                        iterations++;
                    }
                    if ((numbers[3]) == textBox1.Text.Substring(3, 1))
                    {
                        //pictureBox4.BackColor = Color.Green;
                        iterations++;
                    }
                    if ((numbers[0]) == textBox1.Text.Substring(0, 1) & (numbers[1]) == textBox1.Text.Substring(1, 1) & (numbers[2]) == textBox1.Text.Substring(2, 1) & (numbers[3]) == textBox1.Text.Substring(3, 1)) 
                    {
                        MessageBox.Show("You Win!");
                    }
                    
                    switch (iterations) 
                    {
                        
                        case (1):
                            pictureBox1.BackColor = Color.Green;
                            pictureBox2.BackColor = Color.Red;
                            pictureBox3.BackColor = Color.Red;
                            pictureBox4.BackColor = Color.Red;
                            break;
                        case (2):
                            pictureBox1.BackColor = Color.Green;
                            pictureBox2.BackColor = Color.Green;
                            pictureBox3.BackColor = Color.Red;
                            pictureBox4.BackColor = Color.Red;
                            break;
                        case (3):
                            pictureBox1.BackColor = Color.Green;
                            pictureBox2.BackColor = Color.Green;
                            pictureBox3.BackColor = Color.Green;
                            pictureBox4.BackColor = Color.Red;
                            break;
                        case (4):
                            pictureBox1.BackColor = Color.Green;
                            pictureBox2.BackColor = Color.Green;
                            pictureBox3.BackColor = Color.Green;
                            pictureBox4.BackColor = Color.Green;
                            break;
                    }
                }
                if(textBox1.TextLength > 4)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    pictureBox1.BackColor = Color.Red;
                    pictureBox2.BackColor = Color.Red;
                    pictureBox3.BackColor = Color.Red;
                    pictureBox4.BackColor = Color.Red;
                }
                if (textBox1.Text.Length < 4) 
                {
                    pictureBox1.BackColor = Color.Red;
                    pictureBox2.BackColor = Color.Red;
                    pictureBox3.BackColor = Color.Red;
                    pictureBox4.BackColor = Color.Red;
                }
            }
            catch 
            {
                return;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
