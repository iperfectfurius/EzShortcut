using System;
using System.Collections;
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
            void AddedItemClickEvent(object sender, EventArgs e, Hashtable properties)
            {
                switch (properties["Type"].ToString())
                {
                    case "File":
                        if ((bool)properties["Privileges"])
                            OpenShortcut.ExecuteWithElevatedPermissions(properties["Route"].ToString());
                        else
                            OpenShortcut.OpenFile(properties["Route"].ToString());
                        break;
                    case "Folder":
                        OpenShortcut.OpenFolder($"\"{properties["Route"].ToString()}\"");
                        break;
                    case "Script":
                        OpenShortcut.ExecuteScript(properties["Route"].ToString());
                        break;
                    default:
                        break;
                }
                
            }

            foreach (JObject file in cg.configLoaded["open"])
            {
                foreach (var pair in file)
                {
                    //need change to dictionary
                    Hashtable properties = new Hashtable();
                    properties.Add("Name", pair.Key);
                    properties.Add("Privileges", pair.Key.Contains('*'));
                    properties.Add("Type", pair.Key.Contains('>') ? "Folder" : "File");
                    properties.Add("Route", pair.Value);

                    var newFile = new ToolStripMenuItem(properties["Name"].ToString());
                    newFile.Click += new EventHandler((s, e) => AddedItemClickEvent(s, e, properties));

                    newFile.Name = properties["Name"].ToString();

                    (contextMenuStrip1.Items[0] as ToolStripMenuItem).DropDownItems.Add(newFile);
                }
            }

            foreach (JObject script in cg.configLoaded["scripts"])
            {
                foreach (var pair in script)
                {
                    
                    Hashtable properties = new Hashtable();
                    properties.Add("Name", pair.Key);
                    properties.Add("Type", "Script");
                    properties.Add("Route", pair.Value);

                    var newFile = new ToolStripMenuItem(pair.Key);
                    newFile.Click += new EventHandler((s, e) => AddedItemClickEvent(s, e, properties));
                    newFile.Name = pair.Key;

                    (contextMenuStrip1.Items[1] as ToolStripMenuItem).DropDownItems.Add(newFile);
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Visible = false;
            notifyIcon1.Dispose();
        }

        private void abrirConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cg.openConfig();
        }

        private void reloadMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cg.LoadConfig();
            DeleteDropDownMenu();
            LoadConfig();
            contextMenuStrip1.Show();
        }

        private void DeleteDropDownMenu()
        {
            (contextMenuStrip1.Items[0] as ToolStripMenuItem).DropDownItems.Clear();
            (contextMenuStrip1.Items[1] as ToolStripMenuItem).DropDownItems.Clear();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}