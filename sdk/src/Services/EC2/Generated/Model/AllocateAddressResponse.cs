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
    /// This is the response object from the AllocateAddress operation.
    /// </summary>
    public partial class AllocateAddressResponse : AmazonWebServiceResponse
    {
        private string _allocationId;
        private string _carrierIp;
        private string _customerOwnedIp;
        private string _customerOwnedIpv4Pool;
        private DomainType _domain;
        private string _networkBorderGroup;
        private string _publicIp;
        private string _publicIpv4Pool;

        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// The ID that represents the allocation of the Elastic IP address.
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
        /// Gets and sets the property CarrierIp. 
        /// <para>
        /// The carrier IP address. This option is only available for network interfaces that
        /// reside in a subnet in a Wavelength Zone.
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
        /// The customer-owned IP address.
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
        /// Gets and sets the property CustomerOwnedIpv4Pool. 
        /// <para>
        /// The ID of the customer-owned address pool.
        /// </para>
        /// </summary>
        public string CustomerOwnedIpv4Pool
        {
            get { return this._customerOwnedIpv4Pool; }
            set { this._customerOwnedIpv4Pool = value; }
        }

        // Check to see if CustomerOwnedIpv4Pool property is set
        internal bool IsSetCustomerOwnedIpv4Pool()
        {
            return this._customerOwnedIpv4Pool != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The network (<c>vpc</c>).
        /// </para>
        /// </summary>
        public DomainType Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The set of Availability Zones, Local Zones, or Wavelength Zones from which Amazon
        /// Web Services advertises IP addresses.
        /// </para>
        /// </summary>
        public string NetworkBorderGroup
        {
            get { return this._networkBorderGroup; }
            set { this._networkBorderGroup = value; }
        }

        // Check to see if NetworkBorderGroup property is set
        internal bool IsSetNetworkBorderGroup()
        {
            return this._networkBorderGroup != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// The Elastic IP address.
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
        /// Gets and sets the property PublicIpv4Pool. 
        /// <para>
        /// The ID of an address pool.
        /// </para>
        /// </summary>
        public string PublicIpv4Pool
        {
            get { return this._publicIpv4Pool; }
            set { this._publicIpv4Pool = value; }
        }

        // Check to see if PublicIpv4Pool property is set
        internal bool IsSetPublicIpv4Pool()
        {
            return this._publicIpv4Pool != null;
        }

    }
}