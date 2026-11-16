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

namespace Amazon.S3Vectors.Model
{
    /// <summary>
    /// Relevance scores for a full-text-only or hybrid search result.
    /// </summary>
    public partial class QueryScores
    {
        /// <summary>
        /// Gets and sets the property Bm25Scores. 
        /// <para>
        /// The BM25 scores for the searchable metadata keys that the result matched.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Bm25Score> Bm25Scores { get; set; } = AWSConfigs.InitializeCollections ? new List<Bm25Score>() : null;

        /// <summary>
        /// Checks to see if the Bm25Scores property is set.
        /// </summary>
        internal bool IsSetBm25Scores() => this.Bm25Scores != null && (this.Bm25Scores.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Fused. 
        /// <para>
        /// The Reciprocal Rank Fusion (RRF) score that combines the vector and full-text rankings.
        /// This field is returned only for hybrid requests.
        /// </para>
        /// </summary>
        public float? Fused { get; set; }

        /// <summary>
        /// Checks to see if the Fused property is set.
        /// </summary>
        internal bool IsSetFused() => this.Fused.HasValue;

        /// <summary>
        /// Gets and sets the property VectorDistance. 
        /// <para>
        /// The distance from the query vector. This field is returned when a hybrid result matches
        /// the vector search.
        /// </para>
        /// </summary>
        public float? VectorDistance { get; set; }

        /// <summary>
        /// Checks to see if the VectorDistance property is set.
        /// </summary>
        internal bool IsSetVectorDistance() => this.VectorDistance.HasValue;
    }
}
