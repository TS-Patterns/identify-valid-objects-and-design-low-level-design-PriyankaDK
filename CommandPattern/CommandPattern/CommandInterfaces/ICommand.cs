using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.CommandInterfaces
{
    /// <summary>
    /// The 'Command' interface
    /// </summary>
    public interface ICommand
    {
        void Execute();
    }
}
