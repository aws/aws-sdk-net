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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Contains the configuration parameters for a PUT Copy object operation. S3 Batch Operations
    /// passes every object to the underlying <code>CopyObject</code> API operation. For more
    /// information about the parameters for this operation, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectCOPY.html">CopyObject</a>.
    /// </summary>
    public partial class S3CopyObjectOperation
    {
        private List<S3Grant> _accessControlGrants = new List<S3Grant>();
        private bool? _bucketKeyEnabled;
        private S3CannedAccessControlList _cannedAccessControlList;
        private S3ChecksumAlgorithm _checksumAlgorithm;
        private S3MetadataDirective _metadataDirective;
        private DateTime? _modifiedSinceConstraint;
        private S3ObjectMetadata _newObjectMetadata;
        private List<S3Tag> _newObjectTagging = new List<S3Tag>();
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
        /// Gets and sets the property AccessControlGrants.
        /// </summary>
        public List<S3Grant> AccessControlGrants
        {
            get { return this._accessControlGrants; }
            set { this._accessControlGrants = value; }
        }

        // Check to see if AccessControlGrants property is set
        internal bool IsSetAccessControlGrants()
        {
            return this._accessControlGrants != null && this._accessControlGrants.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Specifies whether Amazon S3 should use an S3 Bucket Key for object encryption with
        /// server-side encryption using Amazon Web Services KMS (SSE-KMS). Setting this header
        /// to <code>true</code> causes Amazon S3 to use an S3 Bucket Key for object encryption
        /// with SSE-KMS.
        /// </para>
        ///  
        /// <para>
        /// Specifying this header with an <i>object</i> action doesn’t affect <i>bucket-level</i>
        /// settings for S3 Bucket Key.
        /// </para>
        /// </summary>
        public bool BucketKeyEnabled
        {
            get { return this._bucketKeyEnabled.GetValueOrDefault(); }
            set { this._bucketKeyEnabled = value; }
        }

        // Check to see if BucketKeyEnabled property is set
        internal bool IsSetBucketKeyEnabled()
        {
            return this._bucketKeyEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CannedAccessControlList.
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
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/CheckingObjectIntegrity.xml">
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
        public DateTime ModifiedSinceConstraint
        {
            get { return this._modifiedSinceConstraint.GetValueOrDefault(); }
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
        /// </summary>
        public List<S3Tag> NewObjectTagging
        {
            get { return this._newObjectTagging; }
            set { this._newObjectTagging = value; }
        }

        // Check to see if NewObjectTagging property is set
        internal bool IsSetNewObjectTagging()
        {
            return this._newObjectTagging != null && this._newObjectTagging.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ObjectLockLegalHoldStatus. 
        /// <para>
        /// The legal hold status to be applied to all objects in the Batch Operations job.
        /// </para>
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
        /// </summary>
        public DateTime ObjectLockRetainUntilDate
        {
            get { return this._objectLockRetainUntilDate.GetValueOrDefault(); }
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
        /// Specifies an optional metadata property for website redirects, <code>x-amz-website-redirect-location</code>.
        /// Allows webpage redirects if the object is accessed through a website endpoint.
        /// </para>
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
        /// Gets and sets the property RequesterPays.
        /// </summary>
        public bool RequesterPays
        {
            get { return this._requesterPays.GetValueOrDefault(); }
            set { this._requesterPays = value; }
        }

        // Check to see if RequesterPays property is set
        internal bool IsSetRequesterPays()
        {
            return this._requesterPays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SSEAwsKmsKeyId.
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
        /// to copy objects into a folder named <code>Folder1</code> in the destination bucket,
        /// set the <code>TargetKeyPrefix</code> property to <code>Folder1</code>.
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
        /// For example, to copy objects to a bucket named <code>destinationBucket</code>, set
        /// the <code>TargetResource</code> property to <code>arn:aws:s3:::destinationBucket</code>.
        /// </para>
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
        public DateTime UnModifiedSinceConstraint
        {
            get { return this._unModifiedSinceConstraint.GetValueOrDefault(); }
            set { this._unModifiedSinceConstraint = value; }
        }

        // Check to see if UnModifiedSinceConstraint property is set
        internal bool IsSetUnModifiedSinceConstraint()
        {
            return this._unModifiedSinceConstraint.HasValue; 
        }

    }
}