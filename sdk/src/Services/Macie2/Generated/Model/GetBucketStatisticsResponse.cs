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
    /// This is the response object from the GetBucketStatistics operation.
    /// </summary>
    public partial class GetBucketStatisticsResponse : AmazonWebServiceResponse
    {
        private long? _bucketCount;
        private BucketCountByEffectivePermission _bucketCountByEffectivePermission;
        private BucketCountByEncryptionType _bucketCountByEncryptionType;
        private BucketCountPolicyAllowsUnencryptedObjectUploads _bucketCountByObjectEncryptionRequirement;
        private BucketCountBySharedAccessType _bucketCountBySharedAccessType;
        private BucketStatisticsBySensitivity _bucketStatisticsBySensitivity;
        private long? _classifiableObjectCount;
        private long? _classifiableSizeInBytes;
        private DateTime? _lastUpdated;
        private long? _objectCount;
        private long? _sizeInBytes;
        private long? _sizeInBytesCompressed;
        private ObjectLevelStatistics _unclassifiableObjectCount;
        private ObjectLevelStatistics _unclassifiableObjectSizeInBytes;

        /// <summary>
        /// Gets and sets the property BucketCount. 
        /// <para>
        /// The total number of buckets.
        /// </para>
        /// </summary>
        public long BucketCount
        {
            get { return this._bucketCount.GetValueOrDefault(); }
            set { this._bucketCount = value; }
        }

        // Check to see if BucketCount property is set
        internal bool IsSetBucketCount()
        {
            return this._bucketCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BucketCountByEffectivePermission. 
        /// <para>
        /// The total number of buckets that are publicly accessible due to a combination of permissions
        /// settings for each bucket.
        /// </para>
        /// </summary>
        public BucketCountByEffectivePermission BucketCountByEffectivePermission
        {
            get { return this._bucketCountByEffectivePermission; }
            set { this._bucketCountByEffectivePermission = value; }
        }

        // Check to see if BucketCountByEffectivePermission property is set
        internal bool IsSetBucketCountByEffectivePermission()
        {
            return this._bucketCountByEffectivePermission != null;
        }

        /// <summary>
        /// Gets and sets the property BucketCountByEncryptionType. 
        /// <para>
        /// The total number of buckets that use certain types of server-side encryption to encrypt
        /// new objects by default. This object also reports the total number of buckets that
        /// don't encrypt new objects by default.
        /// </para>
        /// </summary>
        public BucketCountByEncryptionType BucketCountByEncryptionType
        {
            get { return this._bucketCountByEncryptionType; }
            set { this._bucketCountByEncryptionType = value; }
        }

        // Check to see if BucketCountByEncryptionType property is set
        internal bool IsSetBucketCountByEncryptionType()
        {
            return this._bucketCountByEncryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property BucketCountByObjectEncryptionRequirement. 
        /// <para>
        /// The total number of buckets whose bucket policies do or don't require server-side
        /// encryption of objects when objects are uploaded to the buckets.
        /// </para>
        /// </summary>
        public BucketCountPolicyAllowsUnencryptedObjectUploads BucketCountByObjectEncryptionRequirement
        {
            get { return this._bucketCountByObjectEncryptionRequirement; }
            set { this._bucketCountByObjectEncryptionRequirement = value; }
        }

        // Check to see if BucketCountByObjectEncryptionRequirement property is set
        internal bool IsSetBucketCountByObjectEncryptionRequirement()
        {
            return this._bucketCountByObjectEncryptionRequirement != null;
        }

        /// <summary>
        /// Gets and sets the property BucketCountBySharedAccessType. 
        /// <para>
        /// The total number of buckets that are or aren't shared with other Amazon Web Services
        /// accounts, Amazon CloudFront origin access identities (OAIs), or CloudFront origin
        /// access controls (OACs).
        /// </para>
        /// </summary>
        public BucketCountBySharedAccessType BucketCountBySharedAccessType
        {
            get { return this._bucketCountBySharedAccessType; }
            set { this._bucketCountBySharedAccessType = value; }
        }

        // Check to see if BucketCountBySharedAccessType property is set
        internal bool IsSetBucketCountBySharedAccessType()
        {
            return this._bucketCountBySharedAccessType != null;
        }

        /// <summary>
        /// Gets and sets the property BucketStatisticsBySensitivity. 
        /// <para>
        /// The aggregated sensitive data discovery statistics for the buckets. If automated sensitive
        /// data discovery is currently disabled for your account, the value for each statistic
        /// is 0.
        /// </para>
        /// </summary>
        public BucketStatisticsBySensitivity BucketStatisticsBySensitivity
        {
            get { return this._bucketStatisticsBySensitivity; }
            set { this._bucketStatisticsBySensitivity = value; }
        }

        // Check to see if BucketStatisticsBySensitivity property is set
        internal bool IsSetBucketStatisticsBySensitivity()
        {
            return this._bucketStatisticsBySensitivity != null;
        }

        /// <summary>
        /// Gets and sets the property ClassifiableObjectCount. 
        /// <para>
        /// The total number of objects that Amazon Macie can analyze in the buckets. These objects
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
        /// The total storage size, in bytes, of all the objects that Amazon Macie can analyze
        /// in the buckets. These objects use a supported storage class and have a file name extension
        /// for a supported file or storage format.
        /// </para>
        ///  
        /// <para>
        /// If versioning is enabled for any of the buckets, this value is based on the size of
        /// the latest version of each applicable object in the buckets. This value doesn't reflect
        /// the storage size of all versions of all applicable objects in the buckets.
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
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when Amazon Macie most recently
        /// retrieved bucket or object metadata from Amazon S3 for the buckets.
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
        /// The total number of objects in the buckets.
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
        /// Gets and sets the property SizeInBytes. 
        /// <para>
        /// The total storage size, in bytes, of the buckets.
        /// </para>
        ///  
        /// <para>
        /// If versioning is enabled for any of the buckets, this value is based on the size of
        /// the latest version of each object in the buckets. This value doesn't reflect the storage
        /// size of all versions of the objects in the buckets.
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
        /// The total storage size, in bytes, of the objects that are compressed (.gz, .gzip,
        /// .zip) files in the buckets.
        /// </para>
        ///  
        /// <para>
        /// If versioning is enabled for any of the buckets, this value is based on the size of
        /// the latest version of each applicable object in the buckets. This value doesn't reflect
        /// the storage size of all versions of the applicable objects in the buckets.
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
        /// Gets and sets the property UnclassifiableObjectCount. 
        /// <para>
        /// The total number of objects that Amazon Macie can't analyze in the buckets. These
        /// objects don't use a supported storage class or don't have a file name extension for
        /// a supported file or storage format.
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
        /// the buckets. These objects don't use a supported storage class or don't have a file
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

    }
}