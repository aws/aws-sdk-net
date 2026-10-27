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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Configuration for a managed VPC Lattice resource. The gateway creates and manages
    /// the VPC Lattice resource gateway and resource configuration on your behalf using a
    /// service-linked role.
    /// </summary>
    public partial class ManagedVpcResource
    {
        /// <summary>
        /// Gets and sets the property EndpointIpAddressType. 
        /// <para>
        /// The IP address type for the resource configuration endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointIpAddressType EndpointIpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointIpAddressType property is set.
        /// </summary>
        internal bool IsSetEndpointIpAddressType() => this.EndpointIpAddressType != null;

        /// <summary>
        /// Gets and sets the property RoutingDomain. 
        /// <para>
        /// An intermediate domain to use as the resource configuration endpoint instead of the
        /// actual target domain. Use this when you want to route traffic through an intermediate
        /// component such as a VPC endpoint or internal load balancer. For more information,
        /// see xref:lattice-vpc-egress-routing-domain[Route traffic through an intermediate domain].
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string RoutingDomain { get; set; }

        /// <summary>
        /// Checks to see if the RoutingDomain property is set.
        /// </summary>
        internal bool IsSetRoutingDomain() => this.RoutingDomain != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security group IDs to associate with the VPC Lattice resource gateway. If not
        /// specified, the default security group for the VPC is used.
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
        /// The subnet IDs within the VPC where the VPC Lattice resource gateway is placed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to apply to the managed VPC Lattice resource gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcIdentifier. 
        /// <para>
        /// The ID of the VPC that contains your private resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VpcIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the VpcIdentifier property is set.
        /// </summary>
        internal bool IsSetVpcIdentifier() => this.VpcIdentifier != null;
    }
}
