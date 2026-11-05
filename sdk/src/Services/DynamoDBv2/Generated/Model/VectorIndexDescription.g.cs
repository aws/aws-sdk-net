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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Contains the current state and configuration of a vector index, including its status,
    /// size, item count, and the settings specified when the index was created.
    /// </summary>
    public partial class VectorIndexDescription
    {
        /// <summary>
        /// Gets and sets the property Backfilling. 
        /// <para>
        /// Specifies whether the index is currently backfilling. During backfill, <c>SearchVectors</c>
        /// operations might return incomplete results.
        /// </para>
        /// </summary>
        public bool? Backfilling { get; set; }

        /// <summary>
        /// Checks to see if the Backfilling property is set.
        /// </summary>
        internal bool IsSetBackfilling() => this.Backfilling.HasValue;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The number of dimensions in each vector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? Dimensions { get; set; }

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions.HasValue;

        /// <summary>
        /// Gets and sets the property DistanceFunction. 
        /// <para>
        /// The distance function used to calculate similarity between vectors.
        /// </para>
        /// </summary>
        public VectorDistanceFunction DistanceFunction { get; set; }

        /// <summary>
        /// Checks to see if the DistanceFunction property is set.
        /// </summary>
        internal bool IsSetDistanceFunction() => this.DistanceFunction != null;

        /// <summary>
        /// Gets and sets the property IndexArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the vector index.
        /// </para>
        /// </summary>
        public string IndexArn { get; set; }

        /// <summary>
        /// Checks to see if the IndexArn property is set.
        /// </summary>
        internal bool IsSetIndexArn() => this.IndexArn != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the vector index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property IndexSizeBytes. 
        /// <para>
        /// The total size of the vector index, in bytes. Amazon DynamoDB updates this value approximately
        /// every six hours. Recent changes might not be reflected in this value.
        /// </para>
        /// </summary>
        public long? IndexSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the IndexSizeBytes property is set.
        /// </summary>
        internal bool IsSetIndexSizeBytes() => this.IndexSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property IndexStatus. 
        /// <para>
        /// The current state of the vector index:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The index is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The index is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The index is being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IndexStatus IndexStatus { get; set; }

        /// <summary>
        /// Checks to see if the IndexStatus property is set.
        /// </summary>
        internal bool IsSetIndexStatus() => this.IndexStatus != null;

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// The number of items indexed in the vector index. Amazon DynamoDB updates this value
        /// approximately every six hours. Recent changes might not be reflected in this value.
        /// </para>
        /// </summary>
        public long? ItemCount { get; set; }

        /// <summary>
        /// Checks to see if the ItemCount property is set.
        /// </summary>
        internal bool IsSetItemCount() => this.ItemCount.HasValue;

        /// <summary>
        /// Gets and sets the property Projection. 
        /// <para>
        /// Specifies attributes that are copied (projected) from the table into the vector index.
        /// </para>
        /// </summary>
        public Projection Projection { get; set; }

        /// <summary>
        /// Checks to see if the Projection property is set.
        /// </summary>
        internal bool IsSetProjection() => this.Projection != null;

        /// <summary>
        /// Gets and sets the property SearchSchema. 
        /// <para>
        /// The search schema that defines partition key and inline filter attributes for the
        /// vector index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<SearchSchemaElement> SearchSchema { get; set; } = AWSConfigs.InitializeCollections ? new List<SearchSchemaElement>() : null;

        /// <summary>
        /// Checks to see if the SearchSchema property is set.
        /// </summary>
        internal bool IsSetSearchSchema() => this.SearchSchema != null && (this.SearchSchema.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VectorAttribute. 
        /// <para>
        /// The vector attribute configuration for the index.
        /// </para>
        /// </summary>
        public VectorAttributeDefinition VectorAttribute { get; set; }

        /// <summary>
        /// Checks to see if the VectorAttribute property is set.
        /// </summary>
        internal bool IsSetVectorAttribute() => this.VectorAttribute != null;
    }
}
