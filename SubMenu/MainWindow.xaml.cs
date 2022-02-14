using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace SubMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyContextMenu.ItemsSource = new List<MenuItem>
            {
                new MenuItem
                {
                    Name = "Menu 1",
                    Items = new ObservableCollection<MenuItem>
                    {
                        new MenuItem
                        {
                            Name = "Menu 1.1", Items = new ObservableCollection<MenuItem>
                            {
                                new MenuItem { Name = "SubMenu 1.1.1" },
                                new MenuItem { Name = "SubMenu 1.1.2" }
                            }
                        },
                        new MenuItem
                        {
                            Name = "Menu 1.2", Items = new ObservableCollection<MenuItem>
                            {
                                new MenuItem { Name = "SubMenu 1.2.1" },
                                new MenuItem { Name = "SubMenu 1.2.2" },
                                new MenuItem { Name = "SubMenu 1.2.3" },
                                new MenuItem { Name = "SubMenu 1.2.4" }
                            }
                        }
                    }
                },
            };
        }
    }
}
