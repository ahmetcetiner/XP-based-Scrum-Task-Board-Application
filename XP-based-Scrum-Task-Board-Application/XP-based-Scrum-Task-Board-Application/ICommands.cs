
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP_based_Scrum_Task_Board_Application
{
    public interface ICommands
    {
        int AddProject(string projectName, int ProjectId);
        void DeleteProject(int projectID, string projectName);
        void UptadeProject(int projectID, string projectName);
        List<string> EmployeesFilltoProject(List<string> Name);
        void AddProjectEmployees(int SelectedEmployees,int ProjectId);
        int EmployeesID(string Name, int ID);
        List<string> ProjectCardTextAdd();
        List<int> ProjectCardNameAdd();
        void EmployeesAdd(string EmployeesName);
        List<string> EmployeesCardTextAdd();
        List<int> EmployesCardNameAdd();
        List<int> FillCardNametoFormMain(int ProjectsId);
        List<string> FillCardTexttoFormMain(int ProjectsId);
        List<string> FillCardStatustoFormMain(int ProjectsId);
        void CardAdd(int ProjectId, string Status, string CreationDate, string RelizationTime, string CardDescription, string Nots);
        void EmployeesUpdate(string Name, int ID);
        void EmployeesDelete(int ID);
        void CardDelete(int ID);
        void CardStatusUpdate(int ID, string status);
    }
}
