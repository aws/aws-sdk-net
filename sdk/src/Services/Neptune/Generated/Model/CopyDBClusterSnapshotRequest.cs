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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
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
    /// </summary>
    public partial class CopyDBClusterSnapshotRequest : AmazonNeptuneRequest
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
        /// True to copy all tags from the source DB cluster snapshot to the target DB cluster
        /// snapshot, and otherwise false. The default is false.
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
        /// The AWS AWS KMS key ID for an encrypted DB cluster snapshot. The KMS key ID is the
        /// Amazon Resource Name (ARN), KMS key identifier, or the KMS key alias for the KMS encryption
        /// key.
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted DB cluster snapshot from your AWS account, you can specify
        /// a value for <code>KmsKeyId</code> to encrypt the copy with a new KMS encryption key.
        /// If you don't specify a value for <code>KmsKeyId</code>, then the copy of the DB cluster
        /// snapshot is encrypted with the same KMS key as the source DB cluster snapshot.
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted DB cluster snapshot that is shared from another AWS account,
        /// then you must specify a value for <code>KmsKeyId</code>.
        /// </para>
        ///  
        /// <para>
        ///  KMS encryption keys are specific to the AWS Region that they are created in, and
        /// you can't use encryption keys from one AWS Region in another AWS Region.
        /// </para>
        ///  
        /// <para>
        /// You cannot encrypt an unencrypted DB cluster snapshot when you copy it. If you try
        /// to copy an unencrypted DB cluster snapshot and specify a value for the KmsKeyId parameter,
        /// an error is returned.
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
        /// Not currently supported.
        /// </para>
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
        /// The identifier of the DB cluster snapshot to copy. This parameter is not case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// You can't copy from one AWS Region to another.
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
        /// Specify a valid DB snapshot identifier.
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
        /// <para>
        /// The tags to assign to the new DB cluster snapshot copy.
        /// </para>
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
        /// snapshot. This parameter is not case-sensitive.
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
        /// Cannot end with a hyphen or contain two consecutive hyphens.
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