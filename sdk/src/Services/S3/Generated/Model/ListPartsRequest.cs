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
    /// Container for the parameters to the ListParts operation.
    /// <important> 
    /// <para>
    /// End of support notice: Beginning October 1, 2025, Amazon S3 will stop returning <c>DisplayName</c>.
    /// Update your applications to use canonical IDs (unique identifier for Amazon Web Services
    /// accounts), Amazon Web Services account ID (12 digit identifier) or IAM ARNs (full
    /// resource naming) as a direct replacement of <c>DisplayName</c>. 
    /// </para>
    ///  
    /// <para>
    /// This change affects the following Amazon Web Services Regions: US East (N. Virginia)
    /// Region, US West (N. California) Region, US West (Oregon) Region, Asia Pacific (Singapore)
    /// Region, Asia Pacific (Sydney) Region, Asia Pacific (Tokyo) Region, Europe (Ireland)
    /// Region, and South America (São Paulo) Region.
    /// </para>
    ///  </important> 
    /// <para>
    /// Lists the parts that have been uploaded for a specific multipart upload.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must provide the <c>upload ID</c> in the request. You obtain
    /// this uploadID by sending the initiate multipart upload request through <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateMultipartUpload.html">CreateMultipartUpload</a>.
    /// </para>
    ///  
    /// <para>
    /// The <c>ListParts</c> request returns a maximum of 1,000 uploaded parts. The limit
    /// of 1,000 parts is also the default value. You can restrict the number of parts in
    /// a response by specifying the <c>max-parts</c> request parameter. If your multipart
    /// upload consists of more than 1,000 parts, the response returns an <c>IsTruncated</c>
    /// field with the value of <c>true</c>, and a <c>NextPartNumberMarker</c> element. To
    /// list remaining uploaded parts, in subsequent <c>ListParts</c> requests, include the
    /// <c>part-number-marker</c> query string parameter and set its value to the <c>NextPartNumberMarker</c>
    /// field value from the previous response.
    /// </para>
    ///  
    /// <para>
    /// For more information on multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
    /// Objects Using Multipart Upload</a> in the <i>Amazon S3 User Guide</i>.
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
    ///  <b>General purpose bucket permissions</b> - For information about permissions required
    /// to use the multipart upload API, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
    /// Upload and Permissions</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If the upload was created using server-side encryption with Key Management Service
    /// (KMS) keys (SSE-KMS) or dual-layer server-side encryption with Amazon Web Services
    /// KMS keys (DSSE-KMS), you must have permission to the <c>kms:Decrypt</c> action for
    /// the <c>ListParts</c> request to succeed.
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
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>ListParts</c>:
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
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectAttributes.html">GetObjectAttributes</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListMultipartUploads.html">ListMultipartUploads</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListPartsRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private string _expectedBucketOwner;
        private string _key;
        private int? _maxParts;
        private string _partNumberMarker;
        private RequestPayer _requestPayer;
        private string _sseCustomerAlgorithm;
        private string _sseCustomerKey;
        private string _sseCustomerKeyMD5;
        private string _uploadId;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket to which the parts are being uploaded. 
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
        /// Object key for which the multipart upload was initiated.
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
        /// Sets the maximum number of parts to return.
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
        /// Gets and sets the property PartNumberMarker. 
        /// <para>
        /// Specifies the part after which listing should begin. Only parts with higher part numbers
        /// will be listed.
        /// </para>
        /// </summary>
        public string PartNumberMarker
        {
            get { return this._partNumberMarker; }
            set { this._partNumberMarker = value; }
        }

        // Check to see if PartNumberMarker property is set
        internal bool IsSetPartNumberMarker()
        {
            return this._partNumberMarker != null;
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
        /// The server-side encryption (SSE) algorithm used to encrypt the object. This parameter
        /// is needed only when the object was created using a checksum algorithm. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Protecting
        /// data using SSE-C keys</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The server-side encryption (SSE) customer managed key. This parameter is needed only
        /// when the object was created using a checksum algorithm. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Protecting
        /// data using SSE-C keys</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The MD5 server-side encryption (SSE) customer managed key. This parameter is needed
        /// only when the object was created using a checksum algorithm. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Protecting
        /// data using SSE-C keys</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property UploadId. 
        /// <para>
        /// Upload ID identifying the multipart upload whose parts are being listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

    }
}