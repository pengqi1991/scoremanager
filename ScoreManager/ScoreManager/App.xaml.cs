using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using ScoreManager.Cores.Regions;
using ScoreManager.Modules.BasicInfo;
using ScoreManager.Modules.Register;
using ScoreManager.Services;
using ScoreManager.Services.Interfaces;
using ScoreManager.Views;
using Syncfusion.SfSkinManager;
using Syncfusion.UI.Xaml.NavigationDrawer;
using System.Windows;

namespace ScoreManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            
           
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<BasicInfoModule>();
            moduleCatalog.AddModule<RegisterModule>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(SfNavigationDrawer), Container.Resolve<MenuRibbonRegionAdapter>());
        }
    }
}
