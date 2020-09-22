using ContentManagementSystem.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagementSystem.Helpers;
using ContentManagementSystem.Models;
using ContentManagementSystem.ViewModels;
using System.Net.Mime;
using System.Xml.Schema;

namespace ContentManagementSystem.Controllers
{
    public class ContentController : Controller 
    {
        private readonly ICMSRepository _cmsRepo;
        private readonly IWebHostEnvironment _webHostEnv;
        private readonly IDataRepository _dataRepository;

        public ContentController(ICMSRepository cmsRepo, IWebHostEnvironment webHostEnv, IDataRepository dataRepository)
        {
            this._cmsRepo = cmsRepo;
            this._webHostEnv = webHostEnv;
            this._dataRepository = dataRepository;
        }

        public async Task<IActionResult> Add(Guid id)
        {
            var fields = await _cmsRepo.GetFieldsForModel(id);
            ViewData["ModelId"] = id.ToString();
            return View(fields);
        }

        [HttpPost]
        public async Task<IActionResult> Add(IFormCollection model)
        {
            int index = await _cmsRepo.GetIndex(Guid.Parse(model["ModelId"].ToString()));

            foreach(var file in model.Files)
            {
                var filename = FileHelper.ProcessFileUpload(file, _webHostEnv);

                var content = new Content()
                {
                    Id = Guid.NewGuid(),
                    ModelId = Guid.Parse(model["ModelId"].ToString()),
                    FieldId = Guid.Parse(file.Name.ToString()),
                    Contents = filename,
                    Index = index + 1
                };

                _dataRepository.Add(content);
            }

            foreach(var item in model.Keys)
            {
                if(item != "__RequestVerificationToken" && item != "ModelId")
                {
                    var content = new Content() 
                    {
                        Id = Guid.NewGuid(),
                        ModelId = Guid.Parse(model["ModelId"].ToString()),
                        FieldId = Guid.Parse(item.ToString()),
                        Contents = model[item].ToString(),
                        Index = index + 1
                    };

                    _dataRepository.Add(content);
                }
            }

            if(await _dataRepository.SaveAll())
            {
                return RedirectToAction("Index", "Fields", new { id = model["ModelId"] });
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        [Route("api/[controller]/index")]
        public async Task<List<Dictionary<string, string>>> Index(Guid id)
        {
            var contents = await _cmsRepo.GetContentForModel(id);

            int index = await _cmsRepo.GetIndex(id);

            // List<string> contentToReturn = new List<string>();

            List<Dictionary<string, string>> contentToReturn = new List<Dictionary<string, string>>();

            for(int i = 1; i <= index; i++)
            {
                Dictionary<string, string> dataToSerialise = new Dictionary<string, string>();

                foreach(var content in contents.Where(x => x.Index == i).ToList())
                {
                    String fieldName = content.Field.Name;

                    fieldName = fieldName.ToLower();
                    fieldName = fieldName.Replace(" ", "_");

                    dataToSerialise.Add(fieldName, content.Contents);
                }

                contentToReturn.Add(dataToSerialise);
            }

            return contentToReturn;
        }

    }
}
