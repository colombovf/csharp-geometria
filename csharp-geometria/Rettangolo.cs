using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_geometria
{
    //Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo. 
    public class Rettangolo
    {
        public int baseRettangolo = 5;
        public int altezzaRettangolo = 7;

        //Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono,
        //rispettivamente, l’area e il perimetro del rettangolo.

        public int CalcoloArea()
        {
            int Area = baseRettangolo * altezzaRettangolo;
            return Area;
        }

        public int CalcoloPerimetro()
        {
            int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
            return perimetro;
        }

    }










}
