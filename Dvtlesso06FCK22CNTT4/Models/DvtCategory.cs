using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dvtlesso06FCK22CNTT4.Models
{
    public class DvtCategory
    {
        [Key]
        public int Id { get; set; }
        public string DvtCategoryName { get; set; }
        // thuộc tính quan hệ
        public virtual ICollection<BhpBook> BhpBooks { get; set; }
    }
}