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
    /// Contains all the possible checksum or digest values for an object.
    /// </summary>
    public partial class Checksum
    {
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumSHA1;
        private string _checksumSHA256;

        /// <summary>
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// The base64-encoded, 32-bit CRC-32 checksum of the object. This will only be present
        /// if it was uploaded with the object. When you use an API operation on an object that
        /// was uploaded using multipart uploads, this value may not be a direct checksum value
        /// of the full object. Instead, it's a calculation based on the checksum values of each
        /// individual part. For more information about how checksums are calculated with multipart
        /// uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html#large-object-checksums">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The base64-encoded, 32-bit CRC-32C checksum of the object. This will only be present
        /// if it was uploaded with the object. When you use an API operation on an object that
        /// was uploaded using multipart uploads, this value may not be a direct checksum value
        /// of the full object. Instead, it's a calculation based on the checksum values of each
        /// individual part. For more information about how checksums are calculated with multipart
        /// uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html#large-object-checksums">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The base64-encoded, 160-bit SHA-1 digest of the object. This will only be present
        /// if it was uploaded with the object. When you use the API operation on an object that
        /// was uploaded using multipart uploads, this value may not be a direct checksum value
        /// of the full object. Instead, it's a calculation based on the checksum values of each
        /// individual part. For more information about how checksums are calculated with multipart
        /// uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html#large-object-checksums">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The base64-encoded, 256-bit SHA-256 digest of the object. This will only be present
        /// if it was uploaded with the object. When you use an API operation on an object that
        /// was uploaded using multipart uploads, this value may not be a direct checksum value
        /// of the full object. Instead, it's a calculation based on the checksum values of each
        /// individual part. For more information about how checksums are calculated with multipart
        /// uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html#large-object-checksums">
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
