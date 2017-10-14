using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请选择你想要的运算: 1.加法  2.减法  3.乘法  4.除法");
            int i =int.Parse(Console.ReadLine());
            string str;
            Console.WriteLine("请输入你的两个操作数，用空格间隔");
            str = Console.ReadLine();
            string[] array=str.Split(' ');
            Calculator cal = new Calculator();
            switch (i)
            {
                case 1: Console.WriteLine("你是希望进行字符串运算还是数字运算？ 1.字符串  2.数字");
                    int j=int.Parse(Console.ReadLine());
                    if (j == 1)
                    {
                        Console.WriteLine("结果为：" + cal.Jia(array[0] , array[1]));
                    }else if(j==2)
                    {
                        Console.WriteLine("结果为:" + cal.Jia(double.Parse(array[0]) , double.Parse(array[1])));
                    }
                    break;

                case 2: Console.WriteLine("你是希望进行字符串运算还是数字运算？ 1.字符串  2.数字");
                     j = int.Parse(Console.ReadLine());
                    if (j == 1)
                    {
                        Console.WriteLine("结果为：" + cal.Jian(array[0], array[1]));
                    }
                    else if (j == 2)
                    {
                        Console.WriteLine("结果为:" + cal.Jian(double.Parse(array[0]), double.Parse(array[1])));
                    }
                    break;
                case 3: Console.WriteLine("结果为:" + cal.Cheng(double.Parse(array[0]) , double.Parse(array[1]))); break;
                case 4:
                    try
                    {
                        Console.WriteLine("结果为:" + cal.Chu(double.Parse(array[0]), double.Parse(array[1]))); break;
                    }catch(DivideByZeroException e)
                    {
                        Console.WriteLine("除数不能为零"); break;
                    }
            }


        }
    }
    public class Calculator
    {
        public string Jia(string a, string b)
        {

            return a + b;
        }
        public string Jian(string a, string b)
        {

            return a.Replace(b, "");
        }
        public double Jia(double a, double b)
        {
            return a + b;
        }
        public double Jian(double a, double b)
        {
            return a - b;
        }
        public double Cheng(double a, double b)
        {
            return a * b;

        }
        public double Chu(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a/b;
        }
    }
}
