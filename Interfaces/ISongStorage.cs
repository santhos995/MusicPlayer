using DataStructures;

namespace SongStorageInterfaces
{
    public interface ISongStorage
    {
        Song[] GetSongs();
        Song GetSong(string name);
        bool AddSong(Song song);
        bool UpdateSong(string name, Song song);
    }
}