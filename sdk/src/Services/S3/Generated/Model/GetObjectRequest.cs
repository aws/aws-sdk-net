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
    /// in the bucket named <c>examplebucket</c>, specify the object key name as <c>/examplebucket/photos/2006/February/sample.jpg</c>.
    /// For more information about request types, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html#VirtualHostingSpecifyBucket">HTTP
    /// Host Header Bucket Specification</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Directory buckets</b> - Only virtual-hosted-style requests are supported. For
    /// a virtual hosted-style request example, if you have the object <c>photos/2006/February/sample.jpg</c>
    /// in the bucket named <c>amzn-s3-demo-bucket--usw2-az1--x-s3</c>, specify the object
    /// key name as <c>/photos/2006/February/sample.jpg</c>. Also, when you make requests
    /// to this API operation, your requests are sent to the Zonal endpoint. These endpoints
    /// support virtual-hosted-style requests in the format <c>https://<i>bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information about endpoints
    /// in Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/endpoint-directory-buckets-AZ.html">Regional
    /// and Zonal endpoints for directory buckets in Availability Zones</a> in the <i>Amazon
    /// S3 User Guide</i>. For more information about endpoints in Local Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-lzs-for-directory-buckets.html">Concepts
    /// for directory buckets in Local Zones</a> in the <i>Amazon S3 User Guide</i>.
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
    ///  
    /// <para>
    /// If the object is encrypted using SSE-KMS, you must also have the <c>kms:GenerateDataKey</c>
    /// and <c>kms:Decrypt</c> permissions in IAM identity-based policies and KMS key policies
    /// for the KMS key.
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
    ///  <b>Directory buckets </b> - Directory buckets only support <c>EXPRESS_ONEZONE</c>
    /// (the S3 Express One Zone storage class) in Availability Zones and <c>ONEZONE_IA</c>
    /// (the S3 One Zone-Infrequent Access storage class) in Dedicated Local Zones. Unsupported
    /// storage class values won't write a destination object and will respond with the HTTP
    /// status code <c>400 Bad Request</c>.
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
    ///  
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, there are only two supported options
    /// for server-side encryption: SSE-S3 and SSE-KMS. SSE-C isn't supported. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-serv-side-encryption.html">Protecting
    /// data with server-side encryption</a> in the <i>Amazon S3 User Guide</i>.
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
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>.
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
    ///  </li> </ul> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class GetObjectRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private ByteRange _byteRange;
        private ChecksumMode _checksumMode;
        private string _etagToMatch;
        private string _etagToNotMatch;
        private string _expectedBucketOwner;
        private string _key;
        private DateTime? _modifiedSinceDate;
        private int? _partNumber;
        private RequestPayer _requestPayer;
        private DateTime? _responseExpires;
        private ServerSideEncryptionCustomerMethod _serverSideEncryptionCustomerMethod;
        private string _serverSideEncryptionCustomerProvidedKey;
        private string _serverSideEncryptionCustomerProvidedKeyMD5;
        private DateTime? _unmodifiedSinceDate;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name containing the object. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets</b> - When you use this operation with a directory bucket, you
        /// must use virtual-hosted-style requests in the format <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>.
        /// Path-style requests are not supported. Directory bucket names must be unique in the
        /// chosen Zone (Availability Zone or Local Zone). Bucket names must follow the format
        /// <c> <i>bucket-base-name</i>--<i>zone-id</i>--x-s3</c> (for example, <c> <i>amzn-s3-demo-bucket</i>--<i>usw2-az1</i>--x-s3</c>).
        /// For information about bucket naming restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory
        /// bucket naming rules</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access points</b> - When you use this action with an access point for general
        /// purpose buckets, you must provide the alias of the access point in place of the bucket
        /// name or specify the access point ARN. When you use this action with an access point
        /// for directory buckets, you must provide the access point name in place of the bucket
        /// name. When using the access point ARN, you must direct requests to the access point
        /// hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Object Lambda access points</b> - When you use this action with an Object Lambda
        /// access point, you must direct requests to the Object Lambda access point hostname.
        /// The Object Lambda access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-object-lambda.<i>Region</i>.amazonaws.com.
        /// </para>
        ///  <note> 
        /// <para>
        /// Object Lambda access points are not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>S3 on Outposts</b> - When you use this action with S3 on Outposts, you must direct
        /// requests to the S3 on Outposts hostname. The S3 on Outposts hostname takes the form
        /// <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>.
        /// When you use this action with S3 on Outposts, the destination bucket must be the Outposts
        /// access point ARN or the access point alias. For more information about S3 on Outposts,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What
        /// is S3 on Outposts?</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property ByteRange. 
        /// <para>
        /// Downloads the specified byte range of an object. For more information about the HTTP
        /// Range header, see <a href="https://www.rfc-editor.org/rfc/rfc9110.html#name-range">https://www.rfc-editor.org/rfc/rfc9110.html#name-range</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon S3 doesn't support retrieving multiple ranges of data per <c>GET</c> request.
        /// </para>
        ///  </note>
        /// </summary>
        public ByteRange ByteRange
        {
            get { return this._byteRange; }
            set { this._byteRange = value; }
        }

        // Check to see if ByteRange property is set
        internal bool IsSetByteRange()
        {
            return this._byteRange != null && this._byteRange.FormattedByteRange != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumMode. 
        /// <para>
        /// To retrieve the checksum, this mode must be enabled.
        /// </para>
        /// </summary>
        /// para
        /// <b>General purpose buckets</b> - In addition, if you enable checksum mode and the object is uploaded with a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_Checksum.html">checksum</a>
        /// and encrypted with an Key Management Service (KMS) key, you must have permission to use the <c>kms:Decrypt</c> action to retrieve the checksum.
        /// </para>
        public ChecksumMode ChecksumMode
        {
            get { return this._checksumMode; }
            set { this._checksumMode = value; }
        }

        // Check to see if ChecksumMode property is set
        internal bool IsSetChecksumMode()
        {
            return this._checksumMode != null;
        }

        /// <summary>
        /// Gets and sets the property EtagToMatch. 
        /// <para>
        /// Return the object only if its entity tag (ETag) is the same as the one specified in
        /// this header; otherwise, return a <c>412 Precondition Failed</c> error.
        /// </para>
        ///  
        /// <para>
        /// If both of the <c>If-Match</c> and <c>If-Unmodified-Since</c> headers are present
        /// in the request as follows: <c>If-Match</c> condition evaluates to <c>true</c>, and;
        /// <c>If-Unmodified-Since</c> condition evaluates to <c>false</c>; then, S3 returns <c>200
        /// OK</c> and the data requested. 
        /// </para>
        ///  
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        /// </summary>
        public string EtagToMatch
        {
            get { return this._etagToMatch; }
            set { this._etagToMatch = value; }
        }

        // Check to see if EtagToMatch property is set
        internal bool IsSetEtagToMatch()
        {
            return this._etagToMatch != null;
        }

        /// <summary>
        /// Gets and sets the property EtagToNotMatch. 
        /// <para>
        /// Return the object only if its entity tag (ETag) is different from the one specified
        /// in this header; otherwise, return a <c>304 Not Modified</c> error.
        /// </para>
        ///  
        /// <para>
        /// If both of the <c>If-None-Match</c> and <c>If-Modified-Since</c> headers are present
        /// in the request as follows:<c> If-None-Match</c> condition evaluates to <c>false</c>,
        /// and; <c>If-Modified-Since</c> condition evaluates to <c>true</c>; then, S3 returns
        /// <c>304 Not Modified</c> HTTP status code.
        /// </para>
        ///  
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        /// </summary>
        public string EtagToNotMatch
        {
            get { return this._etagToNotMatch; }
            set { this._etagToNotMatch = value; }
        }

        // Check to see if EtagToNotMatch property is set
        internal bool IsSetEtagToNotMatch()
        {
            return this._etagToNotMatch != null;
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
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this._expectedBucketOwner);
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Key of the object to get.
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..".
        /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".."
        /// is interpreted as use parent directory.
        /// </para>
        /// Starting with .NET 8, the AWS .NET SDK disables System.Uri's feature of canonicalizing the resource path. This allows S3 keys like
        /// "foo/../bar/file.txt" to work correctly with the AWS .NET SDK.
        /// For further information view the documentation for the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
        /// </remarks>
        /// 
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
        /// Gets and sets the property ModifiedSinceDate. 
        /// <para>
        /// Return the object only if it has been modified since the specified time; otherwise,
        /// return a <c>304 Not Modified</c> error.
        /// </para>
        ///  
        /// <para>
        /// If both of the <c>If-None-Match</c> and <c>If-Modified-Since</c> headers are present
        /// in the request as follows:<c> If-None-Match</c> condition evaluates to <c>false</c>,
        /// and; <c>If-Modified-Since</c> condition evaluates to <c>true</c>; then, S3 returns
        /// <c>304 Not Modified</c> status code.
        /// </para>
        ///  
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        /// </summary>
        public DateTime? ModifiedSinceDate
        {
            get { return this._modifiedSinceDate ?? DateTime.SpecifyKind(default, DateTimeKind.Utc); }
            set { this._modifiedSinceDate = value; }
        }

        // Check to see if ModifiedSinceDate property is set
        internal bool IsSetModifiedSinceDate()
        {
            return this._modifiedSinceDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartNumber. 
        /// <para>
        /// Part number of the object being read. This is a positive integer between 1 and 10,000.
        /// Effectively performs a 'ranged' GET request for the part specified. Useful for downloading
        /// just a part of an object.
        /// </para>
        /// </summary>
        public int? PartNumber
        {
            get { return this._partNumber; }
            set { PartNumberCustomSetter(value); }
        }

        // Check to see if PartNumber property is set
        internal bool IsSetPartNumber()
        {
            return this._partNumber.HasValue; 
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
        /// Gets and sets the property ResponseExpires. 
        /// <para>
        /// Sets the <c>Expires</c> header of the response.
        /// </para>
        /// </summary>
        public DateTime? ResponseExpires
        {
            get { return this._responseExpires; }
            set { this._responseExpires = value; }
        }

        // Check to see if ResponseExpires property is set
        internal bool IsSetResponseExpires()
        {
            return this._responseExpires.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerMethod. 
        /// <para>
        /// Specifies the algorithm to use when decrypting the object (for example, <c>AES256</c>).
        /// </para>
        ///  
        /// <para>
        /// If you encrypt an object by using server-side encryption with customer-provided encryption
        /// keys (SSE-C) when you store the object in Amazon S3, then when you GET the object,
        /// you must use the following headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-server-side-encryption-customer-algorithm</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-server-side-encryption-customer-key</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-server-side-encryption-customer-key-MD5</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
        /// Encryption (Using Customer-Provided Encryption Keys)</a> in the <i>Amazon S3 User
        /// Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod
        {
            get { return this._serverSideEncryptionCustomerMethod; }
            set { this._serverSideEncryptionCustomerMethod = value; }
        }

        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this._serverSideEncryptionCustomerMethod != null && this._serverSideEncryptionCustomerMethod != Amazon.S3.ServerSideEncryptionCustomerMethod.None;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerProvidedKey. 
        /// <para>
        /// Specifies the customer-provided encryption key that you originally provided for Amazon
        /// S3 to encrypt the data before storing it. This value is used to decrypt the object
        /// when recovering it and must match the one used when storing the data. The key must
        /// be appropriate for use with the algorithm specified in the <c>x-amz-server-side-encryption-customer-algorithm</c>
        /// header.
        /// </para>
        ///  
        /// <para>
        /// If you encrypt an object by using server-side encryption with customer-provided encryption
        /// keys (SSE-C) when you store the object in Amazon S3, then when you GET the object,
        /// you must use the following headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-server-side-encryption-customer-algorithm</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-server-side-encryption-customer-key</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-server-side-encryption-customer-key-MD5</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
        /// Encryption (Using Customer-Provided Encryption Keys)</a> in the <i>Amazon S3 User
        /// Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionCustomerProvidedKey
        {
            get { return this._serverSideEncryptionCustomerProvidedKey; }
            set { this._serverSideEncryptionCustomerProvidedKey = value; }
        }

        // Check to see if ServerSideEncryptionCustomerProvidedKey property is set
        internal bool IsSetServerSideEncryptionCustomerProvidedKey()
        {
            return !System.String.IsNullOrEmpty(this._serverSideEncryptionCustomerProvidedKey);
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerProvidedKeyMD5. 
        /// <para>
        /// Specifies the 128-bit MD5 digest of the customer-provided encryption key according
        /// to RFC 1321. Amazon S3 uses this header for a message integrity check to ensure that
        /// the encryption key was transmitted without error.
        /// </para>
        ///  
        /// <para>
        /// If you encrypt an object by using server-side encryption with customer-provided encryption
        /// keys (SSE-C) when you store the object in Amazon S3, then when you GET the object,
        /// you must use the following headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-server-side-encryption-customer-algorithm</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-server-side-encryption-customer-key</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-server-side-encryption-customer-key-MD5</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
        /// Encryption (Using Customer-Provided Encryption Keys)</a> in the <i>Amazon S3 User
        /// Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string ServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this._serverSideEncryptionCustomerProvidedKeyMD5; }
            set { this._serverSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        // Check to see if ServerSideEncryptionCustomerProvidedKeyMD5 property is set
        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
        {
             return !System.String.IsNullOrEmpty(this._serverSideEncryptionCustomerProvidedKeyMD5);
        }

        /// <summary>
        /// Gets and sets the property UnmodifiedSinceDate. 
        /// <para>
        /// Return the object only if it has not been modified since the specified time; otherwise,
        /// return a <c>412 Precondition Failed</c> error.
        /// </para>
        ///  
        /// <para>
        /// If both of the <c>If-Match</c> and <c>If-Unmodified-Since</c> headers are present
        /// in the request as follows: <c>If-Match</c> condition evaluates to <c>true</c>, and;
        /// <c>If-Unmodified-Since</c> condition evaluates to <c>false</c>; then, S3 returns <c>200
        /// OK</c> and the data requested. 
        /// </para>
        ///  
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        /// </summary>
        public DateTime? UnmodifiedSinceDate
        {
            get { return this._unmodifiedSinceDate ?? DateTime.SpecifyKind(default, DateTimeKind.Utc); }
            set { this._unmodifiedSinceDate = value; }
        }

        // Check to see if UnmodifiedSinceDate property is set
        internal bool IsSetUnmodifiedSinceDate()
        {
            return this._unmodifiedSinceDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID used to reference a specific version of the object.
        /// </para>
        ///  
        /// <para>
        /// By default, the <c>GetObject</c> operation returns the current version of an object.
        /// To return a different version, use the <c>versionId</c> subresource.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// If you include a <c>versionId</c> in your request header, you must have the <c>s3:GetObjectVersion</c>
        /// permission to access a specific version of an object. The <c>s3:GetObject</c> permission
        /// is not required in this scenario.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you request the current version of an object without a specific <c>versionId</c>
        /// in the request header, only the <c>s3:GetObject</c> permission is required. The <c>s3:GetObjectVersion</c>
        /// permission is not required in this scenario.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Directory buckets</b> - S3 Versioning isn't enabled and supported for directory
        /// buckets. For this API operation, only the <c>null</c> value of the version ID is supported
        /// by directory buckets. You can only specify <c>null</c> to the <c>versionId</c> query
        /// parameter in the request.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// For more information about versioning, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketVersioning.html">PutBucketVersioning</a>.
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

        #region Flexible checksum properties
        
        /// <inheritdoc/>
        protected override CoreChecksumResponseBehavior CoreChecksumMode
        {
            get
            {
                if (IsSetChecksumMode())
                {
                    return (CoreChecksumResponseBehavior)Enum.Parse(typeof(CoreChecksumResponseBehavior), this.ChecksumMode);
                }

                return CoreChecksumResponseBehavior.DISABLED;
            }
            set { this.ChecksumMode = value.ToString(); }
        }

        private static readonly List<CoreChecksumAlgorithm> _supportedChecksumAlgorithms = new List<CoreChecksumAlgorithm>
        {
            CoreChecksumAlgorithm.CRC64NVME, CoreChecksumAlgorithm.CRC32, CoreChecksumAlgorithm.CRC32C, CoreChecksumAlgorithm.SHA256, CoreChecksumAlgorithm.SHA1
        };

        /// <inheritdoc/>
        protected override System.Collections.ObjectModel.ReadOnlyCollection<CoreChecksumAlgorithm> ChecksumResponseAlgorithms => _supportedChecksumAlgorithms.AsReadOnly();

        #endregion
    }
}