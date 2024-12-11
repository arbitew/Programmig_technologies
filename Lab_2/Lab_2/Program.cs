using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static double testik(double T, double A, double B, double C)
        {
            return A - B / (T + C);
        }
        static double vagner(double T, double a, double b, double c, double d, double T_c)
        {
            double T_r = T / T_c;
            double tau = Convert.ToDouble(1) - T_r;
            return (1 / T_r) * (a * tau + b * Math.Pow(tau, 1.5) + c * Math.Pow(tau, 2.5) + d * Math.Pow(tau, 5));
        }

        static void Main(string[] args)
        {
            //directory.getcurrentdirrectory
            string f = File.ReadAllText("D:\\РХТУ\\Studying\\Course 2\\semester 4\\Programming_technologies\\Lab_2\\Lab_2\\TextFile1.txt");
            double A = 14.9571;
            double B = 3231.225;
            double C = -98.138;
            double a = -11.806;
            double b = 12.0699;
            double c = -20.477;
            double d1 = 13.884;
            double T_c = 588.1;
            double P_c = 3897.0;//МПа    
            double test;
            int i, k = 4, s = 0, d = 0, j = 0;
            string subs;
            double[] mass = new double[f.Length];
            for (i = 4; i < f.Length; i++)
            {
                if (f[i] == 'P')
                {
                    s = i + 4;
                    i = i + 4;
                    d = 1;
                }
                if (d == 1)
                {
                    if ((f[i] == ' ') || (i == f.Length - 1))
                    {
                        subs = f.Substring(s, i - s);
                        mass[j] = Convert.ToDouble(f.Substring(s, i - s));
                        j++;
                        s = i + 1;
                    }
                }
            }
            j = 0;
            for (i = 4;i < f.Length; i++)
            {
                if ((f[i] == ' ') || (f[i] == 'P'))
                {
                    subs = f.Substring(k, i - k);
                    test = Convert.ToDouble(f.Substring(k, i - k));
                    Console.Write(Math.Exp(testik(Convert.ToDouble(f.Substring(k, i - k)), A, B, C)));
                    Console.Write(" ");
                    Console.Write(Math.Exp(vagner(Convert.ToDouble(f.Substring(k, i - k)), a, b, c, d1, T_c)) * P_c);
                    Console.Write(" "); 
                    Console.WriteLine(mass[j]);
                    j++;
                    k = i + 1;
                }
                if(f[i] == 'P')
                {
                       k = i + 2;
                    break;
                }
            }
            AssemblyName myAssemblyName = new AssemblyName();
            myAssemblyName.Name = "MyAssembly";
            myAssemblyName.Version = new Version("1.0.0.2023");
            Console.WriteLine(myAssemblyName.Version);
            string path = @"D:\РХТУ\Studying\Course 2\semester 4\Programming_technologies\Lab_2\Lab_2\Datachange.txt";
            File.SetLastWriteTime(path, DateTime.Now);
            File.WriteAllText(path, Convert.ToString(File.GetLastWriteTime(path)));
            /*try
            {
                string path = @"D:\РХТУ\Studying\Course 2\semester 4\Programming_technologies\Lab_2\Lab_2\Datachange.txt";
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                else
                {
                    // Take an action that will affect the write time.
                    File.SetLastWriteTime(path, new DateTime(2023, 02, 27));
                }

                // Get the creation time of a well-known directory.
                DateTime dt = File.GetLastWriteTime(path);
                Console.WriteLine("The last write time for this file was {0}.", dt);

                // Update the last write time.
                File.SetLastWriteTime(path, DateTime.Now);
                dt = File.GetLastWriteTime(path);
                Console.WriteLine("The last write time for this file was {0}.", dt);
            }

            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }*/
        }
    }
}
