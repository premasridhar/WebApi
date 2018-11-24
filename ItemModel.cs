using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ItemModel
    {

        public string ITCODE { get; set; }
        public string ITDESC { get; set; }

        public decimal ITRATE { get; set; }

        public ICollection<PODetailModel> PODETAILs { get; set; }

    }
}