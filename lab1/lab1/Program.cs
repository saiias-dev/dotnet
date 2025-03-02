//using System;
//using System.Reflection.Metadata.Ecma335;

//namespace dotnet
//{
//    class Program
//    {
//        static int Main(string[] args)
//        {
//            //Console.WriteLine("Лабораторная работа №1");

//            //Lab1 task1 = new Lab1();
//            //double x = task1.M1(a, b);

//            //Console.Write("n = ");
//            //double n = Convert.ToDouble(Console.ReadLine());

//            //Console.Write("m = ");
//            //double m = Convert.ToDouble(Console.ReadLine());

//            //Lab1 task2 = new Lab1();
//            //Console.WriteLine(task2.M2(n, m));

//            //Lab1 task3 = new Lab1();
//            //task3.M3();

//            //Lab1 task4 = new Lab1();
//            //task4.M4();

//            //Lab1 task5 = new Lab1();
//            //task5.M5();

//            //Lab1 task6 = new Lab1();
//            //task6.M6();

//            //Lab1 task7 = new Lab1();
//            //task7.M7();

//            //Lab1 task8 = new Lab1();
//            //task8.M8();

            

//            Console.WriteLine("Лабораторная работа №2");
//            Console.WriteLine("Ваша машина? ");
//            Console.WriteLine("1. Toyota     2. Ferrari    3.Bugatti");
//            int name = Convert.ToInt32(Console.ReadLine());
//            Car _car;
//            switch (name)
//            {
//                case 1:
//                    Console.WriteLine("Вы выбрали Toyota");
//                    _car = new Toyota();
//                    break;
//                case 2:
//                    Console.WriteLine("Вы выбрали Ferrari");
//                    _car = new Ferrari();
//                    break;
//                case 3:
//                    Console.WriteLine("Вы выбрали Bugatti");
//                    _car = new Bugatti();
//                    break;
//                default:
//                    Console.WriteLine("Неизвестная машина");
//                    return 0;
//                    break;
//            }
//            int choose = 1;
//            while(choose != 0)
//            {
//                Console.WriteLine("1. Запустить машину    2. Ускориться    3. Замедлиться    4.Остановить машину    5.Включить радио    6. Выключить радио    0. Выключить программу");
//                choose = Convert.ToInt32(Console.ReadLine());
//                switch (choose)
//                {
//                    case 0:
//                        choose = 0;
//                        break;
//                    case 1:
//                        _car.Start();
//                        break;
//                    case 2:
//                        _car.Speedup();
//                        break;
//                    case 3:
//                        _car.Speeddown();
//                        break;
//                    case 4:
//                        _car.Stop();
//                        break;
//                    case 5:
//                        _car.RadioOn();
//                        break;
//                    case 6:
//                        _car.RadiOff();
//                        break;
//                    default :
//                        break;
//                }
//            }
//            return 0;
//        }
        

        
//}

//}


