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
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            ButtonName = txt_ProjectName.Text;
            this.Close();
        }
    }
}
