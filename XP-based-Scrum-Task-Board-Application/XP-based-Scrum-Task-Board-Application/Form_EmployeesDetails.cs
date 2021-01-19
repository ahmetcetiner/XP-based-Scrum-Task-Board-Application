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
        public Form_EmployeesDetails()
        {
            InitializeComponent();
        }
        public string Name;
        public bool Transition = false;
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Transition = true;
            Name = txt_EmployeesName.Text + " " + txt_EmployeesLastName.Text;
            this.Close();
        }
    }
}
