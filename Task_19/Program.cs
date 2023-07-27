//Математическое решение
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number >= 10000 && number < 100000){
    int first = number / 10000;
    int second = (number % 10000) / 1000;
    int last = number % 10;
    int secondLast = (number % 100) / 10;
    if (first == last && second == secondLast){
        Console.WriteLine($"Число {number} - полиндром.");
    }
    else{
        Console.WriteLine($"Число {number} не является полиндромом.");
    }
}
else Console.WriteLine($"Число {number} не пятизначное.");

//Решение со строкой
/*Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine()!;
if (int.Parse(number) >= 10000 && int.Parse(number) < 100000){
    if (number[0] == number[4] && number[1] == number[3]){
        Console.WriteLine($"Число {number} - полиндром.");
    }
    else{
        Console.WriteLine($"Число {number} не является полиндромом.");
    }
}
else Console.WriteLine($"Число {number} не пятизначное.");*/