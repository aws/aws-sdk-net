/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using Amazon.Runtime;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Response object for Transfer Utility upload operations.
    /// Contains unified response fields from both simple uploads (PutObjectResponse) 
    /// and multipart uploads (CompleteMultipartUploadResponse).
    /// </summary>
    public class TransferUtilityUploadResponse : AmazonWebServiceResponse
    {
        private bool? _bucketKeyEnabled;
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private ChecksumType _checksumType;
        private string _etag;
        private Expiration _expiration;
        private RequestCharged _requestCharged;
        private ServerSideEncryptionCustomerMethod _serverSideEncryptionCustomerMethod;
        private string _sseCustomerKeyMD5;
        private string _sseKmsEncryptionContext;
        private string _sseKmsKeyId;
        private ServerSideEncryptionMethod _serverSideEncryption;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled.
        /// <para>
        /// Indicates whether the uploaded object uses an S3 Bucket Key for server-side encryption with AWS KMS (SSE-KMS).
        /// </para>
        /// </summary>
        public bool BucketKeyEnabled
        {
            get { return this._bucketKeyEnabled.GetValueOrDefault(); }
            set { this._bucketKeyEnabled = value; }
        }

        /// <summary>
        /// Checks if BucketKeyEnabled property is set.
        /// </summary>
        /// <returns>true if BucketKeyEnabled property is set.</returns>
        internal bool IsSetBucketKeyEnabled()
        {
            return this._bucketKeyEnabled.HasValue;
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC32.
        /// <para>
        /// The base64-encoded, 32-bit CRC-32 checksum of the object.
        /// </para>
        /// </summary>
        public string ChecksumCRC32
        {
            get { return this._checksumCRC32; }
            set { this._checksumCRC32 = value; }
        }

        /// <summary>
        /// Checks if ChecksumCRC32 property is set.
        /// </summary>
        /// <returns>true if ChecksumCRC32 property is set.</returns>
        internal bool IsSetChecksumCRC32()
        {
            return !string.IsNullOrEmpty(this._checksumCRC32);
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC32C.
        /// <para>
        /// The base64-encoded, 32-bit CRC-32C checksum of the object.
        /// </para>
        /// </summary>
        public string ChecksumCRC32C
        {
            get { return this._checksumCRC32C; }
            set { this._checksumCRC32C = value; }
        }

        /// <summary>
        /// Checks if ChecksumCRC32C property is set.
        /// </summary>
        /// <returns>true if ChecksumCRC32C property is set.</returns>
        internal bool IsSetChecksumCRC32C()
        {
            return !string.IsNullOrEmpty(this._checksumCRC32C);
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC64NVME.
        /// <para>
        /// The base64-encoded, 64-bit CRC-64NVME checksum of the object.
        /// </para>
        /// </summary>
        public string ChecksumCRC64NVME
        {
            get { return this._checksumCRC64NVME; }
            set { this._checksumCRC64NVME = value; }
        }

        /// <summary>
        /// Checks if ChecksumCRC64NVME property is set.
        /// </summary>
        /// <returns>true if ChecksumCRC64NVME property is set.</returns>
        internal bool IsSetChecksumCRC64NVME()
        {
            return !string.IsNullOrEmpty(this._checksumCRC64NVME);
        }

        /// <summary>
        /// Gets and sets the property ChecksumSHA1.
        /// <para>
        /// The base64-encoded, 160-bit SHA-1 digest of the object.
        /// </para>
        /// </summary>
        public string ChecksumSHA1
        {
            get { return this._checksumSHA1; }
            set { this._checksumSHA1 = value; }
        }

        /// <summary>
        /// Checks if ChecksumSHA1 property is set.
        /// </summary>
        /// <returns>true if ChecksumSHA1 property is set.</returns>
        internal bool IsSetChecksumSHA1()
        {
            return !string.IsNullOrEmpty(this._checksumSHA1);
        }

        /// <summary>
        /// Gets and sets the property ChecksumSHA256.
        /// <para>
        /// The base64-encoded, 256-bit SHA-256 digest of the object.
        /// </para>
        /// </summary>
        public string ChecksumSHA256
        {
            get { return this._checksumSHA256; }
            set { this._checksumSHA256 = value; }
        }

        /// <summary>
        /// Checks if ChecksumSHA256 property is set.
        /// </summary>
        /// <returns>true if ChecksumSHA256 property is set.</returns>
        internal bool IsSetChecksumSHA256()
        {
            return !string.IsNullOrEmpty(this._checksumSHA256);
        }

        /// <summary>
        /// Gets and sets the property ChecksumType.
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object.
        /// </para>
        /// </summary>
        public ChecksumType ChecksumType
        {
            get { return this._checksumType; }
            set { this._checksumType = value; }
        }

        /// <summary>
        /// Checks if ChecksumType property is set.
        /// </summary>
        /// <returns>true if ChecksumType property is set.</returns>
        internal bool IsSetChecksumType()
        {
            return this._checksumType != null;
        }

        /// <summary>
        /// Gets and sets the property ETag.
        /// <para>
        /// Entity tag for the uploaded object.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._etag; }
            set { this._etag = value; }
        }

        /// <summary>
        /// Checks if ETag property is set.
        /// </summary>
        /// <returns>true if ETag property is set.</returns>
        internal bool IsSetETag()
        {
            return !string.IsNullOrEmpty(this._etag);
        }

        /// <summary>
        /// Gets and sets the property Expiration.
        /// <para>
        /// If the expiration is configured for the object, the response includes this header.
        /// It includes the expiry-date and rule-id key-value pairs providing object expiration information.
        /// </para>
        /// </summary>
        public Expiration Expiration
        {
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        /// <summary>
        /// Checks if Expiration property is set.
        /// </summary>
        /// <returns>true if Expiration property is set.</returns>
        internal bool IsSetExpiration()
        {
            return this._expiration != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCharged.
        /// <para>
        /// If present, indicates that the requester was successfully charged for the request.
        /// </para>
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this._requestCharged; }
            set { this._requestCharged = value; }
        }

        /// <summary>
        /// Checks if RequestCharged property is set.
        /// </summary>
        /// <returns>true if RequestCharged property is set.</returns>
        internal bool IsSetRequestCharged()
        {
            return this._requestCharged != null;
        }

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod
        {
            get { return this._serverSideEncryptionCustomerMethod; }
            set { this._serverSideEncryptionCustomerMethod = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionCustomerMethod property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerMethod property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this._serverSideEncryptionCustomerMethod != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerProvidedKeyMD5.
        /// <para>
        /// If server-side encryption with a customer-provided encryption key was requested, the response will include this header to provide round-trip message integrity verification of the customer-provided encryption key.
        /// </para>
        /// </summary>
        public string ServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this._sseCustomerKeyMD5; }
            set { this._sseCustomerKeyMD5 = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionCustomerProvidedKeyMD5 property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKeyMD5 property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !string.IsNullOrEmpty(this._sseCustomerKeyMD5);
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKeyManagementServiceEncryptionContext.
        /// <para>
        /// If present, specifies the AWS KMS Encryption Context to use for object encryption.
        /// </para>
        /// </summary>
        public string ServerSideEncryptionKeyManagementServiceEncryptionContext
        {
            get { return this._sseKmsEncryptionContext; }
            set { this._sseKmsEncryptionContext = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionKeyManagementServiceEncryptionContext property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionKeyManagementServiceEncryptionContext property is set.</returns>
        internal bool IsSetServerSideEncryptionKeyManagementServiceEncryptionContext()
        {
            return !string.IsNullOrEmpty(this._sseKmsEncryptionContext);
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKeyManagementServiceKeyId.
        /// <para>
        /// If x-amz-server-side-encryption is present and has the value of aws:kms, this header specifies the ID of the AWS Key Management Service (AWS KMS) symmetric customer managed customer master key (CMK) that was used for the object.
        /// </para>
        /// </summary>
        public string ServerSideEncryptionKeyManagementServiceKeyId
        {
            get { return this._sseKmsKeyId; }
            set { this._sseKmsKeyId = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionKeyManagementServiceKeyId property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionKeyManagementServiceKeyId property is set.</returns>
        internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
        {
            return !string.IsNullOrEmpty(this._sseKmsKeyId);
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionMethod.
        /// <para>
        /// The server-side encryption algorithm used when storing this object in Amazon S3.
        /// </para>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this._serverSideEncryption; }
            set { this._serverSideEncryption = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionMethod property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionMethod property is set.</returns>
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this._serverSideEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId.
        /// <para>
        /// Version of the object.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        /// <summary>
        /// Checks if VersionId property is set.
        /// </summary>
        /// <returns>true if VersionId property is set.</returns>
        internal bool IsSetVersionId()
        {
            return !string.IsNullOrEmpty(this._versionId);
        }
    }
}
