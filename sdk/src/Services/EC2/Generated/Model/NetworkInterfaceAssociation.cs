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
    /// Describes association information for an Elastic IP address (IPv4 only), or a Carrier
    /// IP address (for a network interface which resides in a subnet in a Wavelength Zone).
    /// </summary>
    public partial class NetworkInterfaceAssociation
    {
        private string _allocationId;
        private string _associationId;
        private string _carrierIp;
        private string _customerOwnedIp;
        private string _ipOwnerId;
        private string _publicDnsName;
        private string _publicIp;

        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// The allocation ID.
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
        /// The association ID.
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
        /// Gets and sets the property CarrierIp. 
        /// <para>
        /// The carrier IP address associated with the network interface.
        /// </para>
        ///  
        /// <para>
        /// This option is only available when the network interface is in a subnet which is associated
        /// with a Wavelength Zone.
        /// </para>
        /// </summary>
        public string CarrierIp
        {
            get { return this._carrierIp; }
            set { this._carrierIp = value; }
        }

        // Check to see if CarrierIp property is set
        internal bool IsSetCarrierIp()
        {
            return this._carrierIp != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerOwnedIp. 
        /// <para>
        /// The customer-owned IP address associated with the network interface.
        /// </para>
        /// </summary>
        public string CustomerOwnedIp
        {
            get { return this._customerOwnedIp; }
            set { this._customerOwnedIp = value; }
        }

        // Check to see if CustomerOwnedIp property is set
        internal bool IsSetCustomerOwnedIp()
        {
            return this._customerOwnedIp != null;
        }

        /// <summary>
        /// Gets and sets the property IpOwnerId. 
        /// <para>
        /// The ID of the Elastic IP address owner.
        /// </para>
        /// </summary>
        public string IpOwnerId
        {
            get { return this._ipOwnerId; }
            set { this._ipOwnerId = value; }
        }

        // Check to see if IpOwnerId property is set
        internal bool IsSetIpOwnerId()
        {
            return this._ipOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property PublicDnsName. 
        /// <para>
        /// The public DNS name.
        /// </para>
        /// </summary>
        public string PublicDnsName
        {
            get { return this._publicDnsName; }
            set { this._publicDnsName = value; }
        }

        // Check to see if PublicDnsName property is set
        internal bool IsSetPublicDnsName()
        {
            return this._publicDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// The address of the Elastic IP address bound to the network interface.
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

    }
}