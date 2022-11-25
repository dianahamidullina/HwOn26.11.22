using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw20
{
    internal class Rectangle : Point
    {
        int width;
        int higth;
       
        public override double Square()//вычисляет площадь прямоугольника
        {
            Console.WriteLine("Enter weigth:");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter higth:");
            higth = int.Parse(Console.ReadLine());
            double plosh2 = width * higth;
            Console.WriteLine($"The Square of rectangle is {plosh2}");
            return plosh2;
          
        }
        public override void ColorChange()
        {
            Color = "Red";
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
