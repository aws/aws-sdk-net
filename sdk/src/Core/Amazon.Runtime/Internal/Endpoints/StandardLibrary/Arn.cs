/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Runtime.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Amazon.Runtime.Internal.Endpoints.StandardLibrary
{
    /// <summary>
    /// Internal implementation of ARN (Amazon Resource Name).
    /// Used by standard library functions to parse and validate ARNs.
    /// </summary>
    public class Arn : PropertyBag
    {
        /// <summary>
        /// ARN partition
        /// </summary>
        public string partition
        {
            get { return (string)this["partition"]; }
            set { this["partition"] = value; }
        }

        /// <summary>
        /// ARN service
        /// </summary>
        public string service
        {
            get { return (string)this["service"]; }
            set { this["service"] = value; }
        }

        /// <summary>
        /// ARN region
        /// </summary>
        public string region
        {
            get { return (string)this["region"]; }
            set { this["region"] = value; }
        }

        /// <summary>
        /// ARN accountId
        /// </summary>
        public string accountId
        {
            get { return (string)this["accountId"]; }
            set { this["accountId"] = value; }
        }

        /// <summary>
        /// ARN list of ResourceIDs
        /// </summary>
        public List<string> resourceId
        {
            get { return (List<string>)this["resourceId"]; }
            set { this["resourceId"] = value; }
        }

        /// <summary>
        /// Check if input string is a valid ARN
        /// </summary>
        public static bool IsArn(string arn)
        {
            return arn != null && arn.StartsWith("arn:");
        }

        /// <summary>
        /// Parses the string into an ARN object.
        /// </summary>
        /// <param name="arnString">String to parse into an ARN.</param>
        /// <param name="arn">The out parameter for the ARN object created by TryParse.</param>
        /// <returns>True if the string was parsed into an ARN object.</returns>
        public static bool TryParse(string arnString, out Arn arn)
        {
            try
            {
                if (IsArn(arnString))
                {
                    arn = Parse(arnString);
                    return true;
                }
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception) { }
#pragma warning restore CA1031 // Do not catch general exception types
            arn = null;
            return false;
        }

        /// <summary>
        /// Parses the string into an ARN object.
        /// </summary>
        /// <param name="arnString">String to parse into an Arn.</param>
        /// <returns>The Arn object created from the passed in string.</returns>
        /// <exception cref="ArgumentNullException">Thrown if arnString is null.</exception>
        /// <exception cref="ArgumentException">Thrown if the string passed in not valid ARN.</exception>
        public static Arn Parse(string arnString)
        {
            if (arnString == null)
            {
                throw new ArgumentNullException(nameof(arnString));
            }

            const string malformedErrorMessage = "ARN is in incorrect format. ARN format is: arn:<partition>:<service>:<region>:<account-id>:<resource>";

            var tokens = arnString.Split(new char[] { ':' }, 6);
            if (tokens.Length != 6)
            {
                throw new ArgumentException(malformedErrorMessage);
            }

            if (tokens[0] != "arn")
            {
                throw new ArgumentException(malformedErrorMessage);
            }

            string partition = tokens[1];
            if (string.IsNullOrEmpty(partition))
            {
                throw new ArgumentException("Malformed ARN - no partition specified");
            }
            string service = tokens[2];
            if (string.IsNullOrEmpty(service))
            {
                throw new ArgumentException("Malformed ARN - no service specified");
            }

            string region = tokens[3];
            string accountId = tokens[4];
            string resource = tokens[5];
            if (string.IsNullOrEmpty(resource))
            {
                throw new ArgumentException("Malformed ARN - no resource specified");
            }

            return new Arn
            {
                partition = partition,
                service = service,
                region = region,
                accountId = accountId,
                resourceId = resource.Split(new[] { ':', '/' }).ToList()
            };
        }
    }
}
