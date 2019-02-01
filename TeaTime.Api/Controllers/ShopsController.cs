using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeaTime.Api.Models;

namespace TeaTime.Api.Controllers
{
    public class ShopsController : ApiController
    {
        private IEnumerable<Shop> _testShops = new List<Shop>
        {
            new Shop { Id = "HelBrown", Name = "桃分伯朗", Phone = "033597567" },
            new Shop { Id = "LnkBrown", Name = "林口伯朗", Phone = "032110056" }
        };

        public IEnumerable<Shop> GetAllShops()
        {
            return _testShops;
        }

        public IHttpActionResult GetShop(string id)
        {
            var shop = _testShops.FirstOrDefault(s => s.Id == id);
            if (shop == null)
            {
                return NotFound();
            }

            return Ok(shop);
        }
    }
}
