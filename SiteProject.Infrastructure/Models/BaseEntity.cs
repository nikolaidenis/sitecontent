using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteProject.Infrastructure.Models
{
    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
    }
}
