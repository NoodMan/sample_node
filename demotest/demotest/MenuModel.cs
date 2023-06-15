using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demotest
{
        public class MenuModel
        {
            public int Id { get; set; }
            public string LinkText { get; set; }
            public string ActionName { get; set; }
            public string Controller { get; set; }
            public bool IsPublic { get; set; }
        }
    
}
