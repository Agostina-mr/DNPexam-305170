using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Models
{
    public class Child
    {   
        [Key] 
        public int ChildId { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, Range(3,6, ErrorMessage = "Kids should be between 3 and 6 years old")]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        public List<Toy> Toys { get; set; }
    }
}