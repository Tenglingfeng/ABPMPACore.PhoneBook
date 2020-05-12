using Abp.AspNetCore.Mvc.ViewComponents;

namespace Test.Web.Views
{
    public abstract class TestViewComponent : AbpViewComponent
    {
        protected TestViewComponent()
        {
            LocalizationSourceName = TestConsts.LocalizationSourceName;
        }
    }
}
