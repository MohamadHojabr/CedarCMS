using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Models
{
    public class Content
    {
        public Content()
        {
            ContentId = Guid.NewGuid();
        }

        public Guid ContentId { get; set; }

        public string Name { get; set; }
    }
}
