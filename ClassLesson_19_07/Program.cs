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
            int x = Convert.ToInt32(Cities[0].People);
            int xx = Convert.ToInt32(Cities[1].People);
            int xxx = Convert.ToInt32(Cities[2].People);

            if (x >= xx && x >= xxx)
            {
                Console.WriteLine("Most populated:" + Cities[0].NameCiti + "(" + Cities[0].People + ")");
            }
            else if (xx >= x && xx >= xxx)
            {
                Console.WriteLine("Most populated:" + Cities[1].NameCiti + "(" + Cities[1].People + ")");
            }
            else
            {
                Console.WriteLine("Most populated:" + Cities[2].NameCiti + "(" + Cities[2].People + ")");
            }

            int q = Cities[0].NameCiti.Length;
            int qq = Cities[1].NameCiti.Length;
            int qqq = Cities[2].NameCiti.Length;
            if (q >= qq && q >= qqq)
            {
                Console.WriteLine("Longest name:" + Cities[0].NameCiti + "(" + q + "letters)");
            }
            else if (qq >= q && qq >= qqq)
            {
                Console.WriteLine("Longest name:" + Cities[0].NameCiti + "(" + qq + "letters)");
            }
            else
            {
                Console.WriteLine("Longest name:" + Cities[0].NameCiti + "(" + qqq + "letters)");
            }
            int w= Convert.ToInt32(Cities[0].S);
            int ww = Convert.ToInt32(Cities[1].S);
            int www = Convert.ToInt32(Cities[2].S);
            double t = q / w;
            double tt = qq / ww;
            double ttt = qqq / www;

            Console.WriteLine("Density:");
            Console.WriteLine("       "+ Cities[0].NameCiti+"-"+t);
            Console.WriteLine("       " + Cities[1].NameCiti + "-" + tt);
            Console.WriteLine("       " + Cities[1].NameCiti + "-" + ttt);


            Console.ReadKey();
        }
    }
}
