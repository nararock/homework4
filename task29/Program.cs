// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
Console.WriteLine("Введите размер массива");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижнюю границу для чисел в массиве");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу для чисел в массиве");
int max = Convert.ToInt32(Console.ReadLine());

outputArray(createArray(number, min, max));

int[] createArray(int size, int minNumber, int maxNumber){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(minNumber, maxNumber + 1);
    }
    return array;
}

void outputArray(int[] arr){
    Console.WriteLine(String.Join(",", arr));
}
