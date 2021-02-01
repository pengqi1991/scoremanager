using Prism.Regions;
using Syncfusion.UI.Xaml.NavigationDrawer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManager.Cores.Regions
{
    public class MenuRibbonRegionAdapter : RegionAdapterBase<SfNavigationDrawer>
    {
        public MenuRibbonRegionAdapter(IRegionBehaviorFactory factory) : base(factory)
        {

        }
        protected override void Adapt(IRegion region, SfNavigationDrawer regionTarget)
        {
            region.Views.CollectionChanged += ((x, y) =>
            {
                switch (y.Action)
                {
                    case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                        foreach (NavigationItem group in y.NewItems)
                        {
                            regionTarget.Items.Add(group);
                            if (regionTarget.Items[0] == group)
                            {
                                regionTarget.SelectedItem = group;
                            }
                        }
                        break;
                    case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                        foreach (NavigationItem group in y.OldItems)
                        {
                            regionTarget.Items.Remove(group);

                        }
                        break;

                }

            });
        }
        protected override IRegion CreateRegion()
        {
            //SingleActiveRegion AllActiveRegion
            return new SingleActiveRegion();
        }
    }
}
