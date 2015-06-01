using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductManagement.Admin.Models;
using ProductManagement.Core.Repository;
using ProductManagement.Data;

namespace ProductManagement.Admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var model = new List<CategoryPageModel> { };

            var repository = new CategoryRepository();

            model.AddRange(repository.GetAll().Select(category => new CategoryPageModel() { Id = category.Id, Name = category.Name }));

            return View(model);
        }

        public ActionResult Detail(int? id)
        {
            var model = new CategoryPageModel();
            if (id != null)
            {
                var repository = new CategoryRepository();
                var category = repository.GetById(id.Value);

                if (category != null)
                {
                    model.Id = category.Id;
                    model.Name = category.Name;
                }

            }
            return View(model);
        }
    }
}