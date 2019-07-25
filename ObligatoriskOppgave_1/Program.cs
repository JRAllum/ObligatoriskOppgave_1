using System;
using System.Collections.Generic;
using System.Linq;


namespace ObligatoriskOppgave_1
{
    class Program
    {
        
        static void Main(string[] args)
        {


            var personList = Person.Liste();

            var loop = true;
            while (loop == true)
            {
                var txt = Console.ReadLine();
                if (txt == "hjelp")
                {
                    Console.WriteLine(
                        "liste => lister alle personer med id, fornavn, fødselsår, dødsår og navn og id på mor og far om det finnes registrert.");
                    Console.WriteLine("vis => viser en bestemt person med mor, far og barn.");
                    Console.WriteLine("slutt => Avslutter program.");
                }

                else if (txt == "liste")
                {
                    foreach (var person in personList)
                    {
                        Console.Write($"Id: {person.Id}, Fornavn: {person.FirstName}");
                        if (person.LastName != null) Console.Write($", Etternavn: {person.LastName}");
                        Console.WriteLine($", Fødselsår: {person.BirthYear}");
                        if (person.Father != null)
                            Console.WriteLine($"FarId: {person.Father.Id}, FarNavn: {person.Father.FirstName}");
                        if (person.Mother != null)
                            Console.WriteLine($"MorId: {person.Mother.Id}, MorNavn: {person.Mother.FirstName}");
                        Console.WriteLine();

                    }
                }

                else if (txt == "vis")
                {
                    Console.Write("Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Person.Show(id, personList);
                    Console.WriteLine();

                }
                else if (txt == "slutt")
                {
                    loop = false;
                }
            }
        }

        
    }
}
