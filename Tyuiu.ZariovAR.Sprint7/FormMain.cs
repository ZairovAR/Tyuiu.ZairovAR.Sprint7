using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Tyuiu.ZariovAR.Sprint7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Form activeForm;

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMenu.Controls.Add(childForm);
            this.panelMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            flowLayoutPanelMenu.Hide();
        }


        bool isShow;
        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanelMenu.Visible) 
            {
                isShow = false;
                flowLayoutPanelMenu.Hide();
                timermenu.Start();
            }
            else 
            {
                isShow = true;
                flowLayoutPanelMenu.Show();
                timermenu.Start();
            }
                
        }

        private void timermenu_Tick(object sender, EventArgs e)
        {
            if (isShow) { 
                if (flowLayoutPanelMenu.Width >= 127)
                    timermenu.Stop();

                flowLayoutPanelMenu.Width += 35;
            }
            else {
                if (flowLayoutPanelMenu.Width <= 0)
                {
                    flowLayoutPanelMenu.Hide();
                    timermenu.Stop();
                }
                    

                flowLayoutPanelMenu.Width -= 35;
            }
        }

        private void X_butten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonWinow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Button currentButton;
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }
        private void buttonPopulation_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#5F9EA0");
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    paneltwo.BackColor = color;
                    pictureBoxLogo.BackColor = ColorTranslator.FromHtml("#468185");
                    pictureBoxMenu.Visible = true;
                }
            }

            OpenChildForm(new FormPopulation());
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#5F9EA0");
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    paneltwo.BackColor = color;
                    pictureBoxLogo.BackColor = ColorTranslator.FromHtml("#468185");
                    pictureBoxMenu.Visible = true;
                }
            }

            OpenChildForm(new FormEconomy());
        }

        private void buttonterritory_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#5F9EA0");
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    paneltwo.BackColor = color;
                    pictureBoxLogo.BackColor = ColorTranslator.FromHtml("#468185");
                    pictureBoxMenu.Visible = true;
                }
            }

            OpenChildForm(new FormGeography());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormArturcs formAbout = new FormArturcs();
            formAbout.ShowDialog();
        }
    }
}
