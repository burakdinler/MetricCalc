using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc.Html;
using WebUI.Models.Enums;
using WebUI.Models.Responses;
using WebUI.Models.Results;

namespace WebUI.Library
{
    public static class Calculations
    {
        #region CallOperations
        public static string ApiURL(string component, UrlType urlType)
        {
            string apiUrl = Operations.ApiUrl(urlType);
            string apiFunc = "/measures/component?metricKeys=";
            List<MetricKeys> metricKeys = new KeyRepository().MetricKeys();

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);
            return url;
        }
        #endregion

        #region ApiResultCaller
        public static ResultModel ApiResults(string component, UrlType urlType)
        {
            string apiURL = ApiURL(component,urlType);

            var response = Operations.webResponse(Operations.webRequest(apiURL)).GetResponseStream();
            StreamReader reader = new StreamReader(response);

            var jResult = JsonConvert.DeserializeObject<RootObject>(reader.ReadToEnd().ToString()).component.measures;
            ResultModel result = new ResultModel();
            foreach (var item in jResult)
            {
                switch (item.metric)
                {
                    case "complexity":
                        result.Complexity = convertVal(item.value);
                        break;
                    case "cognitive_complexity":
                        result.CognitiveComplexity = convertVal(item.value);
                        break;
                    case "duplicated_blocks":
                        result.DuplicatedBlocks = convertVal(item.value);
                        break;
                    case "duplicated_files":
                        result.DuplicatedFiles = convertVal(item.value);
                        break;
                    case "duplicated_lines":
                        result.DuplicatedLines = convertVal(item.value);
                        break;
                    case "duplicated_lines_density":
                        result.DuplicatedLineDensity = convertVal(item.value);
                        break;
                    case "violations":
                        result.Issues = convertVal(item.value);
                        break;
                    case "blocker_violations":
                        result.BlockerIssues = convertVal(item.value);
                        break;
                    case "critical_violations":
                        result.CriticalIssues = convertVal(item.value);
                        break;
                    case "major_violations":
                        result.MajorIssues = convertVal(item.value);
                        break;
                    case "minor_violations":
                        result.MinorIssues = convertVal(item.value);
                        break;
                    case "info_violations":
                        result.InfoIssues = convertVal(item.value);
                        break;
                    case "code_smells":
                        result.CodeSmells = convertVal(item.value);
                        break;
                    case "sqale_rating":
                        result.MaintainabilityRating = convertVal(item.value);
                        break;
                    case "sqale_index":
                        result.TechnicalDebt = convertVal(item.value);
                        break;
                    case "sqale_debt_ratio":
                        result.TechnicalDebtRatio = convertVal(item.value);
                        break;
                    case "alert_status":
                        result.QualityGateStatus = convertVal(item.value);
                        break;
                    case "bugs":
                        result.Bugs = convertVal(item.value);
                        break;
                    case "new_bugs":
                        result.NewBugs = convertVal(item.value);
                        break;
                    case "reliability_rating":
                        result.ReliabilityRating = convertVal(item.value);
                        break;
                    case "reliability_remediation_effort":
                        result.ReliabilityRmediationEffort = convertVal(item.value);
                        break;
                    case "vulnerabilities":
                        result.Vulnerabilities = convertVal(item.value);
                        break;
                    case "security_rating":
                        result.SecurityRating = convertVal(item.value);
                        break;
                    case "security_remediation_effort":
                        result.SecurityRemediationEffort = convertVal(item.value);
                        break;
                    case "security_hotspots":
                        result.SecurityHotspots = convertVal(item.value);
                        break;
                    case "security_review_rating":
                        result.SecurityReviewRating = convertVal(item.value);
                        break;
                    case "classes":
                        result.Classes = convertVal(item.value);
                        break;
                    case "comment_lines":
                        result.CommentLines = convertVal(item.value);
                        break;
                    case "comment_lines_density":
                        result.CommentDensity = convertVal(item.value);
                        break;
                    case "files":
                        result.Files = convertVal(item.value);
                        break;
                    case "lines":
                        result.Lines = convertVal(item.value);
                        break;
                    case "ncloc":
                        result.LinesOfCode = convertVal(item.value);
                        break;
                    case "ncloc_language_distribution":
                        result.LinesOfCodePerLanguage = item.value;
                        break;
                    case "functions":
                        result.Functions = convertVal(item.value);
                        break;
                    case "statements":
                        result.Statements = convertVal(item.value);
                        break;
                    case "test_success_density":
                        result.UnitTestSuccessDensity = convertVal(item.value);
                        break;
                    default:
                        break;
                }
            }
            return result;
        }
        #endregion

        public static decimal convertVal(string str)
        {
            decimal value = 0m;
            str = str.Replace(".", ",");
            decimal.TryParse(str, out value);
            return value;
        }
    }
}