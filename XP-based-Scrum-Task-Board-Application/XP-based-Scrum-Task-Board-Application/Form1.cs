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
        public string CardStatus;
        public Form_Main()
        {
            InitializeComponent();
        }
        Commands commands = new Commands();
        Form_TechnicalCard form_TechnicalCard;
        Form_ProjectLogin form_ProjectLogin = new Form_ProjectLogin();
        List<int> CardNameList = new List<int>();
        List<string> CardTextList = new List<string>();
        List<string> CardStatusList = new List<string>();
        bool login = true;
        private void Form_Main_Load(object sender, EventArgs e)
        {
            if (login)
            {
                form_ProjectLogin.ShowDialog();
                if (!form_ProjectLogin.transition)
                {
                    this.Close();
                }
                login = false;
            }
            Panel_Todo.Controls.Clear();
            Panel_InProgress.Controls.Clear();
            Panel_Revison.Controls.Clear();
            Panel_Check.Controls.Clear();
            Panel_Done.Controls.Clear();
            ICommands icommands = (ICommands)commands;
            CardNameList = icommands.FillCardNametoFormMain(form_ProjectLogin.CardID);
            CardTextList = icommands.FillCardTexttoFormMain(form_ProjectLogin.CardID);
            CardStatusList = icommands.FillCardStatustoFormMain(form_ProjectLogin.CardID);
            for (int i = 0; i < CardNameList.Count; i++)
            {
                Card_Add(CardStatusList[i], CardNameList[i], CardTextList[i]);
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Close_MouseEnter(object sender, EventArgs e)
        {
            btn_Close.Image = Properties.Resources.icons8_shutdown_3;
        }
        private void btn_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_Close.Image = Properties.Resources.icons8_shutdown_2;
        }
        private void btn_TodoCardAdd_Click(object sender, EventArgs e)
        {
            CardStatus = Panel_Todo.Name;
            form_TechnicalCard = new Form_TechnicalCard(CardStatus, form_ProjectLogin.CardID,0);
            form_TechnicalCard.ShowDialog();
            Form_Main_Load(sender, e);
        }
        private void btn_InProgressCardAdd_Click(object sender, EventArgs e)
        {
            CardStatus = Panel_InProgress.Name;
            form_TechnicalCard = new Form_TechnicalCard(CardStatus, form_ProjectLogin.CardID, 0);
            form_TechnicalCard.ShowDialog();
            Form_Main_Load(sender, e);
        }
        private void btn_RevisonCardAdd_Click(object sender, EventArgs e)
        {
            CardStatus = Panel_Revison.Name;
            form_TechnicalCard = new Form_TechnicalCard(CardStatus, form_ProjectLogin.CardID, 0);
            form_TechnicalCard.ShowDialog();
            Form_Main_Load(sender, e);
        }
        private void btn_CheckCardAdd_Click(object sender, EventArgs e)
        {
            CardStatus = Panel_Check.Name;
            form_TechnicalCard = new Form_TechnicalCard(CardStatus, form_ProjectLogin.CardID, 0);
            form_TechnicalCard.ShowDialog();
            Form_Main_Load(sender, e);
        }
        private void btn_DoneCardAdd_Click(object sender, EventArgs e)
        {
            CardStatus = Panel_Done.Name;
            form_TechnicalCard = new Form_TechnicalCard(CardStatus, form_ProjectLogin.CardID, 0);
            form_TechnicalCard.ShowDialog();
            Form_Main_Load(sender, e);
        }
        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            Panel parent = sender as Panel;
            e.Effect = DragDropEffects.Move;
            parent.BackColor = Color.FromArgb(239, 244, 142);
        }
        private void panel_DragLeave(object sender, EventArgs e)
        {
            Panel parent = sender as Panel;
            parent.BackColor = Color.FromArgb(210, 230, 3);
        }
        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            ICommands icommands = (ICommands)commands;
            Panel parent = sender as Panel;
            Button button = (Button)e.Data.GetData(typeof(Button));
            button.Parent = parent;
            parent.BackColor = Color.FromArgb(210, 230, 3);
            icommands.CardStatusUpdate(Convert.ToInt32(button.Name) ,parent.Name);
        }
        private void Card_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button button = sender as Button;
                form_TechnicalCard = new Form_TechnicalCard(CardStatus, form_ProjectLogin.CardID, Convert.ToInt32(button.Name));
                if (form_TechnicalCard.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            Form_Main_Load(sender, e);
        }
        private void Card_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button button = sender as Button;
                button.DoDragDrop(button, DragDropEffects.Move);
            }
        }
        private void Card_Add(string PanelToAttach,int Name, string Text)
        {
            Button crt = new Button();
            crt.MouseMove += new MouseEventHandler(Card_MouseMove);
            crt.MouseClick += new MouseEventHandler(Card_MouseClick);
            crt.TextAlign = ContentAlignment.TopLeft;
            crt.Padding = new Padding(10);
            crt.BackColor = Color.FromArgb(62, 151, 139);
            crt.Name = Name.ToString();
            crt.Text = Text;
            crt.Size = new Size(270, 100);
            crt.Dock = DockStyle.Top;
            if (PanelToAttach == Panel_Todo.Name)
            {
                Panel_Todo.Controls.Add(crt);
            }
            if (PanelToAttach == Panel_InProgress.Name)
            {
                Panel_InProgress.Controls.Add(crt);
            }
            if (PanelToAttach == Panel_Revison.Name)
            {
                Panel_Revison.Controls.Add(crt);
            }
            if (PanelToAttach == Panel_Check.Name)
            {
                Panel_Check.Controls.Add(crt);
            }
            if (PanelToAttach == Panel_Done.Name)
            {
                Panel_Done.Controls.Add(crt);
            }
        }
    }
}
