using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        public int ArtistId { get; set; }
        [Required(ErrorMessage = "Can not be empty.")]
        [Display(Name = "Name of album")]
        public string AlbumName { get; set; } = null!;
        public DataType AlbumReleaseDate { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual ICollection<Song> Songs { get; } = new List<Song>();

    }
}
