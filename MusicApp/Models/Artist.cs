﻿using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        [Required(ErrorMessage = "Can not be empty.")]
        [Display(Name = "Artist")]
        public string ArtistName { get; set; } = null!;
        public DateTime ArtistBirthday { get; set; }
        public DateTime? ArtistDeathday { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Album> Albums { get; } = new List<Album>();

    }
}
