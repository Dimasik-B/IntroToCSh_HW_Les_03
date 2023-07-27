Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;
string result = "";
while (count <= number){
    result += Math.Pow(count, 3).ToString() + ", ";
    count++;
}
Console.WriteLine(result.Remove(result.Length-2));