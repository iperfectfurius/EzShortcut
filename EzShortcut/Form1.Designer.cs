﻿namespace EzShortcut
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "EZShortcut V0.1";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "EZShortcut V0.1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lolToolStripMenuItem,
            this.scriptsToolStripMenuItem,
            this.abrirConfigToolStripMenuItem,
            this.reloadMenuToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 114);
            // 
            // lolToolStripMenuItem
            // 
            this.lolToolStripMenuItem.Name = "lolToolStripMenuItem";
            this.lolToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.lolToolStripMenuItem.Text = "Abrir...";
            // 
            // scriptsToolStripMenuItem
            // 
            this.scriptsToolStripMenuItem.Name = "scriptsToolStripMenuItem";
            this.scriptsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.scriptsToolStripMenuItem.Text = "Scripts";
            // 
            // abrirConfigToolStripMenuItem
            // 
            this.abrirConfigToolStripMenuItem.Name = "abrirConfigToolStripMenuItem";
            this.abrirConfigToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.abrirConfigToolStripMenuItem.Text = "Abrir Config";
            this.abrirConfigToolStripMenuItem.Click += new System.EventHandler(this.abrirConfigToolStripMenuItem_Click);
            // 
            // reloadMenuToolStripMenuItem
            // 
            this.reloadMenuToolStripMenuItem.Name = "reloadMenuToolStripMenuItem";
            this.reloadMenuToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.reloadMenuToolStripMenuItem.Text = "Reload Menu";
            this.reloadMenuToolStripMenuItem.Click += new System.EventHandler(this.reloadMenuToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(4, 0);
            this.ControlBox = false;
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EZShortcut V0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem lolToolStripMenuItem;
        private ToolStripMenuItem scriptsToolStripMenuItem;
        private ToolStripMenuItem abrirConfigToolStripMenuItem;
        private ToolStripMenuItem reloadMenuToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}