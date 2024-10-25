using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HomeWork
{
    public interface ICommand
    {
        void Execute();
        void UnDo();
    }
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Всет включен.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Свет выключен.");
        }
    }
    public class Door
    {
        public void Open()
        {
            Console.WriteLine("ДВерь открыта");
        }
        public void Close()
        {
            Console.WriteLine("Дверь закрыта");
        }
    }
    public class Thermostat
    {
        public void Increase()
        {
            Console.WriteLine("Температура увеличена");
        }
        public void Decrease()
        {
            Console.WriteLine("Температура уменьшена");
        }
    }
    public class TV
    {
        public void TurnOn()
        {
            Console.WriteLine("Телевизор включен");
        }
        public void TurnOff()
        {
            Console.WriteLine("Телевизор выключен");
        }
    }
    public class LightOnCommand : ICommand
    {
        private Light _light;
        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOn();
        }
        public void UnDo()
        {
            _light.TurnOff();
        }
    }
    public class LightOffCommand : ICommand
    {
        private Light _light;
        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOff();
        }
        public void UnDo()
        {
            _light.TurnOn();
        }
    }
    public class DoorOpenCommand : ICommand
    {
        private Door _door;
        public DoorOpenCommand(Door door)
        {
            _door = door;
        }
        public void Execute()
        {
            _door.Open();
        }
        public void UnDo()
        {
            _door.Close();
        }
    }
    public class DoorCloseCommand : ICommand
    {
        private Door _door;
        public DoorCloseCommand(Door door)
        {
            _door = door;
        }
        public void Execute()
        {
            _door.Close();
        }
        public void UnDo()
        {
            _door.Open();
        }
    }
    public class ThermostatIncreaseCommand : ICommand
    {
        private Thermostat _thermostat;
        public ThermostatIncreaseCommand(Thermostat thermostat)
        {
            _thermostat = thermostat;
        }
        public void Execute()
        {
            _thermostat.Increase();
        }
        public void UnDo()
        {
            _thermostat.Decrease();
        }
    }
    public class ThermostatDecreaseCommand : ICommand
    {
        private Thermostat _thermostat;
        public ThermostatDecreaseCommand(Thermostat thermostat)
        {
            _thermostat = thermostat;
        }
        public void Execute()
        {
            _thermostat.Decrease();
        }
        public void UnDo()
        {
            _thermostat.Increase();
        }
    }
    public class TVOnCommand : ICommand
    {
        private TV _tv;
        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.TurnOn();
        }
        public void UnDo()
        {
            _tv.TurnOff();
        }
    }
    public class TVOffCommand : ICommand
    {
        private TV _tv;
        public TVOffCommand(TV tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.TurnOff();
        }
        public void UnDo()
        {
            _tv.TurnOn();
        }
    }
    public class Invoker
    {
        private Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void SetCommand(ICommand command)
        {
            _commandHistory.Push(command);
            command.Execute();
        }

        public void UnDo()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand command = _commandHistory.Pop();
                command.UnDo();
            }
            else
            {
                Console.WriteLine("Нет команд для отмены.");
            }
        }
    }
    internal class Command
    {
    }
}
