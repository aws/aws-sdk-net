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
    /// Container for the parameters to the DisassociateNatGatewayAddress operation.
    /// Disassociates secondary Elastic IP addresses (EIPs) from a public NAT gateway. You
    /// cannot disassociate your primary EIP. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-nat-gateway.html#nat-gateway-edit-secondary">Edit
    /// secondary IP address associations</a> in the <i>Amazon Virtual Private Cloud User
    /// Guide</i>.
    /// 
    ///  
    /// <para>
    /// While disassociating is in progress, you cannot associate/disassociate additional
    /// EIPs while the connections are being drained. You are, however, allowed to delete
    /// the NAT gateway.
    /// </para>
    ///  
    /// <para>
    /// An EIP will only be released at the end of MaxDrainDurationSeconds. The EIPs stay
    /// associated and support the existing connections but do not support any new connections
    /// (new connections are distributed across the remaining associated EIPs). As the existing
    /// connections drain out, the EIPs (and the corresponding private IPs mapped to them)
    /// get released.
    /// </para>
    /// </summary>
    public partial class DisassociateNatGatewayAddressRequest : AmazonEC2Request
    {
        private List<string> _associationIds = new List<string>();
        private int? _maxDrainDurationSeconds;
        private string _natGatewayId;

        /// <summary>
        /// Gets and sets the property AssociationIds. 
        /// <para>
        /// The association IDs of EIPs that have been associated with the NAT gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AssociationIds
        {
            get { return this._associationIds; }
            set { this._associationIds = value; }
        }

        // Check to see if AssociationIds property is set
        internal bool IsSetAssociationIds()
        {
            return this._associationIds != null && this._associationIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxDrainDurationSeconds. 
        /// <para>
        /// The maximum amount of time to wait (in seconds) before forcibly releasing the IP addresses
        /// if connections are still in progress. Default value is 350 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4000)]
        public int MaxDrainDurationSeconds
        {
            get { return this._maxDrainDurationSeconds.GetValueOrDefault(); }
            set { this._maxDrainDurationSeconds = value; }
        }

        // Check to see if MaxDrainDurationSeconds property is set
        internal bool IsSetMaxDrainDurationSeconds()
        {
            return this._maxDrainDurationSeconds.HasValue; 
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

    }
}