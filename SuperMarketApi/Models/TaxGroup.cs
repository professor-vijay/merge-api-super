﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarketApi.Models
{
    public class TaxGroup
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Tax1 { get; set; }
        public double Tax2 { get; set; }
        public double Tax3 { get; set; }
        public bool IsInclusive { get; set; }
        public bool Updated { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

    }
}
