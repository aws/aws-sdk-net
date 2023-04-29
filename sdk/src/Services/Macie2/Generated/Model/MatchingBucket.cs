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
    /// Provides statistical data and other information about an S3 bucket that Amazon Macie
    /// monitors and analyzes for your account. By default, object count and storage size
    /// values include data for object parts that are the result of incomplete multipart uploads.
    /// For more information, see <a href="https://docs.aws.amazon.com/macie/latest/user/monitoring-s3-how-it-works.html">How
    /// Macie monitors Amazon S3 data security</a> in the <i>Amazon Macie User Guide</i>.
    /// 
    ///  
    /// <para>
    /// If an error occurs when Macie attempts to retrieve and process information about the
    /// bucket or the bucket's objects, the value for most of these properties is null. Key
    /// exceptions are accountId and bucketName. To identify the cause of the error, refer
    /// to the errorCode and errorMessage values.
    /// </para>
    /// </summary>
    public partial class MatchingBucket
    {
        private string _accountId;
        private string _bucketName;
        private long? _classifiableObjectCount;
        private long? _classifiableSizeInBytes;
        private BucketMetadataErrorCode _errorCode;
        private string _errorMessage;
        private JobDetails _jobDetails;
        private DateTime? _lastAutomatedDiscoveryTime;
        private long? _objectCount;
        private ObjectCountByEncryptionType _objectCountByEncryptionType;
        private int? _sensitivityScore;
        private long? _sizeInBytes;
        private long? _sizeInBytesCompressed;
        private ObjectLevelStatistics _unclassifiableObjectCount;
        private ObjectLevelStatistics _unclassifiableObjectSizeInBytes;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The unique identifier for the Amazon Web Services account that owns the bucket.
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
        ///  
        /// <para>
        /// If versioning is enabled for the bucket, Macie calculates this value based on the
        /// size of the latest version of each applicable object in the bucket. This value doesn't
        /// reflect the storage size of all versions of each applicable object in the bucket.
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
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code for an error that prevented Amazon Macie from retrieving and processing
        /// information about the bucket and the bucket's objects. If this value is ACCESS_DENIED,
        /// Macie doesn't have permission to retrieve the information. For example, the bucket
        /// has a restrictive bucket policy and Amazon S3 denied the request. If this value is
        /// null, Macie was able to retrieve and process the information.
        /// </para>
        /// </summary>
        public BucketMetadataErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A brief description of the error (errorCode) that prevented Amazon Macie from retrieving
        /// and processing information about the bucket and the bucket's objects. This value is
        /// null if Macie was able to retrieve and process the information.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property JobDetails. 
        /// <para>
        /// Specifies whether any one-time or recurring classification jobs are configured to
        /// analyze objects in the bucket, and, if so, the details of the job that ran most recently.
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
        /// Gets and sets the property LastAutomatedDiscoveryTime. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when Amazon Macie most recently
        /// analyzed data in the bucket while performing automated sensitive data discovery for
        /// your account. This value is null if automated sensitive data discovery is currently
        /// disabled for your account.
        /// </para>
        /// </summary>
        public DateTime LastAutomatedDiscoveryTime
        {
            get { return this._lastAutomatedDiscoveryTime.GetValueOrDefault(); }
            set { this._lastAutomatedDiscoveryTime = value; }
        }

        // Check to see if LastAutomatedDiscoveryTime property is set
        internal bool IsSetLastAutomatedDiscoveryTime()
        {
            return this._lastAutomatedDiscoveryTime.HasValue; 
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
        /// The total number of objects in the bucket, grouped by server-side encryption type.
        /// This includes a grouping that reports the total number of objects that aren't encrypted
        /// or use client-side encryption.
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
        /// Gets and sets the property SensitivityScore. 
        /// <para>
        /// The current sensitivity score for the bucket, ranging from -1 (classification error)
        /// to 100 (sensitive). This value is null if automated sensitive data discovery is currently
        /// disabled for your account.
        /// </para>
        /// </summary>
        public int SensitivityScore
        {
            get { return this._sensitivityScore.GetValueOrDefault(); }
            set { this._sensitivityScore = value; }
        }

        // Check to see if SensitivityScore property is set
        internal bool IsSetSensitivityScore()
        {
            return this._sensitivityScore.HasValue; 
        }

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

    }
}