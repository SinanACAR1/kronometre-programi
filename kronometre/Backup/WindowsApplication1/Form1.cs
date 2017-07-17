using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 0;
        int dakika = 0;
        int salise = 0;
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            label3.Text = salise.ToString();
            if (salise == 10)
            {
                saniye++;
                salise = 0;
                label3.Text = salise.ToString();
                label2.Text = saniye.ToString();
            }
            if (saniye == 59)
            {
                dakika++;
                saniye = 0;
                label2.Text = saniye.ToString();
                label1.Text = dakika.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            i++;
            listBox1.Items.Add(i+"." + " Tur " +label1.Text +" dakika " + label2.Text+" saniye "+ label3.Text+ " salise ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            saniye = 0;
            dakika = 0;
            salise = 0;
            i = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
        }
    }
}