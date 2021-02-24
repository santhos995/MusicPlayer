
using SongStorageInterfaces;
using DataStructures;

namespace MusicPlayer
{
    public class MusicPlayerClass : IMusicPlayer
    {
        private ISongStorage _songStorage;
        private Song[] _playlist;
        private int _curSongIndex = -1;

        private MusicPlayerClass()
        {
                
        }

        public MusicPlayerClass(ISongStorage songStorage)
        {
            _songStorage = songStorage;
        }
        public void Play()
        {
            if (_playlist != null && _curSongIndex>=0)
            {
                _playlist[_curSongIndex++].Resume();
            }
            else
            {
                _playlist = _songStorage.GetSongs();
                _curSongIndex = 0;
            }
            for (int i = _curSongIndex+1; i < _playlist.Length; i++)
            {
                _playlist[i].Play();
            }
        }

        public void PlayByName(string name)
        {
            _songStorage.GetSong(name).Play();
        }

        public void Pause()
        {
            throw new System.NotImplementedException();
        }

        public void ShufflePlay()
        {
            throw new System.NotImplementedException();
        }
    }
}