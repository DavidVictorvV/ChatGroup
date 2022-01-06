namespace ChapAppMediator
{
    public interface IObserver
    {
        void ReceiveMessage(string userName, string reciever, string message);
        int Id { get; }
        string Name { get; }
    }
}