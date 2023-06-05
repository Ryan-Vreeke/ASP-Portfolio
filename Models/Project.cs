using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{

    public class Project
    {
        public int ID { get; set; }

        [Required]
        public string? Name{get; set;}       
       
    }
}