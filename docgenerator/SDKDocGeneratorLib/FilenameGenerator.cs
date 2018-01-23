using System;
using System.Collections.Generic;
using System.Text;

namespace SDKDocGenerator
{
    public class FilenameGenerator
    {
        private const int MAX_FILE_SIZE = 160;

        // we shorten some namespaces to avoid hitting folder name limits in Windows. We need
        // to know this info when generating filenames as well as generating cross-service
        // urls
        public static Dictionary<string, string> ServiceNamespaceContractions = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
        {
            {"ElasticLoadBalancing", "ELB"},
            {"ElasticBeanstalk", "EB"},
            {"ElasticMapReduce", "EMR"},
            {"ElasticTranscoder", "ETS"},
            {"SimpleNotificationService", "SNS"},
            {"IdentityManagement", "IAM"},
            {"DatabaseMigrationService", "DMS"},
            {"ApplicationDiscoveryService", "ADS"},
            {"SimpleSystemsManagement", "SSM"},
        };

        // Where possible we use a fully namespaced name as key to avoid confusing same-named
        // shapes from different services that may or may not differ in casing only, eg
        // HttpHeader in CognitoIdentityProvider vs HTTPHeader in WAF/WAFRegional. We also use
        // case sensitive comparison in the unlikely event a service introduces shapes with
        // the same name differing only in case.
        private static readonly Dictionary<string, string> FixedupNameDictionary = new Dictionary<string, string>(StringComparer.Ordinal);

        private static string Fixup(string name, TypeWrapper type = null)
        {
            var lookupKey = type == null ? name : string.Concat(type.Namespace, ".", name);
            string fixedUpName;
            if (FixedupNameDictionary.TryGetValue(lookupKey, out fixedUpName))
            {
                return fixedUpName;
            }

            var sb = new StringBuilder(name);

            // don't use encoded <> in filename, as browsers re-encode it in links to %3C
            // and the link fails
            sb.Replace('.', '_')
                .Replace("&lt;", "!")
                .Replace("&gt;", "!")
                .Replace("Amazon", "")
                .Replace("_Model_", "")
                .Replace("_Begin", "")
                .Replace("_End", "")
                .Replace("Client_", "")
                .Replace("+", "")
                .Replace("_", "");

            foreach (var k in ServiceNamespaceContractions.Keys)
            {
                sb.Replace(k, ServiceNamespaceContractions[k]);
            }

            if (sb.Length > MAX_FILE_SIZE)
            {
                throw new ApplicationException(string.Format("Filename: {0} is too long", sb));
            }

            fixedUpName = sb.ToString();
            FixedupNameDictionary[lookupKey] = fixedUpName;
            return fixedUpName;
        }

        public static string GenerateParametersTail(IList<ParameterInfoWrapper> parameters)
        {
            var sb = new StringBuilder();
            foreach (var parameter in parameters)
            {
                if (sb.Length > 0)
                    sb.Append("_");
                sb.AppendFormat("{0}", Fixup(parameter.ParameterType.GetDisplayName(false), parameter.ParameterType));
            }

            return sb.ToString();
        }

        public static string GenerateFilename(TypeWrapper type)
        {
            return Fixup(string.Format("T_{0}", type.Name), type) + ".html";
        }

        public static string GenerateFilename(PropertyInfoWrapper info)
        {
            return Fixup(string.Format("P_{0}_{1}", info.DeclaringType.Name, info.Name), info.DeclaringType) + ".html";
        }

        public static string GenerateFilename(MethodInfoWrapper info)
        {
            return Fixup(string.Format("M_{0}_{1}_{2}", info.DeclaringType.Name, info.Name, GenerateParametersTail(info.GetParameters())), info.DeclaringType) + ".html";
        }

        public static string GenerateFilename(ConstructorInfoWrapper info)
        {
            return Fixup(string.Format("M_{0}_{1}_{2}", info.DeclaringType.Name, info.Name, GenerateParametersTail(info.GetParameters())), info.DeclaringType) + ".html";
        }

        public static string GenerateFilename(FieldInfoWrapper info)
        {
            return Fixup(string.Format("F_{0}_{1}", info.DeclaringType.Name, info.Name), info.DeclaringType) + ".html";
        }

        public static string GenerateFilename(EventInfoWrapper info)
        {
            return Fixup(string.Format("E_{0}_{1}", info.DeclaringType.Name, info.Name), info.DeclaringType) + ".html";
        }

        public static string GenerateNamespaceFilename(string namespaceName)
        {
            return Fixup(string.Format("N_{0}", namespaceName)) + ".html";
        }

        public static string Escape(string url)
        {
            return url.Replace("`", "&#96;");
        }
    }
}
