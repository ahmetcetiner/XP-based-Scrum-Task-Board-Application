using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;

namespace XP_based_Scrum_Task_Board_Application
{
    [TestFixture]
    class EmployeesTest
    {
        Commands command = new Commands();

        [Test]
        public void EmployeeID()
        {
            int result; 
            result = command.EmployeesID("Ahmet ÇETİNER",0);
            Assert.AreEqual(13,result);
        }

        [Test]

        public void GetProjectNames()
        {
            List<string> result = new List<string>();
            result = command.ProjectCardTextAdd();
            Assert.AreEqual("test",result[0]);
        }

        [Test]

        public void GetCardName()
        {
            List<int> result = new List<int>();
            result = command.ProjectCardNameAdd();
            Assert.AreEqual(35, result[0]);
        }
    }
}
