using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie31v1
{
    class WriteReadDataAndCalculation
    {
        public string WriteScrAndReadKey(string Text)
        {
            Console.WriteLine(Text);
            return Console.ReadLine();
        }

        public int AgeVeryficationAndCalculation(string dateOfBirth)
        {
            DateTime date = DateTime.ParseExact(dateOfBirth, "yyyy.MM.dd",
                                System.Globalization.CultureInfo.InvariantCulture);
            var year = date.Year;
            var month = date.Month;
            var todayDate = DateTime.Now;
            var numberOfMonth = month - todayDate.Month;
            var ageInt = (numberOfMonth <= 0) ?
                todayDate.Year - year : todayDate.Year - year - 1;
            return ageInt;
        }
    }
}
