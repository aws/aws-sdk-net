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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  InitiateMultipartUpload response and response metadata.
    /// </summary>
    public class InitiateMultipartUploadResponse : AmazonWebServiceResponse
    {
        private DateTime? abortDate;
        private string abortRuleId;
        private bool? bucketKeyEnabled;
        private string bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string key;
        private RequestCharged requestCharged;
        private ServerSideEncryptionMethod serverSideEncryption;
        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKeyMD5;
        private string serverSideEncryptionKeyManagementServiceKeyId;
        private string serverSideEncryptionKeyManagementServiceEncryptionContext;
        private string uploadId;

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
        /// The response also includes the <code>x-amz-abort-rule-id</code> header that provides
        /// the ID of the lifecycle configuration rule that defines the abort action.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime AbortDate
        {
            get { return this.abortDate.GetValueOrDefault(); }
            set { this.abortDate = value; }
        }

        // Check to see if AbortDate property is set
        internal bool IsSetAbortDate()
        {
            return this.abortDate.HasValue;
        }

        /// <summary>
        /// Gets and sets the property AbortRuleId. 
        /// <para>
        /// This header is returned along with the <code>x-amz-abort-date</code> header. It identifies
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
            get { return this.abortRuleId; }
            set { this.abortRuleId = value; }
        }

        // Check to see if AbortRuleId property is set
        internal bool IsSetAbortRuleId()
        {
            return this.abortRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Indicates whether the multipart upload uses an S3 Bucket Key for server-side encryption 
        /// with Key Management Service (KMS) keys (SSE-KMS).
        /// </para>
        /// </summary>
        public bool BucketKeyEnabled
        {
            get { return this.bucketKeyEnabled.GetValueOrDefault(); }
            set { this.bucketKeyEnabled = value; }
        }

        // Check to see if BucketKeyEnabled property is set
        internal bool IsSetBucketKeyEnabled()
        {
            return bucketKeyEnabled.HasValue;
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
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
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
        /// Gets and sets the property Key. 
        /// <para>
        /// Object key for which the multipart upload was initiated.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// If present, indicates that the requester was successfully charged for the request.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this.requestCharged; }
            set { this.requestCharged = value; }
        }

        /// <summary>
        /// Checks to see if RequestCharged is set.
        /// </summary>
        /// <returns>true, if RequestCharged property is set.</returns>
        internal bool IsSetRequestCharged()
        {
            return requestCharged != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionMethod. 
        /// <para>
        /// The server-side encryption algorithm used when you store this object in Amazon S3 (for example, <c>AES256</c>, <c>aws:kms</c>).
        /// </para> 
        /// 
        /// <para>
        /// <b>Directory buckets</b> - For directory buckets, there are only two supported options for server-side encryption: server-side encryption with 
        /// Amazon S3 managed keys (SSE-S3) (<c>AES256</c>) and server-side encryption with KMS keys (SSE-KMS) (<c>aws:kms</c>). 
        /// We recommend that the bucket's default encryption uses the desired encryption configuration and you don't override the bucket default encryption 
        /// in your <c>CreateSession</c> requests or <c>PUT</c> object requests. 
        /// 
        /// Then, new objects are automatically encrypted with the desired encryption settings. 
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-serv-side-encryption.html">Protecting data with server-side encryption</a> in 
        /// the <i>Amazon S3 User Guide</i>. 
        /// For more information about the encryption overriding behaviors in directory buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-specifying-kms-encryption.html">Specifying server-side encryption with KMS for new object uploads</a>. 
        /// </para>
        /// 
        /// <para>
        /// In the Zonal endpoint API calls (except <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>) using the REST API, 
        /// the encryption request headers must match the encryption settings that are specified in the <c>CreateSession</c> request. 
        /// You can't override the values of the encryption settings (<c>x-amz-server-side-encryption</c>, <c>x-amz-server-side-encryption-aws-kms-key-id</c>, <c>x-amz-server-side-encryption-context</c>, and <c>x-amz-server-side-encryption-bucket-key-enabled</c>) 
        /// that are specified in the <c>CreateSession</c> request. 
        /// 
        /// You don't need to explicitly specify these encryption settings values in Zonal endpoint API calls, and Amazon S3 will use the encryption settings values from the <c>CreateSession</c> 
        /// request to protect new objects in the directory bucket. 
        /// </para> 
        /// <para>
        /// When you use the CLI or the Amazon Web Services SDKs, for <c>CreateSession</c>, the session token refreshes automatically to avoid service 
        /// interruptions when a session expires. 
        /// The CLI or the Amazon Web Services SDKs use the bucket's default encryption configuration for the <c>CreateSession</c> request. 
        /// 
        /// It's not supported to override the encryption settings values in the <c>CreateSession</c> request. 
        /// So in the Zonal endpoint API calls (except <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a> and 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>), the encryption request headers must match the 
        /// default encryption configuration of the directory bucket.
        /// </para>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.serverSideEncryption; }
            set { this.serverSideEncryption = value; }
        }

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
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
            get { return this.serverSideCustomerEncryption; }
            set { this.serverSideCustomerEncryption = value; }
        }

        /// <summary>
        /// The MD5 of the customer encryption key specified in the ServerSideEncryptionCustomerProvidedKey property. The MD5 is
        /// base 64 encoded. This field is optional, the SDK will calculate the MD5 if this is not set.
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
            get { return this.serverSideEncryptionCustomerProvidedKeyMD5; }
            set { this.serverSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        /// <summary>
        /// <para>
        /// If present, indicates the ID of the KMS key that was used for object encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionKeyManagementServiceKeyId
        {
            get { return this.serverSideEncryptionKeyManagementServiceKeyId; }
            set { this.serverSideEncryptionKeyManagementServiceKeyId = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionKeyManagementServiceKeyId property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionKeyManagementServiceKeyId property is set.</returns>
        internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionKeyManagementServiceKeyId);
        }

        /// <summary>
        /// <para>
        /// If present, indicates the Amazon Web Services KMS Encryption Context to use for object encryption. 
        /// The value of this header is a Base64-encoded string of a UTF-8 encoded JSON, which contains the encryption context as key-value pairs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionKeyManagementServiceEncryptionContext
        {
            get { return this.serverSideEncryptionKeyManagementServiceEncryptionContext; }
            set { this.serverSideEncryptionKeyManagementServiceEncryptionContext = value; }
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// ID for the initiated multipart upload.
        /// </para>
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this.uploadId != null;
        }

    }
}
    
