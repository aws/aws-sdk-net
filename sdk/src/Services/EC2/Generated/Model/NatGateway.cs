/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a NAT gateway.
    /// </summary>
    public partial class NatGateway
    {
        private DateTime? _createTime;
        private DateTime? _deleteTime;
        private string _failureCode;
        private string _failureMessage;
        private List<NatGatewayAddress> _natGatewayAddresses = new List<NatGatewayAddress>();
        private string _natGatewayId;
        private NatGatewayState _state;
        private string _subnetId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time the NAT gateway was created.
        /// </para>
        /// </summary>
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteTime. 
        /// <para>
        /// The date and time the NAT gateway was deleted, if applicable.
        /// </para>
        /// </summary>
        public DateTime DeleteTime
        {
            get { return this._deleteTime.GetValueOrDefault(); }
            set { this._deleteTime = value; }
        }

        // Check to see if DeleteTime property is set
        internal bool IsSetDeleteTime()
        {
            return this._deleteTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// If the NAT gateway could not be created, specifies the error code for the failure.
        /// (<code>InsufficientFreeAddressesInSubnet</code> | <code>Gateway.NotAttached</code>
        /// | <code>InvalidAllocationID.NotFound</code> | <code>Resource.AlreadyAssociated</code>
        /// | <code>InternalError</code> | <code>InvalidSubnetID.NotFound</code>)
        /// </para>
        /// </summary>
        public string FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// If the NAT gateway could not be created, specifies the error message for the failure,
        /// that corresponds to the error code. 
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// For InsufficientFreeAddressesInSubnet: "Subnet has insufficient free addresses to
        /// create this NAT gateway"
        /// </para>
        /// </li> <li>
        /// <para>
        /// For Gateway.NotAttached: "Network vpc-xxxxxxxx has no Internet gateway attached"
        /// </para>
        /// </li> <li>
        /// <para>
        /// For InvalidAllocationID.NotFound: "Elastic IP address eipalloc-xxxxxxxx could not
        /// be associated with this NAT gateway"
        /// </para>
        /// </li> <li>
        /// <para>
        /// For Resource.AlreadyAssociated: "Elastic IP address eipalloc-xxxxxxxx is already associated"
        /// </para>
        /// </li> <li>
        /// <para>
        /// For InternalError: "Network interface eni-xxxxxxxx, created and used internally by
        /// this NAT gateway is in an invalid state. Please try again."
        /// </para>
        /// </li> <li>
        /// <para>
        /// For InvalidSubnetID.NotFound: "The specified subnet subnet-xxxxxxxx does not exist
        /// or could not be found."
        /// </para>
        /// </li> </ul>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property NatGatewayAddresses. 
        /// <para>
        /// Information about the IP addresses and network interface associated with the NAT gateway.
        /// </para>
        /// </summary>
        public List<NatGatewayAddress> NatGatewayAddresses
        {
            get { return this._natGatewayAddresses; }
            set { this._natGatewayAddresses = value; }
        }

        // Check to see if NatGatewayAddresses property is set
        internal bool IsSetNatGatewayAddresses()
        {
            return this._natGatewayAddresses != null && this._natGatewayAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// The ID of the NAT gateway.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the NAT gateway.
        /// </para>
        /// </summary>
        public NatGatewayState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in which the NAT gateway is located.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC in which the NAT gateway is located.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}