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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateVpcEndpoint operation. Updates an OpenSearch
    /// Serverless-managed interface endpoint. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
    /// Amazon OpenSearch Serverless using an interface endpoint</a>.
    /// </summary>
    public partial class UpdateVpcEndpointRequest : AmazonOpenSearchServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property AddSecurityGroupIds. 
        /// <para>
        /// The unique identifiers of the security groups to add to the endpoint. Security groups
        /// define the ports, protocols, and sources for inbound traffic that you are authorizing
        /// into your endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> AddSecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddSecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetAddSecurityGroupIds() => this.AddSecurityGroupIds != null && (this.AddSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AddSubnetIds. 
        /// <para>
        /// The ID of one or more subnets to add to the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> AddSubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddSubnetIds property is set.
        /// </summary>
        internal bool IsSetAddSubnetIds() => this.AddSubnetIds != null && (this.AddSubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the interface endpoint to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property RemoveSecurityGroupIds. 
        /// <para>
        /// The unique identifiers of the security groups to remove from the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> RemoveSecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveSecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetRemoveSecurityGroupIds() => this.RemoveSecurityGroupIds != null && (this.RemoveSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemoveSubnetIds. 
        /// <para>
        /// The unique identifiers of the subnets to remove from the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> RemoveSubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveSubnetIds property is set.
        /// </summary>
        internal bool IsSetRemoveSubnetIds() => this.RemoveSubnetIds != null && (this.RemoveSubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
