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
    /// Configuration for domains that should bypass all proxies and connect directly to the
    /// internet. These bypass rules take precedence over all proxy routing rules.
    /// </summary>
    public partial class ProxyBypass
    {
        private List<string> _domainPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DomainPatterns. 
        /// <para>
        /// Array of domain patterns that should bypass the proxy. Supports <c>.amazonaws.com</c>
        /// for subdomain matching or <c>amazonaws.com</c> for exact domain matching. Requests
        /// to these domains connect directly without using any proxy. Maximum 253 characters
        /// per pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> DomainPatterns
        {
            get { return this._domainPatterns; }
            set { this._domainPatterns = value; }
        }

        // Check to see if DomainPatterns property is set
        internal bool IsSetDomainPatterns()
        {
            return this._domainPatterns != null && (this._domainPatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}