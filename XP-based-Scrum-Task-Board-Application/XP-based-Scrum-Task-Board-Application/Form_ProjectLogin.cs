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
        public int CardID;
        Commands commands = new Commands();
        List<string> ProjectsCardList = new List<string>();
        List<int> ProjectsCardNameList = new List<int>();
        List<string> EmployeesCardList = new List<string>();
        List<int> EmployeesCardNameList = new List<int>();
        private void Form_ProjectLogin_Load(object sender, EventArgs e)
        {
            Panel_Project.Controls.Clear();
            Panel_Employees.Controls.Clear();
            ICommands icommands = (ICommands)commands;
            ProjectsCardList = icommands.ProjectCardTextAdd();
            ProjectsCardNameList = icommands.ProjectCardNameAdd();
            EmployeesCardList = icommands.EmployeesCardTextAdd();
            EmployeesCardNameList = icommands.EmployesCardNameAdd();
            for (int i = 0; i < EmployeesCardList.Count; i++)
            {
                Card_Add(Panel_Employees, EmployeesCardList[i], EmployeesCardNameList[i], false);
            }
            for (int i = 0; i <ProjectsCardList.Count; i++)
            {
                Card_Add(Panel_Project, ProjectsCardList[i], ProjectsCardNameList[i], true);
            }
            transition = false;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Close_MouseEnter(object sender, EventArgs e)
        {
           //btn_Close.Image = Properties.Resources.icons8_shutdown_2;
        }
        private void btn_Close_MouseLeave(object sender, EventArgs e)
        {
            //btn_Close.Image = Properties.Resources.icons8_shutdown_3;
        }

        private void btn_ProjectCardAdd_Click(object sender, EventArgs e)
        {
            Form_ProjectDetails form_ProjectDetails = new Form_ProjectDetails();
            form_ProjectDetails.ShowDialog();
            Form_ProjectLogin_Load(sender, e);
        }
        private void ProjectCard_Click(object sender, EventArgs e)
        {
            Button SelectedCard = sender as Button;
            CardID = Convert.ToInt32(SelectedCard.Name);
            transition = true;
            this.Close();

        }
        public void Card_Add(Panel PanelToAttach, string ButtonText,int ButtonName,bool projectcard)
        {
            Button crt = new Button();
            if (projectcard)
            {
                crt.Click += ProjectCard_Click;
            }
            crt.TextAlign = ContentAlignment.TopLeft;
            crt.Padding = new Padding(10);
            crt.BackColor = Color.Red;
            crt.Name = ButtonName.ToString();
            crt.Text = ButtonText;
            crt.Size = new Size(270, 50);
            crt.Dock = DockStyle.Top;
            PanelToAttach.Controls.Add(crt);
        }

        private void btn_EmployeesCardAdd_Click(object sender, EventArgs e)
        {
            Form_EmployeesDetails form_EmployeesDetails = new Form_EmployeesDetails();
            form_EmployeesDetails.ShowDialog();
            Form_ProjectLogin_Load(sender, e);
        }
    }
}
