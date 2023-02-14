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
    /// Describes the IP addresses and network interface associated with a NAT gateway.
    /// </summary>
    public partial class NatGatewayAddress
    {
        private string _allocationId;
        private string _associationId;
        private string _failureMessage;
        private bool? _isPrimary;
        private string _networkInterfaceId;
        private string _privateIp;
        private string _publicIp;
        private NatGatewayAddressStatus _status;

        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// [Public NAT gateway only] The allocation ID of the Elastic IP address that's associated
        /// with the NAT gateway.
        /// </para>
        /// </summary>
        public string AllocationId
        {
            get { return this._allocationId; }
            set { this._allocationId = value; }
        }

        // Check to see if AllocationId property is set
        internal bool IsSetAllocationId()
        {
            return this._allocationId != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// [Public NAT gateway only] The association ID of the Elastic IP address that's associated
        /// with the NAT gateway.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// The address failure message.
        /// </para>
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
        /// Gets and sets the property IsPrimary. 
        /// <para>
        /// Defines if the IP address is the primary address.
        /// </para>
        /// </summary>
        public bool IsPrimary
        {
            get { return this._isPrimary.GetValueOrDefault(); }
            set { this._isPrimary = value; }
        }

        // Check to see if IsPrimary property is set
        internal bool IsSetIsPrimary()
        {
            return this._isPrimary.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface associated with the NAT gateway.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIp. 
        /// <para>
        /// The private IP address associated with the NAT gateway.
        /// </para>
        /// </summary>
        public string PrivateIp
        {
            get { return this._privateIp; }
            set { this._privateIp = value; }
        }

        // Check to see if PrivateIp property is set
        internal bool IsSetPrivateIp()
        {
            return this._privateIp != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// [Public NAT gateway only] The Elastic IP address associated with the NAT gateway.
        /// </para>
        /// </summary>
        public string PublicIp
        {
            get { return this._publicIp; }
            set { this._publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this._publicIp != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The address status.
        /// </para>
        /// </summary>
        public NatGatewayAddressStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}