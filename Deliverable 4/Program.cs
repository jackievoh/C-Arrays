int n = 25;

int[] fibonacci = new int[n];

fibonacci[0] = 0;
fibonacci[1] = 1;

for (int i = 2; i < n; i++)
{
    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);
}

Console.ReadLine();