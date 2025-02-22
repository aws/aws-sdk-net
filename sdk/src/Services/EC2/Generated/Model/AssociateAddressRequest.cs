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
    /// Container for the parameters to the AssociateAddress operation.
    /// Associates an Elastic IP address, or carrier IP address (for instances that are in
    /// subnets in Wavelength Zones) with an instance or a network interface. Before you can
    /// use an Elastic IP address, you must allocate it to your account.
    /// 
    ///  
    /// <para>
    /// If the Elastic IP address is already associated with a different instance, it is disassociated
    /// from that instance and associated with the specified instance. If you associate an
    /// Elastic IP address with an instance that has an existing Elastic IP address, the existing
    /// address is disassociated from the instance, but remains allocated to your account.
    /// </para>
    ///  
    /// <para>
    /// [Subnets in Wavelength Zones] You can associate an IP address from the telecommunication
    /// carrier to the instance or network interface. 
    /// </para>
    ///  
    /// <para>
    /// You cannot associate an Elastic IP address with an interface in a different network
    /// border group.
    /// </para>
    ///  <important> 
    /// <para>
    /// This is an idempotent operation. If you perform the operation more than once, Amazon
    /// EC2 doesn't return an error, and you may be charged for each time the Elastic IP address
    /// is remapped to the same instance. For more information, see the <i>Elastic IP Addresses</i>
    /// section of <a href="http://aws.amazon.com/ec2/pricing/">Amazon EC2 Pricing</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class AssociateAddressRequest : AmazonEC2Request
    {
        private string _allocationId;
        private bool? _allowReassociation;
        private bool? _dryRun;
        private string _instanceId;
        private string _networkInterfaceId;
        private string _privateIpAddress;
        private string _publicIp;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AssociateAddressRequest() { }

        /// <summary>
        /// Instantiates AssociateAddressRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The ID of the instance. The instance must have exactly one attached network interface. You can specify either the instance ID or the network interface ID, but not both.</param>
        /// <param name="publicIp">Deprecated.</param>
        public AssociateAddressRequest(string instanceId, string publicIp)
        {
            _instanceId = instanceId;
            _publicIp = publicIp;
        }

        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// The allocation ID. This is required.
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
        /// Gets and sets the property AllowReassociation. 
        /// <para>
        /// Reassociation is automatic, but you can specify false to ensure the operation fails
        /// if the Elastic IP address is already associated with another resource.
        /// </para>
        /// </summary>
        public bool? AllowReassociation
        {
            get { return this._allowReassociation; }
            set { this._allowReassociation = value; }
        }

        // Check to see if AllowReassociation property is set
        internal bool IsSetAllowReassociation()
        {
            return this._allowReassociation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance. The instance must have exactly one attached network interface.
        /// You can specify either the instance ID or the network interface ID, but not both.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

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
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The primary or secondary private IP address to associate with the Elastic IP address.
        /// If no private IP address is specified, the Elastic IP address is associated with the
        /// primary private IP address.
        /// </para>
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this._privateIpAddress; }
            set { this._privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this._privateIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// Deprecated.
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