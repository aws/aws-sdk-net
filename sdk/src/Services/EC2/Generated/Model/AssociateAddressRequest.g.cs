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
    /// Container for the parameters to the AssociateAddress operation. Associates an Elastic
    /// IP address, or carrier IP address (for instances that are in subnets in Wavelength
    /// Zones) with an instance or a network interface. Before you can use an Elastic IP address,
    /// you must allocate it to your account. <para> If the Elastic IP address is already
    /// associated with a different instance, it is disassociated from that instance and associated
    /// with the specified instance. If you associate an Elastic IP address with an instance
    /// that has an existing Elastic IP address, the existing address is disassociated from
    /// the instance, but remains allocated to your account. </para> <para> [Subnets in Wavelength
    /// Zones] You can associate an IP address from the telecommunication carrier to the instance
    /// or network interface. </para> <para> You cannot associate an Elastic IP address with
    /// an interface in a different network border group. </para> <important> <para> This
    /// is an idempotent operation. If you perform the operation more than once, Amazon EC2
    /// doesn't return an error, and you may be charged for each time the Elastic IP address
    /// is remapped to the same instance. For more information, see the <i>Elastic IP Addresses</i>
    /// section of <a href="http://aws.amazon.com/ec2/pricing/">Amazon EC2 Pricing</a>. </para>
    /// </important>
    /// </summary>
    public partial class AssociateAddressRequest : AmazonEC2Request
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public AssociateAddressRequest() { }

        /// <summary>
        /// Instantiates AssociateAddressRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The ID of the instance. The instance must have exactly one attached network interface.   You can specify either the instance ID or the network interface ID, but not both.</param>
        /// <param name="publicIp">Deprecated.</param>
        public AssociateAddressRequest(string instanceId, string publicIp)
        {
            this.InstanceId = instanceId;
            this.PublicIp = publicIp;
        }

        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// The allocation ID. This is required.
        /// </para>
        /// </summary>
        public string AllocationId { get; set; }

        /// <summary>
        /// Checks to see if the AllocationId property is set.
        /// </summary>
        internal bool IsSetAllocationId() => this.AllocationId != null;

        /// <summary>
        /// Gets and sets the property AllowReassociation. 
        /// <para>
        /// Reassociation is automatic, but you can specify false to ensure the operation fails
        /// if the Elastic IP address is already associated with another resource.
        /// </para>
        /// </summary>
        public bool? AllowReassociation { get; set; }

        /// <summary>
        /// Checks to see if the AllowReassociation property is set.
        /// </summary>
        internal bool IsSetAllowReassociation() => this.AllowReassociation.HasValue;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance. The instance must have exactly one attached network interface.
        /// You can specify either the instance ID or the network interface ID, but not both.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface. If the instance has more than one network interface,
        /// you must specify a network interface ID.
        /// </para>
        ///  
        /// <para>
        /// You can specify either the instance ID or the network interface ID, but not both.
        /// 
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The primary or secondary private IP address to associate with the Elastic IP address.
        /// If no private IP address is specified, the Elastic IP address is associated with the
        /// primary private IP address.
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
        /// Deprecated.
        /// </para>
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// Checks to see if the PublicIp property is set.
        /// </summary>
        internal bool IsSetPublicIp() => this.PublicIp != null;
    }
}
