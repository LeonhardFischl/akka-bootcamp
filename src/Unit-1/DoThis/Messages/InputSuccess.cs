using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTail.Messages
{
    /// <summary>
    /// Determines valid input
    /// </summary>
    public class InputSuccess
    {
        public string Reason { get; }

        public InputSuccess(string reason)
        {
            Reason = reason;
        }
    }
}
