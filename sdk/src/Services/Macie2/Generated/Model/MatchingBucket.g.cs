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
    /// If an error or issue prevents Macie from retrieving and processing information about
    /// the bucket or the bucket's objects, the value for many of these properties is null.
    /// Key exceptions are accountId and bucketName. To identify the cause, refer to the errorCode
    /// and errorMessage values.
    /// </para>
    /// </summary>
    public partial class MatchingBucket
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
    }
}
