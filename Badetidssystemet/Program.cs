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

            string Type;
            DateTime StartTidspunkt;
            DateTime SlutTidspunkt;


            Console.WriteLine("Indtast følgende oplysninger: Type, start tidspunkt og slut tidspunkt");
            Type = Console.ReadLine();
            StartTidspunkt = Convert.ToDateTime(Console.ReadLine());
            SlutTidspunkt = Convert.ToDateTime(Console.ReadLine());

            BadetidsPeriode newBadetidsPeriode = new BadetidsPeriode();
            newBadetidsPeriode.NewBadetidsPeriode(Type, StartTidspunkt, SlutTidspunkt);


            





       }

       



}
}
