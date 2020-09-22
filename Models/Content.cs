using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.Models
{
    public class Content
    {
        public Guid Id { get; set; }

        public Guid FieldId { get; set; }
        public virtual Field Field { get; set; }

        public Guid ModelId { get; set; }
        public virtual Model Model { get; set; }

        public string Contents { get; set; }
        public int Index { get; set; }

    }
}
