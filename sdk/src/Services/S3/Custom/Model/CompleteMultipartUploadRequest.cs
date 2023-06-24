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
    /// operation. After successfully uploading all relevant parts of an upload, you call
    /// this action to complete the upload. Upon receiving this request, Amazon S3 concatenates
    /// all the parts in ascending order by part number to create a new object. In the Complete
    /// Multipart Upload request, you must provide the parts list. You must ensure that the
    /// parts list is complete. This action concatenates the parts that you provide in the
    /// list. For each part in the list, you must provide the part number and the <code>ETag</code>
    /// value, returned after that part was uploaded.
    /// </para>
    ///  
    /// <para>
    /// Processing of a Complete Multipart Upload request could take several minutes to complete.
    /// After Amazon S3 begins processing the request, it sends an HTTP response header that
    /// specifies a 200 OK response. While processing is in progress, Amazon S3 periodically
    /// sends white space characters to keep the connection from timing out. Because a request
    /// could fail after the initial 200 OK response has been sent, it is important that you
    /// check the response body to determine whether the request succeeded.
    /// </para>
    ///  
    /// <para>
    /// Note that if <code>CompleteMultipartUpload</code> fails, applications should be prepared
    /// to retry the failed requests. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ErrorBestPractices.html">Amazon
    /// S3 Error Best Practices</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// You cannot use <code>Content-Type: application/x-www-form-urlencode</code> with Complete
    /// Multipart Upload requests. It is not allowed by the Amazon S3. Also, if
    /// you do not provide a <code>Content-Type</code> header, <code>CompleteMultipartUpload</code>
    /// returns a 200 OK response.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
    /// Objects Using Multipart Upload</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about permissions required to use the multipart upload API, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
    /// Upload and Permissions</a>.
    /// </para>
    ///  
    /// <para>
    ///  <code>CompleteMultipartUpload</code> has the following special errors:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Error code: <code>EntityTooSmall</code> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: Your proposed upload is smaller than the minimum allowed object size.
    /// Each part must be at least 5 MB in size, except the last part.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 400 Bad Request
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Error code: <code>InvalidPart</code> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: One or more of the specified parts could not be found. The part might
    /// not have been uploaded, or the specified entity tag might not have matched the part's
    /// entity tag.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 400 Bad Request
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Error code: <code>InvalidPartOrder</code> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: The list of parts was not in ascending order. The parts list must be
    /// specified in order by part number.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 400 Bad Request
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Error code: <code>NoSuchUpload</code> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: The specified multipart upload does not exist. The upload ID might be
    /// invalid, or the multipart upload might have been aborted or completed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 404 Not Found
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// The following operations are related to <code>CompleteMultipartUpload</code>:
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
        private string _checksumSHA1;
        private string _checksumSHA256;
        private string key;
        private List<PartETag> partETags = new List<PartETag>();
        private string uploadId;
        private RequestPayer requestPayer;
        private string _sseCustomerAlgorithm;
        private string _sseCustomerKey;
        private string _sseCustomerKeyMD5;
        private string expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// Name of the bucket to which the multipart upload was initiated.
        /// </para>
        ///  
        /// <para>
        /// When using this action with an access point, you must direct requests to the access
        /// point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you use this action with Amazon S3 on Outposts, you must direct requests to the
        /// S3 on Outposts hostname. The S3 on Outposts hostname takes the form <code> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</code>.
        /// When you use this action with S3 on Outposts through the Amazon Web Services SDKs,
        /// you provide the Outposts access point ARN in place of the bucket name. For more information
        /// about S3 on Outposts ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What
        /// is S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
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
        /// is the same data that was originally sent. This specifies the base64-encoded, 32-bit
        /// CRC32 checksum of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
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
        /// is the same data that was originally sent. This specifies the base64-encoded, 32-bit
        /// CRC32C checksum of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
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
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the base64-encoded, 160-bit
        /// SHA-1 digest of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
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
        /// is the same data that was originally sent. This specifies the base64-encoded, 256-bit
        /// SHA-256 digest of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
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
        /// The account ID of the expected bucket owner. 
        /// If the bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.
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
        /// The key of the S3 object that was being uploaded.
        /// </summary>
        /// <remarks>
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory. For further information view the documentation for 
        /// the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
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
        /// A collection of part numbers and corresponding etags.
        /// </summary>
        public List<PartETag> PartETags
        {
            get
            {
                if (this.partETags == null)
                {
                    this.partETags = new List<PartETag>();
                }

                return this.partETags;
            }
            set { this.partETags = value; }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags.
        /// </summary>
        /// <param name="partETags">PartETags that will added to this request.</param>
        public void AddPartETags(params PartETag[] partETags)
        {
            foreach (PartETag part in partETags)
            {
                this.PartETags.Add(part);
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags.
        /// </summary>
        /// <param name="partETags">PartETags that will added to this request.</param>
        public void AddPartETags(IEnumerable<PartETag> partETags)
        {
            foreach (PartETag part in partETags)
            {
                this.PartETags.Add(part);
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from UploadParts.</param>
        public void AddPartETags(params UploadPartResponse[] responses)
        {
            foreach (UploadPartResponse response in responses)
            {
                this.PartETags.Add(new PartETag(response));
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from UploadParts.</param>
        public void AddPartETags(IEnumerable<UploadPartResponse> responses)
        {
            foreach (UploadPartResponse response in responses)
            {
                this.PartETags.Add(new PartETag(response));
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the CopyPartResponse into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from CopyParts.</param>
        public void AddPartETags(params CopyPartResponse[] responses)
        {
            foreach (CopyPartResponse response in responses)
            {
                this.PartETags.Add(new PartETag(response.PartNumber, response.ETag));
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the CopyPartResponse into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from CopyParts.</param>
        public void AddPartETags(IEnumerable<CopyPartResponse> responses)
        {
            foreach (CopyPartResponse response in responses)
            {
                this.PartETags.Add(new PartETag(response.PartNumber, response.ETag));
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
        /// The SSE algorithm used to encrypt the object. This is only needed when the object
        /// was created using a checksum algorithm. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Protecting
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