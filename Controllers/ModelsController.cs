using ContentManagementSystem.Data;
using ContentManagementSystem.Models;
using ContentManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.Controllers
{
    public class ModelsController : Controller
    {
        private readonly IDataRepository _dataRepo;

        public ModelsController(IDataRepository dataRepo)
        {
            this._dataRepo = dataRepo;
        }

        public async Task<IActionResult> Index()
        {
            var model = new ModelViewModel();
            model.Models = await _dataRepo.GetList<Model>();

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ModelViewModel model)
        {
            if (ModelState.IsValid)
            {
                var modelToAdd = new Model()
                {
                    Name = model.ModelToAdd.Name,
                    Description = model.ModelToAdd.Description
                };

                modelToAdd.Id = Guid.NewGuid();

                _dataRepo.Add<Model>(modelToAdd);

                if(await _dataRepo.SaveAll())
                    return RedirectToAction("Index");

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
            
        } 
    }
}
