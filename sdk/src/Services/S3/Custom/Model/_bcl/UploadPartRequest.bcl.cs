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
    /// Container for the parameters to the UploadPart operation.
    /// Uploads a part in a multipart upload.
    /// 
    ///  <note> 
    /// <para>
    /// In this operation, you provide new data as a part of an object in your request. However,
    /// you have an option to specify your existing Amazon S3 object as a data source for
    /// the part you are uploading. To upload a part from an existing object, you use the
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>
    /// operation. 
    /// </para>
    ///  </note> 
    /// <para>
    /// You must initiate a multipart upload (see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateMultipartUpload.html">CreateMultipartUpload</a>)
    /// before you can upload any part. In response to your initiate request, Amazon S3 returns
    /// an upload ID, a unique identifier that you must include in your upload part request.
    /// </para>
    ///  
    /// <para>
    /// Part numbers can be any number from 1 to 10,000, inclusive. A part number uniquely
    /// identifies a part and also defines its position within the object being created. If
    /// you upload a new part using the same part number that was used with a previous part,
    /// the previously uploaded part is overwritten.
    /// </para>
    ///  
    /// <para>
    /// For information about maximum and minimum part sizes and other multipart upload specifications,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/qfacts.html">Multipart
    /// upload limits</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// After you initiate multipart upload and upload one or more parts, you must either
    /// complete or abort multipart upload in order to stop getting charged for storage of
    /// the uploaded parts. Only after you either complete or abort multipart upload, Amazon
    /// S3 frees up the parts storage and stops charging you for the parts storage.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information on multipart uploads, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html">Multipart
    /// Upload Overview</a> in the <i>Amazon S3 User Guide </i>.
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
    ///  <b>General purpose bucket permissions</b> - For information on the permissions required
    /// to use the multipart upload API, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
    /// Upload and Permissions</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - To grant access to this API operation on a
    /// directory bucket, we recommend that you use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <c>CreateSession</c> </a> API operation for session-based authorization. Specifically,
    /// you grant the <c>s3express:CreateSession</c> permission to the directory bucket in
    /// a bucket policy or an IAM identity-based policy. Then, you make the <c>CreateSession</c>
    /// API call on the bucket to obtain a session token. With the session token in your request
    /// header, you can make API requests to this operation. After the session token expires,
    /// you make another <c>CreateSession</c> API call to generate a new session token for
    /// use. Amazon Web Services CLI or SDKs create session and refresh the session token
    /// automatically to avoid service interruptions when a session expires. For more information
    /// about authorization, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <c>CreateSession</c> </a>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Data integrity</dt> <dd> 
    /// <para>
    ///  <b>General purpose bucket</b> - To ensure that data is not corrupted traversing the
    /// network, specify the <c>Content-MD5</c> header in the upload part request. Amazon
    /// S3 checks the part data against the provided MD5 value. If they do not match, Amazon
    /// S3 returns an error. If the upload request is signed with Signature Version 4, then
    /// Amazon Web Services S3 uses the <c>x-amz-content-sha256</c> header as a checksum instead
    /// of <c>Content-MD5</c>. For more information see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-auth-using-authorization-header.html">Authenticating
    /// Requests: Using the Authorization Header (Amazon Web Services Signature Version 4)</a>.
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - MD5 is not supported by directory buckets. You can use
    /// checksum algorithms to check object integrity.
    /// </para>
    ///  </note> </dd> <dt>Encryption</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket</b> - Server-side encryption is for data encryption at
    /// rest. Amazon S3 encrypts your data as it writes it to disks in its data centers and
    /// decrypts it when you access it. You have mutually exclusive options to protect data
    /// using server-side encryption in Amazon S3, depending on how you choose to manage the
    /// encryption keys. Specifically, the encryption key options are Amazon S3 managed keys
    /// (SSE-S3), Amazon Web Services KMS keys (SSE-KMS), and Customer-Provided Keys (SSE-C).
    /// Amazon S3 encrypts data with server-side encryption using Amazon S3 managed keys (SSE-S3)
    /// by default. You can optionally tell Amazon S3 to encrypt data at rest using server-side
    /// encryption with other key options. The option you use depends on whether you want
    /// to use KMS keys (SSE-KMS) or provide your own encryption key (SSE-C).
    /// </para>
    ///  
    /// <para>
    /// Server-side encryption is supported by the S3 Multipart Upload operations. Unless
    /// you are using a customer-provided encryption key (SSE-C), you don't need to specify
    /// the encryption parameters in each UploadPart request. Instead, you only need to specify
    /// the server-side encryption parameters in the initial Initiate Multipart request. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateMultipartUpload.html">CreateMultipartUpload</a>.
    /// </para>
    ///  
    /// <para>
    /// If you request server-side encryption using a customer-provided encryption key (SSE-C)
    /// in your initiate multipart upload request, you must provide identical encryption information
    /// in each part upload using the following request headers.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// x-amz-server-side-encryption-customer-algorithm
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// x-amz-server-side-encryption-customer-key
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// x-amz-server-side-encryption-customer-key-MD5
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Directory bucket</b> - For directory buckets, only server-side encryption with
    /// Amazon S3 managed keys (SSE-S3) (<c>AES256</c>) is supported. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingServerSideEncryption.html">Using
    /// Server-Side Encryption</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </dd> <dt>Special errors</dt> <dd> <ul> <li> 
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
    ///  </li> <li> 
    /// <para>
    /// SOAP Fault Code Prefix: Client
    /// </para>
    ///  </li> </ul> </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>UploadPart</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateMultipartUpload.html">CreateMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CompleteMultipartUpload.html">CompleteMultipartUpload</a>
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
    public partial class UploadPartRequest : AmazonWebServiceRequest
    {
        /// <summary>
        /// Overrides the default request timeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the value is set, the value is assigned to the Timeout property of the HTTPWebRequest/HttpClient object used
        /// to send requests.
        /// </para>
        /// <para>
        /// Please specify a timeout value only if the operation will not complete within the default intervals
        /// specified for an HttpWebRequest/HttpClient.
        /// </para>
        /// </remarks>
        /// <exception cref="System.ArgumentNullException">The timeout specified is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">The timeout specified is less than or equal to zero and is not Infinite.</exception>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        /// <seealso cref="P:System.Net.Http.HttpClient.Timeout"/>
        public TimeSpan? Timeout
        {
            get { return this.TimeoutInternal; }
            set { this.TimeoutInternal = value; }
        }


        /// <summary>
        /// Overrides the default ReadWriteTimeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the value is set, the value is assigned to the ReadWriteTimeout property of the HTTPWebRequest/WebRequestHandler object used
        /// to send requests.
        /// </para>
        /// <exception cref="System.ArgumentNullException">The timeout specified is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">The timeout specified is less than or equal to zero and is not Infinite.</exception>
        /// </remarks>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.Http.WebRequestHandler.ReadWriteTimeout"/>
        public TimeSpan? ReadWriteTimeout
        {
            get { return this.ReadWriteTimeoutInternal; }
            set { this.ReadWriteTimeoutInternal = value; }
        }

        internal void SetupForFilePath()
        {
            var fileStream = new FileStream(this.FilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            fileStream.Position = this.FilePosition.GetValueOrDefault();
            this.InputStream = fileStream;
        }
    }
}
