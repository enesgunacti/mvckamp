using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETGELISTIRMEKAMP.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager contactManager = new ContactManager(new EfContactDal());
        ContactValidator contactValidator = new ContactValidator(); 
        public ActionResult Index()
        {
            var contactValues = contactManager.GetContactList();
            return View(contactValues);
        }
        public ActionResult GetContactResult(int id)
        {
            var contactValues = contactManager.GetById(id);
            return View(contactValues);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}