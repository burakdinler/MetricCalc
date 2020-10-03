using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Library
{
    public static class Calculations
    {
        #region Complexity
        public static int Complexity()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "complexity" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }

        public static int CognitiveComplexity()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "cognitive_complexity" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }
        #endregion

        #region Duplications
        public static int DuplicatedFiles()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "duplicated_files" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }
        public static int DuplicatedBlocks()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "duplicated_blocks" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }

        public static decimal DuplicatedLineDensity()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "duplicated_lines_density" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0m;
        }
        #endregion

        #region Maintainability
        public static int CodeSmells()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "code_smells" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }

        public static decimal MaintainabilityRating()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "sqale_rating" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0m;
        }

        public static decimal TechnicalDebtRatio()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "sqale_debt_ratio" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0m;
        }


        #endregion

        #region Reliability
        public static int Bugs()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "bugs" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }

        public static int ReliabilityRating()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "reliability_rating" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }

        #endregion

        #region Security

        public static int Vulnerabilities()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "vulnerabilities" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }

        public static decimal SecurityRating()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "security_rating" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }

        public static int SecurityHotspots()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "security_hotspots" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }
        public static decimal SecurityReviewRating()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "security_review_rating" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }

        #endregion

        #region Size

        public static int Classes()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "classes" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }

        public static decimal CommentDensity()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "comment_lines_density" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }

        public static int LinesOfCode()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "ncloc" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }

        #endregion

        #region Tests

        public static int Coverage()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "coverage" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;

        }
        
        public static decimal UnitTestSuccessDensity()
        {
            string apiUrl = Operations.ApiUrl(Models.Enums.UrlType.CLOUD);
            string apiFunc = "/measures/component?metricKeys=";
            string[] metricKeys = { "test_success_density" };
            string component = "hahanov_hahanov.github.io";

            string url = Operations.UrlBuild(apiUrl, apiFunc, metricKeys, component);

            return 0;
        }

        #endregion
    }
}