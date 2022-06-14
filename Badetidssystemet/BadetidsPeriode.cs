using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class BadetidsPeriode
    {
        Dictionary<int, Kreds> Kreds;


        public BadetidsPeriode()
        {
            Kreds = new Dictionary<int, Kreds>();


            new DateTime().AddHours(7).AddMinutes(0);
            int DateTime = 7;
            if (DateTime < 7)
            {
                Console.WriteLine("Man kan ikke bruge pool området før kl. 7");
            }
            new DateTime().AddHours(20).AddMinutes(0);
            int DateTime = 20;
            if (DateTime > 20)
            {
                Console.WriteLine("Man kan ikke bruge pool området efter kl. 20");
            }
 

           
        }

        public void Test()
        {
            Kreds newKreds = new Kreds();

            Kreds k1 = new Kreds(1, "Pool", "PoolVej 1", 11);
            Kreds k2 = new Kreds(2, "Pool", "Poolvej 2", 15);
            Kreds k3 = new Kreds(3, "Strand", "Strandvej 1", 12);

            Console.WriteLine("Kredser vi tilbyder");


        }

        public void NewBadetidsPeriode(string Type, DateTime StartTidspunkt, DateTime SlutTidspunkt)
        {
            newType = Type;
            newStartTidspunkt = StartTidspunkt;
            newSlutTidspunkt = SlutTidspunkt;

            Console.WriteLine("Type : - " + newType + "Start tidspunkt : -" + newStartTidspunkt + "newSlutTidspunkt : - " + newSlutTidspunkt);
            Console.ReadLine();

        }
        string newType;
        DateTime newStartTidspunkt;
        DateTime newSlutTidspunkt;

        public override string ToString()
        {
            return $"Type: {newType} Start tidspunkt: {newStartTidspunkt} Slut tidspunkt: {newSlutTidspunkt}";

        }

       void AdderKreds (Kreds kreds)
       {
            kreds.Add(kreds.NewKreds, kreds);
       }

       void SletKreds(string, IDictionary)
       {

       }





    }
}
