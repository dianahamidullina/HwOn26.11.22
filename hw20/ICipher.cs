using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov10
{
    internal interface ICipher
    {
        string encode(string str);//метод зашифровки
        string decode(string str);//метод расшифровки
       
    }
}
