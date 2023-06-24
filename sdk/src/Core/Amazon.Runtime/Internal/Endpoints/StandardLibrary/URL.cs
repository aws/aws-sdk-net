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
        /// <summary>
        /// URL scheme
        /// </summary>
        public string scheme
        {
            get { return (string)this["scheme"]; }
            set { this["scheme"] = value; }
        }

        /// <summary>
        /// URL authority
        /// </summary>
        public string authority
        {
            get { return (string)this["authority"]; }
            set { this["authority"] = value; }
        }

        /// <summary>
        /// URL path
        /// </summary>
        public string path
        {
            get { return (string)this["path"]; }
            set { this["path"] = value; }
        }

        /// <summary>
        /// URL normalized path
        /// </summary>
        public string normalizedPath
        {
            get { return (string)this["normalizedPath"]; }
            set { this["normalizedPath"] = value; }
        }

        /// <summary>
        /// URL is IP address
        /// </summary>
        public bool isIp
        {
            get { return (bool)this["isIp"]; }
            set { this["isIp"] = value; }
        }
    }
}
