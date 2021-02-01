using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using ScoreManager.Core;
using Syncfusion.UI.Xaml.NavigationDrawer;

namespace ScoreManager.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "成绩处理系统";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private DelegateCommand<NavigationItemClickedEventArgs> _selectedCommand;
        private readonly IRegionManager _regionManager;

        public DelegateCommand<NavigationItemClickedEventArgs> SelectedCommand =>
            _selectedCommand ?? (_selectedCommand = new DelegateCommand<NavigationItemClickedEventArgs>(ExecuteSelectedCommand));

        void ExecuteSelectedCommand(NavigationItemClickedEventArgs parameter)
        {
            string navigationPath = ( parameter.Item as INavigationItem).NavigationPath;
            bool contentRegionExists = _regionManager.Regions.ContainsRegionWithName("ContentRegion");
            _regionManager.RequestNavigate(RegionNames.ContentRegion, navigationPath);

        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
        }

    }
}
