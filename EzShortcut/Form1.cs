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
            LoadConfig();
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
            OpenFile.OpenFiles(@"C:\\PHP\\php.ini");
        }

        private void LoadConfig()
        {

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Visible =false;
        }
    }
}