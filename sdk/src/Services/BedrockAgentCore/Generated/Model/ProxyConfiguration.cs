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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
    /// Configuration for routing browser traffic through customer-managed proxy servers.
    /// Supports 1-5 proxy servers for domain-based routing and proxy bypass rules.
    /// </summary>
    public partial class ProxyConfiguration
    {
        private ProxyBypass _bypass;
        private List<Proxy> _proxies = AWSConfigs.InitializeCollections ? new List<Proxy>() : null;

        /// <summary>
        /// Gets and sets the property Bypass. 
        /// <para>
        /// Optional configuration for domains that should bypass all proxies and connect directly
        /// to their destination, like the internet. Takes precedence over all proxy routing rules.
        /// </para>
        /// </summary>
        public ProxyBypass Bypass
        {
            get { return this._bypass; }
            set { this._bypass = value; }
        }

        // Check to see if Bypass property is set
        internal bool IsSetBypass()
        {
            return this._bypass != null;
        }

        /// <summary>
        /// Gets and sets the property Proxies. 
        /// <para>
        /// An array of 1-5 proxy server configurations for domain-based routing. Each proxy can
        /// specify which domains it handles via <c>domainPatterns</c>, enabling flexible routing
        /// of different traffic through different proxies based on destination domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<Proxy> Proxies
        {
            get { return this._proxies; }
            set { this._proxies = value; }
        }

        // Check to see if Proxies property is set
        internal bool IsSetProxies()
        {
            return this._proxies != null && (this._proxies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}