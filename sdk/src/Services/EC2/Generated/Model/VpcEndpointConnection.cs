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
    /// Describes a VPC endpoint connection to a service.
    /// </summary>
    public partial class VpcEndpointConnection
    {
        private DateTime? _creationTimestamp;
        private List<DnsEntry> _dnsEntries = AWSConfigs.InitializeCollections ? new List<DnsEntry>() : null;
        private List<string> _gatewayLoadBalancerArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private IpAddressType _ipAddressType;
        private List<string> _networkLoadBalancerArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _serviceId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcEndpointConnectionId;
        private string _vpcEndpointId;
        private string _vpcEndpointOwner;
        private string _vpcEndpointRegion;
        private State _vpcEndpointState;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The date and time that the VPC endpoint was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp
        {
            get { return this._creationTimestamp; }
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
        /// The DNS entries for the VPC endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DnsEntry> DnsEntries
        {
            get { return this._dnsEntries; }
            set { this._dnsEntries = value; }
        }

        // Check to see if DnsEntries property is set
        internal bool IsSetDnsEntries()
        {
            return this._dnsEntries != null && (this._dnsEntries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GatewayLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the Gateway Load Balancers for the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GatewayLoadBalancerArns
        {
            get { return this._gatewayLoadBalancerArns; }
            set { this._gatewayLoadBalancerArns = value; }
        }

        // Check to see if GatewayLoadBalancerArns property is set
        internal bool IsSetGatewayLoadBalancerArns()
        {
            return this._gatewayLoadBalancerArns != null && (this._gatewayLoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property NetworkLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the network load balancers for the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NetworkLoadBalancerArns
        {
            get { return this._networkLoadBalancerArns; }
            set { this._networkLoadBalancerArns = value; }
        }

        // Check to see if NetworkLoadBalancerArns property is set
        internal bool IsSetNetworkLoadBalancerArns()
        {
            return this._networkLoadBalancerArns != null && (this._networkLoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the service to which the endpoint is connected.
        /// </para>
        /// </summary>
        public string ServiceId
        {
            get { return this._serviceId; }
            set { this._serviceId = value; }
        }

        // Check to see if ServiceId property is set
        internal bool IsSetServiceId()
        {
            return this._serviceId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
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
        /// Gets and sets the property VpcEndpointConnectionId. 
        /// <para>
        /// The ID of the VPC endpoint connection.
        /// </para>
        /// </summary>
        public string VpcEndpointConnectionId
        {
            get { return this._vpcEndpointConnectionId; }
            set { this._vpcEndpointConnectionId = value; }
        }

        // Check to see if VpcEndpointConnectionId property is set
        internal bool IsSetVpcEndpointConnectionId()
        {
            return this._vpcEndpointConnectionId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint.
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
        /// Gets and sets the property VpcEndpointOwner. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the VPC endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointOwner
        {
            get { return this._vpcEndpointOwner; }
            set { this._vpcEndpointOwner = value; }
        }

        // Check to see if VpcEndpointOwner property is set
        internal bool IsSetVpcEndpointOwner()
        {
            return this._vpcEndpointOwner != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointRegion. 
        /// <para>
        /// The Region of the endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointRegion
        {
            get { return this._vpcEndpointRegion; }
            set { this._vpcEndpointRegion = value; }
        }

        // Check to see if VpcEndpointRegion property is set
        internal bool IsSetVpcEndpointRegion()
        {
            return this._vpcEndpointRegion != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointState. 
        /// <para>
        /// The state of the VPC endpoint.
        /// </para>
        /// </summary>
        public State VpcEndpointState
        {
            get { return this._vpcEndpointState; }
            set { this._vpcEndpointState = value; }
        }

        // Check to see if VpcEndpointState property is set
        internal bool IsSetVpcEndpointState()
        {
            return this._vpcEndpointState != null;
        }

    }
}