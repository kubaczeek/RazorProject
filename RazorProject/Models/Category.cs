using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace RazorProject.Models
{
    public class Category
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public ICollection<File> Products { get; set; }
        [Required]
        public File Photo { get; set; }
    }
}
