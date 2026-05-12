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
 * Do not modify this file. This file is generated from the s3files-2025-05-05.normal.json service model.
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
namespace Amazon.S3Files.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFileSystem operation.
    /// Creates an S3 File System resource scoped to a bucket or prefix within a bucket, enabling
    /// file system access to S3 data. To create a file system, you need an S3 bucket and
    /// an IAM role that grants the service permission to access the bucket.
    /// </summary>
    public partial class CreateFileSystemRequest : AmazonS3FilesRequest
    {
        private bool? _acceptBucketWarning;
        private string _bucket;
        private string _clientToken;
        private string _kmsKeyId;
        private string _prefix;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AcceptBucketWarning. 
        /// <para>
        /// Set to true to acknowledge and accept any warnings about the bucket configuration.
        /// If not specified, the operation may fail if there are bucket configuration warnings.
        /// </para>
        /// </summary>
        public bool? AcceptBucketWarning
        {
            get { return this._acceptBucketWarning; }
            set { this._acceptBucketWarning = value; }
        }

        // Check to see if AcceptBucketWarning property is set
        internal bool IsSetAcceptBucketWarning()
        {
            return this._acceptBucketWarning.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket that will be accessible through the
        /// file system. The bucket must exist and be in the same Amazon Web Services Region as
        /// the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure idempotent creation.
        /// Up to 64 ASCII characters are allowed. If you don't specify a client token, the Amazon
        /// Web Services SDK automatically generates one.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN, key ID, or alias of the KMS key to use for encryption. If not specified,
        /// the service uses a service-owned key for encryption. You can specify a KMS key using
        /// the following formats: key ID, ARN, key alias, or key alias ARN. If you use <c>KmsKeyId</c>,
        /// the file system will be encrypted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// An optional prefix within the S3 bucket to scope the file system access. If specified,
        /// the file system provides access only to objects with keys that begin with this prefix.
        /// If not specified, the file system provides access to the entire bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that grants the S3 Files service permission to read and write
        /// data between the file system and the S3 bucket. This role must have the necessary
        /// permissions to access the specified bucket and prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs to apply as tags to the file system resource. Each tag
        /// is a user-defined key-value pair. You can use tags to categorize and manage your file
        /// systems. Each key must be unique for the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}