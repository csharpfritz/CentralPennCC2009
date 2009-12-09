using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace WebApplication1.Controllers
{
    public class HomeController : MyBaseController
    {

        //
        // GET: /Home/

        public ActionResult Index()
        {

            var p = new Person() {FirstName = "Joe", LastName = "BagADonuts"};

            ViewData.Add("css", "style.css");

            var m = new ViewModel<Person>() {model = p, css = "style.css"};

            return View("Index", p);
        }

    }

    public class ViewModel<T>
    {

        public string css { get; set; }
        public T model { get; set; }

    }

    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class MyBaseController : Controller, IWebUI
    {

        public MyBaseController()
        {
            Data = this.GetDAL();
        }


        
        #region Implementation of IWebUI

        /// <summary>
        /// Get access to my data!
        /// </summary>
        public IDataAccessLayer Data { get; private set; }

        #endregion
    }
}
