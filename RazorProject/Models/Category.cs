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
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Ilość produktów w serwisie")]
        public ICollection<File> Products { get; set; }
        [Required]
        [Display(Name = "Zdjęcie")]
        public File Photo { get; set; }
    }
}
