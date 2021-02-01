using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using ScoreManager.Core;
using ScoreManager.Modules.Register.Menus;
using ScoreManager.Modules.Register.ViewModels;
using ScoreManager.Modules.Register.Views;

namespace ScoreManager.Modules.Register
{
    public class RegisterModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public RegisterModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.MenuRegion, typeof(RegisterMenu));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterPageViewModel>();
        }
        
    }
}