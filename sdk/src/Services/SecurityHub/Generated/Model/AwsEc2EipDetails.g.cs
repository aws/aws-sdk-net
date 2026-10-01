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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an Elastic IP address.
    /// </summary>
    public partial class AwsEc2EipDetails
    {
        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// The identifier that Amazon Web Services assigns to represent the allocation of the
        /// Elastic IP address for use with Amazon VPC.
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
        /// The identifier that represents the association of the Elastic IP address with an EC2
        /// instance.
        /// </para>
        /// </summary>
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain in which to allocate the address.
        /// </para>
        ///  
        /// <para>
        /// If the address is for use with EC2 instances in a VPC, then <c>Domain</c> is <c>vpc</c>.
        /// Otherwise, <c>Domain</c> is <c>standard</c>. 
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the EC2 instance.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The name of the location from which the Elastic IP address is advertised.
        /// </para>
        /// </summary>
        public string NetworkBorderGroup { get; set; }

        /// <summary>
        /// Checks to see if the NetworkBorderGroup property is set.
        /// </summary>
        internal bool IsSetNetworkBorderGroup() => this.NetworkBorderGroup != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The identifier of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceOwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceOwnerId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceOwnerId() => this.NetworkInterfaceOwnerId != null;

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The private IP address that is associated with the Elastic IP address.
        /// </para>
        /// </summary>
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpAddress property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddress() => this.PrivateIpAddress != null;

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// A public IP address that is associated with the EC2 instance.
        /// </para>
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// Checks to see if the PublicIp property is set.
        /// </summary>
        internal bool IsSetPublicIp() => this.PublicIp != null;

        /// <summary>
        /// Gets and sets the property PublicIpv4Pool. 
        /// <para>
        /// The identifier of an IP address pool. This parameter allows Amazon EC2 to select an
        /// IP address from the address pool.
        /// </para>
        /// </summary>
        public string PublicIpv4Pool { get; set; }

        /// <summary>
        /// Checks to see if the PublicIpv4Pool property is set.
        /// </summary>
        internal bool IsSetPublicIpv4Pool() => this.PublicIpv4Pool != null;
    }
}
