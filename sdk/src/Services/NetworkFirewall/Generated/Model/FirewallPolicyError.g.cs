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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// A configuration error that Network Firewall detected for a firewall policy.
    /// </summary>
    public partial class FirewallPolicyError
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The error code identifies the type of error. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DNS_FIREWALL_RULE_GROUP_UNAVAILABLE</c> – The Amazon Route 53 Resolver DNS Firewall
        /// rule group that resolved IP validation references is unavailable, for example, because
        /// it was deleted or is no longer accessible from your account. Update the rule group
        /// ID or remove the resolved IP validation configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROUTE53_RESOLVED_IP_VALIDATION_MISSING</c> – An associated stateful rule group
        /// uses the <c>aws_route_53_resolved_domain</c> keyword, but the policy doesn't have
        /// resolved IP validation configured. The affected rules are inactive until you add resolved
        /// IP validation to the policy or remove the keyword rules.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public FirewallPolicyErrorCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the error and how to resolve it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource that the error relates to, when applicable. For example, for
        /// <c>DNS_FIREWALL_RULE_GROUP_UNAVAILABLE</c> this is the Amazon Route 53 Resolver DNS
        /// Firewall rule group ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;
    }
}
