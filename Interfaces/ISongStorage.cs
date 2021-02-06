using DataStructures;

namespace SongStorageInterfaces
{
    interface ISongStorage
    {
        string[] GetSongs();
        Song GetSong(string name);
        bool AddSong(Song song);
        bool UpdateSong(string name, Song song);
    }
}