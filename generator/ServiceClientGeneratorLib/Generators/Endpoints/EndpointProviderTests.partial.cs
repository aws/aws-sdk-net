using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ServiceClientGenerator.Generators.Endpoints
{
    public partial class EndpointProviderTests
    {
        // all non-alphanumeric and undescores
        private static readonly Regex regex = new Regex("[^a-zA-Z0-9_]");

        /// <summary>
        /// Converts test's documentation to a valid unique test function name.
        /// e.g. "invalid access point ARN: Not S3" -> "Invalid_access_point_ARN_Not_S3_e54f317d56234714a52e6e6062b7d188".
        /// "42 is the ultimate answer" -> "_42_is_the_ultimate_answer_e54f317d56234714a52e6e6062b7d177".
        /// </summary>
        public string ToTestName(string documentation)
        {
            documentation = documentation.Trim().Replace(" ", "_") + "_" + Guid.NewGuid();
            if (char.IsDigit(documentation.First()))
            {
                documentation = "_" + documentation;
            }
            return regex
                .Replace(documentation, string.Empty)
                .Replace("__", "_")
                .ToUpperFirstCharacter();
        }
    }
}
