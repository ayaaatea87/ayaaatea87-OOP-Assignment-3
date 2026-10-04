using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Part_01.src
{
    public interface IEmailSender
    {
        void Send(string to, string body);
    }
}
