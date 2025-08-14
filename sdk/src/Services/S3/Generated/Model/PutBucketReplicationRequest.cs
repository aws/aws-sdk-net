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
    /// Container for the parameters to the PutBucketReplication operation.
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    ///  Creates a replication configuration or replaces an existing one. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication.html">Replication</a>
    /// in the <i>Amazon S3 User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// Specify the replication configuration in the request body. In the replication configuration,
    /// you provide the name of the destination bucket or buckets where you want Amazon S3
    /// to replicate objects, the IAM role that Amazon S3 can assume to replicate objects
    /// on your behalf, and other relevant information. You can invoke this request for a
    /// specific Amazon Web Services Region by using the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_condition-keys.html#condition-keys-requestedregion">
    /// <c>aws:RequestedRegion</c> </a> condition key.
    /// </para>
    ///  
    /// <para>
    /// A replication configuration must include at least one rule, and can contain a maximum
    /// of 1,000. Each rule identifies a subset of objects to replicate by filtering the objects
    /// in the source bucket. To choose additional subsets of objects to replicate, add a
    /// rule for each subset.
    /// </para>
    ///  
    /// <para>
    /// To specify a subset of the objects in the source bucket to apply a replication rule
    /// to, add the Filter element as a child of the Rule element. You can filter objects
    /// based on an object key prefix, one or more object tags, or both. When you add the
    /// Filter element in the configuration, you must also add the following elements: <c>DeleteMarkerReplication</c>,
    /// <c>Status</c>, and <c>Priority</c>.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you are using an earlier version of the replication configuration, Amazon S3 handles
    /// replication of delete markers differently. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication-add-config.html#replication-backward-compat-considerations">Backward
    /// Compatibility</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// For information about enabling versioning on a bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/Versioning.html">Using
    /// Versioning</a>.
    /// </para>
    ///  <dl> <dt>Handling Replication of Encrypted Objects</dt> <dd> 
    /// <para>
    /// By default, Amazon S3 doesn't replicate objects that are stored at rest using server-side
    /// encryption with KMS keys. To replicate Amazon Web Services KMS-encrypted objects,
    /// add the following: <c>SourceSelectionCriteria</c>, <c>SseKmsEncryptedObjects</c>,
    /// <c>Status</c>, <c>EncryptionConfiguration</c>, and <c>ReplicaKmsKeyID</c>. For information
    /// about replication configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication-config-for-kms-objects.html">Replicating
    /// Objects Created with SSE Using KMS keys</a>.
    /// </para>
    ///  
    /// <para>
    /// For information on <c>PutBucketReplication</c> errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ReplicationErrorCodeList">List
    /// of replication-related error codes</a> 
    /// </para>
    ///  </dd> <dt>Permissions</dt> <dd> 
    /// <para>
    /// To create a <c>PutBucketReplication</c> request, you must have <c>s3:PutReplicationConfiguration</c>
    /// permissions for the bucket. 
    /// </para>
    ///  
    /// <para>
    /// By default, a resource owner, in this case the Amazon Web Services account that created
    /// the bucket, can perform this operation. The resource owner can also grant others permissions
    /// to perform the operation. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
    /// Permissions in a Policy</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// To perform this operation, the user or role performing the action must have the <a
    /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">iam:PassRole</a>
    /// permission.
    /// </para>
    ///  </note> </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>PutBucketReplication</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketReplication.html">GetBucketReplication</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketReplication.html">DeleteBucketReplication</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketReplicationRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private ReplicationConfiguration _configuration;
        private string _contentMD5;
        private string _expectedBucketOwner;
        private string _token;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket
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
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the request when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <c>x-amz-checksum</c>
        /// or <c>x-amz-trailer</c> header sent. Otherwise, Amazon S3 fails the request with the
        /// HTTP status code <c>400 Bad Request</c>. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property Configuration.
        /// </summary>
        [AWSProperty(Required=true)]
        public ReplicationConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property ContentMD5. 
        /// <para>
        /// The Base64 encoded 128-bit <c>MD5</c> digest of the data. You must use this header
        /// as a message integrity check to verify that the request body was not corrupted in
        /// transit. For more information, see <a href="http://www.ietf.org/rfc/rfc1864.txt">RFC
        /// 1864</a>.
        /// </para>
        ///  
        /// <para>
        /// For requests made using the Amazon Web Services Command Line Interface (CLI) or Amazon
        /// Web Services SDKs, this field is calculated automatically.
        /// </para>
        /// </summary>
        public string ContentMD5
        {
            get { return this._contentMD5; }
            set { this._contentMD5 = value; }
        }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return this._contentMD5 != null;
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
        /// Gets and sets the property Token. 
        /// <para>
        /// A token to allow Object Lock to be enabled for an existing bucket.
        /// </para>
        /// </summary>
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

    }
}