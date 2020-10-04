using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models.Results
{
    public class ResultModel
    {
        public decimal Complexity { get; set; }
        public decimal CognitiveComplexity { get; set; }
        public decimal DuplicatedBlocks { get; set; }
        public decimal DuplicatedFiles { get; set; }
        public decimal DuplicatedLines { get; set; }
        public decimal DuplicatedLineDensity { get; set; }
        public decimal Issues { get; set; }
        public decimal BlockerIssues { get; set; }
        public decimal CriticalIssues { get; set; }
        public decimal MajorIssues { get; set; }
        public decimal MinorIssues { get; set; }
        public decimal InfoIssues { get; set; }
        public decimal CodeSmells { get; set; }
        public decimal MaintainabilityRating { get; set; }
        public decimal TechnicalDebt { get; set; }
        public decimal TechnicalDebtRatio { get; set; }
        public decimal QualityGateStatus { get; set; }
        public decimal Bugs { get; set; }
        public decimal NewBugs { get; set; }
        public decimal ReliabilityRating { get; set; }
        public decimal ReliabilityRmediationEffort { get; set; }
        public decimal Vulnerabilities { get; set; }
        public decimal SecurityRating { get; set; }
        public decimal SecurityRemediationEffort { get; set; }
        public decimal SecurityHotspots { get; set; }
        public decimal SecurityReviewRating { get; set; }
        public decimal Classes { get; set; }
        public decimal CommentLines { get; set; }
        public decimal CommentDensity { get; set; }
        public decimal Files { get; set; }
        public decimal Lines { get; set; }
        public decimal LinesOfCode { get; set; }
        public string LinesOfCodePerLanguage { get; set; }
        public decimal Functions { get; set; }
        public decimal Statements { get; set; }
        public decimal UnitTestSuccessDensity { get; set; }

        //Calculated Values

        public decimal AnalyseResult { get; set; }
        public decimal ComplexityResult { get; set; }
        public decimal DuplactionsResult { get; set; }
        public decimal MaintainabilityResult { get; set; }
        public decimal ReliabilityResult { get; set; }
        public decimal SecurityResult { get; set; }
        public decimal SizeResult { get; set; }
        public decimal TestsResult { get; set; }
        public decimal IssuesResult { get; set; }
    }
}