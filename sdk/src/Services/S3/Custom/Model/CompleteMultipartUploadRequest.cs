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
    }
}
