using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibExt
{
    public static class TestExtMethods
    {

        public static string left(int decalage, string word)
        {
            if (decalage <= 0)
            {
                return "MORE THAN 0 PLS !";
            }
            else
            {
                return word.Substring(0, decalage);
            }
        }

        public static string right(int decalage, string word)
        {
            if (decalage <= 0)
            {
                return "MORE THAN 0 PLS !";
            }
            else
            {
                return word.Substring(word.Length - decalage);
            }
        }

        public static string ellipsis(int cut, string word)
        {
            var defaultStr = "Alpha Bravo";
            var data = defaultStr.Substring(0, cut);
            return data+word;
        }
        
        public static string fillLeft(string str, int size, char paddingChar = ' ')
        {
            if (str.Length > size)
            {
                return str.Substring(0, size);
            }
            else
            {
                return new string(paddingChar, size - str.Length) + str;
            }
        }
        
        public static string FillRight(string str, int size, char paddingChar = ' ')
        {
            if (str.Length > size)
            {
                return str.Substring(0, size);
            }
            else
            {
                return str + new string(paddingChar, size - str.Length);
            }
        }
        
    }
}
