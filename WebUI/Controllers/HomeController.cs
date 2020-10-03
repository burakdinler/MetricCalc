using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Library;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Calculations.Complexity();
            Calculations.CognitiveComplexity();
            Calculations.DuplicatedFiles();
            Calculations.DuplicatedBlocks();
            Calculations.DuplicatedLineDensity();
            Calculations.CodeSmells();
            Calculations.MaintainabilityRating();
            Calculations.TechnicalDebtRatio();
            Calculations.Bugs();
            Calculations.ReliabilityRating();
            Calculations.Vulnerabilities();
            Calculations.SecurityRating();
            Calculations.SecurityHotspots();
            Calculations.SecurityReviewRating();
            Calculations.Classes();
            Calculations.CommentDensity();
            Calculations.LinesOfCode();
            Calculations.Coverage();
            Calculations.UnitTestSuccessDensity();

            return View();
        }
    }
}