using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Models
{
    public class CategoriesContent
    {
        [Key]
        public int CategoriesContentId { get; set; }
        [Required]
        [DisplayName("نام دسته مطلب")]
        public string Name { get; set; }
        [DisplayName("توضیحات")]
        public string Description { get; set; }
        public int? ParentId { get; set; }

        [DisplayName("گروه بالا دستی")]
        public virtual CategoriesContent Parent { get; set; }
        public virtual ICollection<CategoriesContent> Children { get; set; }
        public virtual ICollection<Content> Content { get; set; }

    }
}
