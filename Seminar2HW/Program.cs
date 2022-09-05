// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа


  int Calculate(int num){
    int number1 = num / 10;
    int result = number1 % 10;
    return result;
}
Console.WriteLine("Введите 3-х значное число");
int num =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая цифра числа " +  Calculate(num));




// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет


int Numbers(int num){
    if (num > 100){
    string stroka = Convert.ToString(num);
    num = stroka[2] - '0';
    return num; 
    } 
    if(num == 100){
        num = 0;
        return num; 
    }
    else {
        return -1;
    }
 }
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int answr = Numbers(num);
if(answr == -1){
Console.WriteLine("Третьей цифры нет");
}
else{
    Console.WriteLine("Третья цифра - " + answr);
}




// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


void Holiday(int day){
if (day==6||day==7){
    Console.WriteLine("Выходной день");
}
    else{
        Console.WriteLine("Будний день");
    }
}
Console.WriteLine("Введите число");
int day=Convert.ToInt32(Console.ReadLine());
if (day > 7 || day<=0){
    Console.WriteLine("такого дня недели нет"); 
}
else Holiday(day); 

