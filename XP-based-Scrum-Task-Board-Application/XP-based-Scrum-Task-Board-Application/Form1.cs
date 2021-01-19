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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            Form_ProjectLogin form_ProjectLogin = new Form_ProjectLogin();
            form_ProjectLogin.ShowDialog();
            if (!form_ProjectLogin.transition)
            {
                this.Close();
            }

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
        private void btn_TodoCardAdd_Click(object sender, EventArgs e)
        {
            Card_Add(Panel_Todo);
        }
        private void btn_InProgressCardAdd_Click(object sender, EventArgs e)
        {
            Card_Add(Panel_InProgress);
        }
        private void btn_RevisonCardAdd_Click(object sender, EventArgs e)
        {
            Card_Add(Panel_Revison);
        }

        private void btn_CheckCardAdd_Click(object sender, EventArgs e)
        {
            Card_Add(Panel_Check);
        }

        private void btn_DoneCardAdd_Click(object sender, EventArgs e)
        {
            Card_Add(Panel_Done);
        }
        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            Panel parent = sender as Panel;
            e.Effect = DragDropEffects.Move;
            parent.BackColor = Color.FromArgb(14, 113, 114);
        }
        private void panel_DragLeave(object sender, EventArgs e)
        {
            Panel parent = sender as Panel;
            parent.BackColor = Color.FromArgb(0, 32, 41);
        }
        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            Panel parent = sender as Panel;
            Button button = (Button)e.Data.GetData(typeof(Button));
            button.Parent = parent;
            parent.BackColor = Color.FromArgb(0, 32, 41);
            MessageBox.Show(button.Name + "Birakildi=" + parent.Name);
        }
        private void Card_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button button = sender as Button;
                Form_TechnicalCard Tech = new Form_TechnicalCard();
                MessageBox.Show("Technic Cart"+button.Text);
                if (Tech.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
        }
        private void Card_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button button = sender as Button;
                button.DoDragDrop(button, DragDropEffects.Move);
            }
        }
        private void Card_Add(Panel PanelToAttach)
        {
            Button crt = new Button();
            crt.MouseMove += new MouseEventHandler(Card_MouseMove);
            crt.MouseClick += new MouseEventHandler(Card_MouseClick);
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
