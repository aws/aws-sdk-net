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

namespace Amazon.S3Files.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFileSystem operation. Creates an S3 File
    /// System resource scoped to a bucket or prefix within a bucket, enabling file system
    /// access to S3 data. To create a file system, you need an S3 bucket and an IAM role
    /// that grants the service permission to access the bucket.
    /// </summary>
    public partial class CreateFileSystemRequest : AmazonS3FilesRequest
    {
        /// <summary>
        /// Gets and sets the property AcceptBucketWarning. 
        /// <para>
        /// Set to true to acknowledge and accept any warnings about the bucket configuration.
        /// If not specified, the operation may fail if there are bucket configuration warnings.
        /// </para>
        /// </summary>
        public bool? AcceptBucketWarning { get; set; }

        /// <summary>
        /// Checks to see if the AcceptBucketWarning property is set.
        /// </summary>
        internal bool IsSetAcceptBucketWarning() => this.AcceptBucketWarning.HasValue;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket that will be accessible through the
        /// file system. The bucket must exist and be in the same Amazon Web Services Region as
        /// the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure idempotent creation.
        /// Up to 64 ASCII characters are allowed. If you don't specify a client token, the Amazon
        /// Web Services SDK automatically generates one.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN, key ID, or alias of the KMS key to use for encryption. If not specified,
        /// the service uses a service-owned key for encryption. You can specify a KMS key using
        /// the following formats: key ID, ARN, key alias, or key alias ARN. If you use <c>KmsKeyId</c>,
        /// the file system will be encrypted.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// An optional prefix within the S3 bucket to scope the file system access. If specified,
        /// the file system provides access only to objects with keys that begin with this prefix.
        /// If not specified, the file system provides access to the entire bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that grants the S3 Files service permission to read and write
        /// data between the file system and the S3 bucket. This role must have the necessary
        /// permissions to access the specified bucket and prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs to apply as tags to the file system resource. Each tag
        /// is a user-defined key-value pair. You can use tags to categorize and manage your file
        /// systems. Each key must be unique for the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
