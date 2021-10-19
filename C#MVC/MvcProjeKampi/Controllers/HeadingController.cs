﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading

        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());

        public ActionResult Index()
        {
            var headingValues = hm.GetList();

            return View(headingValues);
        }

        public ActionResult HeadingReport()
        {
            var headingValues = hm.GetList();

            return View(headingValues);
        }

        [HttpGet]
        public ActionResult AddHeading()//drop down listeme methodu
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text=x.CategoryName,
                                                      Value=x.CategoryID.ToString()
                                                  }).ToList();
            List<SelectListItem> valuewriter=(from x in wm.GetList()
                                              select new SelectListItem
                                              {
                                              Text=x.WriterName + " " + x.WriterSurName,
                                              Value = x.WriterID.ToString()
                                              }).ToList();
            ViewBag.vlc = valueCategory;
            ViewBag.vlw = valuewriter;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");

        }
        [HttpGet]
       public ActionResult EditHeading(int id)
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();


            ViewBag.vlc = valueCategory;
            var HeadingValue = hm.GetByID(id);
            return View(HeadingValue);

        }

        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            hm.HeadingUpdate(p);
            return RedirectToAction("Index");

        }

        public ActionResult DeleteHeading(int id)
        {
            var HeadingValue = hm.GetByID(id);
            HeadingValue.HeadingStatus = false;

            hm.HeadingDelete(HeadingValue);
            return RedirectToAction("Index");
        }
    }
}