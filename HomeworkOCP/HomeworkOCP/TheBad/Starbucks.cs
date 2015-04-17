using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOCP.TheBad
{
    /// <summary>
    /// class for the cofee shop
    /// </summary>
    public class Starbucks
    {
        private List<Latte> lattes;
        private List<Macchiato> machiatos;
        private List<Espresso> espressos;

        /// <summary>
        /// method for making coffees
        /// </summary>
        public void MakeCoffes()
        {
            foreach (Latte latte in lattes)
                latte.Make();

            foreach (Macchiato machiato in machiatos)
                machiato.Make();

            foreach (Espresso esspresso in espressos)
                esspresso.Make();
       }
    }
}
