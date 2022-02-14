using System.Windows;
using ActiproSoftware.Windows.Themes;

namespace SubMenu
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ThemeManager.CurrentTheme = ThemeNames.MetroDark;
            ThemeManager.AreNativeThemesEnabled = true;

            base.OnStartup(e);
        }
    }
}
