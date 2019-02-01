using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TeaTime.Sqlite.Data
{
    public class BaseRepository
    {
        public static SQLiteConnection TeaTimeDbConnection()
        {
            var source = HttpContext.Current.Server.MapPath("~/TeaTime.db");
            return new SQLiteConnection("Data Source=" + source);
        }
    }
}
