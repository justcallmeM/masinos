using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace masinos.Data
{
    public class CarService
    {
        public async Task<string> GetCar(string form, string size, string usage)
        {
            Random random = new Random();
            string jsonString = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "Database", $"Cars.json"));

            IEnumerable<string> images = JObject.Parse(jsonString).ToObject<Cars>()
                                                .ListedCars.Where(x => x.Form == form && x.Size == size && x.Usage == usage)
                                                .Select(x => x.ImagePath);

            int randomNum = random.Next(0, images.Count());

            return await Task.FromResult( images.Count() != 0 ? images.ElementAt(randomNum) : "/cars/placeholder.jpg");
        }

        public async Task<Options> GetOptions()
        {
            string jsonString = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "Database", $"CarOptions.json"));

            CarOptions carOptions = JObject.Parse(jsonString).ToObject<CarOptions>();

            return await Task.FromResult(carOptions.Options);
        }
    }
}
