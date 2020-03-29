using SQLite;
using System;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(ExpenseAnalysis.iOS.FileHelper))]
namespace ExpenseAnalysis.iOS
{
    public class FileHelper : IFileHelper
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "db_sqlnet.db";
            string libraryFolder = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "..", "Library");
            var path = Path.Combine(libraryFolder, dbName);
            return new SQLiteConnection(path);
        }
    }
}
