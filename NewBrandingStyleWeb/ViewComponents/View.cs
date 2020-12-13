using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyleWeb.Database;

namespace NewBrandingStyleWeb.ViewComponents
{
    public class View : ViewComponent
    {
        private readonly ExchangesDbContext _dbContext;

        public View(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var items = _dbContext.Items;
            return View("Index", items);
        }
    }
}
