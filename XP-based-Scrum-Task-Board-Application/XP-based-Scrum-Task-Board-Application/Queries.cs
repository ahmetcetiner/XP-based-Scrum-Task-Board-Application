using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace XP_based_Scrum_Task_Board_Application
{
    public class Queries
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
            SqlCommand command = new SqlCommand("delete from tblProject where (" + projectID + ")");
            connection.Close();
        }
        public void UpdateProject(int projectID, string projectName)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update tblProjects set projectID = (" + projectID + ") , projectName = ('"+projectName+"')"); ;
            connection.Close();
        }
        public void AddTechnicalCard(int cardID, int projectID, string status, string cardName,string explanation, string notes, DateTime creationDate, DateTime realizationTime)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into tblCards values (" + cardID + "," + projectID + ",'" + status + "','" + cardName + "','" + explanation + "','" + notes + "','" + creationDate + "','" + realizationTime + "')");
            connection.Close();
        }
        public void DeleteTechnicalCard(int cardID, int projectID, string status, string cardName, string explanation, string notes, DateTime creationDate, DateTime realizationTime)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from tblCard where (" + cardID + ")");
            connection.Close();
        }
        public void UpdateTechnicalCard(int cardID, int projectID, string status, string cardName, string explanation, string notes, DateTime creationDate, DateTime realizationTime)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update tblCard set cardID = ("+cardID+"),projectID = ("+projectID+"),status = ('"+status+"'),cardName = ('"+cardName+"'),explanation = ('"+explanation+"'),notes = ('"+notes+"'),creationDate = ('"+creationDate+"'),realizitonTime = ('"+realizationTime+"')");
            connection.Close();
        }
        public void AddWorkFollow(int cardID, DateTime date, string status, string workToDo, string explanation)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into tblWorkFollow values (" + cardID + ",'" + date + "','" + status + "','" + workToDo+"','" + explanation + "')");
            connection.Close();
        }
        public void DeleteWorkFollow(int cardID, DateTime date, string status, string workToDo, string explanation)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from tblWorkFollow where (" + cardID + ")");
            connection.Close();
        }
        public void UpdateWokrFollow(int cardID, DateTime date, string status, string workToDo, string explanation)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update tblWorkFollow set cardID = (" + cardID + "),date = ('" + date + "'),workToDo = ('" + workToDo + "'),explanation = ('" + explanation + "')");
            connection.Close();
        }
        public void AddExpertEmployee(int expertID, string expertName)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into tblTechnicalExperts values(" + expertID + ",'" + expertName + "')");
            connection.Close();
        }
        public void DeleteExpertEmployees(int expertID, string expertName)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from tblTechnicalExperts where (" + expertID + ")");
            connection.Close();
        }
        public void UpdateExpertEmployees(int expertID, string expertName)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update tblTechnicalExperts set expertID = (" + expertID + "), expertName = ('" + expertName + "')");
            connection.Close();
        }
        public void AddTechnicalExpert(int expertID,int projectID)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into tblProjectTechnicalExperts values (" + expertID + "," + projectID + ")");
            connection.Close();
        }
        public void DeleteTechnicalExpert(int expertID, int projectID)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from tblProjectTechnicalExperts where = (" + expertID + ")");
            connection.Close();
        }
        public void UpdateTechnicalExpert(int expertID, int projectID)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update tblProjectTechnicalExperts set expertID = (" + expertID + "), projectID = (" + projectID + ")");
            connection.Close();
        }
    }    
}
