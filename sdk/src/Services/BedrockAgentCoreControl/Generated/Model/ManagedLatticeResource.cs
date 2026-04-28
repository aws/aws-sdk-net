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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Configuration for a managed VPC Lattice resource. The gateway creates and manages
    /// the VPC Lattice resource gateway and resource configuration on your behalf using a
    /// service-linked role.
    /// </summary>
    public partial class ManagedLatticeResource
    {
        private EndpointIpAddressType _endpointIpAddressType;
        private string _routingDomain;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _vpcIdentifier;

        /// <summary>
        /// Gets and sets the property EndpointIpAddressType. 
        /// <para>
        /// The IP address type for the resource configuration endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EndpointIpAddressType EndpointIpAddressType
        {
            get { return this._endpointIpAddressType; }
            set { this._endpointIpAddressType = value; }
        }

        // Check to see if EndpointIpAddressType property is set
        internal bool IsSetEndpointIpAddressType()
        {
            return this._endpointIpAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingDomain. 
        /// <para>
        /// An intermediate publicly resolvable domain used as the VPC Lattice resource configuration
        /// endpoint. Required when your private endpoint uses a domain that is not publicly resolvable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string RoutingDomain
        {
            get { return this._routingDomain; }
            set { this._routingDomain = value; }
        }

        // Check to see if RoutingDomain property is set
        internal bool IsSetRoutingDomain()
        {
            return this._routingDomain != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security group IDs to associate with the VPC Lattice resource gateway. If not
        /// specified, the default security group for the VPC is used.
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
        /// The subnet IDs within the VPC where the VPC Lattice resource gateway is placed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Tags to apply to the managed VPC Lattice resource gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// The ID of the VPC that contains your private resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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