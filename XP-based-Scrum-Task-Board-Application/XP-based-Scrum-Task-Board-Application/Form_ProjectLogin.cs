using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XP_based_Scrum_Task_Board_Application
{
    public partial class Form_ProjectLogin : Form
    {
        public Form_ProjectLogin()
        {
            InitializeComponent();
        }
        public bool transition = false;
        private void Form_ProjectLogin_Load(object sender, EventArgs e)
        {
            transition = false;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Close_MouseEnter(object sender, EventArgs e)
        {
            btn_Close.Image = Properties.Resources.icons8_shutdown_2;
        }
        private void btn_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_Close.Image = Properties.Resources.icons8_shutdown_3;
        }

        private void btn_ProjectCardAdd_Click(object sender, EventArgs e)
        {
            Card_Add(Panel_Project);
        }
        private void ProjectCard_Click(object sender, EventArgs e)
        {
            transition = true;
            this.Close();
        }
        private void Card_Add(Panel PanelToAttach)
        {
            Button crt = new Button();
            crt.Click += ProjectCard_Click;
            crt.TextAlign = ContentAlignment.TopLeft;
            crt.Padding = new Padding(10);
            crt.BackColor = Color.Red;
            crt.Name = "test";
            crt.Text = "selam balım";
            crt.Size = new Size(270, 100);
            crt.Dock = DockStyle.Top;
            PanelToAttach.Controls.Add(crt);
        }

    }
}
