using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public interface IManageExecute
    {
        void ProcessExecution(CommandType cmd);
    }

    /// <summary>
    /// Reciever class.
    /// </summary>
    public class ManageExecute : IManageExecute
    {
        public void ProcessExecution(CommandType cmd)
        {
            switch (cmd)
            {
                case CommandType.File:
                    Console.WriteLine("Executed File Action...!");
                    break;
                case CommandType.Open:
                    Console.WriteLine("Executed Open Action...!");
                    break;
                case CommandType.Exit:
                    Console.WriteLine("Executed Exit Action...!");
                    break;
                case CommandType.Copy:
                    Console.WriteLine("Executed Copy Action...!");
                    break;
                case CommandType.Print:
                    Console.WriteLine("Executed Print Action...!");
                    break;
                case CommandType.Delete:
                    Console.WriteLine("Executed Delete Action...!");
                    break;
                default:
                    Console.WriteLine("Invalid Input.! Please enter correct input.");
                    break;

            }
        }
    }

    public enum CommandType
    {
        NoCommand = 0,
        File = 1,
        Open = 2,
        Copy = 3,
        Exit = 4,
        Print = 5,
        Delete = 6

    }
}
