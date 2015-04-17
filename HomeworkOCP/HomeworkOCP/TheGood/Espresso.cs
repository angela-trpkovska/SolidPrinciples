using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOCP.TheGood
{
    /// <summary>
    /// class for espresso coffee
    /// </summary>
    public class Espresso:Coffee
    {

        /// <summary>
        /// make espresso
        /// </summary>
        public override void Make()
        {
            System.Console.WriteLine("I am making espresso!");
        }

    }
}
