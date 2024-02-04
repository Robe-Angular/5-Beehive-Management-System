using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Beehive_Management_System
{
    class Bee
    {
        
        public Bee(int weight)
        {
            this.weight = weight;

        }

        private int weight;

        public virtual int ShiftsLeft {

            get { return 0; }

        }
        
        
        public virtual double GetHoneyConsumption()
        {
            
            double consumption;
            if(ShiftsLeft == 0)
            {
                consumption = 7.5;
            }
            else
            {
                consumption = 9 + ShiftsLeft;
            }
            if(weight > 150)
            {
                consumption *= 1.35;
            }
            return consumption;
        }
    }
}
