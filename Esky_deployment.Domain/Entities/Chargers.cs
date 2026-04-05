using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esky_deployment.Domain.Entities
{
    [Table("chargers")]
    public class Chargers : BaseEntity
    {
        [Column("station_id")]
        public int stationId { get; set; }
        [Column("charge_code"), MaxLength(50)]
        public string? chargeCode {get;set;}
        [Column("power_kw")]
        public int powerKw{get;set;}
        [Column("brand"), MaxLength(100)]
        public string? brand {get;set;}
        [Column("charger_ip"), MaxLength(50)]
        public string? chargerIp{get;set;}
        [Column("sim_id")]
        public int simId{get;set;}
    }
}