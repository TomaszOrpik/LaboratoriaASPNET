using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using NewBrandingStyleWeb.Database;
using NewBrandingStyleWeb.Entities;
using NewBrandingStyleWeb.Models;

namespace NewBrandingStyleWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExchangesController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ExchangesDbContext _dbContext;
        public ExchangesController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost]
        public IActionResult Add(CompanyModel item)
        {
            var entity = new ItemEntity
            {
                Name = item.Name,
                Description = item.Description,
                IsVisible = item.IsVisible
            };
            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();
            return View(entity);
        }
        public IActionResult Post()
        {
            return View();
        }
    }
}
