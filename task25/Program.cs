// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.
exponenta();

void exponenta(){
    while(true){
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень числа");
        int degree = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{number} в степени {degree} равняется {Math.Pow(number, degree)}");
        Console.WriteLine("Продолжить возводить в степень? (Да или Нет)");
        string answer = Console.ReadLine();
        if (answer.ToLower() == "нет") break;
    }
}
