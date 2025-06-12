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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the AssociateNatGatewayAddress operation.
    /// Associates Elastic IP addresses (EIPs) and private IPv4 addresses with a public NAT
    /// gateway. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/nat-gateway-working-with.html">Work
    /// with NAT gateways</a> in the <i>Amazon VPC User Guide</i>.
    /// 
    ///  
    /// <para>
    /// By default, you can associate up to 2 Elastic IP addresses per public NAT gateway.
    /// You can increase the limit by requesting a quota adjustment. For more information,
    /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html#vpc-limits-eips">Elastic
    /// IP address quotas</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// When you associate an EIP or secondary EIPs with a public NAT gateway, the network
    /// border group of the EIPs must match the network border group of the Availability Zone
    /// (AZ) that the public NAT gateway is in. If it's not the same, the EIP will fail to
    /// associate. You can see the network border group for the subnet's AZ by viewing the
    /// details of the subnet. Similarly, you can view the network border group of an EIP
    /// by viewing the details of the EIP address. For more information about network border
    /// groups and EIPs, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/WorkWithEIPs.html">Allocate
    /// an Elastic IP address</a> in the <i>Amazon VPC User Guide</i>. 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class AssociateNatGatewayAddressRequest : AmazonEC2Request
    {
        private List<string> _allocationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _dryRun;
        private string _natGatewayId;
        private List<string> _privateIpAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllocationIds. 
        /// <para>
        /// The allocation IDs of EIPs that you want to associate with your NAT gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AllocationIds
        {
            get { return this._allocationIds; }
            set { this._allocationIds = value; }
        }

        // Check to see if AllocationIds property is set
        internal bool IsSetAllocationIds()
        {
            return this._allocationIds != null && (this._allocationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// The ID of the NAT gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NatGatewayId
        {
            get { return this._natGatewayId; }
            set { this._natGatewayId = value; }
        }

        // Check to see if NatGatewayId property is set
        internal bool IsSetNatGatewayId()
        {
            return this._natGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddresses. 
        /// <para>
        /// The private IPv4 addresses that you want to assign to the NAT gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PrivateIpAddresses
        {
            get { return this._privateIpAddresses; }
            set { this._privateIpAddresses = value; }
        }

        // Check to see if PrivateIpAddresses property is set
        internal bool IsSetPrivateIpAddresses()
        {
            return this._privateIpAddresses != null && (this._privateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}