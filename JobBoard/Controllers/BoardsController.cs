
using Microsoft.AspNetCore.Mvc;
using JobBoards.Models;
using System.Collections.Generic;

namespace JobBoards.Controllers
{
    public class BoardsController : Controller
    {

        [HttpGet("/listings/new")]
        public ActionResult JobForm()
        {
            return View();
        }

        [HttpGet("/SeeListings")]
        public ActionResult SeeListings()
        {
            List<JobBoard> allItems = JobBoard.GetAll();
            return View(allItems);
        }

        [HttpPost("/listings")]
        public ActionResult Index(string newJobTitle, string newCompanyName, string newDescription, string newContactName, string newContactEmail,string newContactPhone)
        {
            JobBoard newJob = new JobBoard(newJobTitle, newCompanyName, newDescription, newCompanyName, newContactEmail, newContactPhone);

            List<JobBoard> allItems = JobBoard.GetAll();
            return View(allItems);
        }
        [HttpPost("/listings/delete")]
        public ActionResult DeleteAll()
        {
            JobBoard.ClearAll();
            return View();
        }
    }
}