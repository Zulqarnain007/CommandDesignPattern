using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    /// <summary>
    /// Invoker class.
    /// </summary>
    public class Invoker
    {
        private ArrayList _objArrayList = new ArrayList();

        public Invoker()
        {
            _objArrayList.Add(new ExecuteFile());
            _objArrayList.Add(new ExecuteOpen());
            _objArrayList.Add(new ExecuteExit());
            _objArrayList.Add(new ExecuteCopy());
            _objArrayList.Add(new ExecutePrint());
            _objArrayList.Add(new ExecuteDelete());
        }

        public IExecute GetCommand(CommandType command)
        {
            foreach (var obj in _objArrayList)
            {
                IExecute objExecute = (IExecute)obj;
                if (objExecute.strCammand == command)
                {
                    return objExecute;
                }
            }
            return null;
        }
    }
}
