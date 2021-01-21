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
    public partial class Form_ProjectDetails : Form
    {
        public Form_ProjectDetails()
        {
            InitializeComponent();
        }
        public string ButtonName;
        public int ProjectID;
        public int EmployeesID;
        public bool Transition = false;
        List<int> EmployeesId = new List<int>();
        Commands commands = new Commands();

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            ICommands icommands = (ICommands)commands;
            ProjectID = icommands.AddProject(txt_ProjectName.Text, ProjectID);
            foreach (var item in lbox_SelectedEmployees.Items)
            {
                EmployeesID = icommands.EmployeesID(item.ToString(), EmployeesID);
                EmployeesId.Add(EmployeesID);
            }
            foreach (var item in EmployeesId)
            {
                icommands.AddProjectEmployees(item, ProjectID);
            }
            Transition = true;
            ButtonName = txt_ProjectName.Text;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_ProjectDetails_Load(object sender, EventArgs e)
        {
            List<string> Name = new List<string>();
            ICommands icommands = (ICommands)commands;
            icommands.EmployeesFilltoProject(Name);
            foreach (var item in Name)
            {
                lbox_Employees.Items.Add(item);
            }
        }

        private void btn_EmployeesAdd_Click(object sender, EventArgs e)
        {
            if (lbox_Employees.SelectedIndex != -1)
            {
                lbox_SelectedEmployees.Items.Add(lbox_Employees.SelectedItem);
                lbox_Employees.Items.RemoveAt(lbox_Employees.SelectedIndex);
            }
        }

        private void lbox_SelectedEmployees_DoubleClick(object sender, EventArgs e)
        {
            lbox_Employees.Items.Add(lbox_SelectedEmployees.SelectedItem);
            lbox_SelectedEmployees.Items.RemoveAt(lbox_SelectedEmployees.SelectedIndex);
        }
    }
}
