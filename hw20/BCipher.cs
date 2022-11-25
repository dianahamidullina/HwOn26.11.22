using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace tumakov10
{
    internal class BCipher : ICipher//10.1
    {
       
        public string encode(string str)
        {
            int nomer; // Номер в алфавите
            int d; // Смещение
            string s; //Результат
            int j; // Переменная для циклов
            

            // Превращаем строку в массив символов.
           
            char[] razbor = str.ToCharArray();
            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            // Перебираем каждый символ сообщения
            for (int i = 0; i < razbor.Length; i++)
            {
                // Ищем индекс буквы
                for (j = 0; j < alfavit.Length; j++)
                {
                    if ((char)razbor[i] == alfavit[j])
                    {
                        break;
                    }
                }


                if (j != 33) // Если j равно 33, значит символ не из алфавита
                {
                    nomer = j; // Индекс буквы
                    d = nomer +29; // Делаем смещение

                    // Проверяем, чтобы не вышли за пределы алфавита
                    if (d > 32)
                    {
                        d = d - 33;
                    }

                    razbor[i] = alfavit[d]; // Меняем букву
                }
            }
       

            s = new string(razbor); // Собираем символы обратно в строку.
            return s;   

        }
        public string decode(string str)
        {
            char[] razbor2 = str.ToCharArray();
            char[] alfavit2 = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            int nomer2;
            int d2;
            string t;
            int l;
            int k;
            for(k  = 0;  k< razbor2.Length; k++)
            {
                for( l = 0; l< alfavit2.Length; l++)
                {
                    if ((char)razbor2[k] == alfavit2[l])
                    {
                        break;
                    }
                }
                if( l!=33)
                {
                    nomer2 = l;
                    d2= nomer2 - 29;
                }
                razbor2[k] = alfavit2[l];
            }
            t = new string(razbor2);
            return t;
        }
      
    
    }

}

