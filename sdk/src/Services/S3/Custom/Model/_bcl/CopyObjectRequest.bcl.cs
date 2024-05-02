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
    /// Container for the parameters to the CopyObject operation.
    /// Creates a copy of an object that is already stored in Amazon S3.
    /// 
    ///  <note> 
    /// <para>
    /// You can store individual objects of up to 5 TB in Amazon S3. You create a copy of
    /// your object up to 5 GB in size in a single atomic action using this API. However,
    /// to copy an object greater than 5 GB, you must use the multipart upload Upload Part
    /// - Copy (UploadPartCopy) API. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjctsUsingRESTMPUapi.html">Copy
    /// Object Using the REST Multipart Upload API</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can copy individual objects between general purpose buckets, between directory
    /// buckets, and between general purpose buckets and directory buckets.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets </b> - For directory buckets, you must make requests for this
    /// API operation to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <c>https://<i>bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Both the Region that you want to copy the object from and the Region that you want
    /// to copy the object to must be enabled for your account.
    /// </para>
    ///  <important> 
    /// <para>
    /// Amazon S3 transfer acceleration does not support cross-Region copies. If you request
    /// a cross-Region copy using a transfer acceleration endpoint, you get a <c>400 Bad
    /// Request</c> error. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/transfer-acceleration.html">Transfer
    /// Acceleration</a>.
    /// </para>
    ///  </important> <dl> <dt>Authentication and authorization</dt> <dd> 
    /// <para>
    /// All <c>CopyObject</c> requests must be authenticated and signed by using IAM
    /// credentials (access key ID and secret access key for the IAM identities). All headers
    /// with the <c>x-amz-</c> prefix, including <c>x-amz-copy-source</c>, must
    /// be signed. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">REST
    /// Authentication</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Directory buckets</b> - You must use the IAM credentials to authenticate and authorize
    /// your access to the <c>CopyObject</c> API operation, instead of using the temporary
    /// security credentials through the <c>CreateSession</c> API operation.
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services CLI or SDKs handles authentication and authorization on your behalf.
    /// </para>
    ///  </dd> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have <i>read</i> access to the source object and <i>write</i> access to the
    /// destination bucket.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - You must have permissions in an IAM policy
    /// based on the source and destination bucket types in a <c>CopyObject</c> operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the source object is in a general purpose bucket, you must have <b> <c>s3:GetObject</c>
    /// </b> permission to read the source object that is being copied. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the destination bucket is a general purpose bucket, you must have <b> <c>s3:PutObject</c>
    /// </b> permission to write the object copy to the destination bucket. 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - You must have permissions in a bucket policy
    /// or an IAM identity-based policy based on the source and destination bucket types in
    /// a <c>CopyObject</c> operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the source object that you want to copy is in a directory bucket, you must have
    /// the <b> <c>s3express:CreateSession</c> </b> permission in the <c>Action</c>
    /// element of a policy to read the object. By default, the session is in the <c>ReadWrite</c>
    /// mode. If you want to restrict the access, you can explicitly set the <c>s3express:SessionMode</c>
    /// condition key to <c>ReadOnly</c> on the copy source bucket.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the copy destination is a directory bucket, you must have the <b> <c>s3express:CreateSession</c>
    /// </b> permission in the <c>Action</c> element of a policy to write the object
    /// to the destination. The <c>s3express:SessionMode</c> condition key can't be
    /// set to <c>ReadOnly</c> on the copy destination bucket. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For example policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam-example-bucket-policies.html">Example
    /// bucket policies for S3 Express One Zone</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam-identity-policies.html">Amazon
    /// Web Services Identity and Access Management (IAM) identity-based policies for S3 Express
    /// One Zone</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Response and special errors</dt> <dd> 
    /// <para>
    /// When the request is an HTTP 1.1 request, the response is chunk encoded. When the request
    /// is not an HTTP 1.1 request, the response would not contain the <c>Content-Length</c>.
    /// You always need to read the entire response body to check if the copy succeeds. to
    /// keep the connection alive while we copy the data. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the copy is successful, you receive a response with information about the copied
    /// object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A copy request might return an error when Amazon S3 receives the copy request or while
    /// Amazon S3 is copying the files. A <c>200 OK</c> response can contain either
    /// a success or an error.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the error occurs before the copy action starts, you receive a standard Amazon S3
    /// error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the error occurs during the copy operation, the error response is embedded in the
    /// <c>200 OK</c> response. For example, in a cross-region copy, you may encounter
    /// throttling and receive a <c>200 OK</c> response. For more information, see <a
    /// href="https://repost.aws/knowledge-center/s3-resolve-200-internalerror">Resolve the
    /// Error 200 response when copying objects to Amazon S3</a>. The <c>200 OK</c>
    /// status code means the copy was accepted, but it doesn't mean the copy is complete.
    /// Another example is when you disconnect from Amazon S3 before the copy is complete,
    /// Amazon S3 might cancel the copy and you may receive a <c>200 OK</c> response.
    /// You must stay connected to Amazon S3 until the entire response is successfully received
    /// and processed.
    /// </para>
    ///  
    /// <para>
    /// If you call this API operation directly, make sure to design your application to parse
    /// the content of the response and handle it appropriately. If you use Amazon Web Services
    /// SDKs, SDKs handle this condition. The SDKs detect the embedded error and apply error
    /// handling per your configuration settings (including automatically retrying the request
    /// as appropriate). If the condition persists, the SDKs throw an exception (or, for the
    /// SDKs that don't use exceptions, they return an error).
    /// </para>
    ///  </li> </ul> </li> </ul> </dd> <dt>Charge</dt> <dd> 
    /// <para>
    /// The copy request charge is based on the storage class and Region that you specify
    /// for the destination object. The request can also result in a data retrieval charge
    /// for the source if the source storage class bills for data retrieval. If the copy source
    /// is in a different region, the data transfer is billed to the copy source account.
    /// For pricing information, see <a href="http://aws.amazon.com/s3/pricing/">Amazon S3
    /// pricing</a>.
    /// </para>
    ///  </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>CopyObject</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CopyObjectRequest
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
    
