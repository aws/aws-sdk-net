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
    /// If versioning is enabled, the operation removes the null version (if there is one)
    /// of an object and inserts a delete marker, which becomes the latest version of the
    /// object. If there isn't a null version, Amazon S3 does not remove any objects but will
    /// still respond that the command was successful.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If versioning is suspended or not enabled, the operation permanently deletes the object.
    /// </para>
    ///  </li> </ul> <note> <ul> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - S3 Versioning isn't enabled and supported for directory
    /// buckets. For this API operation, only the <code>null</code> value of the version ID
    /// is supported by directory buckets. You can only specify <code>null</code> to the <code>versionId</code>
    /// query parameter in the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, you must make requests for this
    /// API operation to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <code>https://<i>bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com/<i>key-name</i>
    /// </code>. Path-style requests are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// To remove a specific version, you must use the <code>versionId</code> query parameter.
    /// Using this query parameter permanently deletes the version. If the object deleted
    /// is a delete marker, Amazon S3 sets the response header <code>x-amz-delete-marker</code>
    /// to true. 
    /// </para>
    ///  
    /// <para>
    /// If the object you want to delete is in a bucket where the bucket versioning configuration
    /// is MFA Delete enabled, you must include the <code>x-amz-mfa</code> request header
    /// in the DELETE <code>versionId</code> request. Requests that include <code>x-amz-mfa</code>
    /// must use HTTPS. For more information about MFA Delete, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMFADelete.html">Using
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
    /// from removing or deleting objects from your bucket, you must deny them the <code>s3:DeleteObject</code>,
    /// <code>s3:DeleteObjectVersion</code>, and <code>s3:PutLifeCycleConfiguration</code>
    /// actions. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - S3 Lifecycle is not supported by directory buckets.
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - The following permissions are required
    /// in your policies when your <code>DeleteObjects</code> request includes specific headers.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b> <code>s3:DeleteObject</code> </b> - To delete an object from a bucket, you must
    /// always have the <code>s3:DeleteObject</code> permission.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <code>s3:DeleteObjectVersion</code> </b> - To delete a specific version of an
    /// object from a versiong-enabled bucket, you must have the <code>s3:DeleteObjectVersion</code>
    /// permission.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - To grant access to this API operation on a
    /// directory bucket, we recommend that you use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <code>CreateSession</code> </a> API operation for session-based authorization. Specifically,
    /// you grant the <code>s3express:CreateSession</code> permission to the directory bucket
    /// in a bucket policy or an IAM identity-based policy. Then, you make the <code>CreateSession</code>
    /// API call on the bucket to obtain a session token. With the session token in your request
    /// header, you can make API requests to this operation. After the session token expires,
    /// you make another <code>CreateSession</code> API call to generate a new session token
    /// for use. Amazon Web Services CLI or SDKs create session and refresh the session token
    /// automatically to avoid service interruptions when a session expires. For more information
    /// about authorization, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <code>CreateSession</code> </a>.
    /// </para>
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <code> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</code>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following action is related to <code>DeleteObject</code>:
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

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name of the bucket containing the object. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets</b> - When you use this operation with a directory bucket, you
        /// must use virtual-hosted-style requests in the format <code> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</code>.
        /// Path-style requests are not supported. Directory bucket names must be unique in the
        /// chosen Availability Zone. Bucket names must follow the format <code> <i>bucket_base_name</i>--<i>az-id</i>--x-s3</code>
        /// (for example, <code> <i>DOC-EXAMPLE-BUCKET</i>--<i>usw2-az2</i>--x-s3</code>). For
        /// information about bucket naming restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory
        /// bucket naming rules</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access points</b> - When you use this action with an access point, you must provide
        /// the alias of the access point in place of the bucket name or specify the access point
        /// ARN. When using the access point ARN, you must direct requests to the access point
        /// hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Access points and Object Lambda access points are not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>S3 on Outposts</b> - When you use this action with Amazon S3 on Outposts, you
        /// must direct requests to the S3 on Outposts hostname. The S3 on Outposts hostname takes
        /// the form <code> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</code>.
        /// When you use this action with S3 on Outposts through the Amazon Web Services SDKs,
        /// you provide the Outposts access point ARN in place of the bucket name. For more information
        /// about S3 on Outposts ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What
        /// is S3 on Outposts?</a> in the <i>Amazon S3 User Guide</i>.
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
        /// this operation. To use this header, you must have the <code>s3:BypassGovernanceRetention</code>
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
        /// <code>403 Forbidden</code> (access denied).
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
        /// For directory buckets in this API operation, only the <code>null</code> value of the
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
    }
}

