//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateRandomArray(int size) {
    int[] Arr = new int [size];
    for(int i=0;  i<size; i++){
        Arr[i] =new Random().Next(100, 1000);
    }
    return Arr;
}
void ShowArray(int[] Arr){
    for(int i=0; i<Arr.Length; i++){
        Console.Write($"{Arr[i]} ");
    }
}
int Even (int[] Arr){
    int count = 0;
    for(int i=0; i<Arr.Length; i++){
        if(Arr[i] % 2 == 0) count++;
    }
    return count;
}
Console.WriteLine("Введите количество элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Arr = CreateRandomArray(size); 
ShowArray(Arr);
Console.WriteLine();
Console.WriteLine($"Количество четных элементов массива : {Even(Arr)} ");


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int[] CreateRandomArray(int size, int min, int max) {
    int[] Arr = new int [size];
    for(int i=0; i<size; i++){
        Arr[i] =new Random().Next(min, max);
    }
    return Arr;
}
void ShowArray(int[] Arr){
    for(int i=0; i<Arr.Length; i++){
        Console.Write($"{Arr[i]} ");
    }
}
int Sum(int[] Arr){
    int count = 0;
    for(int i=1; i<Arr.Length; i += 2){
        count+=Arr[i];
    }
    return count;
}
Console.WriteLine("Введите колличество элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальный элемент массива : ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальный элемент массива : ");
int max = Convert.ToInt32(Console.ReadLine());

int[] Arr = CreateRandomArray(size, min, max); 
ShowArray(Arr);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива на нечетных позициях : {Sum(Arr)}");


//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] CreateRandomArray(int size) {
    double[] Arr = new double [size];
    for(int i=0; i<size; i++){
        Arr[i] = new Random().NextDouble();
    }
    return Arr;
}

void ShowArray(double[] Arr){
    for(int i=0; i<Arr.Length; i++){
        Console.Write($"{Arr[i]} ");
    }
}

double MaxMin(double[] Arr){
    double max = Arr[0];
    double min = Arr[0];

    for(int i=0; i<Arr.Length; i++){
        if(Arr[i] > max ) max = Arr[i];
        if(Arr[i] < min ) min = Arr[i];
    }
        return max - min;
}
Console.WriteLine("Укажите колличество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] Arr = CreateRandomArray(size); 
ShowArray(Arr);
Console.WriteLine();
Console.WriteLine($"Разница составляет : {MaxMin(Arr)}");