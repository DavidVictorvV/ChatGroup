namespace ChapAppMediator
{
    public interface IChatServer
    {
        void RegisterUser(IUser user);
        void RegisterUser(IObserver observer);
        void Unregister(IUser user);
        void Unregister(IObserver observer);
        void SendMessage(string senderName, string message);
    }
}
