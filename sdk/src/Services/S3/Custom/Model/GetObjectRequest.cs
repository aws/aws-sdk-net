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
using System.Collections.ObjectModel;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the GetObject operation.
    /// Retrieves an object from Amazon S3.
    /// 
    ///  
    /// <para>
    /// In the <c>GetObject</c> request, specify the full key name for the object.
    /// </para>
    ///  
    /// <para>
    ///  <b>General purpose buckets</b> - Both the virtual-hosted-style requests and the path-style
    /// requests are supported. For a virtual hosted-style request example, if you have the
    /// object <c>photos/2006/February/sample.jpg</c>, specify the object key name as <c>/photos/2006/February/sample.jpg</c>.
    /// For a path-style request example, if you have the object <c>photos/2006/February/sample.jpg</c>
    /// in the bucket named <c>amzn-s3-demo-bucket</c>, specify the object key name as <c>/amzn-s3-demo-bucket/photos/2006/February/sample.jpg</c>.
    /// For more information about request types, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html#VirtualHostingSpecifyBucket">HTTP
    /// Host Header Bucket Specification</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Directory buckets</b> - Only virtual-hosted-style requests are supported. For
    /// a virtual hosted-style request example, if you have the object <c>photos/2006/February/sample.jpg</c>
    /// in the bucket named <c>amzn-s3-demo-bucket--use1-az5--x-s3</c>, specify the object key name
    /// as <c>/photos/2006/February/sample.jpg</c>. Also, when you make requests to this API
    /// operation, your requests are sent to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <c>https://<i>bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - You must have the required permissions
    /// in a policy. To use <c>GetObject</c>, you must have the <c>READ</c> access to the
    /// object (or version). If you grant <c>READ</c> access to the anonymous user, the <c>GetObject</c>
    /// operation returns the object without using an authorization header. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
    /// permissions in a policy</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you include a <c>versionId</c> in your request header, you must have the <c>s3:GetObjectVersion</c>
    /// permission to access a specific version of an object. The <c>s3:GetObject</c> permission
    /// is not required in this scenario.
    /// </para>
    ///  
    /// <para>
    /// If you request the current version of an object without a specific <c>versionId</c>
    /// in the request header, only the <c>s3:GetObject</c> permission is required. The <c>s3:GetObjectVersion</c>
    /// permission is not required in this scenario. 
    /// </para>
    ///  
    /// <para>
    /// If the object that you request doesn’t exist, the error that Amazon S3 returns depends
    /// on whether you also have the <c>s3:ListBucket</c> permission.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you have the <c>s3:ListBucket</c> permission on the bucket, Amazon S3 returns an
    /// HTTP status code <c>404 Not Found</c> error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you don’t have the <c>s3:ListBucket</c> permission, Amazon S3 returns an HTTP status
    /// code <c>403 Access Denied</c> error.
    /// </para>
    ///  </li> </ul> </li> <li> 
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
    ///  </li> </ul> </dd> <dt>Storage classes</dt> <dd> 
    /// <para>
    /// If the object you are retrieving is stored in the S3 Glacier Flexible Retrieval storage
    /// class, the S3 Glacier Deep Archive storage class, the S3 Intelligent-Tiering Archive
    /// Access tier, or the S3 Intelligent-Tiering Deep Archive Access tier, before you can
    /// retrieve the object you must first restore a copy using <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_RestoreObject.html">RestoreObject</a>.
    /// Otherwise, this operation returns an <c>InvalidObjectState</c> error. For information
    /// about restoring archived objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
    /// Archived Objects</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Directory buckets </b> - For directory buckets, only the S3 Express One Zone storage
    /// class is supported to store newly created objects. Unsupported storage class values
    /// won't write a destination object and will respond with the HTTP status code <c>400
    /// Bad Request</c>.
    /// </para>
    ///  </dd> <dt>Encryption</dt> <dd> 
    /// <para>
    /// Encryption request headers, like <c>x-amz-server-side-encryption</c>, should not be
    /// sent for the <c>GetObject</c> requests, if your object uses server-side encryption
    /// with Amazon S3 managed encryption keys (SSE-S3), server-side encryption with Key Management
    /// Service (KMS) keys (SSE-KMS), or dual-layer server-side encryption with Amazon Web
    /// Services KMS keys (DSSE-KMS). If you include the header in your <c>GetObject</c> requests
    /// for the object that uses these types of keys, you’ll get an HTTP <c>400 Bad Request</c>
    /// error.
    /// </para>
    ///  </dd> <dt>Overriding response header values through the request</dt> <dd> 
    /// <para>
    /// There are times when you want to override certain response header values of a <c>GetObject</c>
    /// response. For example, you might override the <c>Content-Disposition</c> response
    /// header value through your <c>GetObject</c> request.
    /// </para>
    ///  
    /// <para>
    /// You can override values for a set of response headers. These modified response header
    /// values are included only in a successful response, that is, when the HTTP status code
    /// <c>200 OK</c> is returned. The headers you can override using the following query
    /// parameters in the request are a subset of the headers that Amazon S3 accepts when
    /// you create an object. 
    /// </para>
    ///  
    /// <para>
    /// The response headers that you can override for the <c>GetObject</c> response are <c>Cache-Control</c>,
    /// <c>Content-Disposition</c>, <c>Content-Encoding</c>, <c>Content-Language</c>, <c>Content-Type</c>,
    /// and <c>Expires</c>.
    /// </para>
    ///  
    /// <para>
    /// To override values for a set of response headers in the <c>GetObject</c> response,
    /// you can use the following query parameters in the request.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>response-cache-control</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>response-content-disposition</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>response-content-encoding</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>response-content-language</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>response-content-type</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>response-expires</c> 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// When you use these parameters, you must sign the request by using either an Authorization
    /// header or a presigned URL. These parameters cannot be used with an unsigned (anonymous)
    /// request.
    /// </para>
    ///  </note> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>GetObject</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListBuckets.html">ListBuckets</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectAcl.html">GetObjectAcl</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetObjectRequest : AmazonWebServiceRequest
    {
        private ResponseHeaderOverrides responseHeaders;


        void PartNumberCustomSetter(int? value)
        {
            if (value.HasValue)
            {
                if (value < 1 || 10000 < value)
                {
                    throw new ArgumentException("PartNumber must be a positve integer between 1 and 10,000.");
                }
            }

            this._partNumber = value;
        }

        /// <summary>
        /// A set of response headers that should be returned with the object.
        /// </summary>
        public ResponseHeaderOverrides ResponseHeaderOverrides
        {
            get
            {
                if (this.responseHeaders == null)
                {
                    this.responseHeaders = new ResponseHeaderOverrides();
                }
                return this.responseHeaders;
            }
            set
            {
                this.responseHeaders = value;
            }
        }
    }
}
