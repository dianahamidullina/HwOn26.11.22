using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw20
{
     class Circle : Point
    {

        public int r;//radious
      
        public override double Square()// вычисляет площадь окружности
        {
            Console.WriteLine("Enter radious of circle:");
            r = int.Parse(Console.ReadLine());
            double plosh = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Square of Circle is {plosh}");
            return plosh;
        }
        public override void ColorChange()
        {
            Color = "Blue";
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
