using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
            //    Реализовать класс, в котором указанные значения представлены в виде свойств.Для свойств предусмотреть проверку корректности данных. 
            //    Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы. 
            //    Создать объект на основе разработанного класса. 
            //    Осуществить использование объекта в программе.
            
            Angle angle = new Angle(0, 0, 0); 

            
            Console.WriteLine("Angle:{0} minuta:{1} secunda:{2}", angle.gradus, angle.minuta, angle.secunda);
            Console.WriteLine("1 gradus Angle.ToRadians(): {0}", angle.ToRadians());
            Console.ReadKey();
        }
    }
    class Angle
    {
        public int gradus;
        public int minuta;
        public int secunda;

        public int Gradus
        {
            set
            {
                if (value > 0)
                {
                    gradus = value;
                }
                else if (value < 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите число от 0 до 360");
                }
            }
            get 
            {
                return gradus; 
            }
        }

        public int Minuta
        {
            set
            {
                if (value > 0)
                {
                    minuta = value;
                }
                else if (value < 60)
                {
                    minuta = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите число от 0 до 60");
                }
            }
            get
            {
                return minuta;
            }
        }

        public int Secunda
        {
            set
            {
                if (value > 0)
                {
                    secunda = value;
                }
                else if (value < 60)
                {
                    secunda = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите число от 0 до 60");
                }
            }
            get
            {
                return secunda;
            }
        }

        public Angle (int gradus, int minuta, int secunda) 
        {
            this.gradus = gradus;
            this.minuta = minuta;
            this.secunda = secunda;
        }
        
        public double ToRadians()
        {
            return (this.gradus + this.minuta / 60d + this.secunda / (60 * 60)) * Math.PI / 180d;
        }
    }
}

