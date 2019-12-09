using System;
using System.Collections.Generic;

namespace sdfgbx
{
    class Program
    {
      
        static void Main()
        {
            Console.WriteLine("Введите число");
            double first;
             
           first = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int second;
            
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите действие \n" +
                 "1 - сложение \n" +
                 "2 - вычетание \n" +
                 "3 - умножение \n" +
                 "4 - деление \n");
            double m = first + second, u = first * second, d = first/second;
            
           int Y;
           Y = Convert.ToInt32(Console.ReadLine());

            switch (Y)
            {
                case 1:
                    {

                        Console.WriteLine("Результат = " + first + second);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Результат = " + m );
                        break;
                    }
                    
                        case 3:
                    { 
                        Console.WriteLine("Результат = " + u);
                        break;
                    }
                case 4:
                    {
                        
                            Console.WriteLine("Результат = " + d);
                            break;
                        
                    }
            }



        }
    }
}
