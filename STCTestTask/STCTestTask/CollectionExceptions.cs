using System;
using System.Collections.Generic;
using System.Linq;

namespace STCTestTask
{
    internal sealed class CollectionExceptions
    {

        public static IEnumerable<string> Encrypt(IEnumerable<string> source, string key)
        {
            key = key.ToUpper();
            string source2 = "";
            int j = 0;

            foreach (string item in source)
            {
                source2 += item;
                j++;
            }

            if (source2.Length != key.Length)
            {
                int length = key.Length;
                for (int i = 0; i <= source2.Length - length; i++)
                {
                    key = string.Concat(key.Append(key[i]));
                }
            }
            return string.Join(" ",source2.ToCharArray().Where(char.IsLetter)
                                           .Select((x, i) => x.ToString() == x.ToString().ToLower() ?
                                           Convert.ToChar((x + key.ToLower().ToCharArray()[i] - 'a' * 2) % 26 + 'a') :
                                           Convert.ToChar((x + key.ToUpper().ToCharArray()[i] - 'A' * 2) % 26 + 'A'))).Split(' ');
            
        }


        public static IEnumerable<string> Dencrypt(IEnumerable<string> encrypted, string key)
        {
            key = key.ToUpper();
            key = string.Concat(key.ToCharArray()
                                   .Select(x => x.ToString() == x.ToString().ToLower() ?
                                   Convert.ToChar('z' - (x - 'a' - 1)) :
                                   Convert.ToChar('Z' - (x - 'A' - 1))));
            return Encrypt(encrypted, key);
        }
    }
}
