// See https://aka.ms/new-console-template for more information
using listaenlazada;
/*
Locomotora a = new Locomotora();
Vagon v1 = new Vagon(1);
Vagon v2 = new Vagon(2);
a.Primero = v1;
v1.Sig = v2;
a.Imprime();
Console.WriteLine();

Vagon v3 = new Vagon(3);
v1 = a.Primero;
v3.Sig = v1;
a.Primero = v3;
a.Imprime();
*/

Console.WriteLine();
/*
Locomotora z = new Locomotora();
z.AgregaIni(5);
z.AgregaIni(3);
z.AgregaIni(1);
z.AgregaFin(7);
z.EliminaSegundo();
z.Imprime();

Console.WriteLine(z.Get(0));
Console.WriteLine($"hay {z.Length()} elementos");
*/


/*
Console.WriteLine("Ingrese valor a buscar");
int vbus = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(b.BuscaValor(vbus) ? "Encontrado" : "no esta");
*/

Locomotora a = new Locomotora();
a.AgregaFin(1);
a.AgregaFin(3);
a.AgregaFin(5);

Locomotora b = new Locomotora();
b.AgregaFin(2);
b.AgregaFin(4);
b.AgregaFin(6);

a.Imprime();    //1,3,5
Console.WriteLine();
a.MerclaAlFinal2(b);
a.Imprime();    //1,3,5,2,4,6
