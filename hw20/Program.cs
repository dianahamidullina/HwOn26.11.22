using hw20;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov10
{
     class Program
    {
        static void Main(string[] args)
        {
            //10.1
            Console.WriteLine("10.1");
            ICipher cipher;
            ACipher aCipher = new ACipher();
            cipher = aCipher; // ссылаемся на объект класса шифр
            Console.WriteLine("10.1");
            string stroka = "ABCDEFJ";
            string coded = cipher.encode(stroka);// метод зашифровывающий сроку
            Console.WriteLine($"Your cipher is {coded}");
            string incoded = cipher.decode(stroka); // метод расшифровывающий строку
            Console.WriteLine($"Deciper code is {incoded}");
            //10.1 Continue
            BCipher bCipher = new BCipher();
            cipher = bCipher;
            Console.WriteLine("10.1 Continue");
            string predl1 = "абвг";
            string coded2 = cipher.encode(predl1);
            Console.WriteLine($"Encoded predl is {coded2}");
            string incoded2 = cipher.decode(predl1);
            Console.WriteLine($"Decoded predl is {incoded2}");
            //10.1DZ
            Console.WriteLine("10.1dz");
            Circle circle = new Circle();
            circle.Square();
            circle.ColorChange();
            circle.MyCondition();
            circle.MoveX(4);
            circle.MoveY(4);
            circle.Print();
            Rectangle rectangle = new Rectangle();
            rectangle.Square();
            rectangle.ColorChange();
            rectangle.MyCondition();
            rectangle.MoveX(4);
            rectangle.MoveY(4);
            rectangle.Print();
            Point point = new Point();  
            point.Square();
            point.ColorChange();
            point.MyCondition();
            point.MoveX(4);
            point.MoveY(4);
            point.Print();
        }
    }
}
