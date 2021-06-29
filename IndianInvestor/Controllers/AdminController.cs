using AutoMapper;
using IndianInvestor.Contract;
using IndianInvestor.Data;
using IndianInvestor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IndianInvestor.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminRepository _adminrepo;
        private readonly IMapper _mapper;
        public AdminController(IAdminRepository adminrepo,IMapper mapper)
        {
            _adminrepo = adminrepo;
            _mapper = mapper;

        }
        public ActionResult Index()
        {
            var admin = _adminrepo.Findall().ToList();
            var model = _mapper.Map<List<Admin>, List<AdminMV>>(admin);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<List<Admin>> Create(IFormFile file)
        {
           
            var list = new List<Admin>().ToList();
            
           
           
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"]; //sheet1 is name 
                    var rowcount = worksheet.Dimension.Rows;
                    for (int row = 6; row <=rowcount; row++)
                    {
                        list.Add(new Admin
                        {
                            ID = worksheet.Cells[row,1].Value.ToString().Trim(),
                            SecurityCode = worksheet.Cells[row, 2].Value.ToString().Trim(),
                            CompanyName = worksheet.Cells[row, 3].Value.ToString().Trim(),
                            Price = worksheet.Cells[row, 4].Value.ToString().Trim(),
                            MarketCap = worksheet.Cells[row, 5].Value.ToString().Trim(),
                           


                        }) ;
                    }
                    foreach (Admin admin in list)   // inserting the data in table
                    {
                        _adminrepo.Create(admin);
                    }
                }
            }
            return list;
            
        }
        // GET: Admin/Details/5
        public ActionResult Details()
        {
            return View();
        }

        
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
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

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
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
