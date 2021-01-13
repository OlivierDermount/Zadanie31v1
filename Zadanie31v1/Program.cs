using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie31v1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var writeReadDataAndCalculation = new WriteReadDataAndCalculation();
                try
                {
                    var name = writeReadDataAndCalculation.WriteScrAndReadKey("Cześć! Podaj imię");

                    var dateOfBirth = writeReadDataAndCalculation.WriteScrAndReadKey(
                        "Możesz podać cyframi datę urodzenia\n" +
                        " (w formacie rrrr.mm.dd)");

                    var age = writeReadDataAndCalculation.AgeVeryficationAndCalculation(dateOfBirth);

                    var exit = writeReadDataAndCalculation.WriteScrAndReadKey(name + " masz lat " + age + "\n" +
                        "\n Czy chcesz wprowadzić nowych użytkowników?  t/n");
                    if (exit == "n") break;
                }
                catch (Exception ex)
                {
                    writeReadDataAndCalculation.WriteScrAndReadKey(ex.Message + "\n Wciśnij Enter...");
                }
            }
        }
    }
}
