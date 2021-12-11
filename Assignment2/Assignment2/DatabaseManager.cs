using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment2
{
    static public class DatabaseManager
    {
        static SQLiteAsyncConnection _connection;

        static public void createConnection()
        {
            _connection = DependencyService.Get<SQLiteDBInterface>().createSQLiteDB();
        }

        public static async Task<ObservableCollection<Business>> CreateTable()
        {
            await _connection.CreateTableAsync<Business>();

            var BusinessesFromDB = await _connection.Table<Business>().ToListAsync();
            var allBusinesses = new ObservableCollection<Business>(BusinessesFromDB);
            return allBusinesses;
        }

        public static async void InsertSavedRestaurant(Business NewBusiness)
        {
            await _connection.InsertAsync(NewBusiness);
        }

        public static async void DeleteSavedRestaurant(Business toDelete)
        {
            await _connection.DeleteAsync(toDelete);
        }
    }
}
