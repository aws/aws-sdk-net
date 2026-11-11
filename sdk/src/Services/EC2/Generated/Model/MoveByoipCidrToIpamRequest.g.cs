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
    /// Container for the parameters to the MoveByoipCidrToIpam operation. Move a BYOIPv4
    /// CIDR to IPAM from a public IPv4 pool. <para> If you already have a BYOIPv4 CIDR with
    /// Amazon Web Services, you can move the CIDR to IPAM from a public IPv4 pool. You cannot
    /// move an IPv6 CIDR to IPAM. If you are bringing a new IP address to Amazon Web Services
    /// for the first time, complete the steps in <a href="https://docs.aws.amazon.com/vpc/latest/ipam/tutorials-byoip-ipam.html">Tutorial:
    /// BYOIP address CIDRs to IPAM</a>. </para>
    /// </summary>
    public partial class MoveByoipCidrToIpamRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The BYOIP CIDR.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The IPAM pool ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPoolId property is set.
        /// </summary>
        internal bool IsSetIpamPoolId() => this.IpamPoolId != null;

        /// <summary>
        /// Gets and sets the property IpamPoolOwner. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the IPAM pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamPoolOwner { get; set; }

        /// <summary>
        /// Checks to see if the IpamPoolOwner property is set.
        /// </summary>
        internal bool IsSetIpamPoolOwner() => this.IpamPoolOwner != null;
    }
}
