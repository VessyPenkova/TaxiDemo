using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

using TaxiDemo.Core.Contracts;
using TaxiDemo.Core.Models;

namespace TaxiDemo.Core.Services
{
    /// <summary>
    /// Manipulate taxirequest 
    /// </summary>
    public  class TaxiService : ITaxiService
    {
        private readonly IConfiguration config;
        /// <summary>
        /// IoC
        /// </summary>
        /// <param name="_confic">Application Configuration</param>
        public TaxiService(IConfiguration _confic)
        {
            config = _confic;
        }
        /// <summary>
        /// Gets All request
        /// </summary>
        /// <returns>List of Taxirequest</returns>
        public async Task<IEnumerable<TaxiDto>> GetAll()
        {
            string dataPath = config.GetSection("DataFiles:Taxi").Value;
            string data = await File.ReadAllTextAsync(dataPath);

            return JsonConvert.DeserializeObject<IEnumerable<TaxiDto>>(data);
           
        }
    }
}
