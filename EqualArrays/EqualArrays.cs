int[] firstNumber = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] secondNumber = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

bool isIdentical = true;

for (int i = 0; i <= firstNumber.Length - 1; i++)
{
    if (firstNumber[i] != secondNumber[i])
    {
        isIdentical = false;
        Console.WriteLine("Arrays are not identical.");
        break;
    }
}
if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}