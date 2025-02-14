using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace AWSSDK.UnitTests
{
    public static class SpecMarkdownTestDataHelper
    {
        public static string StandardDataClean(this string s)
        {
            // normalize spacing

            var replacements = new Dictionary<string, string>
            {
                {"-", ""},
                {"none", ""},
                {@"N\/A", ""},
                {@"n\/a", ""},
                {"yes", "true"},
                {"Yes", "true"},
                {"no", "false"},
                {"No", "false"},
                {"null", ""}
            };

            foreach (var replacement in replacements)
                // use a regex to match markdown column separators
                s = Regex.Replace(s, $@"\|\s*{replacement.Key}", $"| {replacement.Value}");

            return s;
        }

        public static IEnumerable<object[]> ParseMarkdownTable(this string s)
        {
            return s
                // split into rows
                .Split(new [] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                // split each row into columns
                .Where(r => r.ToCharArray().Any(char.IsLetterOrDigit)) // remove empty rows
                .Select(r => 
                    r.Split('|')
                        .Skip(1) // skip first column, it's whitespace padding
                        .Reverse().Skip(1).Reverse() //skip last column,  it's whitespace padding
                        .Select(c => c.Trim())
                        .ToArray());
        }

        /// <summary>
        /// Example: amz-outpost-id: "op-01234567890123456", x-amz-account-id: "123456789012"
        /// </summary>
        public static IDictionary<string, string> ParseExpectedHeaders(string rawHeaders)
        {
            var pairs = rawHeaders.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);

            return pairs
                .Select(pair =>
                {
                    var parts = pair.Split(new[] {':'});
                    return new KeyValuePair<string, string>(parts[0], parts[1].Replace("\"", "").Trim());
                })
                .ToDictionary(k => k.Key, v => v.Value);
        }
    }
}