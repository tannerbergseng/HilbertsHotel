﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HilbertsHotel;
using HilbertsHotel.Models;

namespace HilbertsHotel.Controllers
{
    public class UserController : Controller
    {
        private HotelContext db = new HotelContext();

        // GET: User
       
        public ActionResult Details(int? ID)
        {
            List<Reservation> x = db.Reservations.ToList();
            return View(x);
        }

    }
}