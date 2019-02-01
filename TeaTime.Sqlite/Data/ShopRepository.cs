using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaTime.Core.Entities;
using TeaTime.Core.Interfaces;

namespace TeaTime.Sqlite.Data
{
    public class ShopRepository : BaseRepository, IShopDataAccess
    {
        public IEnumerable<Shop> GetAll()
        {
            using (var conn = TeaTimeDbConnection())
            {
                conn.Open();
                var shops = conn.Query<Shop>("select * from shop");
                return shops;
            }
        }
    }
}
