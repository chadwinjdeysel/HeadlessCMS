using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagementSystem.Data;
using ContentManagementSystem.Models;
using ContentManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ContentManagementSystem.Controllers
{
    public class FieldsController : Controller
    {
        private readonly ICMSRepository _cmsRepo;
        private readonly IDataRepository _dataRepo;

        public FieldsController(ICMSRepository cmsRepo, IDataRepository dataRepo)
        {
            this._cmsRepo = cmsRepo;
            this._dataRepo = dataRepo;
        }

        public async Task<IActionResult> Index(Guid id)
        {
            var theModel = await _dataRepo.Get<Model>(id);

            var model = new FieldViewModel()
            {
                Fields = await _cmsRepo.GetFieldsForModel(id),
                ModelName = theModel.Name,
                ModelId = id
            };

            //ViewData["ModelId"] = id.ToString();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add(Guid id)
        {
            FieldViewModel model = new FieldViewModel()
            {
                ModelId = id
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(FieldViewModel model)
        {
            if (ModelState.IsValid)
            {   
                var field = new Field()
                {
                    Id = Guid.NewGuid(),
                    ModelId = model.ModelId,
                    Name = model.Name,
                    fieldType = (FieldType)(model.FieldType)
                };

                _dataRepo.Add<Field>(field);

                if (await _dataRepo.SaveAll())
                    return RedirectToAction("Index", new { id = model.ModelId });
            }

            return View(model);
        }


    }
}
