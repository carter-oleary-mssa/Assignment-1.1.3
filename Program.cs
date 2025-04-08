Console.Write("Enter two numbers to be divided: ");
decimal num1 = Convert.ToDecimal(Console.ReadLine());
decimal num2 = Convert.ToDecimal(Console.ReadLine());
int result = Convert.ToInt32(num1 / num2);
Console.WriteLine($"{num1} / {num2} = {(result)}r{num1%num2}");
