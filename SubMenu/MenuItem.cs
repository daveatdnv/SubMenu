using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SubMenu
{
    public class MenuItem
    {
        public string Name { get; set; }

        public ObservableCollection<MenuItem> Items { get; set; }
    }

}
