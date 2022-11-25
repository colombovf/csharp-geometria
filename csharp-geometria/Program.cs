// See https://aka.ms/new-console-template for more information
/*hiedere all’utente di inserire, da console, i valori di base e di altezza 
 * con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato, occuparsi
 * di configurare le sue proprietà di base e altezza e stampare a video il perimetro e l’area.*/

using csharp_geometria;

Rettangolo rettangolo1= new Rettangolo();
Rettangolo rettangolo2= new Rettangolo();
Rettangolo rettangolo3= new Rettangolo();
Rettangolo rettangolo4= new Rettangolo();

Console.WriteLine("Inserire la base del rettangolo:");
rettangolo1.baseRettangolo = int.Parse(Console.ReadLine());
Console.WriteLine("Inserire l'altezza del rettangolo:");
rettangolo1.altezzaRettangolo = int.Parse((Console.ReadLine()));


Console.WriteLine("Il perimetro sarà: " + rettangolo1.CalcoloPerimetro()+ " cm");
Console.WriteLine("Il perimetro sarà: " + rettangolo1.CalcoloArea() + " cm");


Console.WriteLine(rettangolo1.baseRettangolo);
Console.WriteLine(rettangolo1.altezzaRettangolo);


/*Istanziare tanti rettangoli con nome diverso e attributi diversi 
 * (baseRettangolo e altezzaRettangolo) e provate a stampare le loro
 * proprietà ad esemp  io con un metodo StampaRettangolo che vi stampi il vostro rettangolo*/

