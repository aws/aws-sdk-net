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
    /// Container for the parameters to the QueryVectors operation. Returns matching vector
    /// keys from a vector index ranked by vector similarity, full-text relevance, or both.
    /// Specify <c>queryVector</c> to perform a vector search, specify <c>queryTexts</c> to
    /// perform a full-text search, or specify both to perform a hybrid search. Full-text
    /// search ranks results using BM25. Hybrid search combines the vector and full-text rankings
    /// using Reciprocal Rank Fusion (RRF). <para> Amazon S3 Vectors ranks results by distance
    /// for a vector-only search, by BM25 score for a full-text-only search, and by RRF score
    /// for a hybrid search. You can optionally include computed distances, relevance scores,
    /// and vector metadata in the response. Full-text and hybrid searches require a vector
    /// index in <c>ENHANCED</c> mode. </para> <para> To specify the vector index, you can
    /// either use both the vector bucket name and the vector index name, or use the vector
    /// index Amazon Resource Name (ARN). </para> <dl> <dt>Permissions</dt> <dd> <para> You
    /// must have the <c>s3vectors:QueryVectors</c> permission to use this operation. Additional
    /// permissions are required based on the request parameters you specify: </para> <ul>
    /// <li> <para> With only <c>s3vectors:QueryVectors</c> permission, you can retrieve vector
    /// keys of approximate nearest neighbors and computed distances between these vectors.
    /// This permission is sufficient only when you don't set <c>queryTexts</c>, don't set
    /// any metadata filters, and don't request metadata (by keeping the <c>returnMetadata</c>
    /// parameter set to <c>false</c> or not specified). </para> </li> <li> <para> To use
    /// <c>queryTexts</c>, a metadata filter, or <c>returnMetadata</c> set to <c>true</c>
    /// with this operation, you must have both the <c>s3vectors:QueryVectors</c> and <c>s3vectors:GetVectors</c>
    /// permissions. If you use any of these options without the <c>s3vectors:GetVectors</c>
    /// permission, Amazon S3 Vectors returns an <c>AccessDeniedException</c>. </para> </li>
    /// </ul> </dd> </dl>
    /// </summary>
    public partial class QueryVectorsRequest : AmazonS3VectorsRequest
    {
        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Metadata filter to apply during the query. For more information about metadata keys,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-vectors-metadata-filtering.html">Metadata
        /// filtering</a> in the <i>Amazon S3 User Guide</i>. 
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => !this.Filter.IsNull();

        /// <summary>
        /// Gets and sets the property IndexArn. 
        /// <para>
        /// The ARN of the vector index that you want to query.
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
        /// The name of the vector index that you want to query. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token from a previous request. The value of this field is empty for an
        /// initial request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property QueryMode. 
        /// <para>
        /// The mode to use to process the query. If you don't specify a query mode, the operation
        /// uses the mode that's currently configured for the vector index.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CLASSIC</c> - Applies metadata filters during the vector search. You can't specify
        /// <c>CLASSIC</c> for an <c>ENHANCED</c> index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENHANCED</c> - Applies metadata filters before the vector search.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IndexMode QueryMode { get; set; }

        /// <summary>
        /// Checks to see if the QueryMode property is set.
        /// </summary>
        internal bool IsSetQueryMode() => this.QueryMode != null;

        /// <summary>
        /// Gets and sets the property QueryTexts. 
        /// <para>
        /// Full-text queries for searchable metadata keys. Omit <c>queryVector</c> to run a full-text-only
        /// search, or provide both fields to run a hybrid search. Each entry must target a distinct
        /// searchable metadata key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<QueryText> QueryTexts { get; set; } = AWSConfigs.InitializeCollections ? new List<QueryText>() : null;

        /// <summary>
        /// Checks to see if the QueryTexts property is set.
        /// </summary>
        internal bool IsSetQueryTexts() => this.QueryTexts != null && (this.QueryTexts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryVector. 
        /// <para>
        /// The query vector for vector similarity search. The query vector must have the same
        /// dimension as the vector index. For example, if the vector index has 384 dimensions,
        /// the query vector must also have 384 dimensions. You can omit this parameter when you
        /// supply <c>queryTexts</c> to perform a full-text-only search. A request must include
        /// <c>queryVector</c>, <c>queryTexts</c>, or both.
        /// </para>
        /// </summary>
        public VectorData QueryVector { get; set; }

        /// <summary>
        /// Checks to see if the QueryVector property is set.
        /// </summary>
        internal bool IsSetQueryVector() => this.QueryVector != null;

        /// <summary>
        /// Gets and sets the property ReturnDistance. 
        /// <para>
        /// Indicates whether to include the computed distance in the response. The default value
        /// is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ReturnDistance { get; set; }

        /// <summary>
        /// Checks to see if the ReturnDistance property is set.
        /// </summary>
        internal bool IsSetReturnDistance() => this.ReturnDistance.HasValue;

        /// <summary>
        /// Gets and sets the property ReturnMetadata. 
        /// <para>
        /// Indicates whether to include metadata in the response. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ReturnMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ReturnMetadata property is set.
        /// </summary>
        internal bool IsSetReturnMetadata() => this.ReturnMetadata.HasValue;

        /// <summary>
        /// Gets and sets the property ReturnScores. 
        /// <para>
        /// Indicates whether to include relevance scores in the response. Full-text-only results
        /// can include BM25 scores. Hybrid results can also include a Reciprocal Rank Fusion
        /// (RRF) score and vector distance. This setting doesn't add scores to vector-only requests.
        /// The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ReturnScores { get; set; }

        /// <summary>
        /// Checks to see if the ReturnScores property is set.
        /// </summary>
        internal bool IsSetReturnScores() => this.ReturnScores.HasValue;

        /// <summary>
        /// Gets and sets the property TopK. 
        /// <para>
        /// The number of results to return for each query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? TopK { get; set; }

        /// <summary>
        /// Checks to see if the TopK property is set.
        /// </summary>
        internal bool IsSetTopK() => this.TopK.HasValue;

        /// <summary>
        /// Gets and sets the property VectorBucketName. 
        /// <para>
        /// The name of the vector bucket that contains the vector index. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string VectorBucketName { get; set; }

        /// <summary>
        /// Checks to see if the VectorBucketName property is set.
        /// </summary>
        internal bool IsSetVectorBucketName() => this.VectorBucketName != null;
    }
}
