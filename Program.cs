using System;

namespace laba1_Selivanov_ISP233
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello,World!!!");
            //int number = 10;
            //Console.WriteLine(number);//ctrl + k + c
            //Console.Write("Pls name ");
            //string? name = Console.ReadLine();
            //Console.WriteLine($"You name: {name}");
            //Console.Write("Pls name ");
            //string? name = Console.ReadLine();
            //Console.Write("Pls age ");
            //string? age = Console.ReadLine();
            //Console.Write("Pls city ");
            //string? city = Console.ReadLine();
            //Console.WriteLine("Name: {0} age:{1} city:{2}", name, age, city);
            //Console.Write("You num:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age);
            //int age2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age2);

            //int number = 250;
            //long number2 = (byte)(number+10);
            //Console.WriteLine(number2);

            //bool alive = true;
            //bool isDead = false;

            //double iDouble = 4.5;
            //float iFloat = 3.5F;
            //decimal iDecimal = 2.5m;
            //Console.WriteLine("ajhaha");

            //var name = "Dfs";
            //char symbol = 'A';

            //Console.Write("Введите имя: ");
            //string? name = Console.ReadLine();
            //Console.Write("Введите возраст: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Привет {name}");
            //Console.WriteLine($"Через год тебе будет: {age + 1}");


            /* Задание 1
            Console.Write("Ваша любимая игра/кино/аниме: ");
            string? name = Console.ReadLine();
            Console.Write("Ваша любимая цифра: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ваша любимая буква алфавита: ");
            string? alf = Console.ReadLine();
            Console.WriteLine($"любимая игра/кино/аниме: {name}");
            Console.WriteLine($"любимая цифра: {num}");
            Console.WriteLine(Math.PI);
            Console.WriteLine($"любимая буква алфавита: {alf}");
            */

            //Задание 2
            /*
            string lol = "I need more power! ";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(lol);
            }
            */

            //Задание 3
            /*Console.Write("\"Hello There\"");*/

            //Задание 4
            //comp1
            Console.Write("стоимость монитора: ");
            int monic1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("стоимость системного блока: ");
            int block1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("стоимость клавиатуры: ");
            int ckalava1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("стоимость мыши: ");
            int mish1 = Convert.ToInt32(Console.ReadLine());

            //comp2
            Console.Write("стоимость монитора: ");
            int monic2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("стоимость системного блока: ");
            int block2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("стоимость клавиатуры: ");
            int ckalava2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("стоимость мыши: ");
            int mish2 = Convert.ToInt32(Console.ReadLine());

            //comp3
            Console.Write("стоимость монитора: ");
            int monic3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("стоимость системного блока: ");
            int block3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("стоимость клавиатуры: ");
            int ckalava3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("стоимость мыши: ");
            int mish3 = Convert.ToInt32(Console.ReadLine());

            int res = monic1+ monic2+ monic3+ block1+ block2+ block3+ ckalava1+ ckalava2+ ckalava3+ mish1+ mish2+ mish3;
            Console.Write($"Итог: {res}");
        }
    }
}