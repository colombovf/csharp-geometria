// See https://aka.ms/new-console-template for more information
/*hiedere all’utente di inserire, da console, i valori di base e di altezza 
 * con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato, occuparsi
 * di configurare le sue proprietà di base e altezza e stampare a video il perimetro e l’area.*/

using csharp_geometria;

Rettangolo rettangolo1= new Rettangolo();
Rettangolo rettangolo2= new Rettangolo();
Rettangolo rettangolo3= new Rettangolo();
Rettangolo rettangolo4= new Rettangolo();

Console.WriteLine("Rettangolo1:");
Console.Write("Inserire la base del rettangolo:");
rettangolo1.baseRettangolo = int.Parse(Console.ReadLine());
Console.Write("Inserire l'altezza del rettangolo:");
rettangolo1.altezzaRettangolo = int.Parse((Console.ReadLine()));


Console.WriteLine();

Console.WriteLine("--Rettangolo1--");
Console.WriteLine("Base: " + rettangolo1.baseRettangolo);
Console.WriteLine("Altezza: " + rettangolo1.altezzaRettangolo);
Console.WriteLine("Perimetro: " + rettangolo1.CalcoloPerimetro()+ " cm");
Console.WriteLine("Area: " + rettangolo1.CalcoloArea() + " cm2");





/*Istanziare tanti rettangoli con nome diverso e attributi diversi 
 * (baseRettangolo e altezzaRettangolo) e provate a stampare le loro
 * proprietà ad esemp  io con un metodo StampaRettangolo che vi stampi il vostro rettangolo*/
Console.WriteLine();

Console.WriteLine("Rettangolo2:");
Console.Write("Inserire la base del rettangolo:");
rettangolo2.baseRettangolo = int.Parse(Console.ReadLine());
Console.Write("Inserire l'altezza del rettangolo:");
rettangolo2.altezzaRettangolo = int.Parse((Console.ReadLine()));

Console.WriteLine();

Console.Write("--Rettangolo2--");
Console.WriteLine("Base: " + rettangolo2.baseRettangolo);
Console.WriteLine("Altezza: " + rettangolo2.altezzaRettangolo);
Console.WriteLine("Perimetro: " + rettangolo2.CalcoloPerimetro() + " cm");
Console.WriteLine("Area: " + rettangolo2.CalcoloArea() + " cm2");


Console.WriteLine();

Console.WriteLine("Rettangolo3:");
Console.Write("Inserire la base del rettangolo:");
rettangolo3.baseRettangolo = int.Parse(Console.ReadLine());
Console.Write("Inserire l'altezza del rettangolo:");
rettangolo3.altezzaRettangolo = int.Parse((Console.ReadLine()));

Console.WriteLine();
Console.WriteLine("--Rettangolo3--");
Console.WriteLine("Base: " + rettangolo3.baseRettangolo);
Console.WriteLine("Altezza: " + rettangolo3.altezzaRettangolo);
Console.WriteLine("Perimetro: " + rettangolo3.CalcoloPerimetro() + " cm");
Console.WriteLine("Area: " + rettangolo3.CalcoloArea() + " cm2");

Console.WriteLine();

Console.WriteLine("Rettangolo4:");
Console.Write("Inserire la base del rettangolo:");
rettangolo4.baseRettangolo = int.Parse(Console.ReadLine());
Console.Write("Inserire l'altezza del rettangolo:");
rettangolo4.altezzaRettangolo = int.Parse((Console.ReadLine()));

Console.WriteLine();
Console.WriteLine("--Rettangolo4--");
Console.WriteLine("Base: " + rettangolo4.baseRettangolo);
Console.WriteLine("Altezza: " + rettangolo4.altezzaRettangolo);
Console.WriteLine("Perimetro: " + rettangolo4.CalcoloPerimetro() + " cm");
Console.WriteLine("Area: " + rettangolo4.CalcoloArea() + " cm2");

