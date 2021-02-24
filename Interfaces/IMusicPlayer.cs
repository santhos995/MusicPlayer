using System.ServiceModel;

namespace SongStorageInterfaces
{
    [ServiceContract]
    public interface IMusicPlayer
    {
        [OperationContract]
        void Play();

        [OperationContract]
        void PlayByName(string name);
        
        [OperationContract]
        void Pause();

        [OperationContract]
        void ShufflePlay();
    }
}