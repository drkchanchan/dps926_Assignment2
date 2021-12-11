using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using SQLite;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(Assignment2.iOS.sqliteDB))]
namespace Assignment2.iOS
{
    public class sqliteDB : SQLiteDBInterface
    {
        public SQLiteAsyncConnection createSQLiteDB()
        {
            var document_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(document_path, "Assignment2DB.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}