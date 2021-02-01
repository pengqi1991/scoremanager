using Syncfusion.SfSkinManager;
using Syncfusion.Windows.Shared;
using System.Windows;

namespace ScoreManager.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ChromelessWindow
    {
        public MainWindow()
        {
            SfSkinManager.SetTheme(this, new Theme("MaterialLightBlue"));
            SfSkinManager.ApplyStylesOnApplication = true;
            InitializeComponent();
           
        }
    }
}
