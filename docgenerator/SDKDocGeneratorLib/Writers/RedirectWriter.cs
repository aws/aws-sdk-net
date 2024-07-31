using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace SDKDocGenerator
{
    #region rules
    public abstract class RewriteRuleBase
    {
        public string Pattern;
        public string Substitution;
        public string Flags;

        public static string RuleName = "RewriteRule";

        public override string ToString()
        {
            return string.Format(@"{0} {1} ""{2}"" {3}", RuleName, Pattern, Substitution, Flags);
        }

        public int CompareTo(object obj)
        {
            return this.ToString().CompareTo(obj.ToString());
        }
    }

    public class RewriteRule : RewriteRuleBase, IComparable
    {
        public RewriteRule(string pattern, string substitution)
        {
            Pattern = pattern;
            Substitution = substitution;
            Flags = "[L,R,NE]";
        }
    }
    #endregion

    public static class SDKDocRedirectWriter
    {
        public const string RedirectFileName = @"package.redirects.conf";
        public const string DocPathPrefix    = @"/sdkfornet/v4/apidocs/index.html?page=";
        public const string ToolId           = @"DotNetSDKV4";
        
        private static Regex UrlPattern = new Regex(".*/WebAPI/(.*)/(.*)");
        private static IDictionary<string, ISet<RewriteRule>> _rulesForServices = new SortedDictionary<string, ISet<RewriteRule>>();

        public static void Write(Stream stream)
        {
            using (StreamWriter writer = new StreamWriter(stream))
            {
                int totalRuleCount = 0;
                foreach (var service in _rulesForServices)
                {
                    totalRuleCount += service.Value.Count;
                }

                // skip rule for all rules
                writer.WriteLine(@"RewriteCond ""%{REQUEST_URI}"" ""!^/goto/DotNetSDKV4/""");
                writer.WriteLine(string.Format(@"RewriteRule "".?"" ""-"" [S={0}]", totalRuleCount));

                foreach (var service in _rulesForServices)
                {
                    foreach (var rule in service.Value)
                    {
                        writer.WriteLine(rule.ToString());
                    }
                }
            }
        }

        public static bool ExtractServiceIDAndShapeFromUrl(string link, out string serviceId, out string shape)
        {
            Match match = UrlPattern.Match(link);
            if (match.Success && match.Groups.Count == 3)
            {
                serviceId = match.Groups[1].ToString();
                shape = match.Groups[2].ToString();

                return true;
            }
            else
            {
                serviceId = "";
                shape = "";

                System.Console.WriteLine("** Failed to match : " + link);
            }

            return false;
        }

        public static void AddRule(string serviceId, string shape, string docPath)
        {
            string requestedPath = string.Format("^/goto/{0}/{1}/{2}$", ToolId, serviceId, shape);

            ISet<RewriteRule> set;
            if (!_rulesForServices.TryGetValue(serviceId, out set))
            {
                set = new SortedSet<RewriteRule>();
                _rulesForServices.Add(serviceId, set);
            }

            set.Add(new RewriteRule(requestedPath, docPath));
        }
    }
}