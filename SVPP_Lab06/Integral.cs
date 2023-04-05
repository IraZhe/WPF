using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Lab006
{
    public class Integral:IDataErrorInfo
    {
        double a, b;
        int n;
        public Func<double, double> f = (x) => Math.Pow(x,3);

        public Integral(double a, double b, int n)
        {
            A = a;
            B = b;
            N = n;
        }

        public Integral()
        {
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public int N { get => n; set => n = value; }

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get 
            {
                string error = String.Empty;
                switch(columnName)
                {
                    case "A":
                        if(A < -1 || A > 1)
                        {
                            error = "Начало диапазона должно быть [-1;1]";
                        }
                        break;
                    case "B":
                        if (B < 0 || B > 10)
                        {
                            error = "Конец диапазона должен быть [0;10]";
                        }
                        break;
                    case "N":
                        if (N < 100)
                        {
                            error = "К-во точек разбиения должно быть >= 100";
                        }
                        break;
                }
                return error;
            }
        }

        public async IAsyncEnumerable<(double,double,double)> GetDoublesAsync()
        {
            double h = (B - A) / N;
            double s = 0;
            for (int i = 0; i <= n; i++)
            {
                double x = A + h * i;
                s += f(x) * h;
                await Task.Delay(100);
                yield return (x,s,(double)i/N); 
            }
        }


        public override string? ToString()
        {
            return $"A = {A}, B = {B}, N = {N}";
        }
    }
}
