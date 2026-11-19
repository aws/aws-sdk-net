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
    /// Describes association information for an Elastic IP address (IPv4).
    /// </summary>
    public partial class InstanceNetworkInterfaceAssociation
    {
        /// <summary>
        /// Gets and sets the property CarrierIp. 
        /// <para>
        /// The carrier IP address associated with the network interface.
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
        /// The ID of the owner of the Elastic IP address.
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
        /// The public IP address or Elastic IP address bound to the network interface.
        /// </para>
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// Checks to see if the PublicIp property is set.
        /// </summary>
        internal bool IsSetPublicIp() => this.PublicIp != null;
    }
}
