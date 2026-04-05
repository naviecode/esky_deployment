using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esky_deployment.Domain.Entities
{
    [Table("sims")]
    public class Sims : BaseEntity
    {
        [Column("sim_number"), MaxLength(50)]
        public string? simNumber {get;set;}
        [Column("sim_name"), MaxLength(255)]
        public string? simName {get;set;}
        [Column("sim_package_id")]
        public int? simPackageId {get;set;}
        [Column("status")]
        public Boolean status {get;set;}
    }
}