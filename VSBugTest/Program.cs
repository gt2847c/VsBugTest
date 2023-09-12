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

            /*
            // This section does not have using() so won't dispose.  If you stop after records1 at the ;
            // and view the Locals entry - expand the records1.Results View and scroll until the results 
            // disappear, then step to the ToList(), "list" will be empty.  
            // Alternatively if you don't get the results to disappear, then ToList will generate 4,105 entries 

            var reader1 = new StreamReader(_sourcefile);
            var csv1 = new CsvReader(reader1, CultureInfo.InvariantCulture);
            var records1 = csv1.GetRecords<csvdto>();
            ;
            var list = records1.ToList();
            ;
            */


        }
    }
}