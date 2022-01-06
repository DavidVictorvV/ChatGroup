namespace ChapAppMediator
{
    public interface IUser
    {
        void SendMessage(string message);
        void ReceiveMessage(string userName,string reciever, string message);
        int Id { get; }
        string Name { get; }
        bool IsBusy { get; }
    }
}
