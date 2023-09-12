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


        }
    }
}