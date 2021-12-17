using Prism.Regions;
using Prism.Regions.Behaviors;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Windows;

namespace Main.PrismAdapter
{
    public class TabControlExtRegionAdapter : RegionAdapterBase<TabControlExt>
    {
        public TabControlExtRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
        {
        }

        protected override void Adapt(IRegion region, TabControlExt regionTarget)
        {
        }

        protected override void AttachBehaviors(IRegion region, TabControlExt regionTarget)
        {
            if (region == null)
                throw new ArgumentNullException(nameof(region));

            // Add the behavior that syncs the items source items with the rest of the items
            region.Behaviors.Add(SelectorItemsSourceSyncBehavior.BehaviorKey, new SelectorItemsSourceSyncBehavior()
            {
                HostControl = regionTarget
            });

            //在TabControlExt 删除TabItem时并未删除Region里面的View会导致无法重新加载TabItem(故在此增加事件，保证在删除TabItem时删除相应视图)
            regionTarget.OnCloseButtonClick += (s, e) =>
            {
                region.Remove(e.TargetTabItem.Content);
            };

            regionTarget.OnCloseAllTabs += (s, e) => {
                foreach (var item in e.ClosingTabItems)
                {
                    region.Remove(item);
                }
            };

            regionTarget.OnCloseOtherTabs += (s, e) => {
                foreach (var item in e.ClosingTabItems)
                {
                    region.Remove(item);
                }
            };

            base.AttachBehaviors(region, regionTarget);
        }

        protected override IRegion CreateRegion()
        {
            return new Region();
        }
    }
}
