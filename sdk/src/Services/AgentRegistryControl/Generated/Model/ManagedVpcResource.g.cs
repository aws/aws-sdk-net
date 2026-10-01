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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// A service-managed private endpoint provisioned within a customer VPC.
    /// </summary>
    public partial class ManagedVpcResource
    {
        /// <summary>
        /// Gets and sets the property EndpointIpAddressType. 
        /// <para>
        /// The IP address type used by the private endpoint, either IPV4 or IPV6.
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
        /// The routing domain used to resolve traffic through the private endpoint.
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
        /// The identifiers of the security groups associated with the private endpoint network
        /// interfaces.
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
        /// The identifiers of the subnets in which the private endpoint network interfaces are
        /// placed.
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
        /// The tags applied to the service-managed VPC resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcIdentifier. 
        /// <para>
        /// The identifier of the VPC in which the private endpoint is provisioned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 48)]
        public string VpcIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the VpcIdentifier property is set.
        /// </summary>
        internal bool IsSetVpcIdentifier() => this.VpcIdentifier != null;
    }
}
