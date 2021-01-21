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
        public bool Transition = false;
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Commands commands = new Commands();
            ICommands icommands = (ICommands)commands;
            icommands.AddProject(txt_ProjectName.Text);
            Transition = true;
            ButtonName = txt_ProjectName.Text;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
