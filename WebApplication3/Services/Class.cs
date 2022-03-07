using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication3.Services
{
    public class Realization : IPresentation
    {
        Random rand = new Random();
        public double Number1;
        public double Number2;
        
   
        public Realization()
        {
            Number1 = rand.Next(0, 10);
            Number2 = rand.Next(0, 10);

        }
        public string Add()
        {
            return "" + Number1 + " + " + Number2 + " = " + (Number1 + Number2);
        }
        public string Subtract()
        {
            return ""+Number1 +" - "+ Number2+" = "+(Number1-Number2);
        }
        public string Multiply()
        {
            return "" + Number1 + " * " + Number2 + " = " + (Number1 * Number2);
        }
        public string Divide()
        {
            if (Number2 != 0)
                return "" + Number1 + " / " + Number2 + " = " + (Number1 / Number2);
            else
                return "" + Number1 + " / " + Number2 + " = " + "Error: DIVISION BY ZERO";
        }


    }
}
