// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
Console.WriteLine("Введите размер массива");
int number = Convert.ToInt32(Console.ReadLine());
outputArray(createArray(number));

int[] createArray(int size){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(0, 101);
    }
    return array;
}

void outputArray(int[] arr){
    Console.WriteLine(String.Join(",", arr));
}
