using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] a = new string[3];
            String[] b = new string[3];
            String[] c = new string[3];
            a[0] = Convert.ToString(textBox1.Text);
            b[0] = Convert.ToString(textBox2.Text);
            c[0] = Convert.ToString(textBox3.Text);
            a[1] = Convert.ToString(textBox4.Text);
            b[1] = Convert.ToString(textBox5.Text);
            c[1] = Convert.ToString(textBox6.Text);
            a[2] = Convert.ToString(textBox7.Text);
            b[2] = Convert.ToString(textBox8.Text);
            c[2] = Convert.ToString(textBox9.Text);


            for (int k = 0; k <3; k++)
            {
                for (int i = 0; i <3; i++)
                {
                    for (int j = 0; j <3; j++)
                    {
                        listBox1.Items.Add(a[k]+b[i]+c[j]);
                    }

                }
            }
            


        }
    }
}
