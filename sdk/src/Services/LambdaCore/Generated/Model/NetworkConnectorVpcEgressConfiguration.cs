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
 * Do not modify this file. This file is generated from the lambda-core-2026-04-30.normal.json service model.
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
namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// Configuration for a VPC egress network connector. Specifies the VPC subnets, security
    /// groups, network protocol, and associated Lambda compute resource types.
    /// </summary>
    public partial class NetworkConnectorVpcEgressConfiguration
    {
        private List<string> _associatedComputeResourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NetworkProtocol _networkProtocol;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedComputeResourceTypes. 
        /// <para>
        /// The types of Lambda compute resources that can use this connector. Currently, only
        /// <c>MicroVm</c> is supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> AssociatedComputeResourceTypes
        {
            get { return this._associatedComputeResourceTypes; }
            set { this._associatedComputeResourceTypes = value; }
        }

        // Check to see if AssociatedComputeResourceTypes property is set
        internal bool IsSetAssociatedComputeResourceTypes()
        {
            return this._associatedComputeResourceTypes != null && (this._associatedComputeResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkProtocol. 
        /// <para>
        /// The network protocol for the connector. Specify <c>IPv4</c> for IPv4-only networking,
        /// or <c>DualStack</c> for both IPv4 and IPv6.
        /// </para>
        /// </summary>
        public NetworkProtocol NetworkProtocol
        {
            get { return this._networkProtocol; }
            set { this._networkProtocol = value; }
        }

        // Check to see if NetworkProtocol property is set
        internal bool IsSetNetworkProtocol()
        {
            return this._networkProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the VPC security groups to attach to the ENIs. Specify 0 to 5 security
        /// groups. All security groups must be in the same VPC as the subnets.
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
        /// The IDs of the VPC subnets where Lambda provisions elastic network interfaces (ENIs).
        /// Specify 1 to 16 subnets. All subnets must be in the same VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
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

    }
}