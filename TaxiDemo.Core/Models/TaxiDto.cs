using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDemo.Core.Models
{
    /// <summary>
    /// Taxi Model
    /// </summary>
    /// <returns>List of Taxirequest</returns>
    public class TaxiDto
    {
        /// <summary>
        /// Taxi identifier
        /// </summary>
        public Guid Id  { get; set; }
        /// <summary>
        /// Taxi name
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        /// <summary>
        /// Taxi price 
        /// </summary>
        [Range(typeof(decimal), "0.1", "1000", ConvertValueInInvariantCulture = true)]
        public decimal Price { get; set; }
        /// <summary>
        /// Taxi quantity
        /// </summary>
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
