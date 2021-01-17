using System;
using System.Linq;

namespace STCTestTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("source - ThisIsA&%#^-Test");
            Console.WriteLine("key - abcdefh");
            Console.WriteLine("result of Encrypting - " + Encrypt("ThisIsA&%#^-Test", "abcdefh"));
            Console.WriteLine("result of Decrypting - " + Dencrypt(Encrypt("ThisIsATest", "abcdefh"), "abcdefh"));

            string[] word = new string[] { "This", "Is", "A&%#^-", "Test" };
            string answer = "";
            foreach (string item in CollectionExceptions.Encrypt(word, "abcdefh"))
            {
                answer += item;
            }
            Console.WriteLine("result of Encrypting of IEnumerable - " + answer);

            string answer2 = "";
            foreach (string item in CollectionExceptions.Dencrypt(CollectionExceptions.Encrypt(word, "abcdefh"), "abcdefh"))
            {
                answer2 += item;
            }
            Console.WriteLine("result of Decrypting of IEnumerable - " + answer2);
            Console.ReadLine();
        }


        public static string Encrypt(string source, string key)
        {
            key = key.ToUpper();
            if(source.Length != key.Length)
            {
                int length = key.Length;
                for (int i = 0; i <= source.Length -length; i++)
                {
                    key = string.Concat(key.Append(key[i]));
                }
            }
            return string.Concat(source.ToCharArray().Where(char.IsLetter)
                                       .Select((x,i) => x.ToString() == x.ToString().ToLower()?
                                       Convert.ToChar((x + key.ToLower().ToCharArray()[i] - 'a' * 2) % 26 + 'a'):
                                       Convert.ToChar((x + key.ToUpper().ToCharArray()[i] - 'A' * 2) % 26 + 'A')));
        }


        public static string Dencrypt(string encrypted, string key)
        {
            key = key.ToUpper();
            key = string.Concat(key.ToCharArray()
                                   .Select(x => x.ToString() == x.ToString().ToLower()?
                                   Convert.ToChar('z' - (x - 'a' - 1)):
                                   Convert.ToChar('Z' - (x - 'A' - 1))));
            return Encrypt(encrypted, key);
        }
    }
}
