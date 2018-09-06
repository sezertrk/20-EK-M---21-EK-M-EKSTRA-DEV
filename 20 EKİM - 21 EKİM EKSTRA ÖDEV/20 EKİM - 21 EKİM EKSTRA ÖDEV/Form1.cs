using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20_EKİM___21_EKİM_EKSTRA_ÖDEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = System.DateTime.Now.ToString();
            for (int i = listBox6.SelectedIndex; i < (listBox6.SelectedIndex + 1); i++)
            {

                listBox6.Items.RemoveAt(i);
                listBox7.Items.RemoveAt(i);
                listBox8.Items.RemoveAt(i);
                listBox9.Items.RemoveAt(i);
                listBox10.Items.RemoveAt(i);
                listBox11.Items.RemoveAt(i);
                

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
 

    }
}

