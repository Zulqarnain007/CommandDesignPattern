using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ConcreteCommand classes
/// </summary>
namespace CommandDesignPattern
{
    public class ExecuteFile : IExecute
    {
        ManageExecute me = new ManageExecute();
        public ExecuteFile()
        {
            strCammand = CommandType.File;
        }
        public override void Execute()
        {

            me.ProcessExecution(strCammand);
        }
    }

    public class ExecuteOpen : IExecute
    {
        ManageExecute me = new ManageExecute();
        public ExecuteOpen()
        {
            strCammand = CommandType.Open;
        }
        public override void Execute()
        {
            me.ProcessExecution(strCammand);
        }
    }

    public class ExecuteExit : IExecute
    {
        ManageExecute me = new ManageExecute();
        public ExecuteExit()
        {
            strCammand = CommandType.Exit;
        }
        public override void Execute()
        {
            me.ProcessExecution(strCammand);
        }
    }

    public class ExecuteCopy : IExecute
    {
        ManageExecute me = new ManageExecute();
        public ExecuteCopy()
        {
            strCammand = CommandType.Copy;
        }
        public override void Execute()
        {
            me.ProcessExecution(strCammand);
        }
    }

    public class ExecutePrint : IExecute
    {
        ManageExecute me = new ManageExecute();
        public ExecutePrint()
        {
            strCammand = CommandType.Print;
        }
        public override void Execute()
        {
            me.ProcessExecution(strCammand);
        }
    }

    public class ExecuteDelete : IExecute
    {
        ManageExecute me = new ManageExecute();
        public ExecuteDelete()
        {
            strCammand = CommandType.Delete;
        }
        public override void Execute()
        {
            me.ProcessExecution(strCammand);
        }
    }

}
