using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "MCMXCIV";
            Console.WriteLine(RomanToInt(str));
            Console.ReadKey();
        }
        public static int RomanToInt(string s)
        {
            var res = 0;
            var hashMap = new Dictionary<char, int>();
            hashMap.Add('I',1);
            hashMap.Add('V',5);
            hashMap.Add('X',10);
            hashMap.Add('L',50);
            hashMap.Add('C',100);
            hashMap.Add('D',500);
            hashMap.Add('M', 1000);

            for (var i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    res += hashMap[s[i]];
                    continue;
                }
                if(hashMap[s[i-1]] >= hashMap[s[i]])
                {
                    res += hashMap[s[i]];
                }
                else
                {
                    res = res + hashMap[s[i]] - (2 * hashMap[s[i - 1]]);
                }
            }

            return res;

        }

    }

}
