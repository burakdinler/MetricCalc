using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Models.Results;

namespace WebUI.Library
{
    public class KeyRepository
    {
        public List<MetricKeys> MetricKeys()
        {
            List<MetricKeys> metricKeys = new List<MetricKeys>();
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Complexity", KeyTitle = "Complexity ", KeyName = "complexity" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Complexity", KeyTitle = "Cognitive Complexity", KeyName = "cognitive_complexity" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Duplications", KeyTitle = "Duplicated blocks", KeyName = "duplicated_blocks" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Duplications", KeyTitle = "Duplicated files", KeyName = "duplicated_files" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Duplications", KeyTitle = "Duplicated lines", KeyName = "duplicated_lines" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Duplications", KeyTitle = "Duplicated lines (%) ", KeyName = "duplicated_lines_density" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Issues", KeyTitle = "Issues ", KeyName = "violations" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Issues", KeyTitle = "Blocker issues", KeyName = "blocker_violations" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Issues", KeyTitle = "Critical issues", KeyName = "critical_violations" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Issues", KeyTitle = "Major issues", KeyName = "major_violations" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Issues", KeyTitle = "Minor issues", KeyName = "minor_violations" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Issues", KeyTitle = "Info issues", KeyName = "info_violations" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Maintainability", KeyTitle = "Code Smells", KeyName = "code_smells" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Maintainability", KeyTitle = "Maintainability Rating", KeyName = "sqale_rating" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Maintainability", KeyTitle = "Technical Debt", KeyName = "sqale_index" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Maintainability", KeyTitle = "Technical Debt Ratio", KeyName = "sqale_debt_ratio" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Quality Gates", KeyTitle = "Quality Gate Status", KeyName = "alert_status" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Reliability", KeyTitle = "Bugs ", KeyName = "bugs" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Reliability", KeyTitle = "Reliability Rating", KeyName = "reliability_rating" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Reliability", KeyTitle = "Reliability remediation effort", KeyName = "reliability_remediation_effort" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Security", KeyTitle = "Vulnerabilities ", KeyName = "vulnerabilities" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Security", KeyTitle = "Security Rating", KeyName = "security_rating" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Security", KeyTitle = "Security remediation effort", KeyName = "security_remediation_effort" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Security", KeyTitle = "Security Hotspots", KeyName = "security_hotspots" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Security", KeyTitle = "Security Review Rating", KeyName = "security_review_rating" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Size", KeyTitle = "Classes ", KeyName = "classes" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Size", KeyTitle = "Comment lines", KeyName = "comment_lines" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Size", KeyTitle = "Comments (%)", KeyName = "comment_lines_density" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Size", KeyTitle = "Files ", KeyName = "files" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Size", KeyTitle = "Lines ", KeyName = "lines" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Size", KeyTitle = "Lines of code", KeyName = "ncloc" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Size", KeyTitle = "Lines of code per language", KeyName = "ncloc_language_distribution" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Size", KeyTitle = "Functions ", KeyName = "functions" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Size", KeyTitle = "Statements ", KeyName = "statements" });
            metricKeys.Add(new Models.Results.MetricKeys { KeyBranch = "Tests", KeyTitle = "Unit test success density (%) ", KeyName = "test_success_density" });
            return metricKeys;
        }

    }
}