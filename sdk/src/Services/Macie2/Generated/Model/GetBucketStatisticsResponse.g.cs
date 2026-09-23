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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetBucketStatistics operation.
    /// </summary>
    public partial class GetBucketStatisticsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BucketCount. 
        /// <para>
        /// The total number of buckets.
        /// </para>
        /// </summary>
        public long? BucketCount { get; set; }

        /// <summary>
        /// Checks to see if the BucketCount property is set.
        /// </summary>
        internal bool IsSetBucketCount() => this.BucketCount.HasValue;

        /// <summary>
        /// Gets and sets the property BucketCountByEffectivePermission. 
        /// <para>
        /// The total number of buckets that are publicly accessible due to a combination of permissions
        /// settings for each bucket.
        /// </para>
        /// </summary>
        public BucketCountByEffectivePermission BucketCountByEffectivePermission { get; set; }

        /// <summary>
        /// Checks to see if the BucketCountByEffectivePermission property is set.
        /// </summary>
        internal bool IsSetBucketCountByEffectivePermission() => this.BucketCountByEffectivePermission != null;

        /// <summary>
        /// Gets and sets the property BucketCountByEncryptionType. 
        /// <para>
        /// The total number of buckets whose settings do or don't specify default server-side
        /// encryption behavior for objects that are added to the buckets.
        /// </para>
        /// </summary>
        public BucketCountByEncryptionType BucketCountByEncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the BucketCountByEncryptionType property is set.
        /// </summary>
        internal bool IsSetBucketCountByEncryptionType() => this.BucketCountByEncryptionType != null;

        /// <summary>
        /// Gets and sets the property BucketCountByObjectEncryptionRequirement. 
        /// <para>
        /// The total number of buckets whose bucket policies do or don't require server-side
        /// encryption of objects when objects are added to the buckets.
        /// </para>
        /// </summary>
        public BucketCountPolicyAllowsUnencryptedObjectUploads BucketCountByObjectEncryptionRequirement { get; set; }

        /// <summary>
        /// Checks to see if the BucketCountByObjectEncryptionRequirement property is set.
        /// </summary>
        internal bool IsSetBucketCountByObjectEncryptionRequirement() => this.BucketCountByObjectEncryptionRequirement != null;

        /// <summary>
        /// Gets and sets the property BucketCountBySharedAccessType. 
        /// <para>
        /// The total number of buckets that are or aren't shared with other Amazon Web Services
        /// accounts, Amazon CloudFront origin access identities (OAIs), or CloudFront origin
        /// access controls (OACs).
        /// </para>
        /// </summary>
        public BucketCountBySharedAccessType BucketCountBySharedAccessType { get; set; }

        /// <summary>
        /// Checks to see if the BucketCountBySharedAccessType property is set.
        /// </summary>
        internal bool IsSetBucketCountBySharedAccessType() => this.BucketCountBySharedAccessType != null;

        /// <summary>
        /// Gets and sets the property BucketStatisticsBySensitivity. 
        /// <para>
        /// The aggregated sensitive data discovery statistics for the buckets. If automated sensitive
        /// data discovery is currently disabled for your account, the value for most statistics
        /// is 0.
        /// </para>
        /// </summary>
        public BucketStatisticsBySensitivity BucketStatisticsBySensitivity { get; set; }

        /// <summary>
        /// Checks to see if the BucketStatisticsBySensitivity property is set.
        /// </summary>
        internal bool IsSetBucketStatisticsBySensitivity() => this.BucketStatisticsBySensitivity != null;

        /// <summary>
        /// Gets and sets the property ClassifiableObjectCount. 
        /// <para>
        /// The total number of objects that Amazon Macie can analyze in the buckets. These objects
        /// use a supported storage class and have a file name extension for a supported file
        /// or storage format.
        /// </para>
        /// </summary>
        public long? ClassifiableObjectCount { get; set; }

        /// <summary>
        /// Checks to see if the ClassifiableObjectCount property is set.
        /// </summary>
        internal bool IsSetClassifiableObjectCount() => this.ClassifiableObjectCount.HasValue;

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
        public long? ClassifiableSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the ClassifiableSizeInBytes property is set.
        /// </summary>
        internal bool IsSetClassifiableSizeInBytes() => this.ClassifiableSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when Amazon Macie most recently
        /// retrieved bucket or object metadata from Amazon S3 for the buckets.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectCount. 
        /// <para>
        /// The total number of objects in the buckets.
        /// </para>
        /// </summary>
        public long? ObjectCount { get; set; }

        /// <summary>
        /// Checks to see if the ObjectCount property is set.
        /// </summary>
        internal bool IsSetObjectCount() => this.ObjectCount.HasValue;

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
        public long? SizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the SizeInBytes property is set.
        /// </summary>
        internal bool IsSetSizeInBytes() => this.SizeInBytes.HasValue;

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
        public long? SizeInBytesCompressed { get; set; }

        /// <summary>
        /// Checks to see if the SizeInBytesCompressed property is set.
        /// </summary>
        internal bool IsSetSizeInBytesCompressed() => this.SizeInBytesCompressed.HasValue;

        /// <summary>
        /// Gets and sets the property UnclassifiableObjectCount. 
        /// <para>
        /// The total number of objects that Amazon Macie can't analyze in the buckets. These
        /// objects don't use a supported storage class or don't have a file name extension for
        /// a supported file or storage format.
        /// </para>
        /// </summary>
        public ObjectLevelStatistics UnclassifiableObjectCount { get; set; }

        /// <summary>
        /// Checks to see if the UnclassifiableObjectCount property is set.
        /// </summary>
        internal bool IsSetUnclassifiableObjectCount() => this.UnclassifiableObjectCount != null;

        /// <summary>
        /// Gets and sets the property UnclassifiableObjectSizeInBytes. 
        /// <para>
        /// The total storage size, in bytes, of the objects that Amazon Macie can't analyze in
        /// the buckets. These objects don't use a supported storage class or don't have a file
        /// name extension for a supported file or storage format.
        /// </para>
        /// </summary>
        public ObjectLevelStatistics UnclassifiableObjectSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the UnclassifiableObjectSizeInBytes property is set.
        /// </summary>
        internal bool IsSetUnclassifiableObjectSizeInBytes() => this.UnclassifiableObjectSizeInBytes != null;
    }
}
