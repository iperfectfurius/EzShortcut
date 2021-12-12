using System;
using System.Diagnostics;
using EzShortcut.Clases;

namespace EzShortcut
{
    public partial class Form1 : Form
    {
        Config cg = new Config();
        public Form1()
        {
            this.ShowInTaskbar = false;
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("xd");
        }

        private void pHPiniIISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFiles(@"C:\Program Files\iis express\PHP\v7.3\php.ini");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Visible =false;
        }
    }
}