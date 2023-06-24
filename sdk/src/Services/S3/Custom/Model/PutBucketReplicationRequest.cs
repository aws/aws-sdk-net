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
    /// Container for the parameters to the PutBucketReplication operation.
    /// Creates a replication configuration or replaces an existing one. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication.html">Replication</a>
    /// in the <i>Amazon S3 User Guide</i>. 
    /// 
    ///  
    /// <para>
    /// Specify the replication configuration in the request body. In the replication configuration,
    /// you provide the name of the destination bucket or buckets where you want Amazon S3
    /// to replicate objects, the IAM role that Amazon S3 can assume to replicate objects
    /// on your behalf, and other relevant information.
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
    /// Filter element in the configuration, you must also add the following elements: <code>DeleteMarkerReplication</code>,
    /// <code>Status</code>, and <code>Priority</code>.
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
    /// encryption with CMKs stored in Amazon Web Services KMS. To replicate Amazon Web Services
    /// KMS-encrypted objects, add the following: <code>SourceSelectionCriteria</code>, <code>SseKmsEncryptedObjects</code>,
    /// <code>Status</code>, <code>EncryptionConfiguration</code>, and <code>ReplicaKmsKeyID</code>.
    /// For information about replication configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication-config-for-kms-objects.html">Replicating
    /// Objects Created with SSE Using CMKs stored in Amazon Web Services KMS</a>.
    /// </para>
    ///  
    /// <para>
    /// For information on <code>PutBucketReplication</code> errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ReplicationErrorCodeList">List
    /// of replication-related error codes</a> 
    /// </para>
    ///  </dd> <dt>Permissions</dt> <dd> 
    /// <para>
    /// To create a <code>PutBucketReplication</code> request, you must have <code>s3:PutReplicationConfiguration</code>
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
    /// The following operations are related to <code>PutBucketReplication</code>:
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
        private string bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string expectedBucketOwner;
        private ReplicationConfiguration configuration;
        private string token;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket
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
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object. Amazon S3 will
        /// fail the request with a 400 error if there is no checksum associated with the object.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The account ID of the expected bucket owner. If the bucket is owned by a different
        /// account, the request will fail with an HTTP <code>403 (Access Denied)</code> error.
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }

        /// <summary>
        /// The replication configuration to be applied.
        /// </summary>
        public ReplicationConfiguration Configuration
        {
            get { return this.configuration; }
            set { this.configuration = value; }
        }

        // Check to see if ReplicationConfiguration property is set
        internal bool IsSetConfiguration()
        {
            return this.configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// A token to allow Object Lock to be enabled for an existing bucket.
        /// </para>
        /// </summary>
        public string Token
        {
            get { return this.token; }
            set { this.token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this.token != null;
        }

    }
}

