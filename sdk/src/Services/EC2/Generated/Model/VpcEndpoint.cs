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
    /// Describes a VPC endpoint.
    /// </summary>
    public partial class VpcEndpoint
    {
        private DateTime? _creationTimestamp;
        private List<DnsEntry> _dnsEntries = new List<DnsEntry>();
        private DnsOptions _dnsOptions;
        private List<SecurityGroupIdentifier> _groups = new List<SecurityGroupIdentifier>();
        private IpAddressType _ipAddressType;
        private LastError _lastError;
        private List<string> _networkInterfaceIds = new List<string>();
        private string _ownerId;
        private string _policyDocument;
        private bool? _privateDnsEnabled;
        private bool? _requesterManaged;
        private List<string> _routeTableIds = new List<string>();
        private string _serviceName;
        private State _state;
        private List<string> _subnetIds = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private string _vpcEndpointId;
        private VpcEndpointType _vpcEndpointType;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The date and time that the endpoint was created.
        /// </para>
        /// </summary>
        public DateTime CreationTimestamp
        {
            get { return this._creationTimestamp.GetValueOrDefault(); }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DnsEntries. 
        /// <para>
        /// (Interface endpoint) The DNS entries for the endpoint.
        /// </para>
        /// </summary>
        public List<DnsEntry> DnsEntries
        {
            get { return this._dnsEntries; }
            set { this._dnsEntries = value; }
        }

        // Check to see if DnsEntries property is set
        internal bool IsSetDnsEntries()
        {
            return this._dnsEntries != null && this._dnsEntries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DnsOptions. 
        /// <para>
        /// The DNS options for the endpoint.
        /// </para>
        /// </summary>
        public DnsOptions DnsOptions
        {
            get { return this._dnsOptions; }
            set { this._dnsOptions = value; }
        }

        // Check to see if DnsOptions property is set
        internal bool IsSetDnsOptions()
        {
            return this._dnsOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// (Interface endpoint) Information about the security groups that are associated with
        /// the network interface.
        /// </para>
        /// </summary>
        public List<SecurityGroupIdentifier> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && this._groups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the endpoint.
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
        /// Gets and sets the property LastError. 
        /// <para>
        /// The last error that occurred for endpoint.
        /// </para>
        /// </summary>
        public LastError LastError
        {
            get { return this._lastError; }
            set { this._lastError = value; }
        }

        // Check to see if LastError property is set
        internal bool IsSetLastError()
        {
            return this._lastError != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceIds. 
        /// <para>
        /// (Interface endpoint) The network interfaces for the endpoint.
        /// </para>
        /// </summary>
        public List<string> NetworkInterfaceIds
        {
            get { return this._networkInterfaceIds; }
            set { this._networkInterfaceIds = value; }
        }

        // Check to see if NetworkInterfaceIds property is set
        internal bool IsSetNetworkInterfaceIds()
        {
            return this._networkInterfaceIds != null && this._networkInterfaceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the endpoint.
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
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The policy document associated with the endpoint, if applicable.
        /// </para>
        /// </summary>
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsEnabled. 
        /// <para>
        /// (Interface endpoint) Indicates whether the VPC is associated with a private hosted
        /// zone.
        /// </para>
        /// </summary>
        public bool PrivateDnsEnabled
        {
            get { return this._privateDnsEnabled.GetValueOrDefault(); }
            set { this._privateDnsEnabled = value; }
        }

        // Check to see if PrivateDnsEnabled property is set
        internal bool IsSetPrivateDnsEnabled()
        {
            return this._privateDnsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequesterManaged. 
        /// <para>
        /// Indicates whether the endpoint is being managed by its service.
        /// </para>
        /// </summary>
        public bool RequesterManaged
        {
            get { return this._requesterManaged.GetValueOrDefault(); }
            set { this._requesterManaged = value; }
        }

        // Check to see if RequesterManaged property is set
        internal bool IsSetRequesterManaged()
        {
            return this._requesterManaged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RouteTableIds. 
        /// <para>
        /// (Gateway endpoint) The IDs of the route tables associated with the endpoint.
        /// </para>
        /// </summary>
        public List<string> RouteTableIds
        {
            get { return this._routeTableIds; }
            set { this._routeTableIds = value; }
        }

        // Check to see if RouteTableIds property is set
        internal bool IsSetRouteTableIds()
        {
            return this._routeTableIds != null && this._routeTableIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service to which the endpoint is associated.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the endpoint.
        /// </para>
        /// </summary>
        public State State
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// (Interface endpoint) The subnets for the endpoint.
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the endpoint.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointId
        {
            get { return this._vpcEndpointId; }
            set { this._vpcEndpointId = value; }
        }

        // Check to see if VpcEndpointId property is set
        internal bool IsSetVpcEndpointId()
        {
            return this._vpcEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointType. 
        /// <para>
        /// The type of endpoint.
        /// </para>
        /// </summary>
        public VpcEndpointType VpcEndpointType
        {
            get { return this._vpcEndpointType; }
            set { this._vpcEndpointType = value; }
        }

        // Check to see if VpcEndpointType property is set
        internal bool IsSetVpcEndpointType()
        {
            return this._vpcEndpointType != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC to which the endpoint is associated.
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