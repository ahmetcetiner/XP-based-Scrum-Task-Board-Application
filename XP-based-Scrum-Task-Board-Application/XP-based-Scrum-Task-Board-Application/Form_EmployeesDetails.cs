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
    public partial class Form_EmployeesDetails : Form
    {
        int Employes_ID;
        string Employees_Name;
        bool data;
        public Form_EmployeesDetails(int EmployesID, string EmployeesName, bool Data)
        {
            this.Employes_ID = EmployesID;
            this.Employees_Name = EmployeesName;
            this.data = Data;
            InitializeComponent();
        }
        public string Name;
        public bool Transition = false;
        Commands commands = new Commands();
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (txt_EmployeesName.Text != "")
            {
                Name = txt_EmployeesName.Text ;
                ICommands icommands = (ICommands)commands;
                icommands.EmployeesAdd(Name);
                Transition = true;
                this.Close();
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ICommands icommands = (ICommands)commands;
            icommands.EmployeesUpdate(txt_EmployeesName.Text, Employes_ID);
            this.Close();
        }

        private void Form_EmployeesDetails_Load(object sender, EventArgs e)
        {
            if (data)
            {
                txt_EmployeesName.Text = Employees_Name;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            ICommands icommands = (ICommands)commands;
            icommands.EmployeesDelete(Employes_ID);
            this.Close();
        }
    }
}
