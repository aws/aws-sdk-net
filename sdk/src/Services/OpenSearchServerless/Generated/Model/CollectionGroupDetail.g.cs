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
    /// Details about a collection group.
    /// </summary>
    public partial class CollectionGroupDetail
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the collection group.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CapacityLimits. 
        /// <para>
        /// The capacity limits for the collection group, in OpenSearch Compute Units (OCUs).
        /// </para>
        /// </summary>
        public CollectionGroupCapacityLimits CapacityLimits { get; set; }

        /// <summary>
        /// Checks to see if the CapacityLimits property is set.
        /// </summary>
        internal bool IsSetCapacityLimits() => this.CapacityLimits != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The Epoch time when the collection group was created.
        /// </para>
        /// </summary>
        public long? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentCapacity. 
        /// <para>
        /// Current search and indexing capacity for the collection group.
        /// </para>
        /// </summary>
        public CurrentCapacity CurrentCapacity { get; set; }

        /// <summary>
        /// Checks to see if the CurrentCapacity property is set.
        /// </summary>
        internal bool IsSetCurrentCapacity() => this.CurrentCapacity != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the collection group.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Generation. 
        /// <para>
        /// The generation of Amazon OpenSearch Serverless for the collection group.
        /// </para>
        /// </summary>
        public ServerlessGeneration Generation { get; set; }

        /// <summary>
        /// Checks to see if the Generation property is set.
        /// </summary>
        internal bool IsSetGeneration() => this.Generation != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the collection group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 40)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the collection group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 32)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NumberOfCollections. 
        /// <para>
        /// The number of collections associated with the collection group.
        /// </para>
        /// </summary>
        public int? NumberOfCollections { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfCollections property is set.
        /// </summary>
        internal bool IsSetNumberOfCollections() => this.NumberOfCollections.HasValue;

        /// <summary>
        /// Gets and sets the property StandbyReplicas. 
        /// <para>
        /// Indicates whether standby replicas are used for the collection group.
        /// </para>
        /// </summary>
        public StandbyReplicas StandbyReplicas { get; set; }

        /// <summary>
        /// Checks to see if the StandbyReplicas property is set.
        /// </summary>
        internal bool IsSetStandbyReplicas() => this.StandbyReplicas != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs associated with the collection group.
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
