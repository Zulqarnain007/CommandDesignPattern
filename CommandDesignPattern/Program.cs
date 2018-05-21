using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter action from below list.");
            Console.WriteLine("==========Actions Types: =============");
            Console.WriteLine("1. File, 2. Open, 3. Copy, 4. Exit, 5. Print, 6. Delete.");
            Console.WriteLine("======================================");
            object command = Enum.Parse(typeof(CommandType), Console.ReadLine());
            CommandType cmdType = (CommandType)command;

            Invoker invoker = new Invoker();
            IExecute objExecute = invoker.GetCommand(cmdType);
            objExecute.Execute();
            Console.ReadKey();
        }
    }
}
