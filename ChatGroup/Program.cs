using System;

namespace ChapAppMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatServer = new ChatServer();

            var john = new ChatUser("John", chatServer);
            var doe = new ChatUser("Doe", chatServer);
            var andrew = new ChatUser("Andrew", chatServer);

            var andrew1 = new ChatUser("Andrew1", chatServer);
            var andrew2 = new ChatUser("Andrew2", chatServer);
            var andrew3 = new ChatUser("Andrew3", chatServer);
            var andrew4 = new ChatUser("Andrew4", chatServer);
            var andrew5 = new ChatUser("Andrew5", chatServer);
            var andrew6 = new ChatUser("Andrew6", chatServer);
            var andrew7 = new ChatUser("Andrew7", chatServer);
            var andrew8 = new ChatUser("Andrew8", chatServer);
            var andrew9 = new ChatUser("Andrew9", chatServer);

            var john1 = new ChatObserver("John1");
            var john2 = new ChatObserver("John2");
            var john3 = new ChatObserver("John3");


            chatServer.RegisterUser(john);//registred
            chatServer.RegisterUser(doe);//registred
            chatServer.RegisterUser(andrew);//registered
            chatServer.RegisterUser(andrew1);//registered
            chatServer.RegisterUser(andrew2);//registered
            chatServer.RegisterUser(andrew3);//registered
            chatServer.RegisterUser(andrew4);//registered
            chatServer.RegisterUser(andrew5);//registered
            chatServer.RegisterUser(andrew6);//registered
            chatServer.RegisterUser(andrew7);//registered
            chatServer.RegisterUser(john2);//too many users
            chatServer.RegisterUser(andrew8);//too many users
            chatServer.RegisterUser(andrew9);//too many users
            chatServer.Unregister(john);//unregister

            chatServer.RegisterUser(john1);//registered
            chatServer.RegisterUser(john3);//too many users

            john.SendMessage("Test message");//message wont send because john unregistered
            andrew3.SendMessage("We get it!");//every person in chatServer will recieve the message
            andrew9.SendMessage("Can i?");//message wont send because andrew9 isnt registered

            Console.ReadLine();
        }
    }
}
