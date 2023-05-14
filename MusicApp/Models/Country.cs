using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        
        [Required(ErrorMessage = "Can not be empty.")]
        [Display(Name = "Country")]
        public string CountryName { get; set; } = null!;
        public virtual ICollection<Artist> Artists { get; } = new List<Artist>();
    }
}
