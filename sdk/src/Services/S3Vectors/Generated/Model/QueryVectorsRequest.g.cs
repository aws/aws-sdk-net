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
    /// Container for the parameters to the QueryVectors operation. Performs an approximate
    /// nearest neighbor search query in a vector index using a query vector. By default,
    /// it returns the keys of approximate nearest neighbors. You can optionally include the
    /// computed distance (between the query vector and each vector in the response) and metadata
    /// of each vector in the response. <para> To specify the vector index, you can either
    /// use both the vector bucket name and the vector index name, or use the vector index
    /// Amazon Resource Name (ARN). </para> <dl> <dt>Permissions</dt> <dd> <para> You must
    /// have the <c>s3vectors:QueryVectors</c> permission to use this operation. Additional
    /// permissions are required based on the request parameters you specify: </para> <ul>
    /// <li> <para> With only <c>s3vectors:QueryVectors</c> permission, you can retrieve vector
    /// keys of approximate nearest neighbors and computed distances between these vectors.
    /// This permission is sufficient only when you don't set any metadata filters and don't
    /// request metadata (by keeping the <c>returnMetadata</c> parameter set to <c>false</c>
    /// or not specified). </para> </li> <li> <para> If you specify a metadata filter or set
    /// <c>returnMetadata</c> to true, you must have both <c>s3vectors:QueryVectors</c> and
    /// <c>s3vectors:GetVectors</c> permissions. The request fails with a <c>403 Forbidden
    /// error</c> if you request metadata filtering or metadata without the <c>s3vectors:GetVectors</c>
    /// permission. </para> </li> </ul> </dd> </dl>
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
        /// Gets and sets the property QueryVector. 
        /// <para>
        /// The query vector. Ensure that the query vector has the same dimension as the dimension
        /// of the vector index that's being queried. For example, if your vector index contains
        /// vectors with 384 dimensions, your query vector must also have 384 dimensions. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
