using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num1 = 0;
            int num2 = 0;
            int calculator_type = 0;
            float result = 0;
            string op = "";
            int sum = 0;
            int cnt = 0;//用来统计题目个数
            Console.Write("要打印的题目的数量：");
            sum = int.Parse(Console.ReadLine());
            while (true)
            {
                num1 = random.Next() % 100;
                num2 = random.Next() % 100;
                calculator_type = random.Next() % 4;
                switch (calculator_type)
                {
                    //随机生成符号
                    case 0:
                        op = "+";
                        result = num1 + num2;
                        break;
                    case 1:
                        op = "-";
                        result = num1 - num2;
                        break;
                    case 2:
                        op = "×";
                        result = num1 * num2;
                        break;
                    case 3:
                        op = "÷";
                        result = (float)num1 / num2;
                        result = (float)Math.Round(result, 2);//保留两位小数
                        break;
                }
                if (op == "-" && result < 0)
                    continue;
                Console.WriteLine(num1 + op + num2 + "=" + result);
                //输出题目
                cnt++;//题目数加1
                if (cnt == sum)//达到想要的题目数量时退出循环 
                    break;
            }
            Console.ReadKey();
        }
    }
}
