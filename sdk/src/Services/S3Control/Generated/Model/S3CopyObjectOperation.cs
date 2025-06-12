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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
        private List<S3Grant> _accessControlGrants = AWSConfigs.InitializeCollections ? new List<S3Grant>() : null;
        private bool? _bucketKeyEnabled;
        private S3CannedAccessControlList _cannedAccessControlList;
        private S3ChecksumAlgorithm _checksumAlgorithm;
        private S3MetadataDirective _metadataDirective;
        private DateTime? _modifiedSinceConstraint;
        private S3ObjectMetadata _newObjectMetadata;
        private List<S3Tag> _newObjectTagging = AWSConfigs.InitializeCollections ? new List<S3Tag>() : null;
        private S3ObjectLockLegalHoldStatus _objectLockLegalHoldStatus;
        private S3ObjectLockMode _objectLockMode;
        private DateTime? _objectLockRetainUntilDate;
        private string _redirectLocation;
        private bool? _requesterPays;
        private string _sseAwsKmsKeyId;
        private S3StorageClass _storageClass;
        private string _targetKeyPrefix;
        private string _targetResource;
        private DateTime? _unModifiedSinceConstraint;

        /// <summary>
        /// Gets and sets the property AccessControlGrants.  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Grant> AccessControlGrants
        {
            get { return this._accessControlGrants; }
            set { this._accessControlGrants = value; }
        }

        // Check to see if AccessControlGrants property is set
        internal bool IsSetAccessControlGrants()
        {
            return this._accessControlGrants != null && (this._accessControlGrants.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public bool? BucketKeyEnabled
        {
            get { return this._bucketKeyEnabled; }
            set { this._bucketKeyEnabled = value; }
        }

        // Check to see if BucketKeyEnabled property is set
        internal bool IsSetBucketKeyEnabled()
        {
            return this._bucketKeyEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CannedAccessControlList.  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public S3CannedAccessControlList CannedAccessControlList
        {
            get { return this._cannedAccessControlList; }
            set { this._cannedAccessControlList = value; }
        }

        // Check to see if CannedAccessControlList property is set
        internal bool IsSetCannedAccessControlList()
        {
            return this._cannedAccessControlList != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm that you want Amazon S3 to use to create the checksum. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public S3ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataDirective.
        /// </summary>
        public S3MetadataDirective MetadataDirective
        {
            get { return this._metadataDirective; }
            set { this._metadataDirective = value; }
        }

        // Check to see if MetadataDirective property is set
        internal bool IsSetMetadataDirective()
        {
            return this._metadataDirective != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedSinceConstraint.
        /// </summary>
        public DateTime? ModifiedSinceConstraint
        {
            get { return this._modifiedSinceConstraint; }
            set { this._modifiedSinceConstraint = value; }
        }

        // Check to see if ModifiedSinceConstraint property is set
        internal bool IsSetModifiedSinceConstraint()
        {
            return this._modifiedSinceConstraint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NewObjectMetadata. 
        /// <para>
        /// If you don't provide this parameter, Amazon S3 copies all the metadata from the original
        /// objects. If you specify an empty set, the new objects will have no tags. Otherwise,
        /// Amazon S3 assigns the supplied tags to the new objects.
        /// </para>
        /// </summary>
        public S3ObjectMetadata NewObjectMetadata
        {
            get { return this._newObjectMetadata; }
            set { this._newObjectMetadata = value; }
        }

        // Check to see if NewObjectMetadata property is set
        internal bool IsSetNewObjectMetadata()
        {
            return this._newObjectMetadata != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Tag> NewObjectTagging
        {
            get { return this._newObjectTagging; }
            set { this._newObjectTagging = value; }
        }

        // Check to see if NewObjectTagging property is set
        internal bool IsSetNewObjectTagging()
        {
            return this._newObjectTagging != null && (this._newObjectTagging.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public S3ObjectLockLegalHoldStatus ObjectLockLegalHoldStatus
        {
            get { return this._objectLockLegalHoldStatus; }
            set { this._objectLockLegalHoldStatus = value; }
        }

        // Check to see if ObjectLockLegalHoldStatus property is set
        internal bool IsSetObjectLockLegalHoldStatus()
        {
            return this._objectLockLegalHoldStatus != null;
        }

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
        public S3ObjectLockMode ObjectLockMode
        {
            get { return this._objectLockMode; }
            set { this._objectLockMode = value; }
        }

        // Check to see if ObjectLockMode property is set
        internal bool IsSetObjectLockMode()
        {
            return this._objectLockMode != null;
        }

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
        public DateTime? ObjectLockRetainUntilDate
        {
            get { return this._objectLockRetainUntilDate; }
            set { this._objectLockRetainUntilDate = value; }
        }

        // Check to see if ObjectLockRetainUntilDate property is set
        internal bool IsSetObjectLockRetainUntilDate()
        {
            return this._objectLockRetainUntilDate.HasValue; 
        }

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
        [AWSProperty(Min=1, Max=2048)]
        public string RedirectLocation
        {
            get { return this._redirectLocation; }
            set { this._redirectLocation = value; }
        }

        // Check to see if RedirectLocation property is set
        internal bool IsSetRedirectLocation()
        {
            return this._redirectLocation != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterPays.  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? RequesterPays
        {
            get { return this._requesterPays; }
            set { this._requesterPays = value; }
        }

        // Check to see if RequesterPays property is set
        internal bool IsSetRequesterPays()
        {
            return this._requesterPays.HasValue; 
        }

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
        [AWSProperty(Min=1, Max=2000)]
        public string SSEAwsKmsKeyId
        {
            get { return this._sseAwsKmsKeyId; }
            set { this._sseAwsKmsKeyId = value; }
        }

        // Check to see if SSEAwsKmsKeyId property is set
        internal bool IsSetSSEAwsKmsKeyId()
        {
            return this._sseAwsKmsKeyId != null;
        }

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
        public S3StorageClass StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

        /// <summary>
        /// Gets and sets the property TargetKeyPrefix. 
        /// <para>
        /// Specifies the folder prefix that you want the objects to be copied into. For example,
        /// to copy objects into a folder named <c>Folder1</c> in the destination bucket, set
        /// the <c>TargetKeyPrefix</c> property to <c>Folder1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TargetKeyPrefix
        {
            get { return this._targetKeyPrefix; }
            set { this._targetKeyPrefix = value; }
        }

        // Check to see if TargetKeyPrefix property is set
        internal bool IsSetTargetKeyPrefix()
        {
            return this._targetKeyPrefix != null;
        }

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
        [AWSProperty(Min=1, Max=128)]
        public string TargetResource
        {
            get { return this._targetResource; }
            set { this._targetResource = value; }
        }

        // Check to see if TargetResource property is set
        internal bool IsSetTargetResource()
        {
            return this._targetResource != null;
        }

        /// <summary>
        /// Gets and sets the property UnModifiedSinceConstraint.
        /// </summary>
        public DateTime? UnModifiedSinceConstraint
        {
            get { return this._unModifiedSinceConstraint; }
            set { this._unModifiedSinceConstraint = value; }
        }

        // Check to see if UnModifiedSinceConstraint property is set
        internal bool IsSetUnModifiedSinceConstraint()
        {
            return this._unModifiedSinceConstraint.HasValue; 
        }

    }
}