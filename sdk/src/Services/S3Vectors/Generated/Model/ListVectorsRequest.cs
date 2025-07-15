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
    /// Container for the parameters to the ListVectors operation.
    /// <note> 
    /// <para>
    /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
    /// 
    ///  </note> 
    /// <para>
    /// List vectors in the specified vector index. To specify the vector index, you can either
    /// use both the vector bucket name and the vector index name, or use the vector index
    /// Amazon Resource Name (ARN). 
    /// </para>
    ///  
    /// <para>
    ///  <c>ListVectors</c> operations proceed sequentially; however, for faster performance
    /// on a large number of vectors in a vector index, applications can request a parallel
    /// <c>ListVectors</c> operation by providing the <c>segmentCount</c> and <c>segmentIndex</c>
    /// parameters.
    /// </para>
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3vectors:ListVectors</c> permission to use this operation. Additional
    /// permissions are required based on the request parameters you specify:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// With only <c>s3vectors:ListVectors</c> permission, you can list vector keys when <c>returnData</c>
    /// and <c>returnMetadata</c> are both set to false or not specified..
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you set <c>returnData</c> or <c>returnMetadata</c> to true, you must have both
    /// <c>s3vectors:ListVectors</c> and <c>s3vectors:GetVectors</c> permissions. The request
    /// fails with a <c>403 Forbidden</c> error if you request vector data or metadata without
    /// the <c>s3vectors:GetVectors</c> permission.
    /// </para>
    ///  </li> </ul> </dd> </dl>
    /// </para>
    /// </summary>
    public partial class ListVectorsRequest : AmazonS3VectorsRequest
    {
        private string _indexArn;
        private string _indexName;
        private int? _maxResults;
        private string _nextToken;
        private bool? _returnData;
        private bool? _returnMetadata;
        private int? _segmentCount;
        private int? _segmentIndex;
        private string _vectorBucketName;

        /// <summary>
        /// Gets and sets the property IndexArn. 
        /// <para>
        /// The Amazon resource Name (ARN) of the vector index.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of vectors to return on a page.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <c>maxResults</c>, the <c>ListVectors</c> operation uses a default
        /// value of 500.
        /// </para>
        ///  
        /// <para>
        /// If the processed dataset size exceeds 1 MB before reaching the <c>maxResults</c> value,
        /// the operation stops and returns the vectors that are retrieved up to that point, along
        /// with a <c>nextToken</c> that you can use in a subsequent request to retrieve the next
        /// set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token from a previous request. The value of this field is empty for an
        /// initial request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnData. 
        /// <para>
        /// If true, the vector data of each vector will be included in the response. The default
        /// value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ReturnData
        {
            get { return this._returnData; }
            set { this._returnData = value; }
        }

        // Check to see if ReturnData property is set
        internal bool IsSetReturnData()
        {
            return this._returnData.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReturnMetadata. 
        /// <para>
        /// If true, the metadata associated with each vector will be included in the response.
        /// The default value is <c>false</c>.
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
        /// Gets and sets the property SegmentCount. 
        /// <para>
        /// For a parallel <c>ListVectors</c> request, <c>segmentCount</c> represents the total
        /// number of vector segments into which the <c>ListVectors</c> operation will be divided.
        /// The value of <c>segmentCount</c> corresponds to the number of application workers
        /// that will perform the parallel <c>ListVectors</c> operation. For example, if you want
        /// to use four application threads to list vectors in a vector index, specify a <c>segmentCount</c>
        /// value of 4. 
        /// </para>
        ///  
        /// <para>
        /// If you specify a <c>segmentCount</c> value of 1, the <c>ListVectors</c> operation
        /// will be sequential rather than parallel.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>segmentCount</c>, you must also specify <c>segmentIndex</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public int? SegmentCount
        {
            get { return this._segmentCount; }
            set { this._segmentCount = value; }
        }

        // Check to see if SegmentCount property is set
        internal bool IsSetSegmentCount()
        {
            return this._segmentCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentIndex. 
        /// <para>
        /// For a parallel <c>ListVectors</c> request, <c>segmentIndex</c> is the index of the
        /// segment from which to list vectors in the current request. It identifies an individual
        /// segment to be listed by an application worker. 
        /// </para>
        ///  
        /// <para>
        /// Segment IDs are zero-based, so the first segment is always 0. For example, if you
        /// want to use four application threads to list vectors in a vector index, then the first
        /// thread specifies a <c>segmentIndex</c> value of 0, the second thread specifies 1,
        /// and so on. 
        /// </para>
        ///  
        /// <para>
        /// The value of <c>segmentIndex</c> must be less than the value provided for <c>segmentCount</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you provide <c>segmentIndex</c>, you must also provide <c>segmentCount</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int? SegmentIndex
        {
            get { return this._segmentIndex; }
            set { this._segmentIndex = value; }
        }

        // Check to see if SegmentIndex property is set
        internal bool IsSetSegmentIndex()
        {
            return this._segmentIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VectorBucketName. 
        /// <para>
        /// The name of the vector bucket. 
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