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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateNatGatewayAddress operation.
    /// Associates Elastic IP addresses (EIPs) and private IPv4 addresses with a public NAT
    /// gateway. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-nat-gateway.html#nat-gateway-working-with">Work
    /// with NAT gateways</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// 
    ///  
    /// <para>
    /// By default, you can associate up to 2 Elastic IP addresses per public NAT gateway.
    /// You can increase the limit by requesting a quota adjustment. For more information,
    /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html#vpc-limits-eips">Elastic
    /// IP address quotas</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AssociateNatGatewayAddressRequest : AmazonEC2Request
    {
        private List<string> _allocationIds = new List<string>();
        private string _natGatewayId;
        private List<string> _privateIpAddresses = new List<string>();

        /// <summary>
        /// Gets and sets the property AllocationIds. 
        /// <para>
        /// The allocation IDs of EIPs that you want to associate with your NAT gateway.
        /// </para>
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
            return this._allocationIds != null && this._allocationIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// The NAT gateway ID.
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
        /// </summary>
        public List<string> PrivateIpAddresses
        {
            get { return this._privateIpAddresses; }
            set { this._privateIpAddresses = value; }
        }

        // Check to see if PrivateIpAddresses property is set
        internal bool IsSetPrivateIpAddresses()
        {
            return this._privateIpAddresses != null && this._privateIpAddresses.Count > 0; 
        }

    }
}