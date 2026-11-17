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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The VPC peering connection options.
    /// </summary>
    public partial class PeeringConnectionOptionsRequest
    {
        /// <summary>
        /// Gets and sets the property AllowDnsResolutionFromRemoteVpc. 
        /// <para>
        /// If true, enables a local VPC to resolve public DNS hostnames to private IP addresses
        /// when queried from instances in the peer VPC.
        /// </para>
        /// </summary>
        public bool? AllowDnsResolutionFromRemoteVpc { get; set; }

        /// <summary>
        /// Checks to see if the AllowDnsResolutionFromRemoteVpc property is set.
        /// </summary>
        internal bool IsSetAllowDnsResolutionFromRemoteVpc() => this.AllowDnsResolutionFromRemoteVpc.HasValue;

        /// <summary>
        /// Gets and sets the property AllowEgressFromLocalClassicLinkToRemoteVpc. 
        /// <para>
        /// Deprecated.
        /// </para>
        /// </summary>
        public bool? AllowEgressFromLocalClassicLinkToRemoteVpc { get; set; }

        /// <summary>
        /// Checks to see if the AllowEgressFromLocalClassicLinkToRemoteVpc property is set.
        /// </summary>
        internal bool IsSetAllowEgressFromLocalClassicLinkToRemoteVpc() => this.AllowEgressFromLocalClassicLinkToRemoteVpc.HasValue;

        /// <summary>
        /// Gets and sets the property AllowEgressFromLocalVpcToRemoteClassicLink. 
        /// <para>
        /// Deprecated.
        /// </para>
        /// </summary>
        public bool? AllowEgressFromLocalVpcToRemoteClassicLink { get; set; }

        /// <summary>
        /// Checks to see if the AllowEgressFromLocalVpcToRemoteClassicLink property is set.
        /// </summary>
        internal bool IsSetAllowEgressFromLocalVpcToRemoteClassicLink() => this.AllowEgressFromLocalVpcToRemoteClassicLink.HasValue;

        /// <summary>
        /// Gets and sets the property AllowMultipathResilience. 
        /// <para>
        /// Specifies whether you allow multipath resilience for this side of the VPC peering
        /// connection. Multipath resilience is supported only for inter-Region VPC peering connections
        /// between supported Regions. It takes effect only when both the requester and the accepter
        /// allow it. If you don't specify this parameter, the current setting doesn't change.
        /// </para>
        /// </summary>
        public bool? AllowMultipathResilience { get; set; }

        /// <summary>
        /// Checks to see if the AllowMultipathResilience property is set.
        /// </summary>
        internal bool IsSetAllowMultipathResilience() => this.AllowMultipathResilience.HasValue;

        /// <summary>
        /// Gets and sets the property MultipathResilienceMode. 
        /// <para>
        /// The multipath resilience mode. You can specify this parameter only if <c>AllowMultipathResilience</c>
        /// is <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// The following value is valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>always-on</c> – Replicates traffic across multiple network paths while multipath
        /// resilience is in effect.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <c>AllowMultipathResilience</c> is <c>true</c> and you don't specify a mode, the
        /// default is <c>always-on</c>.
        /// </para>
        /// </summary>
        public MultipathResilienceMode MultipathResilienceMode { get; set; }

        /// <summary>
        /// Checks to see if the MultipathResilienceMode property is set.
        /// </summary>
        internal bool IsSetMultipathResilienceMode() => this.MultipathResilienceMode != null;
    }
}
