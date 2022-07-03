Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= userNumber; i++) Console.WriteLine($"{i}^3 = {i*i*i}");
