using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kgFirst.Second
{
    public class Function
    {
        public delegate double functionFromX(double x);
        public functionFromX func;
        private Dictionary<string, double> ratios = new Dictionary<string, double>();
        public Function(string function)
        {
            int firstPtr = 0;
            int secondPtr = 0;
            double outParam = 0;
            for (int i = 0; i < function.Length; i++)
            {
                if (function[i] == '+' || (function[i] == '-' && i != 0) || i == function.Length - 1)
                {
                    if (double.TryParse(function.Substring(firstPtr, Math.Abs(i - secondPtr + 1)), out outParam))
                    {
                        ratios["const"] = outParam;
                        firstPtr = i + 1;
                        secondPtr = i + 1;
                    }
                    else
                    {
                        if (function[i - 1] == 'x')
                        {
                            if (firstPtr != i - 1)
                            {
                                double.TryParse(function.Substring(firstPtr, Math.Abs(firstPtr - i) - 1), out outParam);
                                ratios["1"] = outParam;
                                firstPtr = i + 1;
                                secondPtr = i + 1;
                            }
                            else
                            {
                                ratios["1"] = 1;
                                firstPtr = i + 1;
                                secondPtr = i + 1;
                            }
                        }
                        else
                        {
                            string current = function.Substring(firstPtr, Math.Abs(firstPtr - (i))+1);
                            int powChar =current.IndexOf('^');
                            int len = 0;
                            if (i == function.Length - 1)
                            {
                                len = Math.Abs((powChar) - i);
                            }
                            else
                                len = Math.Abs((powChar) - i) - 1;
                            int pow = int.Parse(current.Substring(powChar + 1, len));
                            if (function[firstPtr + 1] == '^')
                            {
                                ratios[pow.ToString()] = 1;
                                firstPtr = i + 1;
                                secondPtr = i + 1;
                            }
                            else
                            {
                                string str = function.Substring(firstPtr, Math.Abs(firstPtr - powChar) - 1);
                                ratios[pow.ToString()] = double.Parse(str);
                                firstPtr = i + 1;
                                secondPtr = i + 1;
                            }

                        }
                    }
                }
            }
            func = new functionFromX(getValueFromFun);
        }

        public double getValueFromFun(double x)
        {
            double value = 0;
            foreach (var e in ratios.Keys)
            {
                if (e.Equals("const"))
                {
                    value += ratios[e];
                }
                else
                {
                    value += ratios[e] * (Math.Pow(x, int.Parse(e)));
                }
            }
            return value;
        }


    }
}
