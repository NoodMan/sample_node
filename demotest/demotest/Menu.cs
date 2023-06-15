using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demotest
{
    public class Menu
    {
        private List<MenuModel> Menus { get; set; }

        public Menu()
        {
            Menus = new List<MenuModel>();
        }

        public int Count()
        {
            return Menus.Count;
        }

        public void Add(string linkText, string actionName, string controller, bool isPublic = true)
        {
            Menus.Add(new MenuModel()
            {
                Id = this.Menus.Count + 1,
                LinkText = linkText,
                ActionName = actionName,
                Controller = controller,
                IsPublic = isPublic
            });
        }

        public IEnumerable<MenuModel> GetList()
        {
            return Menus.AsEnumerable();
        }

        public void Remove(int Id)
        {
            var menu = Menus.Where(x => x.Id == Id).FirstOrDefault();
            if (menu == null)
            {
                throw new Exception("Le menu sélectionné n'existe pas");
            }
            Menus.Remove(menu);
        }

        public void Update(int Id, string LinkText, string ActionName, string Controller, bool IsPublic = true)
        {
            MenuModel menu = GetList().Where(x => x.Id == Id).FirstOrDefault();
            if (menu == null)
            {
                throw new Exception("Le menu sélectionné n'existe pas");
            }
            menu.LinkText = LinkText;
            menu.ActionName = ActionName;
            menu.Controller = Controller;
            menu.IsPublic = IsPublic;
        }
    }
}
