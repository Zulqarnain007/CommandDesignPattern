using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    /// <summary>
    /// Command class.
    /// </summary>
    public abstract class IExecute
    {
        public CommandType strCammand = CommandType.NoCommand;
        public virtual void Execute()
        {

        }
    }
}
