using System;

namespace Badetidssystemet
{
class Program
{
       
       static void Main(string[] args)
       {
        int ID;
        string Navn;
        string Adresse;
        int AntalDeltagere;


        Console.WriteLine("Indtast følgende oplysninger: ID, navn, Adresse og antal deltagere");
        ID = Convert.ToInt32(Console.ReadLine());
        Navn = Console.ReadLine();
        Adresse = Console.ReadLine();
        AntalDeltagere = Convert.ToInt32(Console.ReadLine());


        Kreds newKreds = new Kreds();
        newKreds.NewKreds(ID, Navn, Adresse, AntalDeltagere);




       }
}
}
