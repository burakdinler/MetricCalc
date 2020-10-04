using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using WebUI.Library;
using WebUI.Models.Enums;
using WebUI.Models.PageModel;
using WebUI.Models.Results;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(HomeModel model)
        {
            ResultModel resultModel = Calculations.ApiResults(model.Component, model.UrlType);
            Session["component"] = model.Component;
            return RedirectToAction("Results", resultModel);
        }

        public ActionResult Results(ResultModel model)
        {
            ViewBag.Component = Session["component"].ToString();

            model.SecurityResult = 4- ((((model.SecurityRemediationEffort - model.Vulnerabilities) / model.SecurityRemediationEffort)) / 4);

            model.TestsResult = model.UnitTestSuccessDensity == 0 ? 4m : (model.UnitTestSuccessDensity / 25)/4 ;

            model.ReliabilityResult = 4- ((((model.ReliabilityRmediationEffort -model.Bugs )/ model.ReliabilityRmediationEffort)) / 4);
            decimal complexityRatio = (((model.Complexity - model.LinesOfCode )/ model.LinesOfCode)/4);
            decimal cognitiveComplexityRatio = (((model.Statements -model.CognitiveComplexity) / model.Statements)/4);
            decimal complexityPoint = 4 - complexityRatio;
            decimal cognitiveComplexityPoint = 4 - cognitiveComplexityRatio;

            model.ComplexityResult =  ((complexityPoint + cognitiveComplexityPoint)/10)*4;
            decimal duplicatedFileRatio = 4 -((model.Files -model.DuplicatedFiles )/ model.Files);
            decimal duplicatedLineRatio = 4-((model.LinesOfCode -model.DuplicatedLines )/ model.LinesOfCode);

            model.DuplactionsResult =  (((duplicatedFileRatio + duplicatedLineRatio) / 2));

            model.MaintainabilityResult =  (4- (((model.TechnicalDebt- model.CodeSmells) / model.TechnicalDebt)));

            decimal issueResult = 0m;
            if (model.BlockerIssues > 0)
            {
                issueResult = 1m;
            }
            else if (model.CriticalIssues > 0)
            {
                issueResult = 1.5m;
            }
            else if (model.MajorIssues > 0)
            {
                issueResult = 2m;
            }
            else if (model.MinorIssues > 0)
            {
                issueResult = 2.5m;
            }
            else if (model.InfoIssues > 0)
            {
                issueResult = 3m;
            }
            else
            {
                issueResult = 4m;
            }
            model.IssuesResult = issueResult;

            decimal sizeResult = 0m;
            if (model.LinesOfCode < 1000)
            {
                sizeResult = 4m;
            }
            else if (model.LinesOfCode >= 1000 && model.LinesOfCode < 10000)
            {
                sizeResult = 3m;
            }
            else if (model.LinesOfCode >= 10000 && model.LinesOfCode < 100000)
            {
                sizeResult = 2m;
            }
            else
            {
                sizeResult = 1m;
            }
            model.SizeResult = sizeResult;

            List<decimal> resultSet = new List<decimal>();
            resultSet.Add(model.SecurityResult);
            resultSet.Add(model.TestsResult);
            resultSet.Add(model.ReliabilityResult);
            resultSet.Add(model.ComplexityResult);
            resultSet.Add(model.DuplactionsResult);
            resultSet.Add(model.MaintainabilityResult);
            resultSet.Add(model.IssuesResult);
            resultSet.Add(model.SizeResult);

            decimal average = resultSet.Average();

            model.AnalyseResult = Convert.ToDecimal(average);


            return View(model);
        }
    }
}