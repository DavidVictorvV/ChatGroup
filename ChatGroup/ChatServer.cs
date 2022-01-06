using System;
using System.Collections.Generic;
using System.Linq;

namespace ChapAppMediator
{
    public class ChatServer:IChatServer
    {
        private List<IUser> _users = new List<IUser>();
        private List<IObserver> _observers = new List<IObserver>();

        public void RegisterUser(IUser user)
        {
            //register user and notify each user that a new one joined the club
            if (!_users.Contains(user) && _users.Count + _observers.Count < 10)
            {
                _users.ForEach(x => x.ReceiveMessage("Server", x.Name, $"User {user.Name} is online"));
                _observers.ForEach(x => x.ReceiveMessage("Server", x.Name, $"User {user.Name} is online"));
                _users.Add(user);
            }
            else
            {
                Console.WriteLine("Server: Too many users!");
            }

        }

        public void RegisterUser(IObserver observer)
        {
            //register user and notify each user that a new one joined the club
            if (!_observers.Contains(observer) && _observers.Count < 2 && _users.Count + _observers.Count < 10)
            {
                _users.ForEach(x => x.ReceiveMessage("Server", x.Name, $"Observer {observer.Name} is online"));
                _observers.ForEach(x => x.ReceiveMessage("Server", x.Name, $"Observer {observer.Name} is online"));
                _observers.Add(observer);
            }
            else
            {
                Console.WriteLine("Server: Too many observers/people on server!");
            }

        }

        public void Unregister(IUser user)
        {
            //unregister user and notify each user that one leaved the club
            if (_users.Contains(user))
            {
                _users.Remove(user);
                _users.ForEach(x => x.ReceiveMessage(x.Name, x.Name, $"User {user.Name} is offline"));
            }
        }

        public void Unregister(IObserver observer)
        {
            //unregister user and notify each user that one leaved the club
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
                _observers.ForEach(x => x.ReceiveMessage(x.Name, x.Name, $"User {observer.Name} is offline"));
            }
        }

        public void SendMessage(string senderName, string message)
        {
            //send message to everyone
            _users.ForEach(x => x.ReceiveMessage(senderName, x.Name, message));
            _observers.ForEach(x => x.ReceiveMessage(senderName, x.Name, message));
        }
    }
}
