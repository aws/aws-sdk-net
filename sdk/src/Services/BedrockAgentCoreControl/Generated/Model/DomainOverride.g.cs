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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The public domain names for a gateway that clients reach through your own proxy or
    /// custom domain. When you configure a domain override, the gateway advertises these
    /// domains instead of the inbound Host header in the URLs that it returns for OAuth discovery,
    /// such as the protected resource metadata and the <c>WWW-Authenticate</c> challenge.
    /// </summary>
    public partial class DomainOverride
    {
        /// <summary>
        /// Gets and sets the property AlternateDomains. 
        /// <para>
        /// Additional public domain names for the gateway, up to 10. Don't repeat the default
        /// domain or list a domain more than once. A request can select one of these domains,
        /// or the default domain, with the <c>x-amzn-bedrock-agentcore-gateway-domain</c> header.
        /// The gateway rejects a request that selects a domain that isn't configured.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> AlternateDomains { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AlternateDomains property is set.
        /// </summary>
        internal bool IsSetAlternateDomains() => this.AlternateDomains != null && (this.AlternateDomains.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultDomain. 
        /// <para>
        /// The default public domain name for the gateway. The gateway advertises this domain
        /// when a request doesn't select a specific domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 253)]
        public string DefaultDomain { get; set; }

        /// <summary>
        /// Checks to see if the DefaultDomain property is set.
        /// </summary>
        internal bool IsSetDefaultDomain() => this.DefaultDomain != null;
    }
}
