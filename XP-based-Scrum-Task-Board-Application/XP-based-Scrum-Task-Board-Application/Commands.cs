using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XP_based_Scrum_Task_Board_Application
{
    public class Commands : ICommands
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GOOUJQ3;Initial Catalog=ScrumTaskBoardDatabase;Integrated Security=True");

        public int AddProject(string projectName, int ProjectId)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT into Projects (ProjectName) OUTPUT inserted.ProjectID VALUES('" + projectName + "')", connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ProjectId = Convert.ToInt32(reader["ProjectID"].ToString());
                }
            }
            connection.Close();
            return ProjectId;
        }

        public void AddProjectEmployees(int SelectedEmployees,int ProjectId)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into ProjectTechnicalEmployees (EmployeesId,ProjectID) values(" + SelectedEmployees + "," + ProjectId + ")", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteProject(int projectID, string projectName)
        {
            throw new NotImplementedException();
        }

        public List<string> EmployeesFilltoProject(List<string> Name)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select EmployeesName From TechnicalEmployees", connection);
            SqlDataReader data_reader = command.ExecuteReader();
            while (data_reader.Read())
            {
                Name.Add(data_reader[0].ToString());
            }
            connection.Close();
            return Name;
        }

        public int EmployeesID(string Name, int ID)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select EmployeesId From TechnicalEmployees Where EmployeesName='" + Name + "'", connection);
            SqlDataReader data_reader = command.ExecuteReader();
            while (data_reader.Read())
            {
                ID = Convert.ToInt32(data_reader[0]);
            }
            connection.Close();
            return ID;
        }

        public List<string> ProjectCardTextAdd()
        {
            List<string> CardText = new List<string>();
            connection.Open();
            SqlCommand commandtext = new SqlCommand("Select ProjectName From Projects", connection);
            SqlDataReader data_readertext = commandtext.ExecuteReader();
            while (data_readertext.Read())
            {
                CardText.Add(data_readertext[0].ToString());
            }
            connection.Close();
            return CardText;
        }
        public List<int> ProjectCardNameAdd()
        {
            List<int> CardName = new List<int>();
            connection.Open();
            SqlCommand commandName = new SqlCommand("Select ProjectID From Projects", connection);
            SqlDataReader data_readerName = commandName.ExecuteReader();
            while (data_readerName.Read())
            {
                CardName.Add(Convert.ToInt32(data_readerName[0]));
            }
            connection.Close();
            return CardName;
        }

        public void UptadeProject(int projectID, string projectName)
        {
            throw new NotImplementedException();
        }

        public void EmployeesAdd(string EmployeesName)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT into TechnicalEmployees (EmployeesName) VALUES('" + EmployeesName + "')", connection);
            command.ExecuteReader();
            connection.Close();
        }
        public List<string> EmployeesCardTextAdd()
        {
            List<string> CardText = new List<string>();
            connection.Open();
            SqlCommand commandtext = new SqlCommand("Select EmployeesName From TechnicalEmployees", connection);
            SqlDataReader data_readertext = commandtext.ExecuteReader();
            while (data_readertext.Read())
            {
                CardText.Add(data_readertext[0].ToString());
            }
            connection.Close();
            return CardText;
        }
        public List<int> EmployesCardNameAdd()
        {
            List<int> CardName = new List<int>();
            connection.Open();
            SqlCommand commandName = new SqlCommand("Select EmployeesId From TechnicalEmployees", connection);
            SqlDataReader data_readerName = commandName.ExecuteReader();
            while (data_readerName.Read())
            {
                CardName.Add(Convert.ToInt32(data_readerName[0]));
            }
            connection.Close();
            return CardName;
        }

        public List<int> FillCardNametoFormMain(int ProjectsId)
        {
            List<int> CardName = new List<int>();
            connection.Open();
            SqlCommand commandName = new SqlCommand("Select CardId From Cards where ProjectId=" + ProjectsId + "", connection);
            SqlDataReader data_readerName = commandName.ExecuteReader();
            while (data_readerName.Read())
            {
                CardName.Add(Convert.ToInt32(data_readerName[0]));
            }
            connection.Close();
            return CardName;
        }

        public List<string> FillCardTexttoFormMain(int ProjectsId)
        {
            List<string> CardText = new List<string>();
            connection.Open();
            SqlCommand commandtext = new SqlCommand("Select CardDescription From Cards where ProjectId=" + ProjectsId + "", connection);
            SqlDataReader data_readertext = commandtext.ExecuteReader();
            while (data_readertext.Read())
            {
                CardText.Add(data_readertext[0].ToString());
            }
            connection.Close();
            return CardText;
        }

        public List<string> FillCardStatustoFormMain(int ProjectsId)
        {
            List<string> CardStatus= new List<string>();
            connection.Open();
            SqlCommand commandStatus = new SqlCommand("Select Status From Cards where ProjectId=" + ProjectsId + "", connection);
            SqlDataReader data_readerStatus = commandStatus.ExecuteReader();
            while (data_readerStatus.Read())
            {
                CardStatus.Add(data_readerStatus[0].ToString());
            }
            connection.Close();
            return CardStatus;
        }

        public void CardAdd(int ProjectId,string Status, string CreationDate, string RelizationTime, string CardDescription, string Nots)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT into Cards (ProjectId,Status,CreationDate,RealizationTime,CardDescription,Nots) OUTPUT inserted.ProjectID VALUES(" + ProjectId + ",'" + Status + "','" + CreationDate + "','" + RelizationTime + "','" + CardDescription + "','" + Nots + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EmployeesUpdate(string Name, int ID)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update TechnicalEmployees set EmployeesName ='" + Name + "' where EmployeesId=" + ID + "", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EmployeesDelete(int ID)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete ProjectTechnicalEmployees where EmployeesId = " + ID + "delete TechnicalEmployees where EmployeesId = " + ID + "", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void CardDelete(int ID)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete Cards where CardId = " + ID + "delete CardTechnicalEmployees where CardId = " + ID + "", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void CardStatusUpdate(int ID, string status)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update Cards set Status ='" + status + "' where CardId=" + ID + "", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
