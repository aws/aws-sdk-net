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

namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// Configuration for a VPC egress network connector. Specifies the VPC subnets, security
    /// groups, network protocol, and associated Lambda compute resource types.
    /// </summary>
    public partial class NetworkConnectorVpcEgressConfiguration
    {
        /// <summary>
        /// Gets and sets the property AssociatedComputeResourceTypes. 
        /// <para>
        /// The types of Lambda compute resources that can use this connector. Currently, only
        /// <c>MicroVm</c> is supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> AssociatedComputeResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssociatedComputeResourceTypes property is set.
        /// </summary>
        internal bool IsSetAssociatedComputeResourceTypes() => this.AssociatedComputeResourceTypes != null && (this.AssociatedComputeResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkProtocol. 
        /// <para>
        /// The network protocol for the connector. Specify <c>IPv4</c> for IPv4-only networking,
        /// or <c>DualStack</c> for both IPv4 and IPv6.
        /// </para>
        /// </summary>
        public NetworkProtocol NetworkProtocol { get; set; }

        /// <summary>
        /// Checks to see if the NetworkProtocol property is set.
        /// </summary>
        internal bool IsSetNetworkProtocol() => this.NetworkProtocol != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the VPC security groups to attach to the ENIs. Specify 0 to 5 security
        /// groups. All security groups must be in the same VPC as the subnets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The IDs of the VPC subnets where Lambda provisions elastic network interfaces (ENIs).
        /// Specify 1 to 16 subnets. All subnets must be in the same VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 16)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
