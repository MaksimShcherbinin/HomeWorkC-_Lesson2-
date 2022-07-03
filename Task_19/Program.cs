Console.Write("Введите пятизначное число: ");
int userNum = Convert.ToInt16(Console.ReadLine());

if(((userNum - userNum%10000)/10000 == userNum%10) && ((userNum%10000 - userNum%1000)/1000 == (userNum%100 - userNum%10)/10)) Console.WriteLine("число: " + userNum + " является полиндромом");
else Console.WriteLine("число: " + userNum + " НЕ является полиндромом");
