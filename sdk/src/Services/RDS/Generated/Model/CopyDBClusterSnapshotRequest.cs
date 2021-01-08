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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CopyDBClusterSnapshot operation.
    /// Copies a snapshot of a DB cluster.
    /// 
    ///  
    /// <para>
    /// To copy a DB cluster snapshot from a shared manual DB cluster snapshot, <code>SourceDBClusterSnapshotIdentifier</code>
    /// must be the Amazon Resource Name (ARN) of the shared DB cluster snapshot.
    /// </para>
    ///  
    /// <para>
    /// You can copy an encrypted DB cluster snapshot from another AWS Region. In that case,
    /// the AWS Region where you call the <code>CopyDBClusterSnapshot</code> action is the
    /// destination AWS Region for the encrypted DB cluster snapshot to be copied to. To copy
    /// an encrypted DB cluster snapshot from another AWS Region, you must provide the following
    /// values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>KmsKeyId</code> - The AWS Key Management System (AWS KMS) key identifier for
    /// the key to use to encrypt the copy of the DB cluster snapshot in the destination AWS
    /// Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PreSignedUrl</code> - A URL that contains a Signature Version 4 signed request
    /// for the <code>CopyDBClusterSnapshot</code> action to be called in the source AWS Region
    /// where the DB cluster snapshot is copied from. The pre-signed URL must be a valid request
    /// for the <code>CopyDBClusterSnapshot</code> API action that can be executed in the
    /// source AWS Region that contains the encrypted DB cluster snapshot to be copied.
    /// </para>
    ///  
    /// <para>
    /// The pre-signed URL request must contain the following parameter values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>KmsKeyId</code> - The AWS KMS key identifier for the customer master key (CMK)
    /// to use to encrypt the copy of the DB cluster snapshot in the destination AWS Region.
    /// This is the same identifier for both the <code>CopyDBClusterSnapshot</code> action
    /// that is called in the destination AWS Region, and the action contained in the pre-signed
    /// URL.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DestinationRegion</code> - The name of the AWS Region that the DB cluster snapshot
    /// is to be created in.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>SourceDBClusterSnapshotIdentifier</code> - The DB cluster snapshot identifier
    /// for the encrypted DB cluster snapshot to be copied. This identifier must be in the
    /// Amazon Resource Name (ARN) format for the source AWS Region. For example, if you are
    /// copying an encrypted DB cluster snapshot from the us-west-2 AWS Region, then your
    /// <code>SourceDBClusterSnapshotIdentifier</code> looks like the following example: <code>arn:aws:rds:us-west-2:123456789012:cluster-snapshot:aurora-cluster1-snapshot-20161115</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To learn how to generate a Signature Version 4 signed request, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">
    /// Authenticating Requests: Using Query Parameters (AWS Signature Version 4)</a> and
    /// <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">
    /// Signature Version 4 Signing Process</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you are using an AWS SDK tool or the AWS CLI, you can specify <code>SourceRegion</code>
    /// (or <code>--source-region</code> for the AWS CLI) instead of specifying <code>PreSignedUrl</code>
    /// manually. Specifying <code>SourceRegion</code> autogenerates a pre-signed URL that
    /// is a valid request for the operation that can be executed in the source AWS Region.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    ///  <code>TargetDBClusterSnapshotIdentifier</code> - The identifier for the new copy
    /// of the DB cluster snapshot in the destination AWS Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>SourceDBClusterSnapshotIdentifier</code> - The DB cluster snapshot identifier
    /// for the encrypted DB cluster snapshot to be copied. This identifier must be in the
    /// ARN format for the source AWS Region and is the same value as the <code>SourceDBClusterSnapshotIdentifier</code>
    /// in the pre-signed URL. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To cancel the copy operation once it is in progress, delete the target DB cluster
    /// snapshot identified by <code>TargetDBClusterSnapshotIdentifier</code> while that DB
    /// cluster snapshot is in "copying" status.
    /// </para>
    ///  
    /// <para>
    /// For more information on copying encrypted DB cluster snapshots from one AWS Region
    /// to another, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_CopySnapshot.html">
    /// Copying a Snapshot</a> in the <i>Amazon Aurora User Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
    /// </para>
    ///  <note> 
    /// <para>
    /// This action only applies to Aurora DB clusters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CopyDBClusterSnapshotRequest : AmazonRDSRequest
    {
        private bool? _copyTags;
        private string _kmsKeyId;
        private string _preSignedUrl;
        private string _sourceDBClusterSnapshotIdentifier;
        private List<Tag> _tags = new List<Tag>();
        private string _targetDBClusterSnapshotIdentifier;

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// A value that indicates whether to copy all tags from the source DB cluster snapshot
        /// to the target DB cluster snapshot. By default, tags are not copied.
        /// </para>
        /// </summary>
        public bool CopyTags
        {
            get { return this._copyTags.GetValueOrDefault(); }
            set { this._copyTags = value; }
        }

        // Check to see if CopyTags property is set
        internal bool IsSetCopyTags()
        {
            return this._copyTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The AWS KMS key identifier for an encrypted DB cluster snapshot. The AWS KMS key identifier
        /// is the key ARN, key ID, alias ARN, or alias name for the AWS KMS customer master key
        /// (CMK).
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted DB cluster snapshot from your AWS account, you can specify
        /// a value for <code>KmsKeyId</code> to encrypt the copy with a new AWS KMS CMK. If you
        /// don't specify a value for <code>KmsKeyId</code>, then the copy of the DB cluster snapshot
        /// is encrypted with the same AWS KMS key as the source DB cluster snapshot. 
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted DB cluster snapshot that is shared from another AWS account,
        /// then you must specify a value for <code>KmsKeyId</code>. 
        /// </para>
        ///  
        /// <para>
        /// To copy an encrypted DB cluster snapshot to another AWS Region, you must set <code>KmsKeyId</code>
        /// to the AWS KMS key identifier you want to use to encrypt the copy of the DB cluster
        /// snapshot in the destination AWS Region. AWS KMS CMKs are specific to the AWS Region
        /// that they are created in, and you can't use CMKs from one AWS Region in another AWS
        /// Region.
        /// </para>
        ///  
        /// <para>
        /// If you copy an unencrypted DB cluster snapshot and specify a value for the <code>KmsKeyId</code>
        /// parameter, an error is returned.
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
        /// Gets and sets the property PreSignedUrl. 
        /// <para>
        /// The URL that contains a Signature Version 4 signed request for the <code>CopyDBClusterSnapshot</code>
        /// API action in the AWS Region that contains the source DB cluster snapshot to copy.
        /// The <code>PreSignedUrl</code> parameter must be used when copying an encrypted DB
        /// cluster snapshot from another AWS Region. Don't specify <code>PreSignedUrl</code>
        /// when you are copying an encrypted DB cluster snapshot in the same AWS Region.
        /// </para>
        ///  
        /// <para>
        /// The pre-signed URL must be a valid request for the <code>CopyDBClusterSnapshot</code>
        /// API action that can be executed in the source AWS Region that contains the encrypted
        /// DB cluster snapshot to be copied. The pre-signed URL request must contain the following
        /// parameter values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>KmsKeyId</code> - The AWS KMS key identifier for the customer master key (CMK)
        /// to use to encrypt the copy of the DB cluster snapshot in the destination AWS Region.
        /// This is the same identifier for both the <code>CopyDBClusterSnapshot</code> action
        /// that is called in the destination AWS Region, and the action contained in the pre-signed
        /// URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DestinationRegion</code> - The name of the AWS Region that the DB cluster snapshot
        /// is to be created in.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SourceDBClusterSnapshotIdentifier</code> - The DB cluster snapshot identifier
        /// for the encrypted DB cluster snapshot to be copied. This identifier must be in the
        /// Amazon Resource Name (ARN) format for the source AWS Region. For example, if you are
        /// copying an encrypted DB cluster snapshot from the us-west-2 AWS Region, then your
        /// <code>SourceDBClusterSnapshotIdentifier</code> looks like the following example: <code>arn:aws:rds:us-west-2:123456789012:cluster-snapshot:aurora-cluster1-snapshot-20161115</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn how to generate a Signature Version 4 signed request, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">
        /// Authenticating Requests: Using Query Parameters (AWS Signature Version 4)</a> and
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">
        /// Signature Version 4 Signing Process</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using an AWS SDK tool or the AWS CLI, you can specify <code>SourceRegion</code>
        /// (or <code>--source-region</code> for the AWS CLI) instead of specifying <code>PreSignedUrl</code>
        /// manually. Specifying <code>SourceRegion</code> autogenerates a pre-signed URL that
        /// is a valid request for the operation that can be executed in the source AWS Region.
        /// </para>
        ///  </note>
        /// </summary>
        public string PreSignedUrl
        {
            get { return this._preSignedUrl; }
            set { this._preSignedUrl = value; }
        }

        // Check to see if PreSignedUrl property is set
        internal bool IsSetPreSignedUrl()
        {
            return this._preSignedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDBClusterSnapshotIdentifier. 
        /// <para>
        /// The identifier of the DB cluster snapshot to copy. This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// You can't copy an encrypted, shared DB cluster snapshot from one AWS Region to another.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must specify a valid system snapshot in the "available" state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source snapshot is in the same AWS Region as the copy, specify a valid DB snapshot
        /// identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source snapshot is in a different AWS Region than the copy, specify a valid
        /// DB cluster snapshot ARN. For more information, go to <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_CopySnapshot.html#USER_CopySnapshot.AcrossRegions">
        /// Copying Snapshots Across AWS Regions</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>my-cluster-snapshot1</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceDBClusterSnapshotIdentifier
        {
            get { return this._sourceDBClusterSnapshotIdentifier; }
            set { this._sourceDBClusterSnapshotIdentifier = value; }
        }

        // Check to see if SourceDBClusterSnapshotIdentifier property is set
        internal bool IsSetSourceDBClusterSnapshotIdentifier()
        {
            return this._sourceDBClusterSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetDBClusterSnapshotIdentifier. 
        /// <para>
        /// The identifier of the new DB cluster snapshot to create from the source DB cluster
        /// snapshot. This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>my-cluster-snapshot2</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetDBClusterSnapshotIdentifier
        {
            get { return this._targetDBClusterSnapshotIdentifier; }
            set { this._targetDBClusterSnapshotIdentifier = value; }
        }

        // Check to see if TargetDBClusterSnapshotIdentifier property is set
        internal bool IsSetTargetDBClusterSnapshotIdentifier()
        {
            return this._targetDBClusterSnapshotIdentifier != null;
        }

    }
}