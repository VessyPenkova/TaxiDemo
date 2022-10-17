using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System.Runtime.CompilerServices;
using TaxiDemo.Core.Contracts;

namespace TaxiDemo.Grpc.Services
{
    public class TaxiGrpsService : Taxi.TaxiBase
    {
        private readonly ITaxiService taxiservice;
        public TaxiGrpsService(ITaxiService _taxiservice)
        {
            taxiservice = _taxiservice;
        }

        public override async Task<TaxiList> GetAll(Empty request, ServerCallContext context)
        {
            TaxiList result = new TaxiList();
            var taxis = await taxiservice.GetAll();

            result.Items.AddRange(taxis.Select(t => new TaxiItem()
            {
                Name = t.Name,
                Id = t.Id.ToString(),
                Price = (double)t.Price,
                Quantity = t.Quantity

            }));

            return result;
        }
    }
}
