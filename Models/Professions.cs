using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace undisclosed_back.Models
{
    public class Professions
    {
        [Key]
        [Required]
        public int Id {get; set;}

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string TempoDeExperiencia { get; set; }
    
        
    }
}