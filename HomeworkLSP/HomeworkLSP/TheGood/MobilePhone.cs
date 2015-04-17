using HomeworkLSP.TheGood.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLSP.TheGood
{
    public class MobilePhone:IMail
    {

        /// <summary>
        /// receive mail on mobile device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="receiver"></param>
        /// <param name="message"></param>
        public void ReceiveMail(string sender, string receiver, string message)
        {
            System.Console.WriteLine("Mail received");
            System.Console.WriteLine("From:{0}", sender);
            System.Console.WriteLine("Body:{0}", message);
        }


    }
}
