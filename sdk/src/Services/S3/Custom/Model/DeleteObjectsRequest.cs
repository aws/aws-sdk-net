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
    /// Container for the parameters to the DeleteObjects operation.
    /// This operation enables you to delete multiple objects from a bucket using a single
    /// HTTP request. If you know the object keys that you want to delete, then this operation
    /// provides a suitable alternative to sending individual delete requests, reducing per-request
    /// overhead.
    /// 
    ///  
    /// <para>
    /// The request can contain a list of up to 1,000 keys that you want to delete. In the
    /// XML, you provide the object key names, and optionally, version IDs if you want to
    /// delete a specific version of the object from a versioning-enabled bucket. For each
    /// key, Amazon S3 performs a delete operation and returns the result of that delete,
    /// success or failure, in the response. If the object specified in the request
    /// isn't found, Amazon S3 confirms the deletion by returning the result as deleted.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - S3 Versioning isn't enabled and supported for directory
    /// buckets.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, you must make requests for this
    /// API operation to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <c>https://<i>bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// The operation supports two modes for the response: verbose and quiet. By default,
    /// the operation uses verbose mode in which the response includes the result of deletion
    /// of each key in your request. In quiet mode the response includes only keys where the
    /// delete operation encountered an error. For a successful deletion in a quiet mode,
    /// the operation does not return any information about the delete in the response body.
    /// </para>
    ///  
    /// <para>
    /// When performing this action on an MFA Delete enabled bucket, that attempts to delete
    /// any versioned objects, you must include an MFA token. If you do not provide one, the
    /// entire request will fail, even if there are non-versioned objects you are trying to
    /// delete. If you provide an invalid token, whether there are versioned keys in the request
    /// or not, the entire Multi-Object Delete request will fail. For information about MFA
    /// Delete, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/Versioning.html#MultiFactorAuthenticationDelete">MFA
    /// Delete</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - MFA delete is not supported by directory buckets.
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - The following permissions are required
    /// in your policies when your <c>DeleteObjects</c> request includes specific headers.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b> <c>s3:DeleteObject</c> </b> - To delete an object from a bucket, you must always
    /// specify the <c>s3:DeleteObject</c> permission.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <c>s3:DeleteObjectVersion</c> </b> - To delete a specific version of an object
    /// from a versiong-enabled bucket, you must specify the <c>s3:DeleteObjectVersion</c>
    /// permission.
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
    ///  </li> </ul> </dd> <dt>Content-MD5 request header</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket</b> - The Content-MD5 request header is required for all
    /// Multi-Object Delete requests. Amazon S3 uses the header value to ensure that your
    /// request body has not been altered in transit.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket</b> - The Content-MD5 request header or a additional checksum
    /// request header (including <c>x-amz-checksum-crc32</c>, <c>x-amz-checksum-crc32c</c>,
    /// <c>x-amz-checksum-sha1</c>, or <c>x-amz-checksum-sha256</c>) is required for all Multi-Object
    /// Delete requests.
    /// </para>
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>DeleteObjects</c>:
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
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListParts.html">ListParts</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_AbortMultipartUpload.html">AbortMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteObjectsRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private bool? bypassGovernanceRetention;
        private ChecksumAlgorithm _checksumAlgorithm;
        private List<KeyVersion> objects = AWSConfigs.InitializeCollections ? new List<KeyVersion>() : null;
        private bool? quiet;
        private MfaCodes mfaCodes;
        private RequestPayer requestPayer;
        private string expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name containing the objects to delete. 
        /// </para> 
        /// <para> 
        /// <b>Directory buckets</b> - When you use this operation with a directory bucket, you must use virtual-hosted-style requests 
        /// in the format <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>. Path-style requests are 
        /// not supported. Directory bucket names must be unique in the chosen Zone (Availability Zone or Local Zone). Bucket names must 
        /// follow the format <c> <i>bucket-base-name</i>--<i>zone-id</i>--x-s3</c> (for example, <c> <i>amzn-s3-demo-bucket</i>--<i>usw2-az1</i>--x-s3</c>). For 
        /// information about bucket naming restrictions, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory bucket naming rules</a> in 
        /// the <i>Amazon S3 User Guide</i>.</para> <para> <b>Access points</b> - When you use this action with an access point for general 
        /// purpose buckets, you must provide the alias of the access point in place of the bucket name or specify the access point ARN. When 
        /// you use this action with an access point for directory buckets, you must provide the access point name in place of the bucket 
        /// name. When using the access point ARN, you must direct requests to the access point hostname. The access point hostname takes the 
        /// form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this action with an access point 
        /// through the Amazon Web Services SDKs, you provide the access point ARN in place of the bucket name. For more information about access 
        /// point ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <note> 
        /// <para>
        /// Object Lambda access points are not supported by directory buckets.
        /// </para> 
        /// </note> 
        /// <para> 
        /// <b>S3 on Outposts</b> - When you use this action with S3 on Outposts, you must direct requests to the S3 on Outposts hostname. The S3 on 
        /// Outposts hostname takes the form <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>. When 
        /// you use this action with S3 on Outposts, the destination bucket must be the Outposts access point ARN or the access point alias. For more 
        /// information about S3 on Outposts, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What is S3 on Outposts?</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property BypassGovernanceRetention. 
        /// <para>
        /// Specifies whether you want to delete this object even if it has a Governance-type
        /// Object Lock in place. To use this header, you must have the <c>s3:BypassGovernanceRetention</c>
        /// permission.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? BypassGovernanceRetention
        {
            get { return this.bypassGovernanceRetention; }
            set { this.bypassGovernanceRetention = value; }
        }

        // Check to see if BypassGovernanceRetention property is set
        internal bool IsSetBypassGovernanceRetention()
        {
            return this.bypassGovernanceRetention.HasValue;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <c>x-amz-checksum-<i>algorithm</i>
        /// </c> or <c>x-amz-trailer</c> header sent. Otherwise, Amazon S3 fails the
        /// request with the HTTP status code <c>400 Bad Request</c>.
        /// </para>
        ///  
        /// <para>
        /// For the <c>x-amz-checksum-<i>algorithm</i> </c> header, replace <c> <i>algorithm</i>
        /// </c> with the supported algorithm from the following list: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CRC-32
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CRC-32C
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CRC-64NVME
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SHA-1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SHA-256
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the individual checksum value you provide through <c>x-amz-checksum-<i>algorithm</i>
        /// </c> doesn't match the checksum algorithm you set through <c>x-amz-sdk-checksum-algorithm</c>,
        /// Amazon S3 fails the request with a <c>BadDigest</c> error.
        /// </para>
        ///  
        /// <para>
        /// If you provide an individual checksum, Amazon S3 ignores any provided <c>ChecksumAlgorithm</c>
        /// parameter.
        /// </para>
        /// </summary>
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
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
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }

        /// <summary>
        /// Gets and sets the property Objects.
        /// </summary>
        public List<KeyVersion> Objects
        {
            get { return this.objects; }
            set { this.objects = value; }
        }

        // Check to see if Objects property is set
        internal bool IsSetObjects()
        {
            return this.objects != null && (this.objects.Count > 0 || !AWSConfigs.InitializeCollections);
        }
        /// <summary>
        /// Gets and sets the property MFA. 
        /// <para>
        /// The concatenation of the authentication device's serial number, a space, and the value
        /// that is displayed on your authentication device. Required to permanently delete a
        /// versioned object if versioning is configured with MFA delete enabled.
        /// </para>
        ///  
        /// <para>
        /// When performing the <c>DeleteObjects</c> operation on an MFA delete enabled
        /// bucket, which attempts to delete the specified versioned objects, you must include
        /// an MFA token. If you don't provide an MFA token, the entire request will fail, even
        /// if there are non-versioned objects that you are trying to delete. If you provide an
        /// invalid token, whether there are versioned object keys in the request or not, the
        /// entire Multi-Object Delete request will fail. For information about MFA Delete, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/Versioning.html#MultiFactorAuthenticationDelete">
        /// MFA Delete</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        /// <remarks>
        /// This is a required property for this request if:<br />
        /// 1. EnableMfaDelete was configured on the bucket
        /// containing this object's version.<br />
        /// 2. You are deleting an object's version
        /// </remarks>
        public MfaCodes MfaCodes
        {
            get { return this.mfaCodes; }
            set { this.mfaCodes = value; }
        }

        /// <summary>
        /// Checks if the MfaCodes property is set.
        /// </summary>
        /// <returns>true if the MfaCodes property is set.</returns>
        internal bool IsSetMfaCodes()
        {
            return (this.mfaCodes != null) &&
                   (!System.String.IsNullOrEmpty(MfaCodes.SerialNumber)) &&
                   (!System.String.IsNullOrEmpty(MfaCodes.AuthenticationValue));
        }


        /// <summary>
        /// Gets and sets the property RequestPayer.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this.requestPayer; }
            set { this.requestPayer = value; }
        }

        // Check to see if RequestPayer property is set
        internal bool IsSetRequestPayer()
        {
            return this.requestPayer != null;
        }
        /// <summary>
        /// Gets and sets the property Quiet.
        /// </summary>
        public bool? Quiet
        {
            get { return this.quiet; }
            set { this.quiet = value; }
        }

        // Check to see if Quiet property is set
        internal bool IsSetQuiet()
        {
            return this.quiet.HasValue;
        }

    }
}

