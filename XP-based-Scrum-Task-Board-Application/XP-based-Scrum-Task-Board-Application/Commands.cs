using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP_based_Scrum_Task_Board_Application
{
    public class Commands : ICommands
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1N5RR86\MSSQLSERVER01;Initial Catalog=Scrum_Task_Board;Integrated Security=True");
        public void AddProject(int projectID, string projectName)
        {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into tblProjects values(" + projectID + ",'" + projectName + "')");
                connection.Close();            
        }
        public void DeleteProject(int projectID, string projectName)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from tblProjects where (" + projectID + ")");
            connection.Close();
        }

        public void UptadeProject(int projectID, string projectName)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update tblProjects set projectID = (" + projectID + ") , projectName = ('" + projectName + "')"); ;
            connection.Close();
        }
    }
}
