﻿namespace Tyuiu.FilinovIA.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        //пример линейной структуры
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        //пример линейной структуры
        public static int Substraction(int a, int b)
        {
            return a - b;
        }
        //пример линейной структуры
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        //пример линейной структуры
        public static int Division(int a, int b)
        {
            if (b == 0) {
                Console.WriteLine("Переменная b = {0} на ноль делить нельзя", b);
                return -1;
            } else {
                return a / b;
            }
        }
    }
}
