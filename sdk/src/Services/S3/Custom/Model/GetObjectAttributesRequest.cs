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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the GetObjectAttributes operation.
    /// Retrieves all the metadata from an object without returning the object iteself. This
    /// action is useful if you're only interested in an object's metadata. To use <code>GetObjectAttributes</code>,
    /// you must have READ access to the object.
    /// 
    ///  
    /// <para>
    ///  <code>GetObjectAttributes</code> combines the functionality of <code>GetObjectAcl</code>,
    /// <code>GetObjectLegelHold</code>, <code>GetObjectLockConfiguration</code>, <code>GetObjectRetention</code>,
    /// <code>GetObjectTagging</code>, <code>HeadObject</code>, and <code>ListParts</code>.
    /// All of the data returned with each of those individual calls can be returned with
    /// a single call to <code>GetObjectAttributes</code>.
    /// </para>
    ///  
    /// <para>
    /// If you encrypt an object by using server-side encryption with customer-provided encryption
    /// keys (SSE-C) when you store the object in Amazon S3, then when you retrieve the metadata
    /// from the object, you must use the following headers:
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
    ///  </li> </ul> 
    /// <para>
    /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
    /// Encryption (Using Customer-Provided Encryption Keys)</a>.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// Encryption request headers, like <code>x-amz-server-side-encryption</code>, should
    /// not be sent for GET requests if your object uses server-side encryption with CMKs
    /// stored in Amazon Web Services KMS (SSE-KMS) or server-side encryption with Amazon
    /// S3–managed encryption keys (SSE-S3). If your object does use these types of keys,
    /// you'll get an HTTP 400 BadRequest error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  The last modified property in this case is the creation date of the object.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// Consider the following when using request headers:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  Consideration 1 – If both of the <code>If-Match</code> and <code>If-Unmodified-Since</code>
    /// headers are present in the request as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>If-Match</code> condition evaluates to <code>true</code>, and;
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>If-Unmodified-Since</code> condition evaluates to <code>false</code>;
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Then Amazon S3 returns <code>200 OK</code> and the data requested.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Consideration 2 – If both of the <code>If-None-Match</code> and <code>If-Modified-Since</code>
    /// headers are present in the request as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>If-None-Match</code> condition evaluates to <code>false</code>, and;
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>If-Modified-Since</code> condition evaluates to <code>true</code>;
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Then Amazon S3 returns the <code>304 Not Modified</code> response code.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
    /// 7232</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// The permissions you need to use this operation depend on whether or not the bucket
    /// is versioned. If the bucket is versioned, you need both the <code>s3:GetObjectVersion</code>
    /// and <code>s3:GetObjectVersionAttributes</code> permissions for this operation. If
    /// the bucket is not versioned, you need the <code>s3:GetObject</code> and <code>s3:GetObjectAttributes</code>
    /// permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
    /// Permissions in a Policy</a>. If the object you request does not exist, the error Amazon
    /// S3 returns depends on whether you also have the <code>s3:ListBucket</code> permission.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you have the <code>s3:ListBucket</code> permission on the bucket, Amazon S3 returns
    /// an HTTP status code 404 ("no such key") error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you don't have the <code>s3:ListBucket</code> permission, Amazon S3 returns an
    /// HTTP status code 403 ("access denied") error.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The following actions are related to <code>GetObjectAttributes</code>:
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
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListParts">ListParts</a>
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
        private List<ObjectAttributes> _objectAttributes = new List<ObjectAttributes>();
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
        /// The account ID of the expected bucket owner. If the bucket is owned by a different
        /// account, the request will fail with an HTTP <code>403 (Access Denied)</code> error.
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
        [AWSProperty(Required = true, Min = 1)]
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
        /// Sets the maximum number of parts to return.
        /// </para>
        /// </summary>
        public int MaxParts
        {
            get { return this._maxParts.GetValueOrDefault(); }
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
        /// An XML header that specifies the fields at the root level that you want returned in
        /// the response. Fields that you do not specify will not be returned.
        /// </para>
        /// </summary>
        public List<ObjectAttributes> ObjectAttributes
        {
            get { return this._objectAttributes; }
            set { this._objectAttributes = value; }
        }

        // Check to see if ObjectAttributes property is set
        internal bool IsSetObjectAttributes()
        {
            return this._objectAttributes != null && this._objectAttributes.Count > 0;
        }

        /// <summary>
        /// Gets and sets the property PartNumberMarker. 
        /// <para>
        /// Specifies the part after which listing should begin. Only parts with higher part numbers
        /// will be listed.
        /// </para>
        /// </summary>
        public int PartNumberMarker
        {
            get { return this._partNumberMarker.GetValueOrDefault(); }
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
        /// Specifies the algorithm to use to when encrypting the object (for example, AES256).
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
        /// Specifies the customer-provided encryption key for Amazon S3 to use in encrypting
        /// data. This value is used to store the object and then it is discarded; Amazon S3 does
        /// not store the encryption key. The key must be appropriate for use with the algorithm
        /// specified in the <code>x-amz-server-side-encryption-customer-algorithm</code> header.
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
        /// Specifies the 128-bit MD5 digest of the encryption key according to RFC 1321. Amazon
        /// S3 uses this header for a message integrity check to ensure that the encryption key
        /// was transmitted without error.
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
        /// Gets and sets the property VersionId.
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