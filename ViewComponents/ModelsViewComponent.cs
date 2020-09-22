using ContentManagementSystem.Data;
using ContentManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.ViewComponents
{
    public class ModelsViewComponent : ViewComponent
    {
        private readonly IDataRepository _dataRepo;

        public ModelsViewComponent(IDataRepository dataRepo)
        {
            this._dataRepo = dataRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var models = await _dataRepo.GetList<Model>();

            return View(models);
        }
    }
}
