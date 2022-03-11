using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using HtmlAgilityPack;


namespace Project_0._1
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        
        );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = BtnLookup.Height;
            pnlNav.Top = BtnLookup.Top;
            pnlNav.Left = BtnLookup.Left;
            BtnLookup.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Welcome to the Application";
            this.PnlFormLoader.Controls.Clear();
            FrmLookUp frmLookUp_Vrb = new FrmLookUp() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLookUp_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmLookUp_Vrb);
            frmLookUp_Vrb.Show();
        }

        private void Application_Load(object sender, EventArgs e)
        {

        }
        private void LookupAccount_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnLookup.Height;
            pnlNav.Top = BtnLookup.Top;
            pnlNav.Left = BtnLookup.Left;
            BtnLookup.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Lookup";
            this.PnlFormLoader.Controls.Clear();
            FrmLookUp frmLookUp_Vrb = new FrmLookUp() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLookUp_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmLookUp_Vrb);
            frmLookUp_Vrb.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnStats.Height;
            pnlNav.Top = BtnStats.Top;
            pnlNav.Left = BtnStats.Left;
            BtnStats.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Stats of your Account";
            this.PnlFormLoader.Controls.Clear();
            FrmStats frmStats_Vrb = new FrmStats() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmStats_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmStats_Vrb);
            frmStats_Vrb.Show();
        }

        private void BtnBosses_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnBosses.Height;
            pnlNav.Top = BtnBosses.Top;
            pnlNav.Left = BtnBosses.Left;
            BtnBosses.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Your total amount of boss kills";
            this.PnlFormLoader.Controls.Clear();
            FrmBosses frmBosses_Vrb = new FrmBosses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmBosses_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmBosses_Vrb);
            frmBosses_Vrb.Show();
        }

        private void BtnClues_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnClues.Height;
            pnlNav.Top = BtnClues.Top;
            pnlNav.Left = BtnClues.Left;
            BtnClues.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "This is how many clues u have done";
            this.PnlFormLoader.Controls.Clear();
            FrmClues frmClues_Vrb = new FrmClues() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmClues_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmClues_Vrb);
            frmClues_Vrb.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnSettings.Height;
            pnlNav.Top = BtnSettings.Top;
            pnlNav.Left = BtnSettings.Left;
            BtnSettings.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Settings";
            this.PnlFormLoader.Controls.Clear();
            FrmSettings frmSettings_Vrb = new FrmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSettings_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmSettings_Vrb);
            frmSettings_Vrb.Show();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnAbout.Height;
            pnlNav.Top = BtnAbout.Top;
            pnlNav.Left = BtnAbout.Left;
            BtnAbout.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Who we are";
            this.PnlFormLoader.Controls.Clear();
            FrmAbout frmAbout_Vrb = new FrmAbout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAbout_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmAbout_Vrb);
            frmAbout_Vrb.Show();
        }

        private void BtnLookup_Leave(object sender, EventArgs e)
        {
            BtnLookup.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnStats_Leave(object sender, EventArgs e)
        {
            BtnStats.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnBosses_Leave(object sender, EventArgs e)
        {
            BtnBosses.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnClues_Leave(object sender, EventArgs e)
        {
            BtnClues.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            BtnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAbout_Leave(object sender, EventArgs e)
        {
            BtnAbout.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
