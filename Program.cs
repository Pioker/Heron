//cria variaveis para calcular os lados 
string Lado1 ="", Lado2 ="", Lado3 ="";
double n1, n2, n3, semiperimetro, area;

Console.Beep();

Console.WriteLine("---------");
Console.WriteLine("Digite abaixo as medidas do triangulo que serão calculadas");
Console.Write("Lado1: ");
Lado1 = Console.ReadLine();
Console.Write("Lado2: ");
Lado2 = Console.ReadLine();
Console.Write("Lado3: ");
Lado3 = Console.ReadLine();

n1= Convert.ToDouble(Lado1);
n2= Convert.ToDouble(Lado2);
n3= Convert.ToDouble(Lado3);

semiperimetro = (n1+n2+n3)/2;
area = Math.Sqrt (semiperimetro* (semiperimetro-n1)*(semiperimetro-n2)*(semiperimetro-n3));

Console.Beep();

Console.WriteLine("----------");
Console.ForegroundColor=ConsoleColor.DarkRed;
Console.WriteLine("\n---Area e Semiperimetro---");
Console .ResetColor ();
Console.WriteLine($"A area é: {area}");
Console.WriteLine($"O semiperimetro é: {semiperimetro}"); 
Console.WriteLine("----------");