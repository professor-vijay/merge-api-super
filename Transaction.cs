using SuperMarketApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarketApi.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public bool Updated { get; set; }
        public int? OrderId { get; set; }
        public virtual Order Order { get; set; }

        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("PaymentType")]
        public int PaymentTypeId { get; set; }
        public virtual PaymentType PaymentType { get; set; }

        public int TranstypeId { get; set; }
        public int? PaymentStatusId { get; set; }

        [DataType(DataType.Date)]
        public DateTime TransDateTime { get; set; }

        [Column(TypeName = "Date")]
        public DateTime TransDate { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        [ForeignKey("Store")]
        public int StoreId { get; set; }
        public virtual Store Store { get; set; }

        public string Notes { get; set; }

        public int TransModeId { get; set; }

        public bool IsIncoming { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        [NotMapped]
        public string ChequeNo { get; set; }
        [NotMapped]
        [DataType(DataType.Date)]
        public System.DateTime ChequeDate { get; set; }

        [ForeignKey("BankAccount")]
        public int? BankAccountId { get; set; }
        public virtual BankAccount BankAccount { get; set; }

        [ForeignKey("Contact")]
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime? DueDate { get; set; }

    }
}
