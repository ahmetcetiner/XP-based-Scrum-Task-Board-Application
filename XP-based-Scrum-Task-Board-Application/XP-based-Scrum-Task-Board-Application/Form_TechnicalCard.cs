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
        public string Card_Status;
        public int Card_ID;
        int id;
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GOOUJQ3;Initial Catalog=ScrumTaskBoardDatabase;Integrated Security=True");
        public Form_TechnicalCard(string CardStatus,int CardID,int ID)
        {
            this.Card_Status = CardStatus;
            this.Card_ID = CardID;
            this.id = ID;
            InitializeComponent();
        }
        Commands commands = new Commands();
        private void btn_Close_MouseEnter(object sender, EventArgs e)
        {
            btn_Close.Image = Properties.Resources.icons8_shutdown_3;
        }
        private void btn_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_Close.Image = Properties.Resources.icons8_shutdown_2;
        }
        private void Form_TechnicalCard_Load(object sender, EventArgs e)
        {
            fill();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ICommands icommands = (ICommands)commands;
            dtp_Date.Format = DateTimePickerFormat.Short;
            icommands.CardAdd(Card_ID, Card_Status, dtp_Date.Text.ToString(), txt_ActualTime.Text, rtb_Description.Text, rtb_Notes.Text);
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            ICommands icommands = (ICommands)commands;
            icommands.CardDelete(id);
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update Cards set CreationDate ='" + dtp_Date.Text + "',RealizationTime='"+ txt_ActualTime.Text + "', CardDescription='"+ rtb_Description.Text + "',Nots='"+ rtb_Notes.Text + "' where ProjectId= " + Card_ID + " and CardId =" + id + "", connection);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }
        void fill()
        {
            List<int> employeesid = new List<int>();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * from Cards where ProjectId= " + Card_ID + " and CardId =" + id + "", connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    txt_ProjectName.Text = Card_ID.ToString();
                    txt_CardNo.Text = reader["CardID"].ToString();
                    dtp_Date.Text = reader["CreationDate"].ToString();
                    txt_ActualTime.Text = reader["RealizationTime"].ToString();
                    rtb_Description.Text = reader["CardDescription"].ToString();
                    rtb_Notes.Text = reader["Nots"].ToString();
                }
            }
            connection.Close();
            connection.Open();
            SqlCommand commandid = new SqlCommand("select EmployeesId from ProjectTechnicalEmployees where ProjectId=  " + Card_ID + "", connection);
            using (SqlDataReader readerid = commandid.ExecuteReader())
            {
                while (readerid.Read())
                {
                    employeesid.Add(Convert.ToInt32(readerid["EmployeesId"]));
                }
            }
            connection.Close();
            foreach (var item in employeesid)
            {
                connection.Open();
                SqlCommand commandTE = new SqlCommand("SELECT EmployeesName from TechnicalEmployees where EmployeesId= "+ item + "", connection);
                using (SqlDataReader readerTE = commandTE.ExecuteReader())
                {
                    while (readerTE.Read())
                    {
                        txt_TechnicalEmp.Text = txt_TechnicalEmp.Text + readerTE["EmployeesName"].ToString() + " ";
                    }
                }
                connection.Close();
            }
        }
    }
}
