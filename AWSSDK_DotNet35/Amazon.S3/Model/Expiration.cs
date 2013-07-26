/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Defines the expiration policy for a given object.
    /// </summary>
    public class Expiration
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


        private static Regex expiryRegex = new Regex("expiry-date=\"(.+?)\"");
        private static Regex ruleRegex = new Regex("rule-id=\"(.+?)\"");

        internal Expiration(string headerValue)
        {
            if (string.IsNullOrEmpty(headerValue))
                throw new ArgumentNullException("headerValue");

            var expiryMatches = expiryRegex.Match(headerValue);
            if (!expiryMatches.Success || !expiryMatches.Groups[1].Success)
                throw new InvalidOperationException("No Expiry Date match");
            string expiryDateValue = expiryMatches.Groups[1].Value;
            DateTime expiryDate = DateTime.ParseExact(expiryDateValue, Amazon.Util.AWSSDKUtils.RFC822DateFormat, CultureInfo.InvariantCulture);

            var ruleMatches = ruleRegex.Match(headerValue);
            if (!ruleMatches.Success || !ruleMatches.Groups[1].Success)
                throw new InvalidOperationException("No Rule Id match");
            string ruleIdValue = ruleMatches.Groups[1].Value;
            string ruleId = UrlDecode(ruleIdValue);

            this.expiryDate = expiryDate;
            this.ruleId = ruleId;
        }

        private static string UrlDecode(string url)
        {
            string decoded = Uri.UnescapeDataString(url).Replace("+", " ");
            return decoded;
        }
    }
}
