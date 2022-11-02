int Num = 12821;

if ((Num / 10000 == Num % 10) && ((Num / 1000) % 10 == (Num % 100) / 10)) Console.WriteLine("Число является палиндромом");

else Console.WriteLine("Число не является палиндромом");
