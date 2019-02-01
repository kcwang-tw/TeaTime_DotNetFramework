using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TeaTime.Core.Entities;
using TeaTime.Core.Interfaces;

namespace TeaTime.Api.Controllers
{
    public class ShopsController : ApiController
    {
        private readonly IShopDataAccess _shopData;

        public ShopsController(IShopDataAccess shopData)
        {
            _shopData = shopData;
        }

        public IEnumerable<Shop> GetAllShops()
        {
            var shops = _shopData.GetAll();
            return shops;
        }

        public IHttpActionResult GetShop(string id)
        {
            var shop = _shopData.GetAll().FirstOrDefault(s => s.Id == id);
            if (shop == null)
            {
                return NotFound();
            }

            return Ok(shop);
        }
    }
}
