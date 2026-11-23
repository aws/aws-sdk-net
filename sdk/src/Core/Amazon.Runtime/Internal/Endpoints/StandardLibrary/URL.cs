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

namespace Amazon.Runtime.Internal.Endpoints.StandardLibrary
{
    /// <summary>
    /// Internal implementation of URL.
    /// Used by standard library functions to parse and validate URLs.
    /// </summary>
    public class URL : PropertyBag
    {
        public override object this[string propertyName]
        {
            get => propertyName switch
            {
                "scheme" => scheme,
                "authority" => authority,
                "path" => path,
                "normalizedPath" => normalizedPath,
                "isIp" => isIp,
                _ => base[propertyName],
            };
            set
            {
                switch (propertyName)
                {
                    case "scheme": scheme = (string)value; break;
                    case "authority": authority = (string)value; break;
                    case "path": path = (string)value; break;
                    case "normalizedPath": normalizedPath = (string)value; break;
                    case "isIp": isIp = (bool)value; break;
                    default: base[propertyName] = value; break;
                }
            }
        }

        /// <summary>
        /// URL scheme
        /// </summary>
        public string scheme { get; set; }

        /// <summary>
        /// URL authority
        /// </summary>
        public string authority { get; set; }

        /// <summary>
        /// URL path
        /// </summary>
        public string path { get; set; }

        /// <summary>
        /// URL normalized path
        /// </summary>
        public string normalizedPath { get; set; }

        /// <summary>
        /// URL is IP address
        /// </summary>
        public bool isIp { get; set; }
    }
}
