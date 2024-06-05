using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dvtlesso06FCK22CNTT4.Models
{
    public class DvtBookStore : DbContext
    {
        public DvtBookStore():base("DvtBookStoreConnectionString") { }
        // khai báo các thuộc tính tương ứng với các bảng trong csdl
        public DbSet<DvtCategory> dvtCategories { get; set; }
        public DbSet<DvtBook> DvtBooks { get; set; }

    }
}