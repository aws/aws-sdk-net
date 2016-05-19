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
        public static Dictionary<string, string> ServiceNamespaceContractions = new Dictionary<string, string>
        {
            {"ElasticLoadBalancing", "ELB"},
            {"ElasticBeanstalk", "EB"},
            {"ElasticMapReduce", "EMR"},
            {"ElasticTranscoder", "ETS"},
            {"SimpleNotificationService", "SNS"},
            {"IdentityManagement", "IAM"},
            {"DatabaseMigrationService", "DMS"},
            {"ApplicationDiscoveryService", "ADS"},
        };

        private static string Fixup(string name)
        {
            var fixedUpName = name.Replace('.', '_');
            // don't use encoded <> in filename, as browsers re-encode it in links to %3C
            // and the link fails
            fixedUpName = fixedUpName.Replace("&lt;", "!").Replace("&gt;", "!");
            fixedUpName = fixedUpName.Replace("Amazon", "");
            fixedUpName = fixedUpName.Replace("_Model_", "");
            fixedUpName = fixedUpName.Replace("_Begin", "");
            fixedUpName = fixedUpName.Replace("_End", "");
            fixedUpName = fixedUpName.Replace("Client_", "");
            fixedUpName = fixedUpName.Replace("_", "");

            foreach (var k in ServiceNamespaceContractions.Keys)
            {
                fixedUpName = fixedUpName.Replace(k, ServiceNamespaceContractions[k]);
            }

            if (fixedUpName.Length > MAX_FILE_SIZE)
            {
                throw new ApplicationException(string.Format("Filename: {0} is too long", fixedUpName));
            }

            return fixedUpName;
        }

        public static string GenerateParametersTail(IList<ParameterInfoWrapper> parameters)
        {
            var sb = new StringBuilder();
            foreach (var parameter in parameters)
            {
                if (sb.Length > 0)
                    sb.Append("_");
                sb.AppendFormat("{0}", Fixup(parameter.ParameterType.GetDisplayName(false)));
            }

            return sb.ToString();
        }

        public static string GenerateFilename(TypeWrapper type)
        {
            return Fixup(string.Format("T_{0}_{1}", type.Namespace, type.Name)) + ".html";
        }

        public static string GenerateFilename(PropertyInfoWrapper info)
        {
            return Fixup(string.Format("P_{0}_{1}_{2}", info.DeclaringType.Namespace, info.DeclaringType.Name, info.Name)) + ".html";
        }

        public static string GenerateFilename(MethodInfoWrapper info)
        {
            return Fixup(string.Format("M_{0}_{1}_{2}_{3}", info.DeclaringType.Namespace, info.DeclaringType.Name, info.Name, GenerateParametersTail(info.GetParameters()))) + ".html";
        }

        public static string GenerateFilename(ConstructorInfoWrapper info)
        {
            return Fixup(string.Format("M_{0}_{1}_{2}_{3}", info.DeclaringType.Namespace, info.DeclaringType.Name, info.Name, GenerateParametersTail(info.GetParameters()))) + ".html";
        }

        public static string GenerateFilename(FieldInfoWrapper info)
        {
            return Fixup(string.Format("F_{0}_{1}_{2}", info.DeclaringType.Namespace, info.DeclaringType.Name, info.Name)) + ".html";
        }

        public static string GenerateFilename(EventInfoWrapper info)
        {
            return Fixup(string.Format("E_{0}_{1}_{2}", info.DeclaringType.Namespace, info.DeclaringType.Name, info.Name)) + ".html";
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
