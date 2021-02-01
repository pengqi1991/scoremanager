using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using ScoreManager.Core;
using ScoreManager.Modules.BasicInfo.Menus;
using ScoreManager.Modules.BasicInfo.ViewModels;
using ScoreManager.Modules.BasicInfo.Views;


namespace ScoreManager.Modules.BasicInfo
{
    public class BasicInfoModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public BasicInfoModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            
            _regionManager.RegisterViewWithRegion(RegionNames.MenuRegion, typeof(BasicInfoMenu));
        
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "BasicInfoPage");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
           // ViewModelLocationProvider.Register<BasicInfoPage, BasicInfoPageViewModel>();
            containerRegistry.RegisterForNavigation<BasicInfoPage, BasicInfoPageViewModel>();

        }
    }
}