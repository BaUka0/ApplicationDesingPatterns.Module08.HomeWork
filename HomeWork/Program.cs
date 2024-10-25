using HomeWork;
using System;
namespace HomeWork_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Light light = new Light();
            Door door = new Door();
            Thermostat thermostat = new Thermostat();
            TV tv = new TV();

            LightOnCommand lightOnCommand = new LightOnCommand(light);
            LightOffCommand lightOffCommand = new LightOffCommand(light);
            DoorOpenCommand doorOpenCommand = new DoorOpenCommand(door);
            DoorCloseCommand doorCloseCommand = new DoorCloseCommand(door);
            ThermostatIncreaseCommand increaseCommand = new ThermostatIncreaseCommand(thermostat);
            ThermostatDecreaseCommand decreaseCommand = new ThermostatDecreaseCommand(thermostat);
            TVOnCommand tvOnCommand = new TVOnCommand(tv);
            TVOffCommand tvOffCommand = new TVOffCommand(tv);

            Invoker invoker = new Invoker();

            invoker.SetCommand(lightOnCommand);
            invoker.SetCommand(doorOpenCommand);
            invoker.SetCommand(increaseCommand);
            invoker.SetCommand(tvOnCommand);

            invoker.UnDo();
            invoker.UnDo();
            invoker.UnDo();*/


            /*Console.WriteLine("Приготовим чай:");
            Beverage tea = new Tea();
            tea.PrepareBeverage();

            Console.WriteLine("Приготовим кофе:");
            Beverage coffee = new Coffee();
            coffee.PrepareBeverage();

            Console.WriteLine("Приготовим горячий шоколад:");
            Beverage hotChocolate = new HotChocolate();
            hotChocolate.PrepareBeverage();*/

            ChatRoom chatRoom = new ChatRoom();

            User user1 = new RegularUser(chatRoom, "Alice");
            User user2 = new RegularUser(chatRoom, "Sergey");
            User user3 = new RegularUser(chatRoom, "Victor");

            chatRoom.Join(user1);
            chatRoom.Join(user2);

            user1.SendMessage("Привет всем!");
            user2.SendMessage("Привет, Alice!");

            chatRoom.Leave(user2);
            user1.SendMessage("Пока, Sergey!");

            chatRoom.Join(user3);
            user1.SendMessage("Привет, Victor!");

            user1.SendPrivateMessage(user3, "Привет, Victor! Это личное сообщение.");
        }
    }
}