// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Prompt (string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine() ?? "";
    int result = Convert.ToInt32(value);
    return result;
}

int Plus (int number)
{
    while (number > 999) {
        number /= 10;  
    }
    return number % 10;
}
bool Minus(int number) 
{
    if (number < 100) {
        Console.WriteLine ("Третьей цифры нет");
        return false; }
    
    return true;
    }
    int number = Prompt("Введите число");
    if (Minus(number)) {
        Console.WriteLine (Plus(number));
    }

    
