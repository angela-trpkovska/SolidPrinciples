using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOCP.TheGood
{
    /// <summary>
    /// class for latte cofee
    /// </summary>
    public class Latte:Coffee
    {
        // <summary>
        /// make latte
        /// </summary>
        public override void Make()
        {
            System.Console.WriteLine("I am making latte!");
        }


    }
}
