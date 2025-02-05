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
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// A container holding the part number, etag, and optional checksum used when completing a multipart upload.
    /// </summary>
    public class PartETag : IComparable<PartETag>
    {
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private int? partNumber;
        private string eTag;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public PartETag()
        {
        }


        /// <summary>
        /// Constructs an instance of PartETag and sets the part number and etag.
        /// </summary>
        /// <param name="partNumber">The part number.</param>
        /// <param name="eTag">the associated ETag for the part number.</param>
        public PartETag(int partNumber, string eTag)
        {
            this.partNumber = partNumber;
            this.eTag = eTag;
        }

        /// <summary>
        /// Constructs an instance of PartETag from an UploadPart response
        /// </summary>
        /// <param name="uploadPartResponse">UploadPart response</param>
        public PartETag(UploadPartResponse uploadPartResponse) : this(uploadPartResponse, false) { }

        /// <summary>
        /// Constructs an instance of PartETag from an UploadPart response
        /// </summary>
        /// <param name="uploadPartResponse">UploadPart response</param>
        /// <param name="copyChecksums">Whether to copy the checksums from the UploadPart response into the PartETag instance</param>
        public PartETag(UploadPartResponse uploadPartResponse, bool copyChecksums)
        {
            partNumber = uploadPartResponse.PartNumber;
            eTag = uploadPartResponse.ETag;

            if (copyChecksums)
            {
                ChecksumCRC32C = uploadPartResponse.ChecksumCRC32C;
                ChecksumCRC32 = uploadPartResponse.ChecksumCRC32;
                ChecksumCRC64NVME = uploadPartResponse.ChecksumCRC64NVME;
                ChecksumSHA1 = uploadPartResponse.ChecksumSHA1;
                ChecksumSHA256 = uploadPartResponse.ChecksumSHA256;
            }
        }

        /// <summary>
        /// Constructs an instance of PartETag from an CopyPart response
        /// </summary>
        /// <param name="copyPartResponse">CopyPart response</param>
        public PartETag(CopyPartResponse copyPartResponse) : this(copyPartResponse, false) { }

        /// <summary>
        /// Constructs an instance of PartETag from an CopyPart response
        /// </summary>
        /// <param name="copyPartResponse">CopyPart response</param>
        /// <param name="copyChecksums">Whether to copy the checksums from the CopyPart response into the PartETag instance</param>
        public PartETag(CopyPartResponse copyPartResponse, bool copyChecksums)
        {
            partNumber = copyPartResponse.PartNumber;
            eTag = copyPartResponse.ETag;

            if (copyChecksums)
            {
                ChecksumCRC32C = copyPartResponse.ChecksumCRC32C;
                ChecksumCRC32 = copyPartResponse.ChecksumCRC32;
                ChecksumCRC64NVME = copyPartResponse.ChecksumCRC64NVME;
                ChecksumSHA1 = copyPartResponse.ChecksumSHA1;
                ChecksumSHA256 = copyPartResponse.ChecksumSHA256;
            }
        }

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has the following meanings:
        /// Value
        /// Meaning
        /// Less than zero
        /// This object is less than the <paramref name="other"/> parameter.
        /// Zero
        /// This object is equal to <paramref name="other"/>.
        /// Greater than zero
        /// This object is greater than <paramref name="other"/>.
        /// </returns>
        public int CompareTo(PartETag other)
        {
            return this.PartNumber.GetValueOrDefault().CompareTo(other.PartNumber.GetValueOrDefault());
        }

        #region PartNumber

        /// <summary>
        /// The part number identifying the part.
        /// </summary>
        public int? PartNumber
        {
            get { return this.partNumber; }
            set { this.partNumber = value; }
        }

        // Check to see if PartNumber property is set
        internal bool IsSetPartNumber()
        {
            return this.partNumber.HasValue;
        }

        #endregion

        #region eTag

        /// <summary>
        /// The entity tag associated with the part.
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

        #endregion

        /// <summary>
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// The Base64 encoded, 32-bit <c>CRC-32</c> checksum of the part. This checksum is only present
        /// if the object was uploaded with the <c>CRC-32</c> checksum algorithm.
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
        /// if the object was uploaded with the <c>CRC-32C</c> checksum algorithm.
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
        /// if the object was uploaded with the <c>SHA-1</c> checksum algorithm.
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
        /// This checksum is present if the object was uploaded with the <c>SHA-256</c> checksum algorithm.
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
    }
}
