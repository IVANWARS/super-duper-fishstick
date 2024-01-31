//int N = 453;
//int firstDigit = N / 100; // 453 / 100 = 4
//int thirdDigit = N % 10; // 453 % 10 = 3
//int result = firstDigit * 10 + thirdDigit; // 4 * 10 + 3 = 43

//Console.WriteLine($"В числе {N} => {result}");


//int N = 947;
//int secondDigit = N / 10 % 10; // 947 / 10 = 94 % 10 = 4
//int thirdDigit = N % 10; //  947 % 10 = 7
//int result = (int)Math.Pow(secondDigit, thirdDigit);

//Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");


//int N = 944556446;
//N (если >= 100) 
//{
  // int thirdDigitFromEnd = N / 100 % 10;
// Консоль.WriteLine($"Третья цыфра с конца: {thirdDigitFromEnd}");
//}
//ещё
//{
 //Консоль.WriteLine("Третей цыфры нет");
//}
 
 
  int a = 5;

  int b = 3;

if (a % b == 0)
{
    Console.WriteLine($"{a} кратно (делится без остатка ) числу {b}");
}
else
{
    System.Console.WriteLine($"остаток от {a} / {b} = {a % b}");
}