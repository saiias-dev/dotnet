using System.Runtime.Intrinsics;

namespace dotnet
{
    public class Lab1
    { 
        public void M1()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if(a == 0)
            {
                Console.WriteLine("Ошибка");
            }
            else { double x = -b / a;
                Console.WriteLine(x);
            }
            
            
        }

        public double M2(double n, double m)
        {
            if (n > m)
            {
                return n;
            }
            else
            {
                return m;
            }
            
        }
        public void M3()
        {
            int k = Convert.ToInt32(Console.ReadLine());

            if (k >= 5 && k <= 20) { Console.WriteLine("Мы нашли " + k + " грибов"); }
            else
            {
                int p = k % 10;
                if (p == 1) { Console.WriteLine("Мы нашли " + k + " гриб в лесу"); }
                if (p >= 2 && p <= 4) { Console.WriteLine("Мы нашли " + k + " гриба в лесу"); }
                if (p >= 5 && p <= 9 || p == 0) { Console.WriteLine("Мы нашли " + k + " грибов в лесу"); }
            }

        }

        public void M4()
        {
            Console.Write("Площадь круга S1 = ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Площадь квадрата S2 = ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            double d = (2 * Math.Sqrt(s1)) / 3.14;
            double a = Math.Sqrt(s2);
            double diag = Math.Sqrt(2*s2);

            if (diag < a) { Console.WriteLine("Квадрат поместится в круг"); }
            else { Console.WriteLine("Квадрат не поместится в круг"); }
            if (a > d) { Console.WriteLine("Круг поместится в квадрате"); }
            else { Console.WriteLine("Круг не поместится в квадрат"); }
        }

        public void M5()
        {
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("v1 = " + v1 + "км/ч");

            int v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("v2 = " + v2 + "м/с");

            double converted = (v1 * 1000) / 3600;

            if (converted < v2) { Console.WriteLine("Скорость v2 больше"); }
            else { Console.WriteLine("Скорость v1 больше"); }
            
        }

        public int Month { get; }

        public void M6()
        {
            System.DateTime moment = System.DateTime.Now;
            int year = moment.Year;
            int month = moment.Month;
            Console.WriteLine(month + " " + year);
            
            Console.WriteLine("Впишите месяц и год Вашего рождения: ");
            int monthofbirth = Convert.ToInt32(Console.ReadLine());
            int yearofbirth = Convert.ToInt32(Console.ReadLine());
            
            int ageafter = year - (yearofbirth + 1);
            int age = year - yearofbirth;

            if (monthofbirth > month) { Console.WriteLine(ageafter);  }
            else { Console.WriteLine(age);  }
        }

        public void M7()
        {
            Console.WriteLine("Впишите Вашу фамилию: ");
            string surname = Console.ReadLine();
            
            char[] bysymbols = surname.ToCharArray();
            if (surname.EndsWith("ов"))
            {
                Console.WriteLine("Здравствуйте, господин " + surname + '!');
            }
            else if (surname.EndsWith("ова"))
            {
                Console.WriteLine("Здравствуйте, госпожа " + surname + '!');
            }
            else
            {
                Console.WriteLine("Здравствуйте, господин(госпожа) " + surname + '!');
            }          
        }

        public void M8()
        {
            Console.Write("Какой сегодня день недели? ");
            string day = Console.ReadLine();
            Console.Write("Какая неделя? ");
            string star = Console.ReadLine();
            if (star == "*")
            {
                if (day == "понедельник" || day == "пн")
                {
                    Console.WriteLine("09:50 Программирование на платформе .NET");
                    Console.WriteLine("11:40 Вычислительные методы");
                    Console.WriteLine("14:00 Социология");
                    Console.WriteLine("15:50 Социология");
                }
                if (day == "вторник" || day == "вт")
                {
                    Console.WriteLine("СРС день");

                }
                if (day == "среда" || day == "ср")
                {
                    Console.WriteLine("08:00 Элективные дисциплины по физической культуре и спорту");
                    Console.WriteLine("09:50 Программная инженерия");
                    Console.WriteLine("11:40 Проектная деятельность");
                }
                if (day == "четверг" || day == "чт")
                {
                    Console.WriteLine("14:00 Программная инженерия");
                    Console.WriteLine("15:50 Языки программирования и методы трансляции");
                }
                if (day == "пятница" || day == "пт")
                {
                    Console.WriteLine("09:50 ДВ4. Технологии сети Интернет");
                    Console.WriteLine("14:00 Программирование на платформе .NET");
                }
                if (day == "суббота" || day == "сб")
                {
                    Console.WriteLine("08:00 Элективные дисциплины по физической культуре и спорту");
                }
            }

            if (star == "**")
            {
                if (day == "понедельник" || day == "пн")
                {
                    Console.WriteLine("09:50 Программирование на платформе .NET");
                    Console.WriteLine("11:40 Вычислительные методы");
                    Console.WriteLine("14:00 Вычислительные методы");
                }
                if (day == "вторник" || day == "вт")
                {
                    Console.WriteLine("СРС день");

                }
                if (day == "среда" || day == "ср")
                {
                    Console.WriteLine("08:00 Элективные дисциплины по физической культуре и спорту");
                    Console.WriteLine("09:50 Программная инженерия");
                    Console.WriteLine("11:40 Проектная деятельность");
                }
                if (day == "четверг" || day == "чт")
                {
                    Console.WriteLine("11:40 Программная инженерия");
                    Console.WriteLine("14:00 Языки программирования и методы трансляции");
                    Console.WriteLine("15:50 Языки программирования и методы трансляции");
                }
                if (day == "пятница" || day == "пт")
                {
                    Console.WriteLine("09:50 ДВ4. Технологии сети Интернет");
                    Console.WriteLine("11:40 ДВ4. Технологии сети Интернет");
                    Console.WriteLine("14:00 Программирование на платформе .NET");
                }
                if (day == "суббота" || day == "сб")
                {
                    Console.WriteLine("08:00 Элективные дисциплины по физической культуре и спорту");
                }
            }
        }
    }
}
