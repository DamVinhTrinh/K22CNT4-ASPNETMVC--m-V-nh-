using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dvtlesso06FCK22CNTT4.Models
{
    public class DvtBook
    {
        [Key]
        public int DvtId { get; set; }
        public string DvtBookId { get; set; }
        public string DvtTitle { get; set; }
        public string DvtAuthor { get; set; }
        public int DvtYear { get; set; }
        public String DvtPulisher { get; set; }
        public string DvtPicture { get; set; }
        public string DvtcategoryId { get; set; }
        // thuộc tính quan hệ
        public virtual DvtCategory DvtCategory { get; set; }
    }
}