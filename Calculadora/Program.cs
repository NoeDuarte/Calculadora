using Calculadora;

Sumador sumador = new Sumador();
Divisor dividir = new Divisor();
Restador restador = new Restador();
Multiplicador multiplicador = new Multiplicador();


Console.WriteLine("EL RESULTADO ES:");
Console.WriteLine( sumador.Sumar(5, 9));
Console.WriteLine(dividir.Dividir(8, 4));
Console.WriteLine(restador.Restar(9, 5));
Console.WriteLine(multiplicador.Multíplicar(4,2));