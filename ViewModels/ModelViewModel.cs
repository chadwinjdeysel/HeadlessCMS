using ContentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.ViewModels
{
    public class ModelViewModel
    {
        public IEnumerable<Model> Models { get; set; }

        public Model ModelToAdd { get; set; }
    }
}
