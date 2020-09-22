using ContentManagementSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.Data
{
    public class Seed
    {

        public static void SeedAll(AppDbContext context)
        {
            SeedModels(context);
            SeedFields(context);
            SeedContents(context);
        }

        public static void SeedModels(AppDbContext context)
        {
            if (!context.Models.Any())
            {
                var modelData = System.IO.File.ReadAllText("Data/SeedModels.json");

                var models = JsonConvert.DeserializeObject<List<Model>>(modelData);

                foreach (var model in models)
                {
                    context.Models.Add(model);
                }

                context.SaveChanges();
            }
        }

        public static void SeedFields(AppDbContext context)
        {
            if (!context.Fields.Any())
            {
                var fieldData = System.IO.File.ReadAllText("Data/SeedFields.json");

                var fields = JsonConvert.DeserializeObject<List<Field>>(fieldData);

                foreach (var field in fields)
                {
                    context.Fields.Add(field);
                }

                context.SaveChanges();
            }
        }

        public static void SeedContents(AppDbContext context)
        {
            if (!context.Contents.Any())
            {
                var contentData = System.IO.File.ReadAllText("Data/SeedContents.json");

                var contents = JsonConvert.DeserializeObject<List<Content>>(contentData);

                foreach (var content in contents)
                {
                    context.Contents.Add(content);
                }

                context.SaveChanges();
            }
        }
    }
}
