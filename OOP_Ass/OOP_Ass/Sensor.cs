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

        public Sensor(int id)
        {
            sId = id;
            rSenVal = new Random(id);
            dVal = 0.0F;
        }

        public double GetValue()
        {
            dVal += rSenVal.NextDouble();
            return dVal;
        }

        public int GetSenId()
        {
            return sId;
        }
    }

}    