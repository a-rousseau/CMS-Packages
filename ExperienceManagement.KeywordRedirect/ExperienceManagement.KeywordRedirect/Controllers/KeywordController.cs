﻿using Composite.Core;
using Composite.Core.Application;
using Composite.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Orckestra.ExperienceManagement.KeywordRedirect.Controllers
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

            var redirect = KeywordManager.GetPublicRedirect(keyword, System.Threading.Thread.CurrentThread.CurrentCulture);

            if (redirect != null) {
                return Redirect(redirect);
            }

            return null;
        }
    }
}
