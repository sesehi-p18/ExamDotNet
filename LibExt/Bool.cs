using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibExt
{
    public static class Bool
    {

        public static int BoolToInt(this bool value)
        {
            if (value == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static string SnakeCase(this string input, string separator = "_")
        {
            return string.IsNullOrWhiteSpace(input) 
                ? string.Empty 
                : string.Join(separator, input.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries));
        }
        
        public static string CustomTrim(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            string trimmed = input.Trim();
            string[] words = trimmed.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return string.Join(" ", words);
        }
        
    }
}
