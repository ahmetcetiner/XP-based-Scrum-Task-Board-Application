
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP_based_Scrum_Task_Board_Application
{
    public interface ICommands
    {
        void AddProject(int projectID, string projectName);
        void DeleteProject(int projectID, string projectName);
        void UptadeProject(int projectID, string projectName);

    }
}
