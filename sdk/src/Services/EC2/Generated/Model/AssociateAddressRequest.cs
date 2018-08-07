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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the AssociateAddress operation.
    /// Associates an Elastic IP address with an instance or a network interface. Before you
    /// can use an Elastic IP address, you must allocate it to your account.
    /// 
    ///  
    /// <para>
    /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
    /// more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
    /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// [EC2-Classic, VPC in an EC2-VPC-only account] If the Elastic IP address is already
    /// associated with a different instance, it is disassociated from that instance and associated
    /// with the specified instance. If you associate an Elastic IP address with an instance
    /// that has an existing Elastic IP address, the existing address is disassociated from
    /// the instance, but remains allocated to your account.
    /// </para>
    ///  
    /// <para>
    /// [VPC in an EC2-Classic account] If you don't specify a private IP address, the Elastic
    /// IP address is associated with the primary IP address. If the Elastic IP address is
    /// already associated with a different instance or a network interface, you get an error
    /// unless you allow reassociation. You cannot associate an Elastic IP address with an
    /// instance or network interface that has an existing Elastic IP address.
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
        /// <param name="instanceId">The ID of the instance. This is required for EC2-Classic. For EC2-VPC, you can specify either the instance ID or the network interface ID, but not both. The operation fails if you specify an instance ID unless exactly one network interface is attached.</param>
        /// <param name="publicIp">The Elastic IP address. This is required for EC2-Classic.</param>
        public AssociateAddressRequest(string instanceId, string publicIp)
        {
            _instanceId = instanceId;
            _publicIp = publicIp;
        }

        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// [EC2-VPC] The allocation ID. This is required for EC2-VPC.
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
        /// [EC2-VPC] For a VPC in an EC2-Classic account, specify true to allow an Elastic IP
        /// address that is already associated with an instance or network interface to be reassociated
        /// with the specified instance or network interface. Otherwise, the operation fails.
        /// In a VPC in an EC2-VPC-only account, reassociation is automatic, therefore you can
        /// specify false to ensure the operation fails if the Elastic IP address is already associated
        /// with another resource.
        /// </para>
        /// </summary>
        public bool AllowReassociation
        {
            get { return this._allowReassociation.GetValueOrDefault(); }
            set { this._allowReassociation = value; }
        }

        // Check to see if AllowReassociation property is set
        internal bool IsSetAllowReassociation()
        {
            return this._allowReassociation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance. This is required for EC2-Classic. For EC2-VPC, you can specify
        /// either the instance ID or the network interface ID, but not both. The operation fails
        /// if you specify an instance ID unless exactly one network interface is attached.
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
        /// [EC2-VPC] The ID of the network interface. If the instance has more than one network
        /// interface, you must specify a network interface ID.
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
        /// [EC2-VPC] The primary or secondary private IP address to associate with the Elastic
        /// IP address. If no private IP address is specified, the Elastic IP address is associated
        /// with the primary private IP address.
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
        /// The Elastic IP address. This is required for EC2-Classic.
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