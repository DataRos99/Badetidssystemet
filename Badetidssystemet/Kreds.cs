using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
   public class Kreds
   {
        

        
       

        public void NewKreds(int ID, string Navn, string Adresse, int AntalDeltagere) 
        {
            newID = ID;
            newNavn = Navn;
            newAdresse = Adresse;
            newAntalDeltagere = AntalDeltagere;

            Console.WriteLine("ID  : - " + newID + "Navn  : - " + newNavn + "Adresse  : - " + newAdresse + "Antal Deltagere : - " + newAntalDeltagere);
            Console.ReadLine();


        }
        int newID;
        string newNavn;
        string newAdresse;
        int newAntalDeltagere;

        public override string ToString()
        {
            return $"Nummer: {newID} Navn: {newNavn} Adresse: {newAdresse} Antal Deltagere: {newAntalDeltagere}";
        }





   }
}
