using ContentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContentManagementSystem.ViewModels
{
    public class FieldViewModel
    {
        public IEnumerable<Field> Fields { get; set; }
        public Guid ModelId { get; set; }
        public string ModelName { get; set; }
        public string Name { get; set; }
        public int FieldType { get; set; }

    }
}
