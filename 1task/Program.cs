using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _1task
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            Int32.TryParse(Console.ReadLine(), out length);
            //StringBuilder strfinal = new StringBuilder(length);
            String str="";
            string t="";
            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0) str += 'B';
                else str += 'R';
                t+='*';
            }
            Console.WriteLine(str);            
            Console.Read();
            StringBuilder strfinal = new StringBuilder(t);
            //StringBuilder strfinal = new StringBuilder(str);
            int k = 1;
            int temp = 0;
            while (str.Length>0)//k<strfinal.Length/2
            {
                if (str.Length==temp||temp==0||str.Length==1)
                {
                    temp = 0;
                    if (k<=length &&((k==1&& strfinal[length-1] != '*') || (k!=1&&strfinal[length-k/2] != '*')))////k-1
                    {
                        for (int i = k - 1+2*k; i < strfinal.Length; i += 2 * k)
                        {
                            if (strfinal[i] == '*')
                            {
                                strfinal[i] = str[0];
                                str = str.Substring(1);
                                temp++;
                            }
                        }
                        if (str.Length==1 &&k<length && strfinal[k - 1] == '*')
                        {
                            strfinal[k - 1] = str[0];
                            str = str.Substring(1);
                            temp++;
                            // k *= 2;
                        }
                        
                    }
                    else if (k <= length)
                    {
                        for (int i = k - 1; i < strfinal.Length; i += 2 * k)
                        {
                            if (strfinal[i] == '*')
                            {
                                strfinal[i] = str[0];
                                str = str.Substring(1);
                                temp++;
                            }
                        }
                    }
                    k *= 2;
                }
                else
                {
                    temp = 0;
                    for (int i = 2*k-1; i < strfinal.Length; i += 2*k)
                    {
                        if (strfinal[i] == '*')
                        {
                            strfinal[i] = str[0];
                            str = str.Substring(1);
                            temp++;
                        }
                    }
                    if (temp<str.Length && strfinal[k-1] == '*')
                    {
                        strfinal[k-1] = str[0];
                        str = str.Substring(1);
                        temp++;
                       // k *= 2;
                    }
                }
            }
            Console.WriteLine(strfinal);
            Console.ReadLine();
            Console.Read();
            int iter = 0;
            string katar = "";
            while (iter < strfinal.Length)
            {
                if (iter % 2 == 0)
                    katar += strfinal[iter];
                else strfinal.Append(strfinal[iter]);
                iter++;
            }
            Console.WriteLine(katar);
            Console.ReadKey();
            Console.ReadLine();
            Console.Read();
        }
    }
}
