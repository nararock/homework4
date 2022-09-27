// Напишите программу, которая задаёт 2 одномерных массива из N 
//элементов которые заполняются случайными значениями в диапазоне 
//от 1 до 10 и находит среднее арифметическое элементов этих 2 массивов, 
//далее от большего из получившихся средних арифметических отнимаем меньшее и 
//округлённый до целого числа результат переводим в двоичную систему счисления.
Console.WriteLine("Введите размер массивов");
int size = Convert.ToInt32(Console.ReadLine());

int[] array1 = createArray(size, 1, 11);
outputArray(array1);
int[] array2 = createArray(size, 1, 11);
outputArray(array2);

double avg1 = getAverage(array1);
double avg2 = getAverage(array2);

int difference = (int)Math.Round(Math.Abs(avg1 - avg2));
Console.WriteLine(@$"Среднее арифметическое 1-го массива {Math.Round(avg1, 2)}; среднее арифметическое 2-го массива {Math.Round(avg2, 2)}; 
округленная разница средних арифметических равна {difference}; разница в двоичном виде {toBinary(difference)}");

int[] createArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void outputArray(int[] arr){
    Console.WriteLine("[" + String.Join(", ", arr) + "]");
}

double getAverage(int[] arr){
    double average = 0;
    for (int i = 0; i < arr.Length; i++){
        average +=arr[i];
    }
    average /= arr.Length;
    return average;
}

string toBinary(int number){
    string binary = Convert.ToString(number, 2);
    return binary;
}