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
    /// Container for the parameters to the GetObjectAttributes operation.
    /// Retrieves all of the metadata from an object without returning the object itself.
    /// This operation is useful if you're interested only in an object's metadata. 
    /// 
    ///  
    /// <para>
    ///  <c>GetObjectAttributes</c> combines the functionality of <c>HeadObject</c> and <c>ListParts</c>.
    /// All of the data returned with both of those individual calls can be returned with
    /// a single call to <c>GetObjectAttributes</c>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, you must make requests for this
    /// API operation to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <c>https://<i>amzn-s3-demo-bucket</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information about endpoints
    /// in Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/endpoint-directory-buckets-AZ.html">Regional
    /// and Zonal endpoints for directory buckets in Availability Zones</a> in the <i>Amazon
    /// S3 User Guide</i>. For more information about endpoints in Local Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-lzs-for-directory-buckets.html">Concepts
    /// for directory buckets in Local Zones</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - To use <c>GetObjectAttributes</c>, you
    /// must have READ access to the object.
    /// </para>
    ///  
    /// <para>
    /// The other permissions that you need to use this operation depend on whether the bucket
    /// is versioned and if a version ID is passed in the <c>GetObjectAttributes</c> request.
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you pass a version ID in your request, you need both the <c>s3:GetObjectVersion</c>
    /// and <c>s3:GetObjectVersionAttributes</c> permissions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you do not pass a version ID in your request, you need the <c>s3:GetObject</c>
    /// and <c>s3:GetObjectAttributes</c> permissions. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
    /// Permissions in a Policy</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If the object that you request does not exist, the error Amazon S3 returns depends
    /// on whether you also have the <c>s3:ListBucket</c> permission.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you have the <c>s3:ListBucket</c> permission on the bucket, Amazon S3 returns an
    /// HTTP status code <c>404 Not Found</c> ("no such key") error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you don't have the <c>s3:ListBucket</c> permission, Amazon S3 returns an HTTP status
    /// code <c>403 Forbidden</c> ("access denied") error.
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
    /// If the object is encrypted with SSE-KMS, you must also have the <c>kms:GenerateDataKey</c>
    /// and <c>kms:Decrypt</c> permissions in IAM identity-based policies and KMS key policies
    /// for the KMS key.
    /// </para>
    ///  </li> </ul> </dd> <dt>Encryption</dt> <dd> <note> 
    /// <para>
    /// Encryption request headers, like <c>x-amz-server-side-encryption</c>, should not be
    /// sent for <c>HEAD</c> requests if your object uses server-side encryption with Key
    /// Management Service (KMS) keys (SSE-KMS), dual-layer server-side encryption with Amazon
    /// Web Services KMS keys (DSSE-KMS), or server-side encryption with Amazon S3 managed
    /// encryption keys (SSE-S3). The <c>x-amz-server-side-encryption</c> header is used when
    /// you <c>PUT</c> an object to S3 and want to specify the encryption method. If you include
    /// this header in a <c>GET</c> request for an object that uses these types of keys, you’ll
    /// get an HTTP <c>400 Bad Request</c> error. It's because the encryption method can't
    /// be changed when you retrieve the object.
    /// </para>
    ///  </note> 
    /// <para>
    /// If you encrypted an object when you stored the object in Amazon S3 by using server-side
    /// encryption with customer-provided encryption keys (SSE-C), then when you retrieve
    /// the metadata from the object, you must use the following headers. These headers provide
    /// the server with the encryption key required to retrieve the object's metadata. The
    /// headers are: 
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
    ///  <b>Directory bucket permissions</b> - For directory buckets, there are only two supported
    /// options for server-side encryption: server-side encryption with Amazon S3 managed
    /// keys (SSE-S3) (<c>AES256</c>) and server-side encryption with KMS keys (SSE-KMS) (<c>aws:kms</c>).
    /// We recommend that the bucket's default encryption uses the desired encryption configuration
    /// and you don't override the bucket default encryption in your <c>CreateSession</c>
    /// requests or <c>PUT</c> object requests. Then, new objects are automatically encrypted
    /// with the desired encryption settings. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-serv-side-encryption.html">Protecting
    /// data with server-side encryption</a> in the <i>Amazon S3 User Guide</i>. For more
    /// information about the encryption overriding behaviors in directory buckets, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-specifying-kms-encryption.html">Specifying
    /// server-side encryption with KMS for new object uploads</a>.
    /// </para>
    ///  </note> </dd> <dt>Versioning</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets</b> - S3 Versioning isn't enabled and supported for directory
    /// buckets. For this API operation, only the <c>null</c> value of the version ID is supported
    /// by directory buckets. You can only specify <c>null</c> to the <c>versionId</c> query
    /// parameter in the request.
    /// </para>
    ///  </dd> <dt>Conditional request headers</dt> <dd> 
    /// <para>
    /// Consider the following when using request headers:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If both of the <c>If-Match</c> and <c>If-Unmodified-Since</c> headers are present
    /// in the request as follows, then Amazon S3 returns the HTTP status code <c>200 OK</c>
    /// and the data requested:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>If-Match</c> condition evaluates to <c>true</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>If-Unmodified-Since</c> condition evaluates to <c>false</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
    /// 7232</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If both of the <c>If-None-Match</c> and <c>If-Modified-Since</c> headers are present
    /// in the request as follows, then Amazon S3 returns the HTTP status code <c>304 Not
    /// Modified</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>If-None-Match</c> condition evaluates to <c>false</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>If-Modified-Since</c> condition evaluates to <c>true</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
    /// 7232</a>.
    /// </para>
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following actions are related to <c>GetObjectAttributes</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectAcl.html">GetObjectAcl</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectLegalHold.html">GetObjectLegalHold</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectLockConfiguration.html">GetObjectLockConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectRetention.html">GetObjectRetention</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectTagging.html">GetObjectTagging</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_HeadObject.html">HeadObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListParts.html">ListParts</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetObjectAttributesRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private string _expectedBucketOwner;
        private string _key;
        private int? _maxParts;
        private List<ObjectAttributes> _objectAttributes = AWSConfigs.InitializeCollections ? new List<ObjectAttributes>() : null;
        private int? _partNumberMarker;
        private RequestPayer _requestPayer;
        private string _sseCustomerAlgorithm;
        private string _sseCustomerKey;
        private string _sseCustomerKeyMD5;
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
        /// Gets and sets the property MaxParts. 
        /// <para>
        /// Sets the maximum number of parts to return. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/mpuoverview.html">Uploading
        /// and copying objects using multipart upload in Amazon S3 </a> in the <i>Amazon Simple
        /// Storage Service user guide</i>.
        /// </para>
        /// </summary>
        public int? MaxParts
        {
            get { return this._maxParts; }
            set { this._maxParts = value; }
        }

        // Check to see if MaxParts property is set
        internal bool IsSetMaxParts()
        {
            return this._maxParts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectAttributes. 
        /// <para>
        /// Specifies the fields at the root level that you want returned in the response. Fields
        /// that you do not specify are not returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ObjectAttributes> ObjectAttributes
        {
            get { return this._objectAttributes; }
            set { this._objectAttributes = value; }
        }

        // Check to see if ObjectAttributes property is set
        internal bool IsSetObjectAttributes()
        {
            return this._objectAttributes != null && (this._objectAttributes.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// Gets and sets the property PartNumberMarker. 
        /// <para>
        /// Specifies the part after which listing should begin. Only parts with higher part numbers
        /// will be listed. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/mpuoverview.html">Uploading
        /// and copying objects using multipart upload in Amazon S3 </a> in the <i>Amazon Simple
        /// Storage Service user guide</i>.
        /// </para>
        /// </summary>
        public int? PartNumberMarker
        {
            get { return this._partNumberMarker; }
            set { this._partNumberMarker = value; }
        }

        // Check to see if PartNumberMarker property is set
        internal bool IsSetPartNumberMarker()
        {
            return this._partNumberMarker.HasValue; 
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
        /// Gets and sets the property SSECustomerAlgorithm. 
        /// <para>
        /// Specifies the algorithm to use when encrypting the object (for example, AES256).
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version ID used to reference a specific version of the object.
        /// </para>
        ///  <note> 
        /// <para>
        /// S3 Versioning isn't enabled and supported for directory buckets. For this API operation,
        /// only the <c>null</c> value of the version ID is supported by directory buckets. You
        /// can only specify <c>null</c> to the <c>versionId</c> query parameter in the request.
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