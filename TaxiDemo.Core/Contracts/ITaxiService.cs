using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDemo.Core.Models;

namespace TaxiDemo.Core.Contracts
{
    /// <summary>
    /// Manipulate taxirequest 
    /// </summary>
    public interface ITaxiService
    {
        /// <summary>
        /// Gets All request
        /// </summary>
        /// <returns>List of Taxirequest</returns>
        Task<IEnumerable<TaxiDto>> GetAll();
    }
}
