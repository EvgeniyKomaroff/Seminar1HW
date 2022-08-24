
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
        int a, b;

    // Ввод данных

        Console.WriteLine("Введите число № 1 : ");
 
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число № 2 : ");

        b = Convert.ToInt32(Console.ReadLine());

    // Определение большего числа и вывод ответа на экран

        if (a > b) 
        { 
         Console.WriteLine("Число № 1 больше числа № 2"); 
        }
         else 
        {
         Console.WriteLine("Число № 2 больше числа № 1"); 
        } 

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

    // Ввод данных
      Console.WriteLine("Введите 3 числа:");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

    // Определение наибольшего числа            

            int max = a;

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }
    // Вывод ответа

            Console.WriteLine("Наибольшее из введённых чисел -> " + max);

//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

    // Ввод данных 

        Console.WriteLine("Введите число:");

            int num = Convert.ToInt32(Console.ReadLine());

    // Определение четности числа и вывод ответа

            if (num % 2 == 1)
            {
                Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
            }          

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

    // Ввод данных

            int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());

    // Определение четных чисел от 1 до N и их вывод в консоль

            Console.WriteLine("Чётные числа от 1 до " + num);

             while (i <= num)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }             