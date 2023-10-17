int[] firstNumber = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] secondNumber = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

foreach (int number in firstNumber)
{
    foreach (int number2 in secondNumber)
        
    if (number == number2)
    {
        Console.Write(number + " ");
    }
}