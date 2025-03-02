// See https://aka.ms/new-console-template for more information
for (int i = 0; i < 100; i+=6)
{
    if (i % 6 == 0) i--;
    Console.Write(i + '\t');
}
Console.WriteLine("Hello, World!");
