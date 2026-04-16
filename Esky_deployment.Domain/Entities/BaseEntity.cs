using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esky_deployment.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime createdTimeStamp { get; set; }
        public DateTime? lastUpdatedTimeStamp { get; set; }
    }
}