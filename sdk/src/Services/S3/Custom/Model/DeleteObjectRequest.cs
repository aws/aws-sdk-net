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
    /// Container for the parameters to the DeleteObject operation.
    /// Removes an object from a bucket. The behavior depends on the bucket's versioning state:
    /// 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If bucket versioning is not enabled, the operation permanently deletes the object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If bucket versioning is enabled, the operation inserts a delete marker, which becomes
    /// the current version of the object. To permanently delete an object in a versioned
    /// bucket, you must include the object’s <c>versionId</c> in the request. For more information
    /// about versioning-enabled buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/DeletingObjectVersions.html">Deleting
    /// object versions from a versioning-enabled bucket</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If bucket versioning is suspended, the operation removes the object that has a null
    /// <c>versionId</c>, if there is one, and inserts a delete marker that becomes the current
    /// version of the object. If there isn't an object with a null <c>versionId</c>, and
    /// all versions of the object have a <c>versionId</c>, Amazon S3 does not remove the
    /// object and only inserts a delete marker. To permanently delete an object that has
    /// a <c>versionId</c>, you must include the object’s <c>versionId</c> in the request.
    /// For more information about versioning-suspended buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/DeletingObjectsfromVersioningSuspendedBuckets.html">Deleting
    /// objects from versioning-suspended buckets</a>.
    /// </para>
    ///  </li> </ul> <note> <ul> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - S3 Versioning isn't enabled and supported for directory
    /// buckets. For this API operation, only the <c>null</c> value of the version ID is supported
    /// by directory buckets. You can only specify <c>null</c> to the <c>versionId</c> query
    /// parameter in the request.
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
    /// To remove a specific version, you must use the <c>versionId</c> query parameter. Using
    /// this query parameter permanently deletes the version. If the object deleted is a delete
    /// marker, Amazon S3 sets the response header <c>x-amz-delete-marker</c> to true. 
    /// </para>
    ///  
    /// <para>
    /// If the object you want to delete is in a bucket where the bucket versioning configuration
    /// is MFA Delete enabled, you must include the <c>x-amz-mfa</c> request header in the
    /// DELETE <c>versionId</c> request. Requests that include <c>x-amz-mfa</c> must use HTTPS.
    /// For more information about MFA Delete, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMFADelete.html">Using
    /// MFA Delete</a> in the <i>Amazon S3 User Guide</i>. To see sample requests that use
    /// versioning, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectDELETE.html#ExampleVersionObjectDelete">Sample
    /// Request</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - MFA delete is not supported by directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can delete objects by explicitly calling DELETE Object or calling (<a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketLifecycle.html">PutBucketLifecycle</a>)
    /// to enable Amazon S3 to remove them for you. If you want to block users or accounts
    /// from removing or deleting objects from your bucket, you must deny them the <c>s3:DeleteObject</c>,
    /// <c>s3:DeleteObjectVersion</c>, and <c>s3:PutLifeCycleConfiguration</c> actions. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - S3 Lifecycle is not supported by directory buckets.
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - The following permissions are required
    /// in your policies when your <c>DeleteObjects</c> request includes specific headers.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b> <c>s3:DeleteObject</c> </b> - To delete an object from a bucket, you must always
    /// have the <c>s3:DeleteObject</c> permission.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <c>s3:DeleteObjectVersion</c> </b> - To delete a specific version of an object
    /// from a versioning-enabled bucket, you must have the <c>s3:DeleteObjectVersion</c>
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
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following action is related to <c>DeleteObject</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteObjectRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private bool? bypassGovernanceRetention;
        private string expectedBucketOwner;
        private string key;
        private MfaCodes mfaCodes;
        private RequestPayer requestPayer;
        private string versionId;
        private string ifMatch;
        private DateTime? ifMatchLastModifiedTime;
        private long? ifMatchSize;


        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name of the bucket containing the object. 
        /// </para> 
        /// <para> 
        /// <b>Directory buckets</b> - When you use this operation with a directory bucket, you must use virtual-hosted-style 
        /// requests in the format <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>. Path-style 
        /// requests are not supported. Directory bucket names must be unique in the chosen Zone (Availability Zone or Local Zone). Bucket 
        /// names must follow the format <c> <i>bucket-base-name</i>--<i>zone-id</i>--x-s3</c> (for example, <c> <i>amzn-s3-demo-bucket</i>--<i>usw2-az1</i>--x-s3</c>). For 
        /// information about bucket naming restrictions, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory bucket naming rules</a> in 
        /// the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <para> 
        /// <b>Access points</b> - When you use this action with an access point for general purpose buckets, you must provide the alias of 
        /// the access point in place of the bucket name or specify the access point ARN. When you use this action with an access point for 
        /// directory buckets, you must provide the access point name in place of the bucket name. When using the access point ARN, you must 
        /// direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When 
        /// using this action with an access point through the Amazon Web Services SDKs, you provide the access point ARN in place of the 
        /// bucket name. For more information about access point ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <note> 
        /// <para>
        /// Object Lambda access points are not supported by directory buckets.
        /// </para> 
        /// </note> 
        /// <para> 
        /// <b>S3 on Outposts</b> - When you use this action with S3 on Outposts, you must direct requests to the S3 on Outposts hostname. The S3 on Outposts 
        /// hostname takes the form <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>. When you use 
        /// this action with S3 on Outposts, the destination bucket must be the Outposts access point ARN or the access point alias. For more information 
        /// about S3 on Outposts, see 
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
        /// Indicates whether S3 Object Lock should bypass Governance-mode restrictions to process
        /// this operation. To use this header, you must have the <c>s3:BypassGovernanceRetention</c>
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
        /// Gets and sets the property Key. 
        /// <para>
        /// Key name of the object to delete.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// Gets and sets the property MFA. 
        /// <para>
        /// The concatenation of the authentication device's serial number, a space, and the value
        /// that is displayed on your authentication device. Required to permanently delete a
        /// versioned object if versioning is configured with MFA delete enabled.
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
            return requestPayer != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID used to reference a specific version of the object.
        /// </para>
        ///  <note> 
        /// <para>
        /// For directory buckets in this API operation, only the <c>null</c> value of the
        /// version ID is supported.
        /// </para>
        ///  </note>
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return !System.String.IsNullOrEmpty(this.versionId);
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>The <c>If-Match</c> header field makes the request method conditional on ETags. If the ETag value does not match, the operation returns
        /// a <c>412 Precondition Failed</c> error. If the ETag matches or if the object doesn't exist, the operation will return a <c>204 Success (No Content) response</c>.</para>
        /// <para>For more information about conditional requests, see <a href="https://docs.aws.amazon.com/https:/tools.ietf.org/html/rfc7232">RFC 7232</a>.</para>
        /// <note>
        /// <para>This functionality is only supported for directory buckets.</para>
        /// </note>
        /// </summary>
        public string IfMatch
        {
            get { return this.ifMatch; }
            set { this.ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return !String.IsNullOrEmpty(this.ifMatch);
        }

        /// <summary>
        /// Gets and sets the property IfMatchLastModifiedTime.
        /// <para>If present, the object is deleted only if its modification times matches the provided
        /// <c>Timestamp</c>. If the <c>Timestamp</c> values do not match, the operation
        /// returns a <c>412 Precondition Failed</c> error. If the <c>Timestamp</c> matches
        /// or if the object doesn’t exist, the operation returns a <c>204 Success (No Content)</c> response.</para>
        /// <note>
        /// <para>This functionality is only supported for directory buckets.</para>
        /// </note>
        /// </summary>
        public DateTime? IfMatchLastModifiedTime
        {
            get { return this.ifMatchLastModifiedTime; }
            set { this.ifMatchLastModifiedTime = value; }
        }

        // Check to see if IfMatchLastModifiedTime property is set
        internal bool IsSetIfMatchLastModifiedTime()
        {
            return this.ifMatchLastModifiedTime.HasValue;
        }

        /// <summary>
        /// Gets and sets the property IfMatchSize.
        /// <para>If present, the object is deleted only if its size matches the provided size in bytes. If the <c>Size</c> value does not match, the operation returns a <c>412 Precondition Failed</c> error. If the <c>Size</c> matches or if the object doesn’t exist,
        /// the operation returns a <c>204 Success (No Content)</c> response.</para>
        /// <note>
        /// <para>This functionality is only supported for directory buckets.</para>
        /// </note>
        /// <important>
        /// <para>You can use the <c>If-Match</c>, <c>x-amz-if-match-last-modified-time</c> and <c>x-amz-if-match-size</c>
        /// conditional headers in conjunction with each-other or individually.</para>
        /// </important>
        /// </summary>
        public long IfMatchSize
        {
            get { return this.ifMatchSize.GetValueOrDefault(); }
            set { this.ifMatchSize = value; }
        }

        // Check to see if MatchSize property is set
        internal bool IsSetIfMatchSize()
        {
            return this.ifMatchSize.HasValue;
        }
    }
}

