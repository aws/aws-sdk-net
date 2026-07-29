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
    /// Container for the parameters to the PutObjectAnnotation operation.
    /// Attaches an annotation to an Amazon S3 object. An annotation is a named payload of
    /// 1 byte to 1 MiB that you can associate with a specific object or object version. Each
    /// object can have up to 1,000 annotations.
    /// 
    ///  
    /// <para>
    /// For annotation naming rules and restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/annotations-overview.html">Annotation
    /// naming guidelines</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Annotations inherit the encryption of their parent object. For objects without server-side
    /// encryption, annotations are encrypted with SSE-S3 (the default for new objects). Objects
    /// encrypted with SSE-C cannot have annotations.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must have the <c>s3:PutObjectAnnotation</c> permission.
    /// If the bucket has Requester Pays enabled, you must include the <c>x-amz-request-payer</c>
    /// header.
    /// </para>
    ///  <note> 
    /// <para>
    /// Annotations are not supported by the following features: S3 Inventory Reports, API
    /// Gateway, S3 Storage Lens, Amazon S3 File Gateway, Amazon FSx, S3 on Outposts, and
    /// S3 Express One Zone (directory buckets).
    /// </para>
    ///  </note> 
    /// <para>
    /// The following operations are related to <c>PutObjectAnnotation</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectAnnotation.html">GetObjectAnnotation</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListObjectAnnotations.html">ListObjectAnnotations</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteObjectAnnotation.html">DeleteObjectAnnotation</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutObjectAnnotationRequest : AmazonWebServiceRequest
    {
        private string _annotationName;
        private MemoryStream _annotationPayload;
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
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
        private string _contentMD5;
        private string _expectedBucketOwner;
        private string _key;
        private string _objectIfMatch;
        private RequestPayer _requestPayer;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property AnnotationName. 
        /// <para>
        /// The name of the annotation.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 512 bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AnnotationName
        {
            get { return this._annotationName; }
            set { this._annotationName = value; }
        }

        // Check to see if AnnotationName property is set
        internal bool IsSetAnnotationName()
        {
            return this._annotationName != null;
        }

        /// <summary>
        /// Gets and sets the property AnnotationPayload. 
        /// <para>
        /// The annotation payload. Must be between 1 byte and 1 MiB in size, and must be valid
        /// UTF-8 encoded text. If the payload contains invalid UTF-8 bytes, the request fails
        /// with HTTP 415 (Unsupported Media Type). To store binary data, encode the payload using
        /// Base64 before uploading.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream AnnotationPayload
        {
            get { return this._annotationPayload; }
            set { this._annotationPayload = value; }
        }

        // Check to see if AnnotationPayload property is set
        internal bool IsSetAnnotationPayload()
        {
            return this._annotationPayload != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket that contains the object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The checksum algorithm to use. Supported values: <c>CRC32</c>, <c>CRC32C</c>, <c>CRC64NVME</c>,
        /// <c>SHA1</c>, <c>SHA256</c>, <c>SHA512</c>, <c>MD5</c>, <c>XXHASH64</c>, <c>XXHASH3</c>,
        /// <c>XXHASH128</c>.
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
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// Base64-encoded CRC32 checksum of the annotation payload.
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
        /// Base64-encoded CRC32C checksum of the annotation payload.
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
        /// Base64-encoded CRC64NVME checksum of the annotation payload.
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
        /// Base64-encoded MD5 checksum of the annotation payload.
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
        /// Base64-encoded SHA1 checksum of the annotation payload.
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
        /// Base64-encoded SHA256 checksum of the annotation payload.
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
        /// Base64-encoded SHA512 checksum of the annotation payload.
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
        /// Base64-encoded XXHASH128 checksum of the annotation payload.
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
        /// Base64-encoded XXHASH3 checksum of the annotation payload.
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
        /// Base64-encoded XXHASH64 checksum of the annotation payload.
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
        /// Gets and sets the property ContentMD5. 
        /// <para>
        /// Base64-encoded MD5 digest of the message.
        /// </para>
        /// </summary>
        public string ContentMD5
        {
            get { return this._contentMD5; }
            set { this._contentMD5 = value; }
        }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return this._contentMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the bucket is owned by a different
        /// account, the request fails with an HTTP 403 (Access Denied) error.
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The object key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property ObjectIfMatch. 
        /// <para>
        /// If specified, the operation only succeeds if the object's ETag matches the provided
        /// value.
        /// </para>
        /// </summary>
        public string ObjectIfMatch
        {
            get { return this._objectIfMatch; }
            set { this._objectIfMatch = value; }
        }

        // Check to see if ObjectIfMatch property is set
        internal bool IsSetObjectIfMatch()
        {
            return this._objectIfMatch != null;
        }

        /// <summary>
        /// Gets and sets the property RequestPayer.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this._requestPayer; }
            set { this._requestPayer = value; }
        }

        // Check to see if RequestPayer property is set
        internal bool IsSetRequestPayer()
        {
            return this._requestPayer != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version ID of the object to attach the annotation to.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}