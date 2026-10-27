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
    /// Container for the parameters to the CreateCollectionGroup operation. Creates a collection
    /// group within OpenSearch Serverless. Collection groups let you manage OpenSearch Compute
    /// Units (OCUs) at a group level, with multiple collections sharing the group's capacity
    /// limits. <para> For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-collection-groups.html">Managing
    /// collection groups</a>. </para>
    /// </summary>
    public partial class CreateCollectionGroupRequest : AmazonOpenSearchServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property CapacityLimits. 
        /// <para>
        /// The capacity limits for the collection group, in OpenSearch Compute Units (OCUs).
        /// These limits control the maximum and minimum capacity for collections within the group.
        /// </para>
        /// </summary>
        public CollectionGroupCapacityLimits CapacityLimits { get; set; }

        /// <summary>
        /// Checks to see if the CapacityLimits property is set.
        /// </summary>
        internal bool IsSetCapacityLimits() => this.CapacityLimits != null;

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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the collection group.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Generation. 
        /// <para>
        /// The generation of Amazon OpenSearch Serverless for the collection group. Valid values
        /// are <c>CLASSIC</c> and <c>NEXTGEN</c>.
        /// </para>
        /// </summary>
        public ServerlessGeneration Generation { get; set; }

        /// <summary>
        /// Checks to see if the Generation property is set.
        /// </summary>
        internal bool IsSetGeneration() => this.Generation != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the collection group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 32)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StandbyReplicas. 
        /// <para>
        /// Indicates whether standby replicas should be used for a collection group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StandbyReplicas StandbyReplicas { get; set; }

        /// <summary>
        /// Checks to see if the StandbyReplicas property is set.
        /// </summary>
        internal bool IsSetStandbyReplicas() => this.StandbyReplicas != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An arbitrary set of tags (key–value pairs) to associate with the OpenSearch Serverless
        /// collection group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
