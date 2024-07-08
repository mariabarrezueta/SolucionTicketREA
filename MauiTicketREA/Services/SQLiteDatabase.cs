using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using MauiTicketREA.Models;

namespace MauiTicketREA.Services
{
    public class SQLiteDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public SQLiteDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<DetailEvent>().Wait();
        }

        public Task<List<DetailEvent>> GetEventsAsync()
        {
            return _database.Table<DetailEvent>().ToListAsync();
        }

        public Task<int> SaveEventAsync(DetailEvent detailEvent)
        {
            if (detailEvent.Id != 0)
            {
                return _database.UpdateAsync(detailEvent);
            }
            else
            {
                return _database.InsertAsync(detailEvent);
            }
        }

        public Task<int> DeleteEventAsync(DetailEvent detailEvent)
        {
            return _database.DeleteAsync(detailEvent);
        }
    }
}

