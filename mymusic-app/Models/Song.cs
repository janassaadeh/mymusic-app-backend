using System.Text.Json.Serialization;

namespace mymusic_app.Models
{
    public class Song
    {
        public Guid Id { get; set; }
        public string DeezerTrackId { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }

        public Guid ArtistId { get; set; }
        public Artist Artist { get; set; }

        public Guid AlbumId { get; set; }
        public Album Album { get; set; }
        [JsonIgnore]
        public ICollection<SongGenre> Genres { get; set; }
        [JsonIgnore]
        public ICollection<UserSongLike> Likes { get; set; }
        [JsonIgnore]
        public ICollection<UserSongPlay> Plays { get; set; }

        [JsonIgnore]
        public ICollection<PlaylistSong> Playlists { get; set; }
    }

}
