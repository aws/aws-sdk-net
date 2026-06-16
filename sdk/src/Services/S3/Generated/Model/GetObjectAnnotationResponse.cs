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
    /// This is the response object from the GetObjectAnnotation operation.
    /// </summary>
    public partial class GetObjectAnnotationResponse : StreamResponse
    {
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumMD5;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private string _checksumSHA512;
        private ChecksumType _checksumType;
        private string _checksumXXHASH128;
        private string _checksumXXHASH3;
        private string _checksumXXHASH64;
        private string _eTag;
        private DateTime? _lastModified;
        private string _objectVersionId;
        private ReplicationStatus _replicationStatus;
        private RequestCharged _requestCharged;
        private ServerSideEncryptionMethod _serverSideEncryption;

        /// <summary>
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// The CRC32 checksum of the annotation payload.
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
        /// The CRC32C checksum of the annotation payload.
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
        /// Gets and sets the property ChecksumCRC64NVME. 
        /// <para>
        /// The CRC64NVME checksum of the annotation payload.
        /// </para>
        /// </summary>
        public string ChecksumCRC64NVME
        {
            get { return this._checksumCRC64NVME; }
            set { this._checksumCRC64NVME = value; }
        }

        // Check to see if ChecksumCRC64NVME property is set
        internal bool IsSetChecksumCRC64NVME()
        {
            return this._checksumCRC64NVME != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumMD5. 
        /// <para>
        /// The MD5 checksum of the annotation payload.
        /// </para>
        /// </summary>
        public string ChecksumMD5
        {
            get { return this._checksumMD5; }
            set { this._checksumMD5 = value; }
        }

        // Check to see if ChecksumMD5 property is set
        internal bool IsSetChecksumMD5()
        {
            return this._checksumMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumSHA1. 
        /// <para>
        /// The SHA1 checksum of the annotation payload.
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
        /// The SHA256 checksum of the annotation payload.
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
        /// Gets and sets the property ChecksumSHA512. 
        /// <para>
        /// The SHA512 checksum of the annotation payload.
        /// </para>
        /// </summary>
        public string ChecksumSHA512
        {
            get { return this._checksumSHA512; }
            set { this._checksumSHA512 = value; }
        }

        // Check to see if ChecksumSHA512 property is set
        internal bool IsSetChecksumSHA512()
        {
            return this._checksumSHA512 != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumType. 
        /// <para>
        /// The type of checksum used.
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
        /// Gets and sets the property ChecksumXXHASH128. 
        /// <para>
        /// The XXHASH128 checksum of the annotation payload.
        /// </para>
        /// </summary>
        public string ChecksumXXHASH128
        {
            get { return this._checksumXXHASH128; }
            set { this._checksumXXHASH128 = value; }
        }

        // Check to see if ChecksumXXHASH128 property is set
        internal bool IsSetChecksumXXHASH128()
        {
            return this._checksumXXHASH128 != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumXXHASH3. 
        /// <para>
        /// The XXHASH3 checksum of the annotation payload.
        /// </para>
        /// </summary>
        public string ChecksumXXHASH3
        {
            get { return this._checksumXXHASH3; }
            set { this._checksumXXHASH3 = value; }
        }

        // Check to see if ChecksumXXHASH3 property is set
        internal bool IsSetChecksumXXHASH3()
        {
            return this._checksumXXHASH3 != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumXXHASH64. 
        /// <para>
        /// The XXHASH64 checksum of the annotation payload.
        /// </para>
        /// </summary>
        public string ChecksumXXHASH64
        {
            get { return this._checksumXXHASH64; }
            set { this._checksumXXHASH64 = value; }
        }

        // Check to see if ChecksumXXHASH64 property is set
        internal bool IsSetChecksumXXHASH64()
        {
            return this._checksumXXHASH64 != null;
        }

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The entity tag of the annotation.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time the annotation was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectVersionId. 
        /// <para>
        /// The version ID of the object that the annotation is attached to.
        /// </para>
        /// </summary>
        public string ObjectVersionId
        {
            get { return this._objectVersionId; }
            set { this._objectVersionId = value; }
        }

        // Check to see if ObjectVersionId property is set
        internal bool IsSetObjectVersionId()
        {
            return this._objectVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// The replication status of the annotation. Possible values include <c>PENDING</c>,
        /// <c>COMPLETED</c>, <c>FAILED</c>, and <c>REPLICA</c>.
        /// </para>
        /// </summary>
        public ReplicationStatus ReplicationStatus
        {
            get { return this._replicationStatus; }
            set { this._replicationStatus = value; }
        }

        // Check to see if ReplicationStatus property is set
        internal bool IsSetReplicationStatus()
        {
            return this._replicationStatus != null;
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
        /// Gets and sets the property ServerSideEncryption. 
        /// <para>
        /// The server-side encryption algorithm used.
        /// </para>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryption
        {
            get { return this._serverSideEncryption; }
            set { this._serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryption property is set
        internal bool IsSetServerSideEncryption()
        {
            return this._serverSideEncryption != null;
        }

    }
}