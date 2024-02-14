using System;
using SchoolApp.classes;

namespace SchoolApp
{
    class Program
    {
        static void Main()
        {
            School school = new();

            school.SchoolBibliotheek.Boeken.Add(new() { Auteur = "Dirk", Titel = "Analyze" });
            school.SchoolBibliotheek.Boeken.Add(new() { Auteur = "Leo", Titel = "Ontwerp" });

            Console.WriteLine("De bibilotheek van de school bevat de volgende boeken: \n");
            school.SchoolBibliotheek.Boeken.ForEach(boek => Console.WriteLine($"{boek.Titel} geschreven door {boek.Auteur}"));

            school.Personen.Add(new Student("Piet"));
            school.Personen.Add(new Student("Karel"));
            school.Personen.Add(new Leerkracht("Danny"));

            Console.WriteLine("\nIn de school zijn de volgende personen aanwezig");
            school.Personen.ForEach(persoon => {
                Console.Write($"{persoon.Naam}: ");

                switch (persoon)
                {
                    case Student:
                        ((Student)persoon).StelUVoor();
                        ((Student)persoon).Lesvolgen();
                        break;

                    case Leerkracht:
                        ((Leerkracht)persoon).StelUVoor();
                        ((Leerkracht)persoon).Lesgeven();
                        break;
                }
            });

            Console.WriteLine("\nDe school heeft een schoolbus die volgende acties kan doen: \n");
            Console.WriteLine(school.DeSchoolbus.Remmen());
            Console.WriteLine(school.DeSchoolbus.Rijden());

            school.Klaslokalen.Add(new KlasLokaal { KlasLokaalnr = "1A" });
            school.Klaslokalen.Add(new KlasLokaal { KlasLokaalnr = "1B" });

            Console.WriteLine("\nIn de school bevinden zich volgende klaslokalen: \n");
            school.Klaslokalen.ForEach(lokaal => Console.WriteLine($"{lokaal.KlasLokaalnr}"));
        }
    }
}