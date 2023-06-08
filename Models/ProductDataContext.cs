using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace XcifyTestCode.Models
{
    
    public partial class XcifySampleTestDB : DataContext
    {
        public XcifySampleTestDB() : base("Data Source=XcifySampleTestDB;Initial Catalog=XcifySampleTestDB;Integrated Security=True")
        {
        }


        //public Table<tblProduct> Products => GetTable<tblProduct>();
        public virtual Table<tblProduct> tblProducts { get; set; }
    }

    
}