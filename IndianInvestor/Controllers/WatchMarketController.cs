using AutoMapper;
using IndianInvestor.Contract;
using IndianInvestor.Data;
using IndianInvestor.Models;
using IndianInvestor.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianInvestor.Controllers
{
    public class WatchMarketController : Controller
    {
        private readonly IAdminRepository _adminrepo;
        private readonly IMapper _mapper;
        public WatchMarketController(IAdminRepository adminrepo,IMapper mapper)
        {
            _adminrepo = adminrepo;
            _mapper = mapper;

        }
        // GET: MarketController
        public ActionResult Index()
        {
            return View();
            
        }
        public ActionResult WatchMarket()
        {
            var stocklist = _adminrepo.Findall().ToList();
            var model = _mapper.Map<List<Admin>, List<AdminMV>>(stocklist);
            return View(model);

        }

        // GET: MarketController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MarketController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MarketController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MarketController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MarketController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MarketController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MarketController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
