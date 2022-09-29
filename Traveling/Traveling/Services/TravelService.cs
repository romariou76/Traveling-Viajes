using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Traveling.Models;

namespace Traveling.Services
{
    public class TravelService : ITravelRepository
    {
        public SQLiteAsyncConnection _database;

        public TravelService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<TravelInfo>().Wait();
        }
        //Insert & Update
        public async Task<bool> AddTravelAsync(TravelInfo travelInfo)
        {
            if(travelInfo.TravelId > 0)
            {
                await _database.UpdateAsync(travelInfo);
            }
            else
            {
                await _database.InsertAsync(travelInfo);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteTravelAsync(int id)
        {
            await _database.DeleteAsync<TravelInfo>(id);
            return await Task.FromResult(true);
        }

        public async Task<TravelInfo> GetTravelAsync(int id)
        {
            return await _database.Table<TravelInfo>().Where(x => x.TravelId == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TravelInfo>> GetTravelAsync()
        {
            return await Task.FromResult( await _database.Table<TravelInfo>().ToListAsync());
        }

        public Task<bool> UpdateTravelAsync(TravelInfo travelInfo)
        {
            throw new NotImplementedException();
        }
    }
}
