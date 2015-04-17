using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOCP.TheGood
{
    /// <summary>
    /// class for machiato coffee
    /// </summary>
    public class Macchiato:Coffee
    {

        /// <summary>
        /// make machiato
        /// </summary>
        public override void Make()
        {
            System.Console.WriteLine("I am making macchiato!");
        }

       
    }
}
