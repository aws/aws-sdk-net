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
    /// The EC2 Instance Connect Endpoint.
    /// </summary>
    public partial class Ec2InstanceConnectEndpoint
    {
        private string _availabilityZone;
        private DateTime? _createdAt;
        private string _dnsName;
        private string _fipsDnsName;
        private string _instanceConnectEndpointArn;
        private string _instanceConnectEndpointId;
        private IpAddressType _ipAddressType;
        private List<string> _networkInterfaceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _ownerId;
        private bool? _preserveClientIp;
        private InstanceConnectEndpointPublicDnsNames _publicDnsNames;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Ec2InstanceConnectEndpointState _state;
        private string _stateMessage;
        private string _subnetId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the EC2 Instance Connect Endpoint was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name of the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property FipsDnsName. 
        /// <para>
        /// The Federal Information Processing Standards (FIPS) compliant DNS name of the EC2
        /// Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public string FipsDnsName
        {
            get { return this._fipsDnsName; }
            set { this._fipsDnsName = value; }
        }

        // Check to see if FipsDnsName property is set
        internal bool IsSetFipsDnsName()
        {
            return this._fipsDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceConnectEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string InstanceConnectEndpointArn
        {
            get { return this._instanceConnectEndpointArn; }
            set { this._instanceConnectEndpointArn = value; }
        }

        // Check to see if InstanceConnectEndpointArn property is set
        internal bool IsSetInstanceConnectEndpointArn()
        {
            return this._instanceConnectEndpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceConnectEndpointId. 
        /// <para>
        /// The ID of the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public string InstanceConnectEndpointId
        {
            get { return this._instanceConnectEndpointId; }
            set { this._instanceConnectEndpointId = value; }
        }

        // Check to see if InstanceConnectEndpointId property is set
        internal bool IsSetInstanceConnectEndpointId()
        {
            return this._instanceConnectEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type of the endpoint.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceIds. 
        /// <para>
        /// The ID of the elastic network interface that Amazon EC2 automatically created when
        /// creating the EC2 Instance Connect Endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NetworkInterfaceIds
        {
            get { return this._networkInterfaceIds; }
            set { this._networkInterfaceIds = value; }
        }

        // Check to see if NetworkInterfaceIds property is set
        internal bool IsSetNetworkInterfaceIds()
        {
            return this._networkInterfaceIds != null && (this._networkInterfaceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that created the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property PreserveClientIp. 
        /// <para>
        /// Indicates whether your client's IP address is preserved as the source. The value is
        /// <c>true</c> or <c>false</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>true</c>, your client's IP address is used when you connect to a resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>false</c>, the elastic network interface IP address is used when you connect
        /// to a resource.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>true</c> 
        /// </para>
        /// </summary>
        public bool? PreserveClientIp
        {
            get { return this._preserveClientIp; }
            set { this._preserveClientIp = value; }
        }

        // Check to see if PreserveClientIp property is set
        internal bool IsSetPreserveClientIp()
        {
            return this._preserveClientIp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicDnsNames. 
        /// <para>
        /// The public DNS names of the endpoint.
        /// </para>
        /// </summary>
        public InstanceConnectEndpointPublicDnsNames PublicDnsNames
        {
            get { return this._publicDnsNames; }
            set { this._publicDnsNames = value; }
        }

        // Check to see if PublicDnsNames property is set
        internal bool IsSetPublicDnsNames()
        {
            return this._publicDnsNames != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security groups associated with the endpoint. If you didn't specify a security
        /// group, the default security group for your VPC is associated with the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public Ec2InstanceConnectEndpointState State
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
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// The message for the current state of the EC2 Instance Connect Endpoint. Can include
        /// a failure message.
        /// </para>
        /// </summary>
        public string StateMessage
        {
            get { return this._stateMessage; }
            set { this._stateMessage = value; }
        }

        // Check to see if StateMessage property is set
        internal bool IsSetStateMessage()
        {
            return this._stateMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in which the EC2 Instance Connect Endpoint was created.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the EC2 Instance Connect Endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC in which the EC2 Instance Connect Endpoint was created.
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