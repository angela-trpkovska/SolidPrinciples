using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOCP.TheGood
{
    /// <summary>
    /// class for the cofee shop
    /// </summary>
    public class Starbucks
    {
        private List<Coffee> coffees;


        public Starbucks()
        {
            coffees = new List<Coffee>();
        }

        /// <summary>
        /// method for making coffees
        /// </summary>
        public void MakeCoffees()
        {
            foreach (Coffee coffe in coffees)
                coffe.Make();
        }

      
    }
}
