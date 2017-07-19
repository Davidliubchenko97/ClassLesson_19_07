using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson_19_07
{
    public struct Citi
    {
        public string NameCiti;
        public string People;
        public string S;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i,j=0;
            int k = -1;
            string name = Convert.ToString(Console.ReadLine());
            Citi[] Cities = new Citi[3];
            for (int l = 0; l < 3; l++)
            {
                for (i = k+1; i < name.Length; i++)

                {
                    if (name[i] != '=')
                        Cities[l].NameCiti += name[i];
                    else if (name[i] == '=')
                    {
                        break;
                    }
                }
                for (j = i + 1; j < name.Length; j++)

                {
                    if (name[j] != ',')
                        Cities[l].People += name[j];
                    else if (name[j] == ',')
                    {
                        break;
                    }
                }
                for (k = j + 1; k < name.Length; k++)

                {
                    if (name[k] != ';')
                        Cities[l].S += name[k];
                    else if (name[k] == ';')
                    {
                        break;
                    }
                }
                //Console.WriteLine(Cities[l].NameCiti + "(" + Cities[l].People + ")" + Cities[l].S);
            }
            decimal x = decimal.Parse(Cities[0].People);
            decimal xx = decimal.Parse(Cities[1].People);
            decimal xxx = decimal.Parse(Cities[2].People);

            if (x >= xx && x >= xxx)
            {
                Console.WriteLine("Most populated:" + Cities[0].NameCiti + "(" + Cities[0].People + " people)");
            }
            else if (xx >= x && xx >= xxx)
            {
                Console.WriteLine("Most populated:" + Cities[1].NameCiti + "(" + Cities[1].People + " people)");
            }
            else
            {
                Console.WriteLine("Most populated:" + Cities[2].NameCiti + "(" + Cities[2].People + " people)");
            }

            int q = Cities[0].NameCiti.Length;
            int qq = Cities[1].NameCiti.Length;
            int qqq = Cities[2].NameCiti.Length;
            if (q >= qq && q >= qqq)
            {
                Console.WriteLine("Longest name:" + Cities[0].NameCiti + "(" + q + " letters)");
            }
            else if (qq >= q && qq >= qqq)
            {
                Console.WriteLine("Longest name:" + Cities[0].NameCiti + "(" + qq + " letters)");
            }
            else
            {
                Console.WriteLine("Longest name:" + Cities[0].NameCiti + "(" + qqq + " letters)");
            }
            decimal w = decimal.Parse(Cities[0].S);
            decimal ww = decimal.Parse(Cities[1].S);
            decimal www = decimal.Parse(Cities[2].S);
            
            
            
            decimal t = (x/w);
            decimal tt = (xx/ww);
            decimal ttt = (xxx/www);
            //Kharkiv=1431000,350;Kiev=2804000,839;Las Vegas=603400,352
            
            Console.WriteLine("Density:");
            Console.WriteLine("       "+ Cities[0].NameCiti+"-"+ "{0:0.00}", t); 
            Console.WriteLine("       " + Cities[1].NameCiti + "-"+ "{0:0.00}", tt); 
            Console.WriteLine("       " + Cities[2].NameCiti + "-"+ "{0:0.00}", ttt);
            Console.ReadKey();
        }
    }
}
