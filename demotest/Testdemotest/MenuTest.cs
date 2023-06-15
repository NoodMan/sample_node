using demotest;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testdemotest
{
    [TestClass()]
    public class MenuTests
    {

        private Menu menu;
        [TestInitialize]
        public void init()
        {
            menu = new Menu();
        }


        [TestMethod]
        [DataRow("lienstexte1", "action1", "controle1", true)]
        [DataRow("lienstexte2", "action2", "controle2", false)]
        public void AddNewElementInMenu(string linkText, string actionName, string controller, bool isPublic = true)
        {

            // Act
            menu.Add(linkText, actionName, controller, isPublic);

            // Assert
            Assert.AreEqual(1, menu.Count());
            Assert.AreEqual(linkText, menu.GetList().FirstOrDefault().LinkText);



        }

        [TestMethod]
        [DataRow("lienstexte1", "action1", "controle1", true)]
        [DataRow("lienstexte2", "action2", "controle2", false)]
        public void UpdateElementInMenu(string linkText, string actionName, string controller, bool isPublic = true)
        {
            menu.Add(linkText, actionName, controller, isPublic);

            menu.Update(1, "ltexte1", "aton1", "contle1");

            Assert.AreEqual("ltexte1",menu.GetList().FirstOrDefault().LinkText);
            Assert.AreEqual("aton1", menu.GetList().FirstOrDefault().ActionName);
            Assert.AreEqual("contle1", menu.GetList().FirstOrDefault().Controller);

        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        public void RemoveElementInMenu(int Id)
        {

            menu.Add("LinkText", "ActionName", "Controller");
            int expectedCount = 0;

            menu.Remove(1);

            Assert.AreEqual(expectedCount, menu.Count());
        }

        [TestMethod]
        public void GetListElementInMenu()
        {
            var menu = new Menu();
            menu.Add("Test Menu 1", "Test Action 1", "Test Controller 1");
            menu.Add("Test Menu 2", "Test Action 2", "Test Controller 2");

            // Act
            var menus = menu.GetList();

            // Assert
            Assert.AreEqual(2, menus.Count());
            Assert.AreEqual("Test Menu 1", menus.FirstOrDefault().LinkText);
            Assert.AreEqual("Test Menu 2", menus.LastOrDefault().LinkText);

        }
    }
}
