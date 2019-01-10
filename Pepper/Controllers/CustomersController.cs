﻿using Pepper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pepper.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer{Name = "ABC", Id = 1},
            new Customer{Name = "CDE", Id = 2}
        };

        // GET: Customers
        public ActionResult Index()
        {
            
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);

        }
    }
}