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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the CompleteMultipartUpload operation.
    /// Completes a multipart upload by assembling previously uploaded parts.
    /// 
    ///  
    /// <para>
    /// You first initiate the multipart upload and then upload all parts using the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPart.html">UploadPart</a>
    /// operation or the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>
    /// operation. After successfully uploading all relevant parts of an upload, you call
    /// this <c>CompleteMultipartUpload</c> operation to complete the upload. Upon receiving
    /// this request, Amazon S3 concatenates all the parts in ascending order by part number
    /// to create a new object. In the CompleteMultipartUpload request, you must provide the
    /// parts list and ensure that the parts list is complete. The CompleteMultipartUpload
    /// API operation concatenates the parts that you provide in the list. For each part in
    /// the list, you must provide the <c>PartNumber</c> value and the <c>ETag</c>
    /// value that are returned after that part was uploaded.
    /// </para>
    ///  
    /// <para>
    /// The processing of a CompleteMultipartUpload request could take several minutes to
    /// finalize. After Amazon S3 begins processing the request, it sends an HTTP response
    /// header that specifies a <c>200 OK</c> response. While processing is in progress,
    /// Amazon S3 periodically sends white space characters to keep the connection from timing
    /// out. A request could fail after the initial <c>200 OK</c> response has been
    /// sent. This means that a <c>200 OK</c> response can contain either a success
    /// or an error. The error response might be embedded in the <c>200 OK</c> response.
    /// If you call this API operation directly, make sure to design your application to parse
    /// the contents of the response and handle it appropriately. If you use Amazon Web Services
    /// SDKs, SDKs handle this condition. The SDKs detect the embedded error and apply error
    /// handling per your configuration settings (including automatically retrying the request
    /// as appropriate). If the condition persists, the SDKs throw an exception (or, for the
    /// SDKs that don't use exceptions, they return an error). 
    /// </para>
    ///  
    /// <para>
    /// Note that if <c>CompleteMultipartUpload</c> fails, applications should be prepared
    /// to retry any failed requests (including 500 error responses). For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ErrorBestPractices.html">Amazon
    /// S3 Error Best Practices</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// You can't use <c>Content-Type: application/x-www-form-urlencoded</c> for the
    /// CompleteMultipartUpload requests. Also, if you don't provide a <c>Content-Type</c>
    /// header, <c>CompleteMultipartUpload</c> can still return a <c>200 OK</c>
    /// response.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
    /// Objects Using Multipart Upload</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, you must make requests for this
    /// API operation to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <c>https://<i>bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - For information about permissions required
    /// to use the multipart upload API, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
    /// Upload and Permissions</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - To grant access to this API operation on a
    /// directory bucket, we recommend that you use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <c>CreateSession</c> </a> API operation for session-based authorization. Specifically,
    /// you grant the <c>s3express:CreateSession</c> permission to the directory bucket
    /// in a bucket policy or an IAM identity-based policy. Then, you make the <c>CreateSession</c>
    /// API call on the bucket to obtain a session token. With the session token in your request
    /// header, you can make API requests to this operation. After the session token expires,
    /// you make another <c>CreateSession</c> API call to generate a new session token
    /// for use. Amazon Web Services CLI or SDKs create session and refresh the session token
    /// automatically to avoid service interruptions when a session expires. For more information
    /// about authorization, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <c>CreateSession</c> </a>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Special errors</dt> <dd> <ul> <li> 
    /// <para>
    /// Error Code: <c>EntityTooSmall</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: Your proposed upload is smaller than the minimum allowed object size.
    /// Each part must be at least 5 MB in size, except the last part.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// HTTP Status Code: 400 Bad Request
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Error Code: <c>InvalidPart</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: One or more of the specified parts could not be found. The part might
    /// not have been uploaded, or the specified ETag might not have matched the uploaded
    /// part's ETag.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// HTTP Status Code: 400 Bad Request
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Error Code: <c>InvalidPartOrder</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: The list of parts was not in ascending order. The parts list must be
    /// specified in order by part number.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// HTTP Status Code: 400 Bad Request
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Error Code: <c>NoSuchUpload</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: The specified multipart upload does not exist. The upload ID might be
    /// invalid, or the multipart upload might have been aborted or completed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// HTTP Status Code: 404 Not Found
    /// </para>
    ///  </li> </ul> </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>CompleteMultipartUpload</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateMultipartUpload.html">CreateMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPart.html">UploadPart</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_AbortMultipartUpload.html">AbortMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListParts.html">ListParts</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListMultipartUploads.html">ListMultipartUploads</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CompleteMultipartUploadRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private ChecksumType checksumType;
        private long? mpuObjectSize;
        private string key;
        private List<PartETag> partETags = AWSConfigs.InitializeCollections ? new List<PartETag>() : null;
        private string uploadId;
        private RequestPayer requestPayer;
        private string _sseCustomerAlgorithm;
        private string _sseCustomerKey;
        private string _sseCustomerKeyMD5;
        private string expectedBucketOwner;
        private string _ifNoneMatch;

        private string _ifMatch;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// Name of the bucket to which the multipart upload was initiated.
        /// </para> 
        /// <para> 
        /// <b>Directory buckets</b> - When you use this operation with a directory bucket, you must use virtual-hosted-style requests in the 
        /// format <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>. Path-style requests are not 
        /// supported. Directory bucket names must be unique in the chosen Zone (Availability Zone or Local Zone). Bucket names must follow 
        /// the format <c> <i>bucket-base-name</i>--<i>zone-id</i>--x-s3</c> (for example, <c> <i>amzn-s3-demo-bucket</i>--<i>usw2-az1</i>--x-s3</c>). For 
        /// information about bucket naming restrictions, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory bucket naming 
        /// rules</a> in the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <para> 
        /// <b>Access points</b> - When you use this action with an access point for general purpose buckets, you must provide the alias of the 
        /// access point in place of the bucket name or specify the access point ARN. When you use this action with an access point for directory 
        /// buckets, you must provide the access point name in place of the bucket name. When using the access point ARN, you must direct requests 
        /// to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When 
        /// using this action with an access point through the Amazon Web Services SDKs, you provide the access point ARN in place of the bucket name. For 
        /// more information about access point ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <note> 
        /// <para>
        /// Object Lambda access points are not supported by directory buckets.
        /// </para> 
        /// </note> 
        /// <para> 
        /// <b>S3 on Outposts</b> - When you use this action with S3 on Outposts, you must direct requests to the S3 on Outposts hostname. The S3 
        /// on Outposts hostname takes the form <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>. When 
        /// you use this action with S3 on Outposts, the destination bucket must be the Outposts access point ARN or the access point alias. For more 
        /// information about S3 on Outposts, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What is S3 on Outposts?</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
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
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the Base64 encoded, 32-bit
        /// <c>CRC-32</c> checksum of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
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
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the Base64 encoded, 32-bit
        /// <c>CRC-32C</c> checksum of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
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
        /// Gets and sets the property ChecksumCRC64NVME. 
        /// <para>
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the Base64 encoded, 64-bit
        /// <c>CRC-64NVME</c> checksum of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the Base64 encoded, 160-bit
        /// <c>SHA-1</c> digest of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
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
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the Base64 encoded, 256-bit
        /// <c>SHA-256</c> digest of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
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
        /// Gets and sets the property ChecksumType.
        /// <para>
        /// This header specifies the checksum type of the object, which determines how part-level checksums
        /// are combined to create an object-level checksum for multipart objects.You can use this header as
        /// a data integrity check to verify that the checksum type that is received is the same checksum that
        /// was specified. If the checksum type doesn't match the checksum type that was specified for the object
        /// during the<c> CreateMultipartUpload</c> request, it'll result in a<c> BadDigest</c> error.For more information,
        /// see Checking object integrity in the Amazon S3 User Guide.
        /// </para>
        /// </summary>
        public ChecksumType ChecksumType
        {
            get { return this.checksumType; }
            set { this.checksumType = value; }
        }

        /// <summary>
        /// Checks to see if ChecksumType is set.
        /// </summary>
        /// <returns>true, if ChecksumType property is set.</returns>
        internal bool IsSetChecksumType()
        {
            return checksumType != null;
        }

        /// <summary>
        /// Gets and sets the property MpuObjectSize. 
        /// <para>
        /// The expected total object size of the multipart upload request.
        /// If there's a mismatch between the specified object size value and the actual
        /// object size value, it results in an <c>HTTP 400 InvalidRequest</c> error.
        /// </para>
        /// </summary>
        public long MpuObjectSize
        {
            get { return this.mpuObjectSize.GetValueOrDefault(); }
            set { this.mpuObjectSize = value; }
        }

        /// <summary>
        /// Checks if MpuObjectSize property is set.
        /// </summary>
        /// <returns>true if MpuObjectSize property is set.</returns>
        internal bool IsSetMpuObjectSize()
        {
            return this.mpuObjectSize.HasValue;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <c>403 Forbidden</c> (access denied).
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }

        /// <summary>
        /// <para>Uploads the object only if the object key name does not already exist in the bucket specified. Otherwise, 
        /// Amazon S3 returns a <c>412 Precondition Failed</c> error.</para> <para>If a conflicting operation occurs 
        /// during the upload S3 returns a <c>409 ConditionalRequestConflict</c> response. On a 409 failure you should 
        /// re-initiate the multipart upload with <c>CreateMultipartUpload</c> and re-upload each part.</para> <para>Expects 
        /// the '*' (asterisk) character.</para> <para>For more information about conditional requests, 
        /// see <a href="https://tools.ietf.org/html/rfc7232">RFC 7232</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/conditional-requests.html">Conditional requests</a> 
        /// in the <i>Amazon S3 User Guide</i>.</para>
        /// </summary>
        public string IfNoneMatch
        {
            get { return this._ifNoneMatch; }
            set { this._ifNoneMatch = value; }
        }

        /// <summary>
        /// Checks to see if IfNoneMatch is set.
        /// </summary>
        /// <returns>true, if IfNoneMatch property is set.</returns>
        internal bool IsSetIfNoneMatch()
        {
            return !string.IsNullOrEmpty(this._ifNoneMatch);
        }

        /// <summary>
        /// <para>Uploads the object only if the ETag (entity tag) value provided during the WRITE operation matches the ETag of the object in S3. If the ETag values do not match, the operation returns a <c>412 Precondition Failed</c> error.</para>
        /// <para>If a conflicting operation occurs during the upload S3 returns a <c>409 ConditionalRequestConflict</c> response. On a 409 failure you should fetch the object's ETag and retry the upload.</para>
        /// <para>Expects the ETag value as a string.</para>
        /// <para>For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC 7232</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/conditional-requests.html">Conditional requests</a> in the <i>Amazon S3 User Guide</i>.</para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        /// <summary>
        /// Checks to see if IfMatch is set.
        /// </summary>
        /// <returns>true, if IfMatch property is set.</returns>
        internal bool IsSetIfMatch()
        {
            return !string.IsNullOrEmpty(this._ifMatch);
        }

        /// <summary>
        /// The key of the S3 object that was being uploaded.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". 
        /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory.
        /// </para>
        /// <para>
        /// Starting with .NET 8, the AWS .NET SDK disables System.Uri's feature of canonicalizing the resource path. This allows S3 keys like
        /// "foo/../bar/file.txt" to work correctly with the AWS .NET SDK.
        /// </para>
        /// <para>
        /// For further information view the documentation for the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
        /// </para>
        /// </remarks>
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
        /// A collection of part numbers and corresponding etags / checksums.
        /// </summary>
        public List<PartETag> PartETags
        {
            get { return this.partETags; }
            set { this.partETags = value; }
        }

        /// <summary>
        /// Adds a collection of parts (including ETags and checksums) to this request.
        /// </summary>
        /// <param name="partETags">PartETags that will added to this request.</param>
        public void AddPartETags(params PartETag[] partETags)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (partETags != null)
            {
                foreach (PartETag part in partETags)
                {
                    this.PartETags.Add(part);
                }
            }
        }

        /// <summary>
        /// Adds a collection of parts (including ETags and checksums) to this request.
        /// </summary>
        /// <param name="partETags">PartETags that will added to this request.</param>
        public void AddPartETags(IEnumerable<PartETag> partETags)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (partETags != null)
            {
                foreach (PartETag part in partETags)
                {
                    this.PartETags.Add(part);
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from UploadParts.</param>
        /// <remarks>
        /// This method only includes ETags. Use one of the <c>AddPartETagsAndChecksums</c> overloads to include checksums as well.
        /// </remarks>
        public void AddPartETags(params UploadPartResponse[] responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (UploadPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: false));
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from UploadParts.</param>
        /// <remarks>
        /// This method only includes ETags. Use one of the <c>AddPartETagsAndChecksums</c> overloads to include checksums as well.
        /// </remarks>
        public void AddPartETags(IEnumerable<UploadPartResponse> responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (UploadPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: false));
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers, ETags and checksums by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from UploadParts.</param>
        public void AddPartETagsAndChecksums(params UploadPartResponse[] responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (UploadPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: true));
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers, ETags and checksums by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from UploadParts.</param>
        public void AddPartETagsAndChecksums(IEnumerable<UploadPartResponse> responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (UploadPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: true));
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the CopyPartResponse into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from CopyParts.</param>
        /// <remarks>
        /// This method only includes ETags. Use one of the <c>AddPartETagsAndChecksums</c> overloads to include checksums as well.
        /// </remarks>
        public void AddPartETags(params CopyPartResponse[] responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (CopyPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: false));
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the CopyPartResponse into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from CopyParts.</param>
        /// <remarks>
        /// This method only includes ETags. Use one of the <c>AddPartETagsAndChecksums</c> overloads to include checksums as well.
        /// </remarks>
        public void AddPartETags(IEnumerable<CopyPartResponse> responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (CopyPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: false));
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers, ETags and checksums by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from CopyParts.</param>
        public void AddPartETagsAndChecksums(params CopyPartResponse[] responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (CopyPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: true));
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers, ETags and checksums by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from CopyParts.</param>
        public void AddPartETagsAndChecksums(IEnumerable<CopyPartResponse> responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (CopyPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: true));
                }
            }
        }

        /// <summary>
        /// Confirms that the requester knows that she or he will be charged for the request.
        /// Bucket owners need not specify this parameter in their requests.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this.requestPayer; }
            set { this.requestPayer = value; }
        }

        /// <summary>
        /// Checks to see if RequetsPayer is set.
        /// </summary>
        /// <returns>true, if RequestPayer property is set.</returns>
        internal bool IsSetRequestPayer()
        {
            return requestPayer != null;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerAlgorithm. 
        /// <para>
        /// The server-side encryption (SSE) algorithm used to encrypt the object. This parameter
        /// is required only when the object was created using a checksum algorithm or if your
        /// bucket policy requires the use of SSE-C. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ServerSideEncryptionCustomerKeys.html#ssec-require-condition-key">Protecting
        /// data using SSE-C keys</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string SSECustomerAlgorithm
        {
            get { return this._sseCustomerAlgorithm; }
            set { this._sseCustomerAlgorithm = value; }
        }

        // Check to see if SSECustomerAlgorithm property is set
        internal bool IsSetSSECustomerAlgorithm()
        {
            return this._sseCustomerAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerKey. 
        /// <para>
        /// The SSE customer key. This is only needed when the object was cureated using a checksum
        /// algorithm. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Protecting
        /// data using SSE-C keys</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string SSECustomerKey
        {
            get { return this._sseCustomerKey; }
            set { this._sseCustomerKey = value; }
        }

        // Check to see if SSECustomerKey property is set
        internal bool IsSetSSECustomerKey()
        {
            return this._sseCustomerKey != null;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerKeyMD5. 
        /// <para>
        /// The MD5 SSE customer key. This is only needed when the object was cureated using a
        /// checksum algorithm. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Protecting
        /// data using SSE-C keys</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string SSECustomerKeyMD5
        {
            get { return this._sseCustomerKeyMD5; }
            set { this._sseCustomerKeyMD5 = value; }
        }

        // Check to see if SSECustomerKeyMD5 property is set
        internal bool IsSetSSECustomerKeyMD5()
        {
            return this._sseCustomerKeyMD5 != null;
        }

        /// <summary>
        /// The upload id for the in-progress multipart upload that should be completed.
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
