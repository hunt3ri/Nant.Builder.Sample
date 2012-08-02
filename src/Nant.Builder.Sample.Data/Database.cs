using System.IO;
using System.Data.SQLite;

namespace Nant.Builder.Sample.Data
{
    public class Database
    {
        const string dirPath = @"c:\dev\tools\sqlite";
        const string fullPath = dirPath + "\\nant-builder-sample.db3";

        public void CreateDb()
        {

            Directory.CreateDirectory(dirPath);

            SQLiteConnection.CreateFile(fullPath);
        }




    }
}
