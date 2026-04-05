using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esky_deployment.Domain.Entities
{
    [Table("stations")]
    public class Station : BaseEntity
    {
        [Column("station_name"), MaxLength(255)]
        public string? stationName {get;set;}
        [Column("station_code"), MaxLength(50)]
        public string? stationCode {get;set;}
        [Column("station_address"), MaxLength(255)]
        public string? stationAddress {get;set;}
        [Column("province"), MaxLength(100)]
        public string? province {get;set;}
        [Column("is_active")]
        public Boolean isActive {get;set;}
        [Column("subnet"), MaxLength(50)]
        public string? subnet{get;set;}
        [Column("vpn_internal_ip"), MaxLength(50)]
        public string? vpnInternalIp{get;set;}
        [Column("vpn_file_name"), MaxLength(255)]
        public string? vpnFileName{get;set;}
    }
}