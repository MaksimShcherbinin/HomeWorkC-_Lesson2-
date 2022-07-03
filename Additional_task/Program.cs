Console.Write("Введите номер искомого числа в последовательности круглых чисел: ");
int userIndex = Convert.ToInt32(Console.ReadLine()) - 1;
double binaryIndex = 0;

for(double i = 0; userIndex >= 1; i++)
{
    binaryIndex = (userIndex % 2) * Math.Pow(10, i) + binaryIndex;
    userIndex = userIndex / 2;
}
Console.WriteLine($"Искомое число: {binaryIndex*5}");
