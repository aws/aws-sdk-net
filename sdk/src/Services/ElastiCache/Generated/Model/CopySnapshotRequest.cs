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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the CopySnapshot operation.
    /// Makes a copy of an existing snapshot.
    /// 
    ///  <note> 
    /// <para>
    /// This operation is valid for Valkey or Redis OSS only.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// Users or groups that have permissions to use the <c>CopySnapshot</c> operation can
    /// create their own Amazon S3 buckets and copy snapshots to it. To control access to
    /// your snapshots, use an IAM policy to control who has the ability to use the <c>CopySnapshot</c>
    /// operation. For more information about using IAM to control the use of ElastiCache
    /// operations, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html">Exporting
    /// Snapshots</a> and <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/IAM.html">Authentication
    /// &amp; Access Control</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// You could receive the following error messages.
    /// </para>
    ///  
    /// <para>
    ///  <b>Error Messages</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Error Message:</b> The S3 bucket %s is outside of the region.
    /// </para>
    ///  
    /// <para>
    ///  <b>Solution:</b> Create an Amazon S3 bucket in the same region as your snapshot.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html#backups-exporting-create-s3-bucket">Step
    /// 1: Create an Amazon S3 Bucket</a> in the ElastiCache User Guide.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Error Message:</b> The S3 bucket %s does not exist.
    /// </para>
    ///  
    /// <para>
    ///  <b>Solution:</b> Create an Amazon S3 bucket in the same region as your snapshot.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html#backups-exporting-create-s3-bucket">Step
    /// 1: Create an Amazon S3 Bucket</a> in the ElastiCache User Guide.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Error Message:</b> The S3 bucket %s is not owned by the authenticated user.
    /// </para>
    ///  
    /// <para>
    ///  <b>Solution:</b> Create an Amazon S3 bucket in the same region as your snapshot.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html#backups-exporting-create-s3-bucket">Step
    /// 1: Create an Amazon S3 Bucket</a> in the ElastiCache User Guide.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Error Message:</b> The authenticated user does not have sufficient permissions
    /// to perform the desired activity.
    /// </para>
    ///  
    /// <para>
    ///  <b>Solution:</b> Contact your system administrator to get the needed permissions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Error Message:</b> The S3 bucket %s already contains an object with key %s.
    /// </para>
    ///  
    /// <para>
    ///  <b>Solution:</b> Give the <c>TargetSnapshotName</c> a new and unique value. If exporting
    /// a snapshot, you could alternatively create a new Amazon S3 bucket and use this same
    /// value for <c>TargetSnapshotName</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Error Message: </b> ElastiCache has not been granted READ permissions %s on the
    /// S3 Bucket.
    /// </para>
    ///  
    /// <para>
    ///  <b>Solution:</b> Add List and Read permissions on the bucket. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html#backups-exporting-grant-access">Step
    /// 2: Grant ElastiCache Access to Your Amazon S3 Bucket</a> in the ElastiCache User Guide.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Error Message: </b> ElastiCache has not been granted WRITE permissions %s on the
    /// S3 Bucket.
    /// </para>
    ///  
    /// <para>
    ///  <b>Solution:</b> Add Upload/Delete permissions on the bucket. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html#backups-exporting-grant-access">Step
    /// 2: Grant ElastiCache Access to Your Amazon S3 Bucket</a> in the ElastiCache User Guide.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Error Message: </b> ElastiCache has not been granted READ_ACP permissions %s on
    /// the S3 Bucket.
    /// </para>
    ///  
    /// <para>
    ///  <b>Solution:</b> Add View Permissions on the bucket. For more information, see <a
    /// href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html#backups-exporting-grant-access">Step
    /// 2: Grant ElastiCache Access to Your Amazon S3 Bucket</a> in the ElastiCache User Guide.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CopySnapshotRequest : AmazonElastiCacheRequest
    {
        private string _kmsKeyId;
        private string _sourceSnapshotName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _targetBucket;
        private string _targetSnapshotName;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key used to encrypt the target snapshot.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSnapshotName. 
        /// <para>
        /// The name of an existing snapshot from which to make a copy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceSnapshotName
        {
            get { return this._sourceSnapshotName; }
            set { this._sourceSnapshotName = value; }
        }

        // Check to see if SourceSnapshotName property is set
        internal bool IsSetSourceSnapshotName()
        {
            return this._sourceSnapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to this resource. A tag is a key-value pair. A tag key
        /// must be accompanied by a tag value, although null is accepted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetBucket. 
        /// <para>
        /// The Amazon S3 bucket to which the snapshot is exported. This parameter is used only
        /// when exporting a snapshot for external access.
        /// </para>
        ///  
        /// <para>
        /// When using this parameter to export a snapshot, be sure Amazon ElastiCache has the
        /// needed permissions to this S3 bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html#backups-exporting-grant-access">Step
        /// 2: Grant ElastiCache Access to Your Amazon S3 Bucket</a> in the <i>Amazon ElastiCache
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html">Exporting
        /// a Snapshot</a> in the <i>Amazon ElastiCache User Guide</i>.
        /// </para>
        /// </summary>
        public string TargetBucket
        {
            get { return this._targetBucket; }
            set { this._targetBucket = value; }
        }

        // Check to see if TargetBucket property is set
        internal bool IsSetTargetBucket()
        {
            return this._targetBucket != null;
        }

        /// <summary>
        /// Gets and sets the property TargetSnapshotName. 
        /// <para>
        /// A name for the snapshot copy. ElastiCache does not permit overwriting a snapshot,
        /// therefore this name must be unique within its context - ElastiCache or an Amazon S3
        /// bucket if exporting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetSnapshotName
        {
            get { return this._targetSnapshotName; }
            set { this._targetSnapshotName = value; }
        }

        // Check to see if TargetSnapshotName property is set
        internal bool IsSetTargetSnapshotName()
        {
            return this._targetSnapshotName != null;
        }

    }
}