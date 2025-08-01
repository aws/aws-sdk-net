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
 * Do not modify this file. This file is generated from the s3vectors-2025-07-15.normal.json service model.
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
    /// Container for the parameters to the QueryVectors operation.
    /// <note> 
    /// <para>
    /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
    /// 
    ///  </note> 
    /// <para>
    /// Performs an approximate nearest neighbor search query in a vector index using a query
    /// vector. By default, it returns the keys of approximate nearest neighbors. You can
    /// optionally include the computed distance (between the query vector and each vector
    /// in the response), the vector data, and metadata of each vector in the response. 
    /// </para>
    ///  
    /// <para>
    /// To specify the vector index, you can either use both the vector bucket name and the
    /// vector index name, or use the vector index Amazon Resource Name (ARN). 
    /// </para>
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3vectors:QueryVectors</c> permission to use this operation.
    /// Additional permissions are required based on the request parameters you specify:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// With only <c>s3vectors:QueryVectors</c> permission, you can retrieve vector keys of
    /// approximate nearest neighbors and computed distances between these vectors. This permission
    /// is sufficient only when you don't set any metadata filters and don't request vector
    /// data or metadata (by keeping the <c>returnMetadata</c> parameter set to <c>false</c>
    /// or not specified).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you specify a metadata filter or set <c>returnMetadata</c> to true, you must have
    /// both <c>s3vectors:QueryVectors</c> and <c>s3vectors:GetVectors</c> permissions. The
    /// request fails with a <c>403 Forbidden error</c> if you request metadata filtering,
    /// vector data, or metadata without the <c>s3vectors:GetVectors</c> permission.
    /// </para>
    ///  </li> </ul> </dd> </dl>
    /// </para>
    /// </summary>
    public partial class QueryVectorsRequest : AmazonS3VectorsRequest
    {
        private Amazon.Runtime.Documents.Document _filter;
        private string _indexArn;
        private string _indexName;
        private VectorData _queryVector;
        private bool? _returnDistance;
        private bool? _returnMetadata;
        private int? _topk;
        private string _vectorBucketName;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Metadata filter to apply during the query. For more information about metadata keys,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-vectors-metadata-filtering.html">Metadata
        /// filtering</a> in the <i>Amazon S3 User Guide</i>. 
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return !this._filter.IsNull();
        }

        /// <summary>
        /// Gets and sets the property IndexArn. 
        /// <para>
        /// The ARN of the vector index that you want to query.
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
        /// The name of the vector index that you want to query. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
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
        /// Gets and sets the property QueryVector. 
        /// <para>
        /// The query vector. Ensure that the query vector has the same dimension as the dimension
        /// of the vector index that's being queried. For example, if your vector index contains
        /// vectors with 384 dimensions, your query vector must also have 384 dimensions. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VectorData QueryVector
        {
            get { return this._queryVector; }
            set { this._queryVector = value; }
        }

        // Check to see if QueryVector property is set
        internal bool IsSetQueryVector()
        {
            return this._queryVector != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnDistance. 
        /// <para>
        /// Indicates whether to include the computed distance in the response. The default value
        /// is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ReturnDistance
        {
            get { return this._returnDistance; }
            set { this._returnDistance = value; }
        }

        // Check to see if ReturnDistance property is set
        internal bool IsSetReturnDistance()
        {
            return this._returnDistance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReturnMetadata. 
        /// <para>
        /// Indicates whether to include metadata in the response. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ReturnMetadata
        {
            get { return this._returnMetadata; }
            set { this._returnMetadata = value; }
        }

        // Check to see if ReturnMetadata property is set
        internal bool IsSetReturnMetadata()
        {
            return this._returnMetadata.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopK. 
        /// <para>
        /// The number of results to return for each query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? TopK
        {
            get { return this._topk; }
            set { this._topk = value; }
        }

        // Check to see if TopK property is set
        internal bool IsSetTopK()
        {
            return this._topk.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VectorBucketName. 
        /// <para>
        /// The name of the vector bucket that contains the vector index. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string VectorBucketName
        {
            get { return this._vectorBucketName; }
            set { this._vectorBucketName = value; }
        }

        // Check to see if VectorBucketName property is set
        internal bool IsSetVectorBucketName()
        {
            return this._vectorBucketName != null;
        }

    }
}