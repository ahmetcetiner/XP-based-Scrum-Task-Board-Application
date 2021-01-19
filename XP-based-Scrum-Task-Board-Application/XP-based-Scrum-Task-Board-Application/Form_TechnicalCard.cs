using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace XP_based_Scrum_Task_Board_Application
{
    public partial class Form_TechnicalCard : Form
    {
        public Form_TechnicalCard()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1N5RR86\MSSQLSERVER01;Initial Catalog=Scrum_Task_Board;Integrated Security=True");
        private void Form_TechnicalCard_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
