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
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for elements related to an individual part.
    /// </summary>
    public partial class ObjectPart
    {
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private int? _partNumber;
        private long? _size;
        private string _checksumMD5;
        private string _checksumSHA512;
        private string _checksumXXHASH128;
        private string _checksumXXHASH3;
        private string _checksumXXHASH64;

        /// <summary>
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// The Base64 encoded, 32-bit <c>CRC-32</c> checksum of the part. This checksum is only present
        /// if the multipart upload request was created with the <c>CRC-32</c> checksum algorithm.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The Base64 encoded, 32-bit <c>CRC-32C</c> checksum of the part. This checksum is only present
        /// if the multipart upload request was created with the <c>CRC-32C</c> checksum algorithm.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The Base64 encoded, 64-bit <c>CRC-64NVME</c> checksum of the part. This checksum is only present
        /// if the multipart upload request was created with the <c>CRC-64NVME</c> checksum algorithm, or if the object was uploaded without 
        /// a checksum (and Amazon S3 added the default checksum, <c>CRC-64NVME</c>, to the uploaded object). 
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property ChecksumSHA1. 
        /// <para>
        /// The Base64 encoded, 160-bit <c>SHA-1</c> checksum of the part. This checksum is only present
        /// if the multipart upload request was created with the <c>SHA-1</c> checksum algorithm.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The Base64 encoded, 256-bit <c>SHA-256</c> checksum of the part.
        /// This checksum is present if the multipart upload request was created with the <c>SHA-256</c> checksum algorithm.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property PartNumber. 
        /// <para>
        /// The part number identifying the part. This value is a positive integer between 1 and
        /// 10,000.
        /// </para>
        /// </summary>
        public int PartNumber
        {
            get { return this._partNumber.GetValueOrDefault(); }
            set { this._partNumber = value; }
        }

        // Check to see if PartNumber property is set
        internal bool IsSetPartNumber()
        {
            return this._partNumber.HasValue;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the uploaded part in bytes.
        /// </para>
        /// </summary>
        public long Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue;
        }

        /// <summary>
        /// Gets and sets the property ChecksumMD5.
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
        /// Gets and sets the property ChecksumSHA512.
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
        /// Gets and sets the property ChecksumXXHASH128.
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
    }
}