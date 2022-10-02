int inp, fact = 1;

Console.Write("Enter an integer number : ");
inp = Convert.ToInt32(Console.ReadLine());

for (int x = 1; x <= inp; x++)
    fact = fact * x;

Console.WriteLine("The factorial of {0} is : {1}", inp, fact);
Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

