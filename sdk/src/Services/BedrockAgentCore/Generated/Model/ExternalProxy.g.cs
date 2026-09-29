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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Configuration for a customer-managed external proxy server. Includes server location,
    /// optional domain-based routing patterns, and authentication credentials.
    /// </summary>
    public partial class ExternalProxy
    {
        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// Optional authentication credentials for the proxy server. If omitted, the proxy is
        /// accessed without authentication (useful for IP-allowlisted proxies).
        /// </para>
        /// </summary>
        public ProxyCredentials Credentials { get; set; }

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null;

        /// <summary>
        /// Gets and sets the property DomainPatterns. 
        /// <para>
        /// Optional array of domain patterns that should route through this specific proxy. Supports
        /// <c>.example.com</c> for subdomain matching (matches any subdomain of example.com)
        /// or <c>example.com</c> for exact domain matching. If omitted, this proxy acts as a
        /// catch-all for domains not matched by other proxies. Maximum 100 patterns per proxy,
        /// each up to 253 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> DomainPatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DomainPatterns property is set.
        /// </summary>
        internal bool IsSetDomainPatterns() => this.DomainPatterns != null && (this.DomainPatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number of the proxy server. Valid range: 1-65535.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Server. 
        /// <para>
        /// The hostname of the proxy server. Must be a valid DNS hostname (maximum 253 characters).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 253)]
        public string Server { get; set; }

        /// <summary>
        /// Checks to see if the Server property is set.
        /// </summary>
        internal bool IsSetServer() => this.Server != null;
    }
}
