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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about an S3 bucket that Amazon Macie monitors and analyzes.
    /// </summary>
    public partial class BucketMetadata
    {
        private string _accountId;
        private string _bucketArn;
        private DateTime? _bucketCreatedAt;
        private string _bucketName;
        private long? _classifiableObjectCount;
        private long? _classifiableSizeInBytes;
        private JobDetails _jobDetails;
        private DateTime? _lastUpdated;
        private long? _objectCount;
        private ObjectCountByEncryptionType _objectCountByEncryptionType;
        private BucketPublicAccess _publicAccess;
        private string _region;
        private ReplicationDetails _replicationDetails;
        private SharedAccess _sharedAccess;
        private long? _sizeInBytes;
        private long? _sizeInBytesCompressed;
        private List<KeyValuePair> _tags = new List<KeyValuePair>();
        private ObjectLevelStatistics _unclassifiableObjectCount;
        private ObjectLevelStatistics _unclassifiableObjectSizeInBytes;
        private bool? _versioning;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The unique identifier for the AWS account that owns the bucket.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bucket.
        /// </para>
        /// </summary>
        public string BucketArn
        {
            get { return this._bucketArn; }
            set { this._bucketArn = value; }
        }

        // Check to see if BucketArn property is set
        internal bool IsSetBucketArn()
        {
            return this._bucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property BucketCreatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the bucket was created.
        /// </para>
        /// </summary>
        public DateTime BucketCreatedAt
        {
            get { return this._bucketCreatedAt.GetValueOrDefault(); }
            set { this._bucketCreatedAt = value; }
        }

        // Check to see if BucketCreatedAt property is set
        internal bool IsSetBucketCreatedAt()
        {
            return this._bucketCreatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ClassifiableObjectCount. 
        /// <para>
        /// The total number of objects that Amazon Macie can analyze in the bucket. These objects
        /// use a supported storage class and have a file name extension for a supported file
        /// or storage format.
        /// </para>
        /// </summary>
        public long ClassifiableObjectCount
        {
            get { return this._classifiableObjectCount.GetValueOrDefault(); }
            set { this._classifiableObjectCount = value; }
        }

        // Check to see if ClassifiableObjectCount property is set
        internal bool IsSetClassifiableObjectCount()
        {
            return this._classifiableObjectCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClassifiableSizeInBytes. 
        /// <para>
        /// The total storage size, in bytes, of the objects that Amazon Macie can analyze in
        /// the bucket. These objects use a supported storage class and have a file name extension
        /// for a supported file or storage format.
        /// </para>
        /// </summary>
        public long ClassifiableSizeInBytes
        {
            get { return this._classifiableSizeInBytes.GetValueOrDefault(); }
            set { this._classifiableSizeInBytes = value; }
        }

        // Check to see if ClassifiableSizeInBytes property is set
        internal bool IsSetClassifiableSizeInBytes()
        {
            return this._classifiableSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobDetails. 
        /// <para>
        /// Specifies whether any one-time or recurring classification jobs are configured to
        /// analyze data in the bucket, and, if so, the details of the job that ran most recently.
        /// </para>
        /// </summary>
        public JobDetails JobDetails
        {
            get { return this._jobDetails; }
            set { this._jobDetails = value; }
        }

        // Check to see if JobDetails property is set
        internal bool IsSetJobDetails()
        {
            return this._jobDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when Amazon Macie most recently
        /// retrieved data about the bucket from Amazon S3.
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectCount. 
        /// <para>
        /// The total number of objects in the bucket.
        /// </para>
        /// </summary>
        public long ObjectCount
        {
            get { return this._objectCount.GetValueOrDefault(); }
            set { this._objectCount = value; }
        }

        // Check to see if ObjectCount property is set
        internal bool IsSetObjectCount()
        {
            return this._objectCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectCountByEncryptionType. 
        /// <para>
        /// The total number of objects that are in the bucket, grouped by server-side encryption
        /// type. This includes a grouping that reports the total number of objects that aren't
        /// encrypted or use client-side encryption.
        /// </para>
        /// </summary>
        public ObjectCountByEncryptionType ObjectCountByEncryptionType
        {
            get { return this._objectCountByEncryptionType; }
            set { this._objectCountByEncryptionType = value; }
        }

        // Check to see if ObjectCountByEncryptionType property is set
        internal bool IsSetObjectCountByEncryptionType()
        {
            return this._objectCountByEncryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property PublicAccess. 
        /// <para>
        /// Specifies whether the bucket is publicly accessible. If this value is true, an access
        /// control list (ACL), bucket policy, or block public access settings allow the bucket
        /// to be accessed by the general public.
        /// </para>
        /// </summary>
        public BucketPublicAccess PublicAccess
        {
            get { return this._publicAccess; }
            set { this._publicAccess = value; }
        }

        // Check to see if PublicAccess property is set
        internal bool IsSetPublicAccess()
        {
            return this._publicAccess != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The AWS Region that hosts the bucket.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationDetails. 
        /// <para>
        /// Specifies whether the bucket is configured to replicate one or more objects to buckets
        /// for other AWS accounts and, if so, which accounts.
        /// </para>
        /// </summary>
        public ReplicationDetails ReplicationDetails
        {
            get { return this._replicationDetails; }
            set { this._replicationDetails = value; }
        }

        // Check to see if ReplicationDetails property is set
        internal bool IsSetReplicationDetails()
        {
            return this._replicationDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SharedAccess.  
        /// <para>
        /// Specifies whether the bucket is shared with another AWS account. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// EXTERNAL - The bucket is shared with an AWS account that isn't part of the same Amazon
        /// Macie organization.
        /// </para>
        /// </li> <li>
        /// <para>
        /// INTERNAL - The bucket is shared with an AWS account that's part of the same Amazon
        /// Macie organization.
        /// </para>
        /// </li> <li>
        /// <para>
        /// NOT_SHARED - The bucket isn't shared with other AWS accounts.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UNKNOWN - Amazon Macie wasn't able to evaluate the shared access settings for the
        /// bucket.
        /// </para>
        /// </li></ul>
        /// </summary>
        public SharedAccess SharedAccess
        {
            get { return this._sharedAccess; }
            set { this._sharedAccess = value; }
        }

        // Check to see if SharedAccess property is set
        internal bool IsSetSharedAccess()
        {
            return this._sharedAccess != null;
        }

        /// <summary>
        /// Gets and sets the property SizeInBytes. 
        /// <para>
        /// The total storage size, in bytes, of the bucket.
        /// </para>
        /// </summary>
        public long SizeInBytes
        {
            get { return this._sizeInBytes.GetValueOrDefault(); }
            set { this._sizeInBytes = value; }
        }

        // Check to see if SizeInBytes property is set
        internal bool IsSetSizeInBytes()
        {
            return this._sizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizeInBytesCompressed. 
        /// <para>
        /// The total compressed storage size, in bytes, of the bucket.
        /// </para>
        /// </summary>
        public long SizeInBytesCompressed
        {
            get { return this._sizeInBytesCompressed.GetValueOrDefault(); }
            set { this._sizeInBytesCompressed = value; }
        }

        // Check to see if SizeInBytesCompressed property is set
        internal bool IsSetSizeInBytesCompressed()
        {
            return this._sizeInBytesCompressed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array that specifies the tags (keys and values) that are associated with the bucket.
        /// </para>
        /// </summary>
        public List<KeyValuePair> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnclassifiableObjectCount. 
        /// <para>
        /// The total number of objects that Amazon Macie can't analyze in the bucket. These objects
        /// don't use a supported storage class or don't have a file name extension for a supported
        /// file or storage format.
        /// </para>
        /// </summary>
        public ObjectLevelStatistics UnclassifiableObjectCount
        {
            get { return this._unclassifiableObjectCount; }
            set { this._unclassifiableObjectCount = value; }
        }

        // Check to see if UnclassifiableObjectCount property is set
        internal bool IsSetUnclassifiableObjectCount()
        {
            return this._unclassifiableObjectCount != null;
        }

        /// <summary>
        /// Gets and sets the property UnclassifiableObjectSizeInBytes. 
        /// <para>
        /// The total storage size, in bytes, of the objects that Amazon Macie can't analyze in
        /// the bucket. These objects don't use a supported storage class or don't have a file
        /// name extension for a supported file or storage format.
        /// </para>
        /// </summary>
        public ObjectLevelStatistics UnclassifiableObjectSizeInBytes
        {
            get { return this._unclassifiableObjectSizeInBytes; }
            set { this._unclassifiableObjectSizeInBytes = value; }
        }

        // Check to see if UnclassifiableObjectSizeInBytes property is set
        internal bool IsSetUnclassifiableObjectSizeInBytes()
        {
            return this._unclassifiableObjectSizeInBytes != null;
        }

        /// <summary>
        /// Gets and sets the property Versioning. 
        /// <para>
        /// Specifies whether versioning is enabled for the bucket.
        /// </para>
        /// </summary>
        public bool Versioning
        {
            get { return this._versioning.GetValueOrDefault(); }
            set { this._versioning = value; }
        }

        // Check to see if Versioning property is set
        internal bool IsSetVersioning()
        {
            return this._versioning.HasValue; 
        }

    }
}