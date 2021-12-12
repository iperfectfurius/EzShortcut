using System;
using System.Diagnostics;

namespace EzShortcut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.ShowInTaskbar = false;
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hide();
            notifyIcon1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("xd");
        }
    }
}