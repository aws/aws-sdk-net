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
    /// Describes association information for an Elastic IP address (IPv4 only), or a Carrier
    /// IP address (for a network interface which resides in a subnet in a Wavelength Zone).
    /// </summary>
    public partial class NetworkInterfaceAssociation
    {
        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// The allocation ID.
        /// </para>
        /// </summary>
        public string AllocationId { get; set; }

        /// <summary>
        /// Checks to see if the AllocationId property is set.
        /// </summary>
        internal bool IsSetAllocationId() => this.AllocationId != null;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The association ID.
        /// </para>
        /// </summary>
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

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
        public string CarrierIp { get; set; }

        /// <summary>
        /// Checks to see if the CarrierIp property is set.
        /// </summary>
        internal bool IsSetCarrierIp() => this.CarrierIp != null;

        /// <summary>
        /// Gets and sets the property CustomerOwnedIp. 
        /// <para>
        /// The customer-owned IP address associated with the network interface.
        /// </para>
        /// </summary>
        public string CustomerOwnedIp { get; set; }

        /// <summary>
        /// Checks to see if the CustomerOwnedIp property is set.
        /// </summary>
        internal bool IsSetCustomerOwnedIp() => this.CustomerOwnedIp != null;

        /// <summary>
        /// Gets and sets the property IpOwnerId. 
        /// <para>
        /// The ID of the Elastic IP address owner.
        /// </para>
        /// </summary>
        public string IpOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the IpOwnerId property is set.
        /// </summary>
        internal bool IsSetIpOwnerId() => this.IpOwnerId != null;

        /// <summary>
        /// Gets and sets the property PublicDnsName. 
        /// <para>
        /// The public DNS name.
        /// </para>
        /// </summary>
        public string PublicDnsName { get; set; }

        /// <summary>
        /// Checks to see if the PublicDnsName property is set.
        /// </summary>
        internal bool IsSetPublicDnsName() => this.PublicDnsName != null;

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// The address of the Elastic IP address bound to the network interface.
        /// </para>
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// Checks to see if the PublicIp property is set.
        /// </summary>
        internal bool IsSetPublicIp() => this.PublicIp != null;
    }
}
