using SuperMarketApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace SuperMarketApi.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int AccountTypeId { get; set; }

        //[Required]
        [StringLength(50)]
        //[Index(IsUnique = true)]
        public string AccountNo { get; set; }
        [Required]
        public string BankName { get; set; }

        public string AccountHolder { get; set; }
        public string CardNumber { get; set; }
        public double? CreditLimit { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime? ExpiryDate { get; set; }


        public double Balance { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime? CreatedDate { get; set; }


        public string BranchCode { get; set; }

        public bool AllowNegative { get; set; }

      
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

    }
}
