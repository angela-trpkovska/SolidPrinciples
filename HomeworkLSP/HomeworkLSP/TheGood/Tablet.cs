using HomeworkLSP.TheGood.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLSP.TheGood
{
    public class Tablet : IMail, IDocument
    {
        /// <summary>
        /// receive mail on tablet
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

        /// <summary>
        /// write document on tablet
        /// </summary>
        /// <param name="text"></param>
        public void WriteDocument(string text)
        {
            System.Console.WriteLine("Starting to write document on tablet application");
            System.Console.WriteLine(text);

        }



    }
}
