using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ass
{
    class Sensor
    {
        double dVal;
        int sId;
        Random rSenVal;
        int maxSenRange = 1;

        public Sensor(int id)
        {
            sId = id;
            rSenVal = new Random(id);
            dVal = 0.0;
        }

        public double GetValue(bool digital)
        {
            if (digital == true)
            {
                dVal = rSenVal.Next(0, 2);
            }
            else
            {
                dVal = rSenVal.NextDouble()*maxSenRange;
            }
            return dVal;
        }

        public int GetSenId()
        {
            return sId;
        }
    }

}    