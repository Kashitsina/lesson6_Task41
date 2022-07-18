void Zadacha41()
{
//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.WriteLine($"Cколько чисел больше 0");
Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());

int count = 0 ;

for (int i = 0; i < m; i++)
{   
    Console.WriteLine();
    Console.WriteLine($"Введите {i} число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number >0 ) count++;
}
Console.WriteLine("Чисел больше нуля:" + count);
}
Zadacha41();
