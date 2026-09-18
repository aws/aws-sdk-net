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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about the VPC peering connection options for the accepter or
    /// requester VPC.
    /// </summary>
    public partial class VpcInfoPeeringOptionsDetails
    {
        /// <summary>
        /// Gets and sets the property AllowDnsResolutionFromRemoteVpc. 
        /// <para>
        /// Indicates whether a local VPC can resolve public DNS hostnames to private IP addresses
        /// when queried from instances in a peer VPC. 
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
        /// Indicates whether a local ClassicLink connection can communicate with the peer VPC
        /// over the VPC peering connection. 
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
        /// Indicates whether a local VPC can communicate with a ClassicLink connection in the
        /// peer VPC over the VPC peering connection. 
        /// </para>
        /// </summary>
        public bool? AllowEgressFromLocalVpcToRemoteClassicLink { get; set; }

        /// <summary>
        /// Checks to see if the AllowEgressFromLocalVpcToRemoteClassicLink property is set.
        /// </summary>
        internal bool IsSetAllowEgressFromLocalVpcToRemoteClassicLink() => this.AllowEgressFromLocalVpcToRemoteClassicLink.HasValue;
    }
}
