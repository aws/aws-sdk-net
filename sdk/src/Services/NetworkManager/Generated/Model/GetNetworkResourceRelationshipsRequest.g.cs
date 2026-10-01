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
    /// Container for the parameters to the GetNetworkResourceRelationships operation. Gets
    /// the network resource relationships for the specified global network.
    /// </summary>
    public partial class GetNetworkResourceRelationshipsRequest : AmazonNetworkManagerRequest
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
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public string GlobalNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the GlobalNetworkId property is set.
        /// </summary>
        internal bool IsSetGlobalNetworkId() => this.GlobalNetworkId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RegisteredGatewayArn. 
        /// <para>
        /// The ARN of the registered gateway.
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
        /// The ARN of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1500)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

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
    }
}
