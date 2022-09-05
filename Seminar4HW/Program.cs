


//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


 int Calculate(int a, int b) {
     int c = a; 
     for ( int i = 1; i < b ; i++ ){
         c *= a;
    }
     return c;
 }

 Console.Write("Введите Ваше число : ");
 int a = Convert.ToInt32(Console.ReadLine()); 
 Console.Write("Введите степень Вашего числа : ");
 int b = Convert.ToInt32(Console.ReadLine());
 if (b < 0) Console.WriteLine ("Некорректный ввод");

 Console.WriteLine("Результат : " + Calculate(a,b) );

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


 int Calculate(int num){

 int result=0;

     for (int i = 0; num != 0 ;i++ ){
          result += num%10;
          num /= 10;
     }
          return result;
 }
 Console.Write("Введите число : ");
 int n = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Сумма цифр числа равна " + Calculate(n));


 //  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 


int [] array = new int[8];
for (int i = 0; i < 8; i++ ){
    Console.Write(" Введите элемент массива № " + (i+1) + " : ");
    array[i] = Convert.ToInt32(Console.ReadLine()); 
}
void Arr(int[] arr){
    Console.Write("[ ");
    for (int i = 0; i <arr.Length; i++){
        Console.Write(arr[i]+ " ");
    }
    Console.Write("]");
}
    Arr(array);
