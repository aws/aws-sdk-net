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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
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
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResourceGateway operation.
    /// A resource gateway is a point of ingress into the VPC where a resource resides. It
    /// spans multiple Availability Zones. For your resource to be accessible from all Availability
    /// Zones, you should create your resource gateways to span as many Availability Zones
    /// as possible. A VPC can have multiple resource gateways.
    /// </summary>
    public partial class CreateResourceGatewayRequest : AmazonVPCLatticeRequest
    {
        private string _clientToken;
        private ResourceGatewayIpAddressType _ipAddressType;
        private int? _ipv4AddressesPerEni;
        private string _name;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _vpcIdentifier;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you retry a request that completed successfully using the same client
        /// token and parameters, the retry succeeds without performing any actions. If the parameters
        /// aren't identical, the retry fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// A resource gateway can have IPv4, IPv6 or dualstack addresses. The IP address type
        /// of a resource gateway must be compatible with the subnets of the resource gateway
        /// and the IP address type of the resource, as described here: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>IPv4</b>Assign IPv4 addresses to your resource gateway network interfaces. This
        /// option is supported only if all selected subnets have IPv4 address ranges, and the
        /// resource also has an IPv4 address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IPv6</b>Assign IPv6 addresses to your resource gateway network interfaces. This
        /// option is supported only if all selected subnets are IPv6 only subnets, and the resource
        /// also has an IPv6 address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Dualstack</b>Assign both IPv4 and IPv6 addresses to your resource gateway network
        /// interfaces. This option is supported only if all selected subnets have both IPv4 and
        /// IPv6 address ranges, and the resource either has an IPv4 or IPv6 address.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The IP address type of the resource gateway is independent of the IP address type
        /// of the client or the VPC endpoint through which the resource is accessed.
        /// </para>
        /// </summary>
        public ResourceGatewayIpAddressType IpAddressType
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
        /// Gets and sets the property Ipv4AddressesPerEni. 
        /// <para>
        /// The number of IPv4 addresses in each ENI for the resource gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=62)]
        public int? Ipv4AddressesPerEni
        {
            get { return this._ipv4AddressesPerEni; }
            set { this._ipv4AddressesPerEni = value; }
        }

        // Check to see if Ipv4AddressesPerEni property is set
        internal bool IsSetIpv4AddressesPerEni()
        {
            return this._ipv4AddressesPerEni.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=40)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the security groups to apply to the resource gateway. The security groups
        /// must be in the same VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The IDs of the VPC subnets in which to create the resource gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the resource gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property VpcIdentifier. 
        /// <para>
        /// The ID of the VPC for the resource gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=50)]
        public string VpcIdentifier
        {
            get { return this._vpcIdentifier; }
            set { this._vpcIdentifier = value; }
        }

        // Check to see if VpcIdentifier property is set
        internal bool IsSetVpcIdentifier()
        {
            return this._vpcIdentifier != null;
        }

    }
}