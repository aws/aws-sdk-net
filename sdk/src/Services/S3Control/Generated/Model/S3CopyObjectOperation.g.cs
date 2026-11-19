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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Contains the configuration parameters for a PUT Copy object operation. S3 Batch Operations
    /// passes every object to the underlying <c>CopyObject</c> API operation. For more information
    /// about the parameters for this operation, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectCOPY.html">CopyObject</a>.
    /// </summary>
    public partial class S3CopyObjectOperation
    {
        /// <summary>
        /// Gets and sets the property AccessControlGrants. 
        /// <para>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Grant> AccessControlGrants { get; set; } = AWSConfigs.InitializeCollections ? new List<S3Grant>() : null;

        /// <summary>
        /// Checks to see if the AccessControlGrants property is set.
        /// </summary>
        internal bool IsSetAccessControlGrants() => this.AccessControlGrants != null && (this.AccessControlGrants.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AnnotationDirective. 
        /// <para>
        /// Specifies whether the Batch Operations copy job copies object annotations from the
        /// source object or skips them. If this property isn't specified, <c>COPY</c> is the
        /// default behavior.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>COPY | EXCLUDE</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public S3AnnotationDirective AnnotationDirective { get; set; }

        /// <summary>
        /// Checks to see if the AnnotationDirective property is set.
        /// </summary>
        internal bool IsSetAnnotationDirective() => this.AnnotationDirective != null;

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Specifies whether Amazon S3 should use an S3 Bucket Key for object encryption with
        /// server-side encryption using Amazon Web Services KMS (SSE-KMS). Setting this header
        /// to <c>true</c> causes Amazon S3 to use an S3 Bucket Key for object encryption with
        /// SSE-KMS.
        /// </para>
        ///  
        /// <para>
        /// Specifying this header with an <i>Copy</i> action doesn’t affect <i>bucket-level</i>
        /// settings for S3 Bucket Key.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - S3 Bucket Keys aren't supported, when you copy SSE-KMS
        /// encrypted objects from general purpose buckets to directory buckets, from directory
        /// buckets to general purpose buckets, or between directory buckets, through <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-objects-Batch-Ops">the
        /// Copy operation in Batch Operations</a>. In this case, Amazon S3 makes a call to KMS
        /// every time a copy request is made for a KMS-encrypted object.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? BucketKeyEnabled { get; set; }

        /// <summary>
        /// Checks to see if the BucketKeyEnabled property is set.
        /// </summary>
        internal bool IsSetBucketKeyEnabled() => this.BucketKeyEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property CannedAccessControlList. 
        /// <para>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public S3CannedAccessControlList CannedAccessControlList { get; set; }

        /// <summary>
        /// Checks to see if the CannedAccessControlList property is set.
        /// </summary>
        internal bool IsSetCannedAccessControlList() => this.CannedAccessControlList != null;

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm that you want Amazon S3 to use to create the checksum. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public S3ChecksumAlgorithm ChecksumAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the ChecksumAlgorithm property is set.
        /// </summary>
        internal bool IsSetChecksumAlgorithm() => this.ChecksumAlgorithm != null;

        /// <summary>
        /// Gets and sets the property MetadataDirective. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public S3MetadataDirective MetadataDirective { get; set; }

        /// <summary>
        /// Checks to see if the MetadataDirective property is set.
        /// </summary>
        internal bool IsSetMetadataDirective() => this.MetadataDirective != null;

        /// <summary>
        /// Gets and sets the property ModifiedSinceConstraint. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public DateTime? ModifiedSinceConstraint { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedSinceConstraint property is set.
        /// </summary>
        internal bool IsSetModifiedSinceConstraint() => this.ModifiedSinceConstraint.HasValue;

        /// <summary>
        /// Gets and sets the property NewObjectMetadata. 
        /// <para>
        /// If you don't provide this parameter, Amazon S3 copies all the metadata from the original
        /// objects. If you specify an empty set, the new objects will have no tags. Otherwise,
        /// Amazon S3 assigns the supplied tags to the new objects.
        /// </para>
        /// </summary>
        public S3ObjectMetadata NewObjectMetadata { get; set; }

        /// <summary>
        /// Checks to see if the NewObjectMetadata property is set.
        /// </summary>
        internal bool IsSetNewObjectMetadata() => this.NewObjectMetadata != null;

        /// <summary>
        /// Gets and sets the property NewObjectTagging. 
        /// <para>
        /// Specifies a list of tags to add to the destination objects after they are copied.
        /// If <c>NewObjectTagging</c> is not specified, the tags of the source objects are copied
        /// to destination objects by default.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - Tags aren't supported by directory buckets. If your source
        /// objects have tags and your destination bucket is a directory bucket, specify an empty
        /// tag set in the <c>NewObjectTagging</c> field to prevent copying the source object
        /// tags to the directory bucket.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Tag> NewObjectTagging { get; set; } = AWSConfigs.InitializeCollections ? new List<S3Tag>() : null;

        /// <summary>
        /// Checks to see if the NewObjectTagging property is set.
        /// </summary>
        internal bool IsSetNewObjectTagging() => this.NewObjectTagging != null && (this.NewObjectTagging.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ObjectLockEventHold. 
        /// <para>
        /// The event hold status to be applied to all objects in the Batch Operations copy job.
        /// Set to <c>ON</c> to enable an event hold or <c>OFF</c> to disable it.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public S3ObjectLockEventHold ObjectLockEventHold { get; set; }

        /// <summary>
        /// Checks to see if the ObjectLockEventHold property is set.
        /// </summary>
        internal bool IsSetObjectLockEventHold() => this.ObjectLockEventHold != null;

        /// <summary>
        /// Gets and sets the property ObjectLockEventHoldDuration. 
        /// <para>
        /// The event hold duration to be applied to all objects in the Batch Operations copy
        /// job. The duration specifies how long the object remains protected after the event
        /// hold is released.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public S3ObjectLockEventHoldDuration ObjectLockEventHoldDuration { get; set; }

        /// <summary>
        /// Checks to see if the ObjectLockEventHoldDuration property is set.
        /// </summary>
        internal bool IsSetObjectLockEventHoldDuration() => this.ObjectLockEventHoldDuration != null;

        /// <summary>
        /// Gets and sets the property ObjectLockLegalHoldStatus. 
        /// <para>
        /// The legal hold status to be applied to all objects in the Batch Operations job.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public S3ObjectLockLegalHoldStatus ObjectLockLegalHoldStatus { get; set; }

        /// <summary>
        /// Checks to see if the ObjectLockLegalHoldStatus property is set.
        /// </summary>
        internal bool IsSetObjectLockLegalHoldStatus() => this.ObjectLockLegalHoldStatus != null;

        /// <summary>
        /// Gets and sets the property ObjectLockMode. 
        /// <para>
        /// The retention mode to be applied to all objects in the Batch Operations job.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public S3ObjectLockMode ObjectLockMode { get; set; }

        /// <summary>
        /// Checks to see if the ObjectLockMode property is set.
        /// </summary>
        internal bool IsSetObjectLockMode() => this.ObjectLockMode != null;

        /// <summary>
        /// Gets and sets the property ObjectLockRetainUntilDate. 
        /// <para>
        /// The date when the applied object retention configuration expires on all objects in
        /// the Batch Operations job.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime? ObjectLockRetainUntilDate { get; set; }

        /// <summary>
        /// Checks to see if the ObjectLockRetainUntilDate property is set.
        /// </summary>
        internal bool IsSetObjectLockRetainUntilDate() => this.ObjectLockRetainUntilDate.HasValue;

        /// <summary>
        /// Gets and sets the property RedirectLocation. 
        /// <para>
        /// If the destination bucket is configured as a website, specifies an optional metadata
        /// property for website redirects, <c>x-amz-website-redirect-location</c>. Allows webpage
        /// redirects if the object copy is accessed through a website endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string RedirectLocation { get; set; }

        /// <summary>
        /// Checks to see if the RedirectLocation property is set.
        /// </summary>
        internal bool IsSetRedirectLocation() => this.RedirectLocation != null;

        /// <summary>
        /// Gets and sets the property RequesterPays. 
        /// <para>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? RequesterPays { get; set; }

        /// <summary>
        /// Checks to see if the RequesterPays property is set.
        /// </summary>
        internal bool IsSetRequesterPays() => this.RequesterPays.HasValue;

        /// <summary>
        /// Gets and sets the property SSEAwsKmsKeyId. 
        /// <para>
        /// Specifies the KMS key ID (Key ID, Key ARN, or Key Alias) to use for object encryption.
        /// If the KMS key doesn't exist in the same account that's issuing the command, you must
        /// use the full Key ARN not the Key ID.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - If you specify <c>SSEAlgorithm</c> with <c>KMS</c>, you
        /// must specify the <c> SSEAwsKmsKeyId</c> parameter with the ID (Key ID or Key ARN)
        /// of the KMS symmetric encryption customer managed key to use. Otherwise, you get an
        /// HTTP <c>400 Bad Request</c> error. The key alias format of the KMS key isn't supported.
        /// To encrypt new object copies in a directory bucket with SSE-KMS, you must specify
        /// SSE-KMS as the directory bucket's default encryption configuration with a KMS key
        /// (specifically, a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a>). The <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed key</a> (<c>aws/s3</c>) isn't supported. Your SSE-KMS configuration
        /// can only support 1 <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a> per directory bucket for the lifetime of the bucket. After you specify
        /// a customer managed key for SSE-KMS as the bucket default encryption, you can't override
        /// the customer managed key for the bucket's SSE-KMS configuration. Then, when you specify
        /// server-side encryption settings for new object copies with SSE-KMS, you must make
        /// sure the encryption key is the same customer managed key that you specified for the
        /// directory bucket's default encryption configuration. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string SSEAwsKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the SSEAwsKmsKeyId property is set.
        /// </summary>
        internal bool IsSetSSEAwsKmsKeyId() => this.SSEAwsKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// Specify the storage class for the destination objects in a <c>Copy</c> operation.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets </b> - This functionality is not supported by directory buckets.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public S3StorageClass StorageClass { get; set; }

        /// <summary>
        /// Checks to see if the StorageClass property is set.
        /// </summary>
        internal bool IsSetStorageClass() => this.StorageClass != null;

        /// <summary>
        /// Gets and sets the property TargetKeyPrefix. 
        /// <para>
        /// Specifies the folder prefix that you want the objects to be copied into. For example,
        /// to copy objects into a folder named <c>Folder1</c> in the destination bucket, set
        /// the <c>TargetKeyPrefix</c> property to <c>Folder1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string TargetKeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the TargetKeyPrefix property is set.
        /// </summary>
        internal bool IsSetTargetKeyPrefix() => this.TargetKeyPrefix != null;

        /// <summary>
        /// Gets and sets the property TargetResource. 
        /// <para>
        /// Specifies the destination bucket Amazon Resource Name (ARN) for the batch copy operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>General purpose buckets</b> - For example, to copy objects to a general purpose
        /// bucket named <c>destinationBucket</c>, set the <c>TargetResource</c> property to <c>arn:aws:s3:::destinationBucket</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Directory buckets</b> - For example, to copy objects to a directory bucket named
        /// <c>destinationBucket</c> in the Availability Zone identified by the AZ ID <c>usw2-az1</c>,
        /// set the <c>TargetResource</c> property to <c>arn:aws:s3express:<i>region</i>:<i>account_id</i>:/bucket/<i>destination_bucket_base_name</i>--<i>usw2-az1</i>--x-s3</c>.
        /// A directory bucket as a destination bucket can be in Availability Zone or Local Zone.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Copying objects across different Amazon Web Services Regions isn't supported when
        /// the source or destination bucket is in Amazon Web Services Local Zones. The source
        /// and destination buckets must have the same parent Amazon Web Services Region. Otherwise,
        /// you get an HTTP <c>400 Bad Request</c> error with the error code <c>InvalidRequest</c>.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TargetResource { get; set; }

        /// <summary>
        /// Checks to see if the TargetResource property is set.
        /// </summary>
        internal bool IsSetTargetResource() => this.TargetResource != null;

        /// <summary>
        /// Gets and sets the property UnModifiedSinceConstraint. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public DateTime? UnModifiedSinceConstraint { get; set; }

        /// <summary>
        /// Checks to see if the UnModifiedSinceConstraint property is set.
        /// </summary>
        internal bool IsSetUnModifiedSinceConstraint() => this.UnModifiedSinceConstraint.HasValue;
    }
}
