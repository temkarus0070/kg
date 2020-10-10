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
            getFun(function);
            func = new functionFromX(getValueFromFun);
        }

        public void getFun(string function)
        {
            int parseNum = 0;
            int len = 0;
            int leftPtr = 0;
            for (int i = 0; i < function.Length; i++)
            {

                if ((i != 0 && ((function[i] == '+' || function[i] == '-')|| ( i==function.Length-1) )))
                {
                    getFun(function, ref leftPtr, i);
                }
            }
        }

        public void getFun(string function,ref int leftPtr,int index)
        {
            int len = index - leftPtr+1;
            
            if(function.Substring(leftPtr,len).Contains("x"))
            {
                getXPow(function, ref leftPtr, index);
            }
            else
            {
                int num = 0;
                getNum(function,ref leftPtr,index,out num);
                ratios["const"] = num;
            }
        }

        public void getXPow(string function,ref int leftPtr,int index)
        {
            int len = index - leftPtr + 1;
            if(function.Substring(leftPtr,len).Contains("^"))
            {
                int powNum = function.Substring(leftPtr, len).IndexOf("^");
                int powNum1 = powNum;
                int pow = 0;
                getNum(function, ref powNum1, index, out pow);
                int ratio = 0;
                getNum(function, ref leftPtr,Math.Abs( powNum -leftPtr-1), out ratio);
                if(ratio==0)
                {
                    if(function[leftPtr]=='x')
                        ratios[pow.ToString()] = 1;
                    if(function[leftPtr]=='-')
                        ratios[pow.ToString()] = -1;
                    if (function[leftPtr] == '+')
                        ratios[pow.ToString()] = 1;
                }
                else
                    ratios[pow.ToString()] = ratio;
            }
            else
            {
                int num=0;
                getNum(function, ref leftPtr, index - 1, out num);
                ratios["1"] = num;
            }
            leftPtr = index;
        }



        public void getNum(string function,ref int leftPtr,int index,out int num)
        {
            num = 0;
            int len = index - leftPtr+1;
            if (len == 0)
                len = 1;
            if (len < 0)
                return;
            if (function.Substring(leftPtr, len).Contains("x"))
            {
                getNum(function, ref leftPtr, index-1, out num);
            }
            if (num != 0)
                return;
            if (index>=0 && (function[index] == '-' || function[index] == '+'))
                len--;
            if (int.TryParse(function.Substring(leftPtr, len), out num))
            {
                leftPtr = index;
                return;
            }
            if (len == 0)
                len = 1;
            if (int.TryParse(function.Substring(leftPtr + 1, len - 1), out num))
            {
                leftPtr = index;
                return;
            }
            

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
