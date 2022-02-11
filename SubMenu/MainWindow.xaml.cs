using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ActiproSoftware.Windows.Themes;

namespace SubMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            ThemeManager.CurrentTheme = ThemeNames.MetroDark;
            ThemeManager.AreNativeThemesEnabled = true;

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
