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
    /// Container for the parameters to the GetObjectMetadata operation.
    /// The <c>HEAD</c> operation retrieves metadata from an object without returning the
    /// object itself. This operation is useful if you're interested only in an object's metadata.
    /// 
    ///  <note> 
    /// <para>
    /// A <c>HEAD</c> request has the same options as a <c>GET</c> operation on an object.
    /// The response is identical to the <c>GET</c> response except that there is no response
    /// body. Because of this, if the <c>HEAD</c> request generates an error, it returns a
    /// generic code, such as <c>400 Bad Request</c>, <c>403 Forbidden</c>, <c>404 Not Found</c>,
    /// <c>405 Method Not Allowed</c>, <c>412 Precondition Failed</c>, or <c>304 Not Modified</c>.
    /// It's not possible to retrieve the exact exception of these error codes.
    /// </para>
    ///  </note> 
    /// <para>
    /// Request headers are limited to 8 KB in size. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTCommonRequestHeaders.html">Common
    /// Request Headers</a>.
    /// </para>
    ///  <dl> <dt>Permissions</dt> <dd>  <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - To use <c>HEAD</c>, you must have the
    /// <c>s3:GetObject</c> permission. You need the relevant read object (or version) permission
    /// for this operation. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/list_amazons3.html">Actions,
    /// resources, and condition keys for Amazon S3</a> in the <i>Amazon S3 User Guide</i>.
    /// For more information about the permissions to S3 API operations by S3 resource types,
    /// see <a href="/AmazonS3/latest/userguide/using-with-s3-policy-actions.html">Required
    /// permissions for Amazon S3 API operations</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If the object you request doesn't exist, the error that Amazon S3 returns depends
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
    /// code <c>403 Forbidden</c> error.
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
    /// If you enable <c>x-amz-checksum-mode</c> in the request and the object is encrypted
    /// with Amazon Web Services Key Management Service (Amazon Web Services KMS), you must
    /// also have the <c>kms:GenerateDataKey</c> and <c>kms:Decrypt</c> permissions in IAM
    /// identity-based policies and KMS key policies for the KMS key to retrieve the checksum
    /// of the object.
    /// </para>
    ///  </li> </ul> </dd> <dt>Encryption</dt> <dd> <note> 
    /// <para>
    /// Encryption request headers, like <c>x-amz-server-side-encryption</c>, should not be
    /// sent for <c>HEAD</c> requests if your object uses server-side encryption with Key
    /// Management Service (KMS) keys (SSE-KMS), dual-layer server-side encryption with Amazon
    /// Web Services KMS keys (DSSE-KMS), or server-side encryption with Amazon S3 managed
    /// encryption keys (SSE-S3). The <c>x-amz-server-side-encryption</c> header is used when
    /// you <c>PUT</c> an object to S3 and want to specify the encryption method. If you include
    /// this header in a <c>HEAD</c> request for an object that uses these types of keys,
    /// you’ll get an HTTP <c>400 Bad Request</c> error. It's because the encryption method
    /// can't be changed when you retrieve the object.
    /// </para>
    ///  </note> 
    /// <para>
    /// If you encrypt an object by using server-side encryption with customer-provided encryption
    /// keys (SSE-C) when you store the object in Amazon S3, then when you retrieve the metadata
    /// from the object, you must use the following headers to provide the encryption key
    /// for the server to be able to retrieve the object's metadata. The headers are: 
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
    ///  <b>Directory bucket </b> - For directory buckets, there are only two supported options
    /// for server-side encryption: SSE-S3 and SSE-KMS. SSE-C isn't supported. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-serv-side-encryption.html">Protecting
    /// data with server-side encryption</a> in the <i>Amazon S3 User Guide</i>. 
    /// </para>
    ///  </note> </dd> <dt>Versioning</dt> <dd> <ul> <li> 
    /// <para>
    /// If the current version of the object is a delete marker, Amazon S3 behaves as if the
    /// object was deleted and includes <c>x-amz-delete-marker: true</c> in the response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the specified version is a delete marker, the response returns a <c>405 Method
    /// Not Allowed</c> error and the <c>Last-Modified: timestamp</c> response header.
    /// </para>
    ///  </li> </ul> <note> <ul> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - Delete marker is not supported for directory buckets.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - S3 Versioning isn't enabled and supported for directory
    /// buckets. For this API operation, only the <c>null</c> value of the version ID is supported
    /// by directory buckets. You can only specify <c>null</c> to the <c>versionId</c> query
    /// parameter in the request.
    /// </para>
    ///  </li> </ul> </note> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>.
    /// </para>
    ///  <note> 
    /// <para>
    /// For directory buckets, you must make requests for this API operation to the Zonal
    /// endpoint. These endpoints support virtual-hosted-style requests in the format <c>https://<i>amzn-s3-demo-bucket</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information about endpoints
    /// in Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/endpoint-directory-buckets-AZ.html">Regional
    /// and Zonal endpoints for directory buckets in Availability Zones</a> in the <i>Amazon
    /// S3 User Guide</i>. For more information about endpoints in Local Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-lzs-for-directory-buckets.html">Concepts
    /// for directory buckets in Local Zones</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> </dd> </dl> 
    /// <para>
    /// The following actions are related to <c>HeadObject</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectAttributes.html">GetObjectAttributes</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetObjectMetadataRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private ChecksumMode _checksumMode;
        private string _etagToMatch;
        private string _etagToNotMatch;
        private string _expectedBucketOwner;
        private string _key;
        private int? _partNumber;
        private string _range;
        private RequestPayer _requestPayer;
        private string _responseCacheControl;
        private string _responseContentDisposition;
        private string _responseContentEncoding;
        private string _responseContentLanguage;
        private string _responseContentType;
        private DateTime? _responseExpires;
        private ServerSideEncryptionCustomerMethod _serverSideEncryptionCustomerMethod;
        private string _serverSideEncryptionCustomerProvidedKey;
        private string _serverSideEncryptionCustomerProvidedKeyMD5;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket that contains the object.
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
        /// Gets and sets the property ChecksumMode. 
        /// <para>
        /// To retrieve the checksum, this parameter must be enabled.
        /// </para>
        ///  
        /// <para>
        ///  <b>General purpose buckets</b> - If you enable checksum mode and the object is uploaded
        /// with a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_Checksum.html">checksum</a>
        /// and encrypted with an Key Management Service (KMS) key, you must have permission to
        /// use the <c>kms:Decrypt</c> action to retrieve the checksum.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets</b> - If you enable <c>ChecksumMode</c> and the object is encrypted
        /// with Amazon Web Services Key Management Service (Amazon Web Services KMS), you must
        /// also have the <c>kms:GenerateDataKey</c> and <c>kms:Decrypt</c> permissions in IAM
        /// identity-based policies and KMS key policies for the KMS key to retrieve the checksum
        /// of the object.
        /// </para>
        /// </summary>
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
        /// Return the object only if its entity tag (ETag) is the same as the one specified;
        /// otherwise, return a 412 (precondition failed) error.
        /// </para>
        ///  
        /// <para>
        /// If both of the <c>If-Match</c> and <c>If-Unmodified-Since</c> headers are present
        /// in the request as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>If-Match</c> condition evaluates to <c>true</c>, and;
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>If-Unmodified-Since</c> condition evaluates to <c>false</c>;
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Then Amazon S3 returns <c>200 OK</c> and the data requested.
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
        /// Return the object only if its entity tag (ETag) is different from the one specified;
        /// otherwise, return a 304 (not modified) error.
        /// </para>
        ///  
        /// <para>
        /// If both of the <c>If-None-Match</c> and <c>If-Modified-Since</c> headers are present
        /// in the request as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>If-None-Match</c> condition evaluates to <c>false</c>, and;
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>If-Modified-Since</c> condition evaluates to <c>true</c>;
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Then Amazon S3 returns the <c>304 Not Modified</c> response code.
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
        /// Gets and sets the property PartNumber. 
        /// <para>
        /// Part number of the object being read. This is a positive integer between 1 and 10,000.
        /// Effectively performs a 'ranged' HEAD request for the part specified. Useful querying
        /// about the size of the part and the number of parts in this object.
        /// </para>
        /// </summary>
        public int? PartNumber
        {
            get { return this._partNumber; }
            set { this._partNumber = value; }
        }

        // Check to see if PartNumber property is set
        internal bool IsSetPartNumber()
        {
            return this._partNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// HeadObject returns only the metadata for an object. If the Range is satisfiable, only
        /// the <c>ContentLength</c> is affected in the response. If the Range is not satisfiable,
        /// S3 returns a <c>416 - Requested Range Not Satisfiable</c> error.
        /// </para>
        /// </summary>
        public string Range
        {
            get { return this._range; }
            set { this._range = value; }
        }

        // Check to see if Range property is set
        internal bool IsSetRange()
        {
            return this._range != null;
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
        /// Gets and sets the property ResponseCacheControl. 
        /// <para>
        /// Sets the <c>Cache-Control</c> header of the response.
        /// </para>
        /// </summary>
        public string ResponseCacheControl
        {
            get { return this._responseCacheControl; }
            set { this._responseCacheControl = value; }
        }

        // Check to see if ResponseCacheControl property is set
        internal bool IsSetResponseCacheControl()
        {
            return this._responseCacheControl != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseContentDisposition. 
        /// <para>
        /// Sets the <c>Content-Disposition</c> header of the response.
        /// </para>
        /// </summary>
        public string ResponseContentDisposition
        {
            get { return this._responseContentDisposition; }
            set { this._responseContentDisposition = value; }
        }

        // Check to see if ResponseContentDisposition property is set
        internal bool IsSetResponseContentDisposition()
        {
            return this._responseContentDisposition != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseContentEncoding. 
        /// <para>
        /// Sets the <c>Content-Encoding</c> header of the response.
        /// </para>
        /// </summary>
        public string ResponseContentEncoding
        {
            get { return this._responseContentEncoding; }
            set { this._responseContentEncoding = value; }
        }

        // Check to see if ResponseContentEncoding property is set
        internal bool IsSetResponseContentEncoding()
        {
            return this._responseContentEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseContentLanguage. 
        /// <para>
        /// Sets the <c>Content-Language</c> header of the response.
        /// </para>
        /// </summary>
        public string ResponseContentLanguage
        {
            get { return this._responseContentLanguage; }
            set { this._responseContentLanguage = value; }
        }

        // Check to see if ResponseContentLanguage property is set
        internal bool IsSetResponseContentLanguage()
        {
            return this._responseContentLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseContentType. 
        /// <para>
        /// Sets the <c>Content-Type</c> header of the response.
        /// </para>
        /// </summary>
        public string ResponseContentType
        {
            get { return this._responseContentType; }
            set { this._responseContentType = value; }
        }

        // Check to see if ResponseContentType property is set
        internal bool IsSetResponseContentType()
        {
            return this._responseContentType != null;
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
        /// Specifies the algorithm to use when encrypting the object (for example, AES256).
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
            return this._serverSideEncryptionCustomerMethod != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerProvidedKey. 
        /// <para>
        /// Specifies the customer-provided encryption key for Amazon S3 to use in encrypting
        /// data. This value is used to store the object and then it is discarded; Amazon S3 does
        /// not store the encryption key. The key must be appropriate for use with the algorithm
        /// specified in the <c>x-amz-server-side-encryption-customer-algorithm</c> header.
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
            return this._serverSideEncryptionCustomerProvidedKey != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerProvidedKeyMD5. 
        /// <para>
        /// Specifies the 128-bit MD5 digest of the encryption key according to RFC 1321. Amazon
        /// S3 uses this header for a message integrity check to ensure that the encryption key
        /// was transmitted without error.
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
            return this._serverSideEncryptionCustomerProvidedKeyMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID used to reference a specific version of the object.
        /// </para>
        ///  <note> 
        /// <para>
        /// For directory buckets in this API operation, only the <c>null</c> value of the version
        /// ID is supported.
        /// </para>
        ///  </note>
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