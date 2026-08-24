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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
        private bool? _backfilling;
        private long? _dimensions;
        private VectorDistanceFunction _distanceFunction;
        private string _indexArn;
        private string _indexName;
        private long? _indexSizeBytes;
        private IndexStatus _indexStatus;
        private long? _itemCount;
        private Projection _projection;
        private List<SearchSchemaElement> _searchSchema = AWSConfigs.InitializeCollections ? new List<SearchSchemaElement>() : null;
        private VectorAttributeDefinition _vectorAttribute;

        /// <summary>
        /// Gets and sets the property Backfilling. 
        /// <para>
        /// Specifies whether the index is currently backfilling. During backfill, <c>SearchVectors</c>
        /// operations might return incomplete results.
        /// </para>
        /// </summary>
        public bool? Backfilling
        {
            get { return this._backfilling; }
            set { this._backfilling = value; }
        }

        // Check to see if Backfilling property is set
        internal bool IsSetBackfilling()
        {
            return this._backfilling.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The number of dimensions in each vector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DistanceFunction. 
        /// <para>
        /// The distance function used to calculate similarity between vectors.
        /// </para>
        /// </summary>
        public VectorDistanceFunction DistanceFunction
        {
            get { return this._distanceFunction; }
            set { this._distanceFunction = value; }
        }

        // Check to see if DistanceFunction property is set
        internal bool IsSetDistanceFunction()
        {
            return this._distanceFunction != null;
        }

        /// <summary>
        /// Gets and sets the property IndexArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the vector index.
        /// </para>
        /// </summary>
        public string IndexArn
        {
            get { return this._indexArn; }
            set { this._indexArn = value; }
        }

        // Check to see if IndexArn property is set
        internal bool IsSetIndexArn()
        {
            return this._indexArn != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the vector index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property IndexSizeBytes. 
        /// <para>
        /// The total size of the vector index, in bytes. Amazon DynamoDB updates this value approximately
        /// every six hours. Recent changes might not be reflected in this value.
        /// </para>
        /// </summary>
        public long? IndexSizeBytes
        {
            get { return this._indexSizeBytes; }
            set { this._indexSizeBytes = value; }
        }

        // Check to see if IndexSizeBytes property is set
        internal bool IsSetIndexSizeBytes()
        {
            return this._indexSizeBytes.HasValue; 
        }

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
        public IndexStatus IndexStatus
        {
            get { return this._indexStatus; }
            set { this._indexStatus = value; }
        }

        // Check to see if IndexStatus property is set
        internal bool IsSetIndexStatus()
        {
            return this._indexStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// The number of items indexed in the vector index. Amazon DynamoDB updates this value
        /// approximately every six hours. Recent changes might not be reflected in this value.
        /// </para>
        /// </summary>
        public long? ItemCount
        {
            get { return this._itemCount; }
            set { this._itemCount = value; }
        }

        // Check to see if ItemCount property is set
        internal bool IsSetItemCount()
        {
            return this._itemCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Projection. 
        /// <para>
        /// Specifies attributes that are copied (projected) from the table into the vector index.
        /// </para>
        /// </summary>
        public Projection Projection
        {
            get { return this._projection; }
            set { this._projection = value; }
        }

        // Check to see if Projection property is set
        internal bool IsSetProjection()
        {
            return this._projection != null;
        }

        /// <summary>
        /// Gets and sets the property SearchSchema. 
        /// <para>
        /// The search schema that defines partition key and inline filter attributes for the
        /// vector index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<SearchSchemaElement> SearchSchema
        {
            get { return this._searchSchema; }
            set { this._searchSchema = value; }
        }

        // Check to see if SearchSchema property is set
        internal bool IsSetSearchSchema()
        {
            return this._searchSchema != null && (this._searchSchema.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VectorAttribute. 
        /// <para>
        /// The vector attribute configuration for the index.
        /// </para>
        /// </summary>
        public VectorAttributeDefinition VectorAttribute
        {
            get { return this._vectorAttribute; }
            set { this._vectorAttribute = value; }
        }

        // Check to see if VectorAttribute property is set
        internal bool IsSetVectorAttribute()
        {
            return this._vectorAttribute != null;
        }

    }
}