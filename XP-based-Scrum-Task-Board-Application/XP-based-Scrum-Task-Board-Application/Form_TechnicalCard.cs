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
        Commands commands = new Commands();
        Form_ProjectLogin form_ProjectLogin = new Form_ProjectLogin();
        Form_Main form_Main = new Form_Main();
        private void Form_TechnicalCard_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ICommands icommands = (ICommands)commands;
            icommands.CardAdd(form_ProjectLogin.CardID, form_Main.CardStatus.ToString(), dtp_Date.ToString(), txt_ActualTime.Text, rtb_Description.Text, rtb_Notes.Text);
        }
    }
}
