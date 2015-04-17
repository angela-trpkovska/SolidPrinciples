using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLSP.TheGood.Interfaces
{
    interface IMail
    {
       void ReceiveMail(string sender, string receiver, string message);
    }
}
