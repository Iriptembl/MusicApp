using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class Song
    {
        public int SongId { get; set; }
        [Required(ErrorMessage = "Can not be empty.")]
        [Display(Name = "Song")]
        public string SongName { get; set; } = null!;
        public DataType SongReleaseDate { get; set;}
        public int SongDuration { get; set; }

        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }


    }
}
