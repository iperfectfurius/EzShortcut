using System;
using System.Diagnostics;
using EzShortcut.Clases;
using Newtonsoft.Json.Linq;

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

        private void LoadConfig()
        {
            void AddedItemClickEventOpen(object sender, EventArgs e, string route)
            {
                OpenFile.OpenFiles(route);
            }
            void AddedItemClickEventScript(object sender, EventArgs e, string script)
            {
                OpenFile.ExecuteScript(script);
            }

            foreach (JObject file in cg.configLoaded["open"])
            {
                foreach (var pair in file)
                {
                    var newFile = new ToolStripMenuItem(pair.Key);
                    newFile.Click += new EventHandler((s, e) => AddedItemClickEventOpen(s, e, pair.Value.ToString()));
                    newFile.Name = pair.Key;

                    (contextMenuStrip1.Items[0] as ToolStripMenuItem).DropDownItems.Add(newFile);
                }
            }

            foreach (JObject script in cg.configLoaded["scripts"])
            {
                foreach (var pair in script)
                {
                    var newFile = new ToolStripMenuItem(pair.Key);
                    newFile.Click += new EventHandler((s, e) => AddedItemClickEventScript(s, e, pair.Value.ToString()));
                    newFile.Name = pair.Key;

                    (contextMenuStrip1.Items[1] as ToolStripMenuItem).DropDownItems.Add(newFile);
                }
            }
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Visible = false;
        }
    }
}