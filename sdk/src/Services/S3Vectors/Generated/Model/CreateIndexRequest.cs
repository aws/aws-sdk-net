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
    /// Container for the parameters to the CreateIndex operation.
    /// Creates a vector index within a vector bucket. To specify the vector bucket, you must
    /// use either the vector bucket name or the vector bucket Amazon Resource Name (ARN).
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3vectors:CreateIndex</c> permission to use this operation.
    /// </para>
    ///  
    /// <para>
    /// You must have the <c>s3vectors:TagResource</c> permission in addition to <c>s3vectors:CreateIndex</c>
    /// permission to create a vector index with tags.
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class CreateIndexRequest : AmazonS3VectorsRequest
    {
        private DataType _dataType;
        private int? _dimension;
        private DistanceMetric _distanceMetric;
        private EncryptionConfiguration _encryptionConfiguration;
        private string _indexName;
        private MetadataConfiguration _metadataConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _vectorBucketArn;
        private string _vectorBucketName;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the vectors to be inserted into the vector index. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataType DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// The dimensions of the vectors to be inserted into the vector index. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public int Dimension
        {
            get { return this._dimension.GetValueOrDefault(); }
            set { this._dimension = value; }
        }

        // Check to see if Dimension property is set
        internal bool IsSetDimension()
        {
            return this._dimension.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DistanceMetric. 
        /// <para>
        /// The distance metric to be used for similarity search. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DistanceMetric DistanceMetric
        {
            get { return this._distanceMetric; }
            set { this._distanceMetric = value; }
        }

        // Check to see if DistanceMetric property is set
        internal bool IsSetDistanceMetric()
        {
            return this._distanceMetric != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for a vector index. By default, if you don't specify,
        /// all new vectors in the vector index will use the encryption configuration of the vector
        /// bucket.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the vector index to create. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
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
        /// Gets and sets the property MetadataConfiguration. 
        /// <para>
        /// The metadata configuration for the vector index. 
        /// </para>
        /// </summary>
        public MetadataConfiguration MetadataConfiguration
        {
            get { return this._metadataConfiguration; }
            set { this._metadataConfiguration = value; }
        }

        // Check to see if MetadataConfiguration property is set
        internal bool IsSetMetadataConfiguration()
        {
            return this._metadataConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of user-defined tags that you would like to apply to the vector index that
        /// you are creating. A tag is a key-value pair that you apply to your resources. Tags
        /// can help you organize, track costs, and control access to resources. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html">Tagging
        /// for cost allocation or attribute-based access control (ABAC)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must have the <c>s3vectors:TagResource</c> permission in addition to <c>s3vectors:CreateIndex</c>
        /// permission to create a vector index with tags.
        /// </para>
        ///  </note>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VectorBucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vector bucket to create the vector index in.
        /// </para>
        /// </summary>
        public string VectorBucketArn
        {
            get { return this._vectorBucketArn; }
            set { this._vectorBucketArn = value; }
        }

        // Check to see if VectorBucketArn property is set
        internal bool IsSetVectorBucketArn()
        {
            return this._vectorBucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property VectorBucketName. 
        /// <para>
        /// The name of the vector bucket to create the vector index in. 
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