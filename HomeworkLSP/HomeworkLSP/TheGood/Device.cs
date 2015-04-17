using HomeworkLSP.TheGood.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLSP.TheGood
{
    /// <summary>
    /// class for the device
    /// </summary>
    public class Device:IDocument,IMail
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string producer;

        public string Producer
        {
            get { return producer; }
            set { producer = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        /// <summary>
        /// receiving mail on the device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="receiver"></param>
        /// <param name="message"></param>
        public virtual  void ReceiveMail(string sender, string receiver, string message)
        {
            System.Console.WriteLine("Mail received");

        }

        /// <summary>
        /// writting document on the device
        /// </summary>
        /// <param name="text"></param>
        public virtual void WriteDocument(string text)
        {
            System.Console.WriteLine("Starting to write document");

        }


    }
}
