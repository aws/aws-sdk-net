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

/*
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// The summary of the configuration for the URL endpoint type.
    /// </summary>
    public partial class UrlEndpointSummary
    {
        private string _healthUrl;
        private string _url;

        /// <summary>
        /// Gets and sets the property HealthUrl. 
        /// <para>
        /// The health check URL of the URL endpoint type. If the URL is a public endpoint, the
        /// <c>HealthUrl</c> must also be a public endpoint. If the URL is a private endpoint
        /// inside a virtual private cloud (VPC), the health URL must also be a private endpoint,
        /// and the host must be the same as the URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string HealthUrl
        {
            get { return this._healthUrl; }
            set { this._healthUrl = value; }
        }

        // Check to see if HealthUrl property is set
        internal bool IsSetHealthUrl()
        {
            return this._healthUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        ///  The URL to route traffic to. The URL must be an <a href="https://datatracker.ietf.org/doc/html/rfc3986">rfc3986-formatted
        /// URL</a>. If the host is a domain name, the name must be resolvable over the public
        /// internet. If the scheme is <c>https</c>, the top level domain of the host must be
        /// listed in the <a href="https://www.iana.org/domains/root/db">IANA root zone database</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}