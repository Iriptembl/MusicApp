using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class Genre
    {
      
        public int GenreId { get; set; }
        [Required(ErrorMessage = "Can not be empty.")]
        [Display(Name = "Genre")]
        public string GenreName { get; set; } = null!;
        public string? GenreInfo { get; set;}

        public virtual ICollection<Song> SongGenres { get; } = new List<Song>();
    }
}
