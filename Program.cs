double a, b, c, d;
double x1, x2;
Console.WriteLine("Digite o primeiro numero: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo  numero: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
c =  Convert.ToInt32(Console.ReadLine());

d = Math.Sqrt(b) - 4 * a *c;

if(d > 0)
{
    x1 = (-b - Math.Sqrt(d) / (2 * a));
    x2  = (-b + Math.Sqrt(d) / (2 * a));
    Console.WriteLine("X1 = ", x1, "X2 = ", x2);
}
else{
    if(d == 0)
    {
        x1  = (-b / (2 * a));
        x2 = x1;
        Console.WriteLine("X1 = ", x1, " X2= ", x2);
    }
    Console.WriteLine("Impossivel!");
}

