using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Assignment2
{
    public interface SQLiteDBInterface
    {
        SQLiteAsyncConnection createSQLiteDB();
    }
}
