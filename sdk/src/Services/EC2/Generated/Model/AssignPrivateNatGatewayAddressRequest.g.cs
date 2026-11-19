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
    /// Container for the parameters to the AssignPrivateNatGatewayAddress operation. Assigns
    /// private IPv4 addresses to a private NAT gateway. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/nat-gateway-working-with.html">Work
    /// with NAT gateways</a> in the <i>Amazon VPC User Guide</i>.
    /// </summary>
    public partial class AssignPrivateNatGatewayAddressRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// The ID of the NAT gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the NatGatewayId property is set.
        /// </summary>
        internal bool IsSetNatGatewayId() => this.NatGatewayId != null;

        /// <summary>
        /// Gets and sets the property PrivateIpAddressCount. 
        /// <para>
        /// The number of private IP addresses to assign to the NAT gateway. You can't specify
        /// this parameter when also specifying private IP addresses.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 31)]
        public int? PrivateIpAddressCount { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpAddressCount property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddressCount() => this.PrivateIpAddressCount.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateIpAddresses. 
        /// <para>
        /// The private IPv4 addresses you want to assign to the private NAT gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PrivateIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PrivateIpAddresses property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddresses() => this.PrivateIpAddresses != null && (this.PrivateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
