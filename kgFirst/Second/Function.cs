using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kgFirst.Second
{
    class Function
    {
        private Dictionary<string, double> ratios = new Dictionary<string, double>();
        public Function(string function)
        {
            int firstPtr = 0;
            int secondPtr = 0;
            double outParam = 0;
            for(int i=0;i<function.Length;i++)
            {
                if (function[i] == '+' || (function[i]=='-' && i!=0) || i==function.Length-1 )
                {
                    if(double.TryParse(function.Substring(firstPtr, Math.Abs(i-secondPtr+1)),out outParam))
                    {
                        ratios["const"] = outParam;
                        firstPtr = i + 1;
                        secondPtr = i + 1;
                    }
                    else
                    {
                        if(function[i-1] == 'x')
                        {
                            if (firstPtr != i-1 ) {
                                double.TryParse(function.Substring(firstPtr, Math.Abs(firstPtr-i ) - 1),out outParam);
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
                            int powChar = function.Substring(firstPtr, Math.Abs(firstPtr-(i - 1))).IndexOf('^');
                            int pow = int.Parse(function.Substring(powChar + 1, Math.Abs((powChar+1) - i)));
                            if(function[firstPtr+1]=='^')
                            {
                                ratios[pow.ToString()] = 1;
                                firstPtr = i + 1;
                                secondPtr = i + 1;
                            }
                            else
                            {
                                string str = function.Substring(firstPtr, Math.Abs(firstPtr  - powChar )-1);
                                ratios[pow.ToString()] = double.Parse(str);
                                firstPtr = i + 1;
                                secondPtr = i + 1;
                            }

                        }
                    }
                }
            }
        }

    }
}
