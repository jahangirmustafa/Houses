using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Houses.Models;
using System.Diagnostics;

namespace Houses.Controllers
{
    public class AgentProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }                

        [HttpGet]
        public IActionResult GetPastSale()
        {
            var data = GetPastSaleData();
            return Json(data);
        }


        #region Helper Methods

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<PastSale> GetPastSaleData()
        {
            var data = new List<PastSale>();

            data.Add(new PastSale { Id = 1, Price = "$900,000", Location = "Jamul, CA", Address = "3247 Greystone Dr • Jamul, CA 91935", Info = "7 bed, 4 bath, 6,150 sqft", SoldDate = DateTime.Parse("09/12/2017"), ImagePath = "images/property/home5.jpg", Represented = RepresentedEnum.Seller.ToString() });
            data.Add(new PastSale { Id = 2, Price = "$490,000", Location = "Santee, CA", Address = "5160 Alzeda Dr • La Mesa, CA 91941", Info = "7 bed, 4 bath, 6,150 sqft", SoldDate = DateTime.Parse("07/11/2017"), ImagePath = "images/property/home4.jpg", Represented = RepresentedEnum.Buyer.ToString() });
            data.Add(new PastSale { Id = 3, Price = "$790,000", Location = "Santee, CA", Address = "3247 Greystone Dr • Jamul, CA 91935", Info = "7 bed, 4 bath, 6,150 sqft", SoldDate = DateTime.Parse("09/12/2017"), ImagePath = "images/property/home6.jpg", Represented = RepresentedEnum.Seller.ToString() });
            data.Add(new PastSale { Id = 4, Price = "$529,000", Location = "Jamul, CA", Address = "5160 Alzeda Dr • La Mesa, CA 91941", Info = "7 bed, 4 bath, 6,150 sqft", SoldDate = DateTime.Parse("09/12/2017"), ImagePath = "images/property/home7.jpg", Represented = RepresentedEnum.Buyer.ToString() });
            data.Add(new PastSale { Id = 5, Price = "$7729,000", Location = "Santee, CA", Address = "3247 Greystone Dr • Jamul, CA 91935", Info = "7 bed, 4 bath, 6,150 sqft", SoldDate = DateTime.Parse("07/11/2017"), ImagePath = "images/property/home12.jpg", Represented = RepresentedEnum.Buyer.ToString() });
            data.Add(new PastSale { Id = 6, Price = "$229,000", Location = "Jamul, CA", Address = "5160 Alzeda Dr • La Mesa, CA 91941", Info = "7 bed, 4 bath, 6,150 sqft", SoldDate = DateTime.Parse("09/12/2017"), ImagePath = "images/property/home5.jpg", Represented = RepresentedEnum.Seller.ToString() });
            data.Add(new PastSale { Id = 7, Price = "$555,000", Location = "Santee, CA", Address = "3247 Greystone Dr • Jamul, CA 91935", Info = "7 bed, 4 bath, 6,150 sqft", SoldDate = DateTime.Parse("07/11/2017"), ImagePath = "images/property/home7.jpg", Represented = RepresentedEnum.Seller.ToString() });
            data.Add(new PastSale { Id = 8, Price = "$1,265,000", Location = "Jamul, CA", Address = "3247 Greystone Dr • Jamul, CA 91935", Info = "7 bed, 4 bath, 6,150 sqft", SoldDate = DateTime.Parse("09/12/2017"), ImagePath = "images/property/home6.jpg", Represented = RepresentedEnum.Buyer.ToString() });

            return data;
        }

        #endregion

    }
}