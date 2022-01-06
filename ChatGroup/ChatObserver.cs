using System;
using System.Collections.Generic;
using System.Text;

namespace ChapAppMediator
{
    class ChatObserver : IObserver
    {

        public int Id { get; }
        public string Name { get; }

        public ChatObserver(string name)
        {
            Id = new Random().Next();
            Name = name;
        }

        public void ReceiveMessage(string userName, string reciever, string message)
        {
            Console.WriteLine($"{userName}: {message} (recieved by: {reciever})");
        }

    }
}
