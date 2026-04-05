using System.ComponentModel.DataAnnotations;

namespace Esky_deployment.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime createdTimeStamp { get; set; }
        public DateTime? lastUpdatedTimeStamp { get; set; }
    }
}