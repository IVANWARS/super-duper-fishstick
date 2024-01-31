//int N = 453;
//int firstDigit = N / 100; // 453 / 100 = 4
//int thirdDigit = N % 10; // 453 % 10 = 3
//int result = firstDigit * 10 + thirdDigit; // 4 * 10 + 3 = 43

//Console.WriteLine($"В числе {N} => {result}");


int N = 947;
int secondDigit = N / 10 % 10; // 947 / 10 = 94 % 10 = 4
int thirdDigit = N % 10; //  947 % 10 = 7
int result = (int)Math.Pow(secondDigit, thirdDigit);

Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");