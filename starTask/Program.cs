// Напишите программу, которая задаёт массив из 10 элементов, которые необходимо 
//заполнить случайными значениями в диапазоне от -10 до 10
// и найти максимальное значение среди них
int[] myArray = createArray(10, -10, 10);
outputArray(myArray); 
Console.WriteLine($"максимальное значение массива {myArray.Max()}");

int[] createArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void outputArray(int[] arr){
    Console.WriteLine(String.Join(", ", arr));
}

