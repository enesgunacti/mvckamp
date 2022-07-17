using Business.Concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETGELISTIRMEKAMP.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        ImageFileManager imageFileManager = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var files = imageFileManager.GetImageFileList();
            return View(files);
        }
    }
}