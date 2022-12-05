using System.ComponentModel.DataAnnotations;

namespace Pokemerch.Api.Models.Entities
{
    public class BaseEntity
    {
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Updated At")]
        public DateTime UpdatedAt { get; set; }
    }
}
