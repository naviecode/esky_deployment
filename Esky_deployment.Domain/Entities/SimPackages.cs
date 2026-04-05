using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esky_deployment.Domain.Entities
{
    [Table("sim_packages")]
    public class SimPackages : BaseEntity
    {
        [Column("telco"), MaxLength(100)]
        public string? telco {get;set;}
        [Column("supplier"), MaxLength(150)]
        public string? supplier {get;set;}
        [Column("activation_date")]
        public DateTime? activationDate {get;set;}
        [Column("next_renewal_date")]
        public DateTime? nextRenewalDate {get;set;}
        [Column("sim_quantity")]
        public int simQuantity {get;set;}
    }
}