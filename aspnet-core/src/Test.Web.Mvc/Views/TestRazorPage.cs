using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Test.Web.Views
{
    public abstract class TestRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TestRazorPage()
        {
            LocalizationSourceName = TestConsts.LocalizationSourceName;
        }
    }
}
