using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    public class Car
    {
        Radio _radio = new Radio();
        protected int v = 0;
        protected int maxv = 0;
        bool isPowerOn = false;
        public void Start()
        {
            if (!isPowerOn)
            {
                Console.WriteLine("Машина запуcкается");
                isPowerOn = true;
            }
            else
            {
                Console.WriteLine("Машина уже запущена");
            }
        }   
        public void Stop()
        {
            if (isPowerOn)
            {
                if (v == 0)
                {
                    Console.WriteLine("Машина выключается");
                    isPowerOn = false;
                }          
                else
                {
                    Console.WriteLine("Остановите машину");
                }
                
            }
            else
            {
                Console.WriteLine("Машина уже выключена");
            }
            
        }
        public void Speedup() 
        {
            if((v+10) > maxv)
            {
                v = maxv;
                Console.WriteLine("Достигнута максимальная скорость");
            }
            else if (!isPowerOn)
            {
                Console.WriteLine("Машина выключена");
            }
            else if(v == 0)
            {
                Console.WriteLine("Машина остановлена, поэтому медленно трогаемся с места ");
                v = 5;
                Console.WriteLine(v);
            }
            else
            {
                Console.WriteLine("+50kmh");
                v += 50;
                Console.WriteLine(v);
            }
        }
        public void Speeddown() 
        {
            if ((v-10) < 0)
            {
                if(v == 0) 
                { 
                    Console.WriteLine("Машина уже остановлена"); 
                }
                else
                {
                    v = 0;
                    Console.WriteLine("Машина остановлена");
                }
                
            }
            else
            {
                Console.WriteLine("-50kmh");
                v -= 50;
                Console.WriteLine(v);
            }
        }
        public void RadioOn()
        {
            if (!isPowerOn)
            {
                Console.WriteLine("Сперва запустите машину");
            }
            else
            {
                _radio.On();
            }
        }
        public void RadiOff()
        {
            if (!isPowerOn)
            {
                Console.WriteLine("Машина выключена");
            }
            else
            {
                _radio.Off();
            }
        }
        
    }
}
