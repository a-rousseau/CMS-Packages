﻿using System.Threading;
using System.Web.Mvc;
using Composite.Core.Application;
using Composite.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Orckestra.Search.KeywordRedirect.Controllers
{
    [ApplicationStartup()]
    public class KeywordControllerRegistrator {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(KeywordController));
        }
    }

    public class KeywordController : Controller
    {
        public KeywordManager KeywordManager { get; }

        public KeywordController(KeywordManager keywordManager) {

            KeywordManager = keywordManager;
        }

        public virtual ActionResult RedirectByKeyword(string paramName = "keywords")
        {
            var keyword = Request[paramName];

            var redirect = KeywordManager.GetPublicRedirect(keyword, Thread.CurrentThread.CurrentCulture, SitemapNavigator.CurrentHomePageId);

            if (redirect != null) {
                return Redirect(redirect);
            }

            return null;
        }
    }
}