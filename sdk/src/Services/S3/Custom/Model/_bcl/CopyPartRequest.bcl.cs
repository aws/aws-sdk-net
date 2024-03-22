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

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the CopyPart operation.
    /// Uploads a part by copying data from an existing object as data source. To specify
    /// the data source, you add the request header <c>x-amz-copy-source</c> in your request.
    /// To specify a byte range, you add the request header <c>x-amz-copy-source-range</c>
    /// in your request. 
    /// 
    ///  
    /// <para>
    /// For information about maximum and minimum part sizes and other multipart upload specifications,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/qfacts.html">Multipart
    /// upload limits</a> in the <i>Amazon S3 User Guide</i>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// Instead of copying data from an existing object as part data, you might use the <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPart.html">UploadPart</a>
    /// action to upload new data as a part of an object in your request.
    /// </para>
    ///  </note> 
    /// <para>
    /// You must initiate a multipart upload before you can upload any part. In response to
    /// your initiate request, Amazon S3 returns the upload ID, a unique identifier that you
    /// must include in your upload part request.
    /// </para>
    ///  
    /// <para>
    /// For conceptual information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
    /// Objects Using Multipart Upload</a> in the <i>Amazon S3 User Guide</i>. For information
    /// about copying objects using a single atomic action vs. a multipart upload, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ObjectOperations.html">Operations
    /// on Objects</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, you must make requests for this
    /// API operation to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <c>https://<i>bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> <dl> <dt>Authentication and authorization</dt> <dd> 
    /// <para>
    /// All <c>UploadPartCopy</c> requests must be authenticated and signed by using IAM credentials
    /// (access key ID and secret access key for the IAM identities). All headers with the
    /// <c>x-amz-</c> prefix, including <c>x-amz-copy-source</c>, must be signed. For more
    /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">REST
    /// Authentication</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Directory buckets</b> - You must use IAM credentials to authenticate and authorize
    /// your access to the <c>UploadPartCopy</c> API operation, instead of using the temporary
    /// security credentials through the <c>CreateSession</c> API operation.
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services CLI or SDKs handles authentication and authorization on your behalf.
    /// </para>
    ///  </dd> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have <c>READ</c> access to the source object and <c>WRITE</c> access to the
    /// destination bucket.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - You must have the permissions in a policy
    /// based on the bucket types of your source bucket and destination bucket in an <c>UploadPartCopy</c>
    /// operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the source object is in a general purpose bucket, you must have the <b> <c>s3:GetObject</c>
    /// </b> permission to read the source object that is being copied. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the destination bucket is a general purpose bucket, you must have the <b> <c>s3:PutObject</c>
    /// </b> permission to write the object copy to the destination bucket. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about permissions required to use the multipart upload API, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
    /// Upload and Permissions</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - You must have permissions in a bucket policy
    /// or an IAM identity-based policy based on the source and destination bucket types in
    /// an <c>UploadPartCopy</c> operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the source object that you want to copy is in a directory bucket, you must have
    /// the <b> <c>s3express:CreateSession</c> </b> permission in the <c>Action</c> element
    /// of a policy to read the object . By default, the session is in the <c>ReadWrite</c>
    /// mode. If you want to restrict the access, you can explicitly set the <c>s3express:SessionMode</c>
    /// condition key to <c>ReadOnly</c> on the copy source bucket.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the copy destination is a directory bucket, you must have the <b> <c>s3express:CreateSession</c>
    /// </b> permission in the <c>Action</c> element of a policy to write the object to the
    /// destination. The <c>s3express:SessionMode</c> condition key cannot be set to <c>ReadOnly</c>
    /// on the copy destination. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For example policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam-example-bucket-policies.html">Example
    /// bucket policies for S3 Express One Zone</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam-identity-policies.html">Amazon
    /// Web Services Identity and Access Management (IAM) identity-based policies for S3 Express
    /// One Zone</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Encryption</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose buckets </b> - For information about using server-side encryption
    /// with customer-provided encryption keys with the <c>UploadPartCopy</c> operation, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a>
    /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPart.html">UploadPart</a>.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory buckets </b> - For directory buckets, only server-side encryption with
    /// Amazon S3 managed keys (SSE-S3) (<c>AES256</c>) is supported.
    /// </para>
    ///  </li> </ul> </dd> <dt>Special errors</dt> <dd> <ul> <li> 
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
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Error Code: <c>InvalidRequest</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: The specified copy source is not supported as a byte-range copy source.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// HTTP Status Code: 400 Bad Request
    /// </para>
    ///  </li> </ul> </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>UploadPartCopy</c>:
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
    public partial class CopyPartRequest
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
    }
}
    
