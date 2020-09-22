using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.Models
{
    public class Field
    {
        public Guid Id { get; set; }

        public Guid ModelId { get; set; }
        public virtual Model Model { get; set; }

        public string Name { get; set; }
        public FieldType fieldType { get; set; }

        public virtual List<Content> Contents{ get; set;}

    }

    public enum FieldType
    {
        ShortText,
        LongText,
        Number,
        File    
    }
}
