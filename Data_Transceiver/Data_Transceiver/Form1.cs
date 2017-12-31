using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Transceiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.PortName = "COM4";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();

            button5.Enabled = false;
            button5.BackColor = Color.Gray;
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("r");
            richTextBox1.Text = serialPort1.ReadLine();
            button1.Enabled = false;
            button1.BackColor = Color.Gray;
            button2.Enabled = true;
            button2.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("t");
            richTextBox1.Text = serialPort1.ReadLine();
            button2.Enabled = false;
            button1.Enabled = true;
            button1.BackColor = Color.Lime;
            button2.BackColor = Color.Gray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("w");
            label1.Text = serialPort1.ReadLine();
            button3.Enabled = false;
            button5.Enabled = true;
            button3.BackColor = Color.Gray;
            button5.BackColor = Color.Yellow;
            label2.Text = "";
            textBox1.Text = "";
            button1.Enabled = false;
            button2.Enabled = false;
            button2.BackColor = Color.Gray;
            button1.BackColor = Color.Gray;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox1.Text);
            label2.Text = "= " + serialPort1.ReadLine();
            button3.Enabled = true;
            button5.Enabled = false;
            button5.BackColor = Color.Gray;
            button3.BackColor = Color.LightSkyBlue;
            label1.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            richTextBox1.Text = "";
            button1.BackColor = Color.Lime;
            button2.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}