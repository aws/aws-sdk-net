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
    /// Details of the parts that were uploaded.
    /// </summary>
    public partial class PartETag : IComparable<PartETag>
    {
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumMD5;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private string _checksumSHA512;
        private string _checksumXXHASH128;
        private string _checksumXXHASH3;
        private string _checksumXXHASH64;
        private string _eTag;
        private int? _partNumber;

        /// <summary>
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// The Base64 encoded, 32-bit <c>CRC32</c> checksum of the part. This checksum is present
        /// if the multipart upload request was created with the <c>CRC32</c> checksum algorithm.
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
        /// The Base64 encoded, 32-bit <c>CRC32C</c> checksum of the part. This checksum is present
        /// if the multipart upload request was created with the <c>CRC32C</c> checksum algorithm.
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
        /// The Base64 encoded, 64-bit <c>CRC64NVME</c> checksum of the part. This checksum is
        /// present if the multipart upload request was created with the <c>CRC64NVME</c> checksum
        /// algorithm. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
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
        /// Gets and sets the property ChecksumMD5. 
        /// <para>
        /// The Base64 encoded, 128-bit <c>MD5</c> digest of the part. This checksum is present
        /// if the multipart upload request was created with the <c>MD5</c> checksum algorithm.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The Base64 encoded, 160-bit <c>SHA1</c> checksum of the part. This checksum is present
        /// if the multipart upload request was created with the <c>SHA1</c> checksum algorithm.
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
        /// The Base64 encoded, 256-bit <c>SHA256</c> checksum of the part. This checksum is present
        /// if the multipart upload request was created with the <c>SHA256</c> checksum algorithm.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The Base64 encoded, 512-bit <c>SHA512</c> digest of the part. This checksum is present
        /// if the multipart upload request was created with the <c>SHA512</c> checksum algorithm.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property ChecksumXXHASH128. 
        /// <para>
        /// The Base64 encoded, 128-bit <c>XXHASH128</c> checksum of the part. This checksum is
        /// present if the multipart upload request was created with the <c>XXHASH128</c> checksum
        /// algorithm. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The Base64 encoded, 64-bit <c>XXHASH3</c> checksum of the part. This checksum is present
        /// if the multipart upload request was created with the <c>XXHASH3</c> checksum algorithm.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The Base64 encoded, 64-bit <c>XXHASH64</c> checksum of the part. This checksum is
        /// present if the multipart upload request was created with the <c>XXHASH64</c> checksum
        /// algorithm. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Entity tag returned when the part was uploaded.
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
        /// Gets and sets the property PartNumber. 
        /// <para>
        /// Part number that identifies the part. This is a positive integer between 1 and 10,000.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  <b>General purpose buckets</b> - In <c>CompleteMultipartUpload</c>, when a additional
        /// checksum (including <c>x-amz-checksum-crc32</c>, <c>x-amz-checksum-crc32c</c>, <c>x-amz-checksum-sha1</c>,
        /// or <c>x-amz-checksum-sha256</c>) is applied to each part, the <c>PartNumber</c> must
        /// start at 1 and the part numbers must be consecutive. Otherwise, Amazon S3 generates
        /// an HTTP <c>400 Bad Request</c> status code and an <c>InvalidPartOrder</c> error code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Directory buckets</b> - In <c>CompleteMultipartUpload</c>, the <c>PartNumber</c>
        /// must start at 1 and the part numbers must be consecutive.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public int? PartNumber
        {
            get { return this._partNumber; }
            set { this._partNumber = value; }
        }

        // Check to see if PartNumber property is set
        internal bool IsSetPartNumber()
        {
            return this._partNumber.HasValue; 
        }

    }
}