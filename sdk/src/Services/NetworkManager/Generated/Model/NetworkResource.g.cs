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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a network resource.
    /// </summary>
    public partial class NetworkResource
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string AwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsRegion property is set.
        /// </summary>
        internal bool IsSetAwsRegion() => this.AwsRegion != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string CoreNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkId property is set.
        /// </summary>
        internal bool IsSetCoreNetworkId() => this.CoreNetworkId != null;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// Information about the resource, in JSON format. Network Manager gets this information
        /// by describing the resource using its Describe API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property DefinitionTimestamp. 
        /// <para>
        /// The time that the resource definition was retrieved.
        /// </para>
        /// </summary>
        public DateTime? DefinitionTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DefinitionTimestamp property is set.
        /// </summary>
        internal bool IsSetDefinitionTimestamp() => this.DefinitionTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The resource metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegisteredGatewayArn. 
        /// <para>
        /// The ARN of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1500)]
        public string RegisteredGatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredGatewayArn property is set.
        /// </summary>
        internal bool IsSetRegisteredGatewayArn() => this.RegisteredGatewayArn != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1500)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type.
        /// </para>
        ///  
        /// <para>
        /// The following are the supported resource types for Direct Connect:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>dxcon</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dx-gateway</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dx-vif</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are the supported resource types for Network Manager:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>attachment</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>connect-peer</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>connection</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>core-network</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>device</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>link</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>peering</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>site</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are the supported resource types for Amazon VPC:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>customer-gateway</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transit-gateway</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transit-gateway-attachment</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transit-gateway-connect-peer</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transit-gateway-route-table</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vpn-connection</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
