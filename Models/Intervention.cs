using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;


namespace Rocket_Elevators_Rest_API.Models
{
    public class Intervention
    {

        
        [Key]
        public int id { get; set; }
        public string? Status { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

    }
}
