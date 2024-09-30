﻿using Microsoft.AspNetCore.Mvc;
using RealEstateAuction.DAL;
using RealEstateAuction.Models;
using System.Diagnostics;

namespace RealEstateAuction.Controllers
{
    public class HomeController : Controller
    {
        private readonly AuctionRepository auctionDAO;

        public HomeController(ILogger<HomeController> logger)
        {
            auctionDAO = new AuctionRepository();
        }
        [Route("")]
        [Route("home")]
        public IActionResult Index()
        {
            //get 6 auction recently to display on hompage
            List<Auction> auctionRecent = auctionDAO.GetAuctionRecently(6);

            return View(auctionRecent);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}