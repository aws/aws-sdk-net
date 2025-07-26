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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the InitiateMultipartUpload operation.
    /// </summary>
    public partial class InitiateMultipartUploadResponse : AmazonWebServiceResponse
    {
        private DateTime? _abortDate;
        private string _abortRuleId;
        private bool? _bucketKeyEnabled;
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private ChecksumType _checksumType;
        private string _key;
        private RequestCharged _requestCharged;
        private ServerSideEncryptionCustomerMethod _serverSideEncryptionCustomerMethod;
        private string _serverSideEncryptionCustomerProvidedKeyMD5;
        private string _serverSideEncryptionKeyManagementServiceEncryptionContext;
        private string _serverSideEncryptionKeyManagementServiceKeyId;
        private ServerSideEncryptionMethod _serverSideEncryptionMethod;
        private string _uploadId;

        /// <summary>
        /// Gets and sets the property AbortDate. 
        /// <para>
        /// If the bucket has a lifecycle rule configured with an action to abort incomplete multipart
        /// uploads and the prefix in the lifecycle rule matches the object name in the request,
        /// the response includes this header. The header indicates when the initiated multipart
        /// upload becomes eligible for an abort operation. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html#mpu-abort-incomplete-mpu-lifecycle-config">
        /// Aborting Incomplete Multipart Uploads Using a Bucket Lifecycle Configuration</a> in
        /// the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The response also includes the <c>x-amz-abort-rule-id</c> header that provides the
        /// ID of the lifecycle configuration rule that defines the abort action.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime? AbortDate
        {
            get { return this._abortDate; }
            set { this._abortDate = value; }
        }

        // Check to see if AbortDate property is set
        internal bool IsSetAbortDate()
        {
            return this._abortDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AbortRuleId. 
        /// <para>
        /// This header is returned along with the <c>x-amz-abort-date</c> header. It identifies
        /// the applicable lifecycle configuration rule that defines the action to abort incomplete
        /// multipart uploads.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string AbortRuleId
        {
            get { return this._abortRuleId; }
            set { this._abortRuleId = value; }
        }

        // Check to see if AbortRuleId property is set
        internal bool IsSetAbortRuleId()
        {
            return this._abortRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Indicates whether the multipart upload uses an S3 Bucket Key for server-side encryption
        /// with Key Management Service (KMS) keys (SSE-KMS).
        /// </para>
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
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket to which the multipart upload was initiated. Does not return
        /// the access point ARN or access point alias if used.
        /// </para>
        ///  <note> 
        /// <para>
        /// Access points are not supported by directory buckets.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// The algorithm that was used to create a checksum of the object.
        /// </para>
        /// </summary>
        public ChecksumAlgorithm ChecksumAlgorithm
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
        /// Gets and sets the property ChecksumType. 
        /// <para>
        ///  Indicates the checksum type that you want Amazon S3 to use to calculate the object’s
        /// checksum value. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity in the Amazon S3 User Guide</a>.
        /// </para>
        /// </summary>
        public ChecksumType ChecksumType
        {
            get { return this._checksumType; }
            set { this._checksumType = value; }
        }

        // Check to see if ChecksumType property is set
        internal bool IsSetChecksumType()
        {
            return this._checksumType != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Object key for which the multipart upload was initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCharged.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this._requestCharged; }
            set { this._requestCharged = value; }
        }

        // Check to see if RequestCharged property is set
        internal bool IsSetRequestCharged()
        {
            return this._requestCharged != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerMethod. 
        /// <para>
        /// If server-side encryption with a customer-provided encryption key was requested, the
        /// response will include this header to confirm the encryption algorithm that's used.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod
        {
            get { return this._serverSideEncryptionCustomerMethod; }
            set { this._serverSideEncryptionCustomerMethod = value; }
        }

        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this._serverSideEncryptionCustomerMethod != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerProvidedKeyMD5. 
        /// <para>
        /// If server-side encryption with a customer-provided encryption key was requested, the
        /// response will include this header to provide the round-trip message integrity verification
        /// of the customer-provided encryption key.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string ServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this._serverSideEncryptionCustomerProvidedKeyMD5; }
            set { this._serverSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        // Check to see if ServerSideEncryptionCustomerProvidedKeyMD5 property is set
        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return this._serverSideEncryptionCustomerProvidedKeyMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKeyManagementServiceEncryptionContext.
        /// 
        /// <para>
        /// If present, indicates the Amazon Web Services KMS Encryption Context to use for object
        /// encryption. The value of this header is a Base64 encoded string of a UTF-8 encoded
        /// JSON, which contains the encryption context as key-value pairs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionKeyManagementServiceEncryptionContext
        {
            get { return this._serverSideEncryptionKeyManagementServiceEncryptionContext; }
            set { this._serverSideEncryptionKeyManagementServiceEncryptionContext = value; }
        }

        // Check to see if ServerSideEncryptionKeyManagementServiceEncryptionContext property is set
        internal bool IsSetServerSideEncryptionKeyManagementServiceEncryptionContext()
        {
            return this._serverSideEncryptionKeyManagementServiceEncryptionContext != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKeyManagementServiceKeyId. 
        /// <para>
        /// If present, indicates the ID of the KMS key that was used for object encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionKeyManagementServiceKeyId
        {
            get { return this._serverSideEncryptionKeyManagementServiceKeyId; }
            set { this._serverSideEncryptionKeyManagementServiceKeyId = value; }
        }

        // Check to see if ServerSideEncryptionKeyManagementServiceKeyId property is set
        internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
        {
            return this._serverSideEncryptionKeyManagementServiceKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionMethod. 
        /// <para>
        /// The server-side encryption algorithm used when you store this object in Amazon S3
        /// or Amazon FSx.
        /// </para>
        ///  <note> 
        /// <para>
        /// When accessing data stored in Amazon FSx file systems using S3 access points, the
        /// only valid server side encryption option is <c>aws:fsx</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this._serverSideEncryptionMethod; }
            set { this._serverSideEncryptionMethod = value; }
        }

        // Check to see if ServerSideEncryptionMethod property is set
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this._serverSideEncryptionMethod != null;
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// ID for the initiated multipart upload.
        /// </para>
        /// </summary>
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

    }
}