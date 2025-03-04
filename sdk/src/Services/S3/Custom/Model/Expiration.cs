/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using Amazon.Runtime.Internal.Util;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Defines the expiration policy for a given object.
    /// </summary>
    public partial class Expiration
    {
        private DateTime expiryDate;        
        private string ruleId;

        /// <summary>
        /// The date and time for expiry.
        /// </summary>
        public DateTime ExpiryDate
        {
            get { return this.expiryDate; }
            set { this.expiryDate = value; }
        }

        /// <summary>
        /// Id of the configuration rule for this expiry.
        /// </summary>
        public string RuleId
        {
            get { return this.ruleId; }
            set { this.ruleId = value; }
        }

        /// <summary>
        /// Constructs an empty instance of an Expiration object
        /// </summary>
        public Expiration()
        {
            expiryDate = DateTime.MinValue;
            ruleId = string.Empty;
        }

        private const string ExpiryRegexPattern = "expiry-date=\"(.+?)\"";
        private const string RuleRegexPattern = "rule-id=\"(.+?)\"";

#if NET8_0_OR_GREATER
        [GeneratedRegex(ExpiryRegexPattern)]
        private static partial Regex ExpiryRegex();
        [GeneratedRegex(RuleRegexPattern)]
        private static partial Regex RuleRegex();
#else
        private static Regex ExpiryRegex() => _expiryRegex;
        private static Regex RuleRegex() => _ruleRegex;
        private static readonly Regex _expiryRegex = new Regex(ExpiryRegexPattern);
        private static readonly Regex _ruleRegex = new Regex(RuleRegexPattern);
#endif

        internal Expiration(string headerValue)
        {
            if (string.IsNullOrEmpty(headerValue))
            {
                throw new ArgumentNullException("headerValue");
            }

            // S3 Express returns a "NotImplemented" value instead of the format we're expecting.
            // We'll return without populating the rule ID and expiry date instead of trying to parse the header.
            if (headerValue.Equals("NotImplemented", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            var expiryMatches = ExpiryRegex().Match(headerValue);
            if (expiryMatches.Success && expiryMatches.Groups[1].Success)
            {
                string expiryDateValue = expiryMatches.Groups[1].Value;

                try
                {
                    this.expiryDate = DateTime.ParseExact(expiryDateValue, Amazon.Util.AWSSDKUtils.RFC822DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
                }
                catch (FormatException)
                {
                    var logger = Logger.GetLogger(typeof(Expiration));
                    logger.DebugFormat("Unable to parse expiry-date from: {0}", headerValue);
                }
            }

            var ruleMatches = RuleRegex().Match(headerValue);
            if (ruleMatches.Success && ruleMatches.Groups[1].Success)
            {
                string ruleIdValue = ruleMatches.Groups[1].Value;
                this.ruleId = UrlDecode(ruleIdValue);
            }
        }

        private static string UrlDecode(string url)
        {
            string decoded = Uri.UnescapeDataString(url).Replace("+", " ");
            return decoded;
        }
    }
}
