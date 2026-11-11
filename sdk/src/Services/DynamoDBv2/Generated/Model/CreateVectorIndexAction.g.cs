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
    /// A new vector index to be added to a table.
    /// </summary>
    public partial class CreateVectorIndexAction
    {
        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The number of dimensions in each vector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? Dimensions { get; set; }

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions.HasValue;

        /// <summary>
        /// Gets and sets the property DistanceFunction. 
        /// <para>
        /// The distance function used to calculate similarity. Valid values: <c>COSINE</c>, <c>EUCLIDEAN</c>,
        /// <c>DOT_PRODUCT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VectorDistanceFunction DistanceFunction { get; set; }

        /// <summary>
        /// Checks to see if the DistanceFunction property is set.
        /// </summary>
        internal bool IsSetDistanceFunction() => this.DistanceFunction != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the vector index. Must be unique within the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 255)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property Projection. 
        /// <para>
        /// Specifies attributes that are copied (projected) from the table into the vector index.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Projection Projection { get; set; }

        /// <summary>
        /// Checks to see if the Projection property is set.
        /// </summary>
        internal bool IsSetProjection() => this.Projection != null;

        /// <summary>
        /// Gets and sets the property SearchSchema. 
        /// <para>
        /// The partition key and inline filter attribute definitions for the vector index.
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
        /// The attribute that contains vector embeddings. If multiple vector indexes reference
        /// the same attribute, they must all use the same number of dimensions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VectorAttributeDefinition VectorAttribute { get; set; }

        /// <summary>
        /// Checks to see if the VectorAttribute property is set.
        /// </summary>
        internal bool IsSetVectorAttribute() => this.VectorAttribute != null;
    }
}
