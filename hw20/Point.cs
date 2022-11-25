using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hw20
{
    internal class Point :  Figure
    {
        
      
       public string Color { get; set; }
        public string Condition { get; set; }
        public override double Square()   
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
           int tochka = one* two;
          Console.WriteLine(tochka);
            return tochka;
        }
        public override void ColorChange()
        {
            Color = "Green";
        }
        public override void MyCondition()
        {
            Condition = "Видимое";
        }
        public override void Print()
        {
            Console.WriteLine($"Your figure has such parametres : \nthe movement is ({X} , {Y})\n  Color is {Color}\n  Condition is {Condition}\n");
        }
    }
}
