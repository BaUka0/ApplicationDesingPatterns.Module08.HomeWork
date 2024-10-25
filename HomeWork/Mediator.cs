using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public interface IMediator
    {
        void SendMessage(User sender, string message);
        void Join(User user);
        void Leave(User user);
        void SendPrivateMessage(User sender, User receiver, string message);
    }
    public class ChatRoom : IMediator
    {
        private List<User> _users = new List<User>();

        public void SendMessage(User sender, string message)
        {
            Console.WriteLine($"{sender.Name}: {message}");
            foreach (User user in _users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage(message, sender);
                }
            }
        }

        public void Join(User user)
        {
            _users.Add(user);
            Console.WriteLine($"{user.Name} присоединился к чату.");
            SendMessage(user, $"{user.Name} присоединился к чату.");
        }

        public void Leave(User user)
        {
            _users.Remove(user);
            Console.WriteLine($"{user.Name} покинул чат.");
            SendMessage(user, $"{user.Name} покинул чат.");
        }

        public void SendPrivateMessage(User sender, User receiver, string message)
        {
            receiver.ReceiveMessage(message, sender);
        }
    }

    public abstract class User
    {
        protected IMediator _mediator;
        public string Name { get; }

        protected User(IMediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
        }

        public void SendMessage(string message)
        {
            if (_mediator == null)
            {
                Console.WriteLine("Ошибка: Вы не подключены к чату.");
                return;
            }

            _mediator.SendMessage(this, message);
        }

        public void SendPrivateMessage(User receiver, string message)
        {
            _mediator.SendPrivateMessage(this, receiver, message);
        }

        public abstract void ReceiveMessage(string message, User sender);
    }
    public class RegularUser : User
    {
        public RegularUser(IMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void ReceiveMessage(string message, User sender)
        {
            Console.WriteLine($"{sender.Name} -> {this.Name}: {message}");
        }
    }
    internal class Mediator
    {
    }
}
