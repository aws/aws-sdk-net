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
    /// Returns information about the  CopyPart response and response metadata.
    /// </summary>
    public class CopyPartResponse : AmazonWebServiceResponse
    {
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private DateTime? lastModified;
        private string eTag;
        private string copySourceVersionId;
        private int partNumber;
        private ServerSideEncryptionMethod serverSideEncryption;
        private string serverSideEncryptionKeyManagementServiceKeyId;
        private bool? bucketKeyEnabled;

        /// <summary>
        /// The version of the source object that was copied, if you have enabled versioning on the source bucketName.
        ///  
        /// </summary>
        public string CopySourceVersionId
        {
            get { return this.copySourceVersionId; }
            set { this.copySourceVersionId = value; }
        }

        // Check to see if CopySourceVersionId property is set
        internal bool IsSetCopySourceVersionId()
        {
            return this.copySourceVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// The base64-encoded, 32-bit CRC32 checksum of the object.
        /// </para>
        /// </summary>
        public string ChecksumCRC32
        {
            get { return this._checksumCRC32; }
            set { this._checksumCRC32 = value; }
        }

        // Check to see if ChecksumCRC32 property is set
        internal bool IsSetChecksumCRC32()
        {
            return this._checksumCRC32 != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC32C. 
        /// <para>
        /// The base64-encoded, 32-bit CRC32C checksum of the object.
        /// </para>
        /// </summary>
        public string ChecksumCRC32C
        {
            get { return this._checksumCRC32C; }
            set { this._checksumCRC32C = value; }
        }

        // Check to see if ChecksumCRC32C property is set
        internal bool IsSetChecksumCRC32C()
        {
            return this._checksumCRC32C != null;
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

        // Check to see if ChecksumSHA1 property is set
        internal bool IsSetChecksumSHA1()
        {
            return this._checksumSHA1 != null;
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

        // Check to see if ChecksumSHA256 property is set
        internal bool IsSetChecksumSHA256()
        {
            return this._checksumSHA256 != null;
        }

        /// <summary>
        /// Entity tag of the object.
        ///  
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this.eTag != null;
        }

        /// <summary>
        /// Date and time at which the object was uploaded.
        ///  
        /// </summary>
        public DateTime LastModified
        {
            get { return this.lastModified ?? default(DateTime); }
            set { this.lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this.lastModified.HasValue;
        }

        /// <summary>
        /// <para>
        /// The server-side encryption algorithm used when storing this object in Amazon S3 (for
        /// example, AES256, <code>aws:kms</code>).
        /// </para>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.serverSideEncryption; }
            set { this.serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryption property is set
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this.serverSideEncryption != null;
        }

        /// <summary>
        /// Gets and sets the PartNumber property.
        /// This is the part number in it's multi-part upload that will uniquely identify the part 
        /// and determine the relative ordering within the destination object.
        /// </summary>
        public int PartNumber
        {
            get { return this.partNumber; }
            set { this.partNumber = value; }
        }

        /// <summary>
        /// The id of the AWS Key Management Service key that Amazon S3 uses to encrypt and decrypt the object.
        /// <para>
        /// If present, specifies the ID of the Amazon Web Services Key Management Service (Amazon
        /// Web Services KMS) symmetric encryption customer managed key that was used for the
        /// object.
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
        /// <para>Indicates whether the multipart upload uses bucket key 
        /// for server-side encryption with AWS KMS (SSE-KMS).</para>
        /// </summary>
        public bool BucketKeyEnabled
        {
            get { return this.bucketKeyEnabled.GetValueOrDefault(); }
            set { this.bucketKeyEnabled = value; }
        }

        internal bool IsSetBucketKeyEnabled()
        {
            return bucketKeyEnabled.HasValue;
        }
    }
}
    
