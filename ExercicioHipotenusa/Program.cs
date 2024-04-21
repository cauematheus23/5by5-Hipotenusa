Double c1, c2, h, hipotenusa;
do
{
    Console.WriteLine("Digite o 1° cateto");
    c1 = Double.Parse(Console.ReadLine());
} while (c1 <= 0);

do
{
    Console.WriteLine("Digite o 2° cateto");
    c2 = Double.Parse(Console.ReadLine());
} while (c2 <= 0);

h  = Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(c2,2));

Console.WriteLine($"A hipotenusa é {h}");


