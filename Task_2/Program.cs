/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
using System.Text.RegularExpressions;

string pattern = @"^[0-9 ,]$";
while(true){
    Console.Write("Введите числа через пробел или запятую: ");
    string[] subs = Console.ReadLine().Split(' ', ',');
    int[] numbers = new int[subs.Count()];
    for(int i = 0; i < subs.Count();i++){
        if(Regex.IsMatch(subs[i], pattern))
            numbers[i] = Convert.ToInt32(subs[i]);
        else{
            Console.WriteLine("Ошибка ввода:Введите только числа через пробел или запятую!");
            continue;
        }
    }
    int numMax = 0;
    for(int i = 0; i < numbers.Count();i++){
        if(numbers[i] > numMax)
            numMax = numbers[i];
    }
    Console.WriteLine($"Максимальное число: {numMax}");
    break;
}