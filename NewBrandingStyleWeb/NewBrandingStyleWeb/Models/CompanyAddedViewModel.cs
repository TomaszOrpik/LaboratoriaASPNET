using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyleWeb.Models
{
    public class CompanyAddedViewModel
    {
        public int NumberOfCharsInName { get; set; }
        public int NumberOfChartsInDescription { get; set; }
        public bool IsHidden { get; set; }
    }
}
