using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191113E
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ora eleje

            //int x = 10;
            //float f = 10F;
            //double d = 12.5;
            //char c = 'a';
            //bool b = false;

            //string s = Console.ReadLine();

            //Console.WriteLine(s[3]);

            //char[] ct = new char[s.Length];

            //for (int i = 0; i < s.Length; i++)
            //{
            //    ct[i] = s[i];
            //}

            //int ujBnetu = (int)ct[0] - 32;
            //ct[0] = (char)ujBnetu;

            //string ujString = "";

            //for (int i = 0; i < ct.Length; i++)
            //{
            //    ujString += ct[i];
            //}

            //Console.WriteLine(ujString);


            ////-------------------

            //string s = "juhasz.zoltan.mate";

            //string s2 = s.ToUpper();

            //Console.WriteLine(s2);
            //Console.WriteLine(s);


            //if (s[2] == 'C') Console.WriteLine("IGEN");
            //else Console.WriteLine("NEM");
            //Console.WriteLine($"A szó {s.Length} karakter");

            //string s3 = s.Replace("juhasz", "ash");

            //Console.WriteLine(s3);

            //if(s.Contains("kiwi"))
            //{
            //    Console.WriteLine("van");
            //}
            //else Console.WriteLine("nincs");

            //string s4 = "RaNDoM ShIt";

            //Console.WriteLine(s4.ToLower());

            //string s5 = s.Remove(6, 7);
            //Console.WriteLine(s5);

            //string s6 = s.Insert(7, "esernyő.");
            //Console.WriteLine(s6);


            //string s7 = s.Substring(7, 6);
            //Console.WriteLine(s7);

            //Console.WriteLine(s.IndexOf("zoltan"));

            //Console.WriteLine(s.Remove(s.IndexOf("zoltan"), "zoltan".Length));

            //Console.WriteLine(s.Replace("zoltan", ""));

            //string em = "juhaszz@verebelyszki.hu";

            //string[] t = em.Split('@', '.');


            //string sor = "juhasz;zoltan;30;fiu;0";

            //Console.WriteLine($"un: {t[0]}");
            //Console.WriteLine($"dom: {t[1]}");
            //Console.WriteLine($"c: {t[2]}");

            //string jov = "---julius_havi_munkaido_elszamolo_lap.pdf---";

            //string s8 = jov.Trim('-');
            //Console.WriteLine(s8);

            //string s9 = String.Join("-", "juhasz", "zoltan", "mate");

            //Console.WriteLine(s9);

            //if (jov.Trim('-').EndsWith(".pdf")) Console.WriteLine("igen");

            //char[] tomb = s9.ToCharArray();

            #endregion

            Console.Write("neved: ");
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++)
            {
                Console.Write($"{s[i]} ");
            }

            Console.ReadKey();
        }
    }
}
