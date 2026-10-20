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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The configuration for a gateway that uses shared Application Load Balancers with host-based
    /// routing. Where they apply, the field names and values are kept consistent with the
    /// Elastic Load Balancing API.
    /// </summary>
    public partial class HostSharedAlbConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccessLogs. 
        /// <para>
        /// The access log configuration for the load balancers that the gateway manages.
        /// </para>
        /// </summary>
        public GatewayElbAccessLogConfiguration AccessLogs { get; set; }

        /// <summary>
        /// Checks to see if the AccessLogs property is set.
        /// </summary>
        internal bool IsSetAccessLogs() => this.AccessLogs != null;

        /// <summary>
        /// Gets and sets the property HttpDesync. 
        /// <para>
        /// The desync mitigation mode for the load balancers that the gateway manages, which
        /// determines how the load balancers handle requests that might pose a security risk.
        /// The default is <c>defensive</c>.
        /// </para>
        /// </summary>
        public GatewayAlbDesyncMitigationMode HttpDesync { get; set; }

        /// <summary>
        /// Checks to see if the HttpDesync property is set.
        /// </summary>
        internal bool IsSetHttpDesync() => this.HttpDesync != null;

        /// <summary>
        /// Gets and sets the property MaxAlbCount. 
        /// <para>
        /// The maximum number of Application Load Balancers that the gateway manages. The default
        /// is 10.
        /// </para>
        /// </summary>
        public int? MaxAlbCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxAlbCount property is set.
        /// </summary>
        internal bool IsSetMaxAlbCount() => this.MaxAlbCount.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the load balancers that the gateway manages.
        /// </para>
        /// </summary>
        public GatewayElbNetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port that the load balancer listener uses is 443. The gateway supports only HTTPS
        /// at port 443.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol for the load balancer listener is <c>HTTPS</c>. No other protocol is
        /// supported.
        /// </para>
        /// </summary>
        public GatewayAlbProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property Scheme. 
        /// <para>
        /// Specifies whether the load balancers the gateway manages are <c>internet-facing</c>
        /// or <c>internal</c>. The default is <c>internet-facing</c>.
        /// </para>
        /// </summary>
        public GatewayElbScheme Scheme { get; set; }

        /// <summary>
        /// Checks to see if the Scheme property is set.
        /// </summary>
        internal bool IsSetScheme() => this.Scheme != null;

        /// <summary>
        /// Gets and sets the property TestTrafficRules. 
        /// <para>
        /// The rules that route test traffic for progressive deployments. During a progressive
        /// deployment, requests whose headers match these rules are routed to the new service
        /// revision so that it can be validated before production traffic shifts to it.
        /// </para>
        /// </summary>
        public GatewayAlbTestTrafficRules TestTrafficRules { get; set; }

        /// <summary>
        /// Checks to see if the TestTrafficRules property is set.
        /// </summary>
        internal bool IsSetTestTrafficRules() => this.TestTrafficRules != null;

        /// <summary>
        /// Gets and sets the property WebACLArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the WAF web ACL to associate with the load balancers
        /// that the gateway manages.
        /// </para>
        /// </summary>
        public string WebACLArn { get; set; }

        /// <summary>
        /// Checks to see if the WebACLArn property is set.
        /// </summary>
        internal bool IsSetWebACLArn() => this.WebACLArn != null;
    }
}
