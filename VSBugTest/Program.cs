using CsvHelper;
using System.Globalization;

namespace VSBugTest
{
    public class Program
    {
        private const string _sourcefile = "datademo.csv";
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(_sourcefile))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<csvdto>();
                    ;
                }
            }

            // This section does not have using() so won't dispose.  

            var reader1 = new StreamReader(_sourcefile);
            var csv1 = new CsvReader(reader1, CultureInfo.InvariantCulture);
            var records1 = csv1.GetRecords<csvdto>();
            ;


        }
    }
}