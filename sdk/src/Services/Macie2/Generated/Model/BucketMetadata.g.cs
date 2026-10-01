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
    /// Provides statistical data and other information about an S3 bucket that Amazon Macie
    /// monitors and analyzes for your account. By default, object count and storage size
    /// values include data for object parts that are the result of incomplete multipart uploads.
    /// For more information, see <a href="https://docs.aws.amazon.com/macie/latest/user/monitoring-s3-how-it-works.html">How
    /// Macie monitors Amazon S3 data security</a> in the <i>Amazon Macie User Guide</i>.
    /// 
    ///  
    /// <para>
    /// If an error or issue prevents Macie from retrieving and processing metadata from Amazon
    /// S3 for the bucket or the bucket's objects, the value for the versioning property is
    /// false and the value for most other properties is null or UNKNOWN. Key exceptions are
    /// accountId, bucketArn, bucketCreatedAt, bucketName, lastUpdated, and region. To identify
    /// the cause, refer to the errorCode and errorMessage values.
    /// </para>
    /// </summary>
    public partial class BucketMetadata
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The unique identifier for the Amazon Web Services account that owns the bucket.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AllowsUnencryptedObjectUploads. 
        /// <para>
        /// Specifies whether the bucket policy for the bucket requires server-side encryption
        /// of objects when objects are added to the bucket. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// FALSE - The bucket policy requires server-side encryption of new objects. PutObject
        /// requests must include a valid server-side encryption header.
        /// </para>
        /// </li> <li>
        /// <para>
        /// TRUE - The bucket doesn't have a bucket policy or it has a bucket policy that doesn't
        /// require server-side encryption of new objects. If a bucket policy exists, it doesn't
        /// require PutObject requests to include a valid server-side encryption header.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UNKNOWN - Amazon Macie can't determine whether the bucket policy requires server-side
        /// encryption of new objects.
        /// </para>
        /// </li></ul> 
        /// <para>
        /// Valid server-side encryption headers are: x-amz-server-side-encryption with a value
        /// of AES256 or aws:kms, and x-amz-server-side-encryption-customer-algorithm with a value
        /// of AES256.
        /// </para>
        /// </summary>
        public AllowsUnencryptedObjectUploads AllowsUnencryptedObjectUploads { get; set; }

        /// <summary>
        /// Checks to see if the AllowsUnencryptedObjectUploads property is set.
        /// </summary>
        internal bool IsSetAllowsUnencryptedObjectUploads() => this.AllowsUnencryptedObjectUploads != null;

        /// <summary>
        /// Gets and sets the property AutomatedDiscoveryMonitoringStatus. 
        /// <para>
        /// Specifies whether automated sensitive data discovery is currently configured to analyze
        /// objects in the bucket. Possible values are: MONITORED, the bucket is included in analyses;
        /// and, NOT_MONITORED, the bucket is excluded from analyses. If automated sensitive data
        /// discovery is disabled for your account, this value is NOT_MONITORED.
        /// </para>
        /// </summary>
        public AutomatedDiscoveryMonitoringStatus AutomatedDiscoveryMonitoringStatus { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedDiscoveryMonitoringStatus property is set.
        /// </summary>
        internal bool IsSetAutomatedDiscoveryMonitoringStatus() => this.AutomatedDiscoveryMonitoringStatus != null;

        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bucket.
        /// </para>
        /// </summary>
        public string BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the BucketArn property is set.
        /// </summary>
        internal bool IsSetBucketArn() => this.BucketArn != null;

        /// <summary>
        /// Gets and sets the property BucketCreatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the bucket was created.
        /// This value can also indicate when changes such as edits to the bucket's policy were
        /// most recently made to the bucket.
        /// </para>
        /// </summary>
        public DateTime? BucketCreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the BucketCreatedAt property is set.
        /// </summary>
        internal bool IsSetBucketCreatedAt() => this.BucketCreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket.
        /// </para>
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

        /// <summary>
        /// Gets and sets the property ClassifiableObjectCount. 
        /// <para>
        /// The total number of objects that Amazon Macie can analyze in the bucket. These objects
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
        /// The total storage size, in bytes, of the objects that Amazon Macie can analyze in
        /// the bucket. These objects use a supported storage class and have a file name extension
        /// for a supported file or storage format.
        /// </para>
        ///  
        /// <para>
        /// If versioning is enabled for the bucket, Macie calculates this value based on the
        /// size of the latest version of each applicable object in the bucket. This value doesn't
        /// reflect the storage size of all versions of each applicable object in the bucket.
        /// </para>
        /// </summary>
        public long? ClassifiableSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the ClassifiableSizeInBytes property is set.
        /// </summary>
        internal bool IsSetClassifiableSizeInBytes() => this.ClassifiableSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The code for an error or issue that prevented Amazon Macie from retrieving and processing
        /// information about the bucket and the bucket's objects. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// ACCESS_DENIED - Macie doesn't have permission to retrieve the information. For example,
        /// the bucket has a restrictive bucket policy and Amazon S3 denied the request.
        /// </para>
        /// </li> <li>
        /// <para>
        /// BUCKET_COUNT_EXCEEDS_QUOTA - Retrieving and processing the information would exceed
        /// the quota for the number of buckets that Macie monitors for an account (10,000).
        /// </para>
        /// </li></ul> 
        /// <para>
        /// If this value is null, Macie was able to retrieve and process the information.
        /// </para>
        /// </summary>
        public BucketMetadataErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A brief description of the error or issue (errorCode) that prevented Amazon Macie
        /// from retrieving and processing information about the bucket and the bucket's objects.
        /// This value is null if Macie was able to retrieve and process the information.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property JobDetails. 
        /// <para>
        /// Specifies whether any one-time or recurring classification jobs are configured to
        /// analyze objects in the bucket, and, if so, the details of the job that ran most recently.
        /// </para>
        /// </summary>
        public JobDetails JobDetails { get; set; }

        /// <summary>
        /// Checks to see if the JobDetails property is set.
        /// </summary>
        internal bool IsSetJobDetails() => this.JobDetails != null;

        /// <summary>
        /// Gets and sets the property LastAutomatedDiscoveryTime. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when Amazon Macie most recently
        /// analyzed objects in the bucket while performing automated sensitive data discovery.
        /// This value is null if this analysis hasn't occurred.
        /// </para>
        /// </summary>
        public DateTime? LastAutomatedDiscoveryTime { get; set; }

        /// <summary>
        /// Checks to see if the LastAutomatedDiscoveryTime property is set.
        /// </summary>
        internal bool IsSetLastAutomatedDiscoveryTime() => this.LastAutomatedDiscoveryTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when Amazon Macie most recently
        /// retrieved bucket or object metadata from Amazon S3 for the bucket.
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
        /// The total number of objects in the bucket.
        /// </para>
        /// </summary>
        public long? ObjectCount { get; set; }

        /// <summary>
        /// Checks to see if the ObjectCount property is set.
        /// </summary>
        internal bool IsSetObjectCount() => this.ObjectCount.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectCountByEncryptionType. 
        /// <para>
        /// The total number of objects in the bucket, grouped by server-side encryption type.
        /// This includes a grouping that reports the total number of objects that aren't encrypted
        /// or use client-side encryption.
        /// </para>
        /// </summary>
        public ObjectCountByEncryptionType ObjectCountByEncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the ObjectCountByEncryptionType property is set.
        /// </summary>
        internal bool IsSetObjectCountByEncryptionType() => this.ObjectCountByEncryptionType != null;

        /// <summary>
        /// Gets and sets the property PublicAccess. 
        /// <para>
        /// Specifies whether the bucket is publicly accessible due to the combination of permissions
        /// settings that apply to the bucket, and provides information about those settings.
        /// </para>
        /// </summary>
        public BucketPublicAccess PublicAccess { get; set; }

        /// <summary>
        /// Checks to see if the PublicAccess property is set.
        /// </summary>
        internal bool IsSetPublicAccess() => this.PublicAccess != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region that hosts the bucket.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ReplicationDetails. 
        /// <para>
        /// Specifies whether the bucket is configured to replicate one or more objects to buckets
        /// for other Amazon Web Services accounts and, if so, which accounts.
        /// </para>
        /// </summary>
        public ReplicationDetails ReplicationDetails { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationDetails property is set.
        /// </summary>
        internal bool IsSetReplicationDetails() => this.ReplicationDetails != null;

        /// <summary>
        /// Gets and sets the property SensitivityScore. 
        /// <para>
        /// The sensitivity score for the bucket, ranging from -1 (classification error) to 100
        /// (sensitive).
        /// </para>
        /// 
        /// <para>
        /// If automated sensitive data discovery has never been enabled for your account or it's
        /// been disabled for your organization or standalone account for more than 30 days, possible
        /// values are: 1, the bucket is empty; or, 50, the bucket stores objects but it's been
        /// excluded from recent analyses.
        /// </para>
        /// </summary>
        public int? SensitivityScore { get; set; }

        /// <summary>
        /// Checks to see if the SensitivityScore property is set.
        /// </summary>
        internal bool IsSetSensitivityScore() => this.SensitivityScore.HasValue;

        /// <summary>
        /// Gets and sets the property ServerSideEncryption. 
        /// <para>
        /// The default server-side encryption settings for the bucket.
        /// </para>
        /// </summary>
        public BucketServerSideEncryption ServerSideEncryption { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideEncryption property is set.
        /// </summary>
        internal bool IsSetServerSideEncryption() => this.ServerSideEncryption != null;

        /// <summary>
        /// Gets and sets the property SharedAccess. 
        /// <para>
        /// Specifies whether the bucket is shared with another Amazon Web Services account, an
        /// Amazon CloudFront origin access identity (OAI), or a CloudFront origin access control
        /// (OAC). Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// EXTERNAL - The bucket is shared with one or more of the following or any combination
        /// of the following: a CloudFront OAI, a CloudFront OAC, or an Amazon Web Services account
        /// that isn't part of your Amazon Macie organization.
        /// </para>
        /// </li> <li>
        /// <para>
        /// INTERNAL - The bucket is shared with one or more Amazon Web Services accounts that
        /// are part of your Amazon Macie organization. It isn't shared with a CloudFront OAI
        /// or OAC.
        /// </para>
        /// </li> <li>
        /// <para>
        /// NOT_SHARED - The bucket isn't shared with another Amazon Web Services account, a CloudFront
        /// OAI, or a CloudFront OAC.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UNKNOWN - Amazon Macie wasn't able to evaluate the shared access settings for the
        /// bucket.
        /// </para>
        /// </li></ul> 
        /// <para>
        /// An <i>Amazon Macie organization</i> is a set of Macie accounts that are centrally
        /// managed as a group of related accounts through Organizations or by Macie invitation.
        /// </para>
        /// </summary>
        public SharedAccess SharedAccess { get; set; }

        /// <summary>
        /// Checks to see if the SharedAccess property is set.
        /// </summary>
        internal bool IsSetSharedAccess() => this.SharedAccess != null;

        /// <summary>
        /// Gets and sets the property SizeInBytes. 
        /// <para>
        /// The total storage size, in bytes, of the bucket.
        /// </para>
        ///  
        /// <para>
        /// If versioning is enabled for the bucket, Amazon Macie calculates this value based
        /// on the size of the latest version of each object in the bucket. This value doesn't
        /// reflect the storage size of all versions of each object in the bucket.
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
        /// .zip) files in the bucket.
        /// </para>
        ///  
        /// <para>
        /// If versioning is enabled for the bucket, Amazon Macie calculates this value based
        /// on the size of the latest version of each applicable object in the bucket. This value
        /// doesn't reflect the storage size of all versions of each applicable object in the
        /// bucket.
        /// </para>
        /// </summary>
        public long? SizeInBytesCompressed { get; set; }

        /// <summary>
        /// Checks to see if the SizeInBytesCompressed property is set.
        /// </summary>
        internal bool IsSetSizeInBytesCompressed() => this.SizeInBytesCompressed.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array that specifies the tags (keys and values) that are associated with the bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyValuePair> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UnclassifiableObjectCount. 
        /// <para>
        /// The total number of objects that Amazon Macie can't analyze in the bucket. These objects
        /// don't use a supported storage class or don't have a file name extension for a supported
        /// file or storage format.
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
        /// the bucket. These objects don't use a supported storage class or don't have a file
        /// name extension for a supported file or storage format.
        /// </para>
        /// </summary>
        public ObjectLevelStatistics UnclassifiableObjectSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the UnclassifiableObjectSizeInBytes property is set.
        /// </summary>
        internal bool IsSetUnclassifiableObjectSizeInBytes() => this.UnclassifiableObjectSizeInBytes != null;

        /// <summary>
        /// Gets and sets the property Versioning. 
        /// <para>
        /// Specifies whether versioning is enabled for the bucket.
        /// </para>
        /// </summary>
        public bool? Versioning { get; set; }

        /// <summary>
        /// Checks to see if the Versioning property is set.
        /// </summary>
        internal bool IsSetVersioning() => this.Versioning.HasValue;
    }
}
