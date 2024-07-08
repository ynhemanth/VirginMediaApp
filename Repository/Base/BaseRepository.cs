using CsvHelper;
using Repository.Configuration;
using Repository.Entity.Model;
using System.Globalization;
using System.Linq.Expressions;

namespace Repository.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        private readonly string path = "Data/Data.csv";


        public BaseRepository()
        {

        }
                
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = ReadCsvFile<T>(path);            

            return result;
        }


        private IEnumerable<T> ReadCsvFile<T>(string filePath)
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Read();
            csv.ReadHeader();
            csv.Context.RegisterClassMap<CsvMapping>();
            var records = csv.GetRecords<T>();

            return records.ToList();
        }
    }
}
