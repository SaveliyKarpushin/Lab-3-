/* Вариант 7
Product: Наименование, Производитель, Цена, 
Срок хранения, Количество. Создать массив объектов. Вывести:
•	список товаров для заданного наименования;
•	список товаров для заданного наименования,
    цена которых не превышает указанной;
•	список товаров, срок хранения которых больше заданного.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_Saveliy
{
    class Program
    {
        public static Product[] myMassive = new Product[5];

        private static void init()
        {
            Product pr1 = new Product();
            pr1.Имя = "Паста арахисовая";
            pr1.Произв = "ИП Радзивиловский";
            pr1.Цена = 400;
            pr1.Срок = new DateTime(2022, 04, 13);
            pr1.Кол = 250;


            Product pr2 = new Product();
            pr2.Имя = "Батончик протеиновый";
            pr2.Произв = "ООО Фитнес Фуд";
            pr2.Цена = 150;
            pr2.Срок = new DateTime(2022, 09, 05);
            pr2.Кол = 320;

            Product pr3 = new Product();
            pr3.Имя = "Хлебцы";
            pr3.Произв = "ООО Хлебпром";
            pr3.Цена = 100;
            pr3.Срок = new DateTime(2022, 02, 10);
            pr3.Кол = 600;

            Product pr4 = new Product();
            pr4.Имя = "Шоколад";
            pr4.Произв = "ООО Фитнес Фуд";
            pr4.Цена = 200;
            pr4.Срок = new DateTime(2022, 07, 23);
            pr4.Кол = 1540;

            Product pr5 = new Product();
            pr5.Имя = "Хлебцы";            
            pr5.Произв = "ООО Фитнес Десерты";
            pr5.Цена = 80;
            pr5.Срок = new DateTime(2021, 12, 17);          
            pr5.Кол = 300;
            

            myMassive[0] = pr1;
            myMassive[1] = pr2;
            myMassive[2] = pr3;
            myMassive[3] = pr4;
            myMassive[4] = pr5;
        }
        
        static void Main(string[] args)
        {

            init();

            //	список товаров для заданного наименования
            Console.WriteLine("\nсписок товаров для заданного наименования");
            Console.WriteLine("Введите имя продукта:");
            string A = Console.ReadLine();
  
            for (uint i = 0; i < myMassive.Length; i++) {
                if (A == myMassive[i].Имя)
                {
                    Console.WriteLine($"\nПродукт-1\nИмя:{myMassive[i].Имя}" +
                        $"\nПроизводитель:{myMassive[i].Произв}\nЦена:{myMassive[i].Цена}" +
                        $"\nСрок годности:{myMassive[i].Срок}\nКоличество:{myMassive[i].Кол}");
                }
            }
           


            //список товаров для заданного наименования, цена которых не превышает указанной
            Console.WriteLine("\nCписок товаров для заданного наименования, цена которых не превышает указанной");
            Console.WriteLine("Введите имя продукта:");
            string A1 = Console.ReadLine();
            Console.WriteLine("Введите цену max:");
            double A2 = double.Parse(Console.ReadLine());

            for (uint i = 0; i < myMassive.Length; i++)
            {
                if (A1 == myMassive[i].Имя && A2 > myMassive[i].Цена)
                {
                    Console.WriteLine($"\nПродукт-1\nИмя:{myMassive[i].Имя}" +
                        $"\nПроизводитель:{myMassive[i].Произв}\nЦена:{myMassive[i].Цена}" +
                        $"\nСрок годности:{myMassive[i].Срок}\nКоличество:{myMassive[i].Кол}");
                }
            }

            //список товаров, срок хранения которых больше заданного.
            Console.WriteLine("\nсписок товаров, срок хранения которых больше заданного");
            Console.WriteLine("Введите срок годности:");
            DateTime A3 = new DateTime();
            A3 = DateTime.Parse(Console.ReadLine());

            for (uint i = 0; i < myMassive.Length; i++)
            {
                if (A3 < myMassive[i].Срок)
                {
                    Console.WriteLine($"\nПродукт-1\nИмя:{myMassive[i].Имя}" +
                        $"\nПроизводитель:{myMassive[i].Произв}\nЦена:{myMassive[i].Цена}" +
                        $"\nСрок годности:{myMassive[i].Срок}\nКоличество:{myMassive[i].Кол}");
                }
            }

        }
    }
}