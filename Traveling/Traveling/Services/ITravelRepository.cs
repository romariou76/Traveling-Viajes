using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Traveling.Models;

namespace Traveling.Services
{
    public interface ITravelRepository
    {
        Task<bool> AddTravelAsync(TravelInfo travelInfo);
        Task<bool> UpdateTravelAsync(TravelInfo travelInfo);
        Task<bool> DeleteTravelAsync(int id);
        Task<TravelInfo> GetTravelAsync(int id);
        Task<IEnumerable<TravelInfo>> GetTravelAsync();
    }
}
