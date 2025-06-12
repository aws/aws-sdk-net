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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the CopyDBClusterSnapshot operation.
    /// Copies a snapshot of a cluster.
    /// 
    ///  
    /// <para>
    /// To copy a cluster snapshot from a shared manual cluster snapshot, <c>SourceDBClusterSnapshotIdentifier</c>
    /// must be the Amazon Resource Name (ARN) of the shared cluster snapshot. You can only
    /// copy a shared DB cluster snapshot, whether encrypted or not, in the same Amazon Web
    /// Services Region.
    /// </para>
    ///  
    /// <para>
    /// To cancel the copy operation after it is in progress, delete the target cluster snapshot
    /// identified by <c>TargetDBClusterSnapshotIdentifier</c> while that cluster snapshot
    /// is in the <i>copying</i> status.
    /// </para>
    /// </summary>
    public partial class CopyDBClusterSnapshotRequest : AmazonDocDBRequest
    {
        private bool? _copyTags;
        private string _kmsKeyId;
        private string _preSignedUrl;
        private string _sourceDBClusterSnapshotIdentifier;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _targetDBClusterSnapshotIdentifier;

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// Set to <c>true</c> to copy all tags from the source cluster snapshot to the target
        /// cluster snapshot, and otherwise <c>false</c>. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? CopyTags
        {
            get { return this._copyTags; }
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
        /// The KMS key ID for an encrypted cluster snapshot. The KMS key ID is the Amazon Resource
        /// Name (ARN), KMS key identifier, or the KMS key alias for the KMS encryption key. 
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted cluster snapshot from your Amazon Web Services account, you
        /// can specify a value for <c>KmsKeyId</c> to encrypt the copy with a new KMS encryption
        /// key. If you don't specify a value for <c>KmsKeyId</c>, then the copy of the cluster
        /// snapshot is encrypted with the same KMS key as the source cluster snapshot.
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted cluster snapshot that is shared from another Amazon Web Services
        /// account, then you must specify a value for <c>KmsKeyId</c>.
        /// </para>
        ///  
        /// <para>
        /// To copy an encrypted cluster snapshot to another Amazon Web Services Region, set <c>KmsKeyId</c>
        /// to the KMS key ID that you want to use to encrypt the copy of the cluster snapshot
        /// in the destination Region. KMS encryption keys are specific to the Amazon Web Services
        /// Region that they are created in, and you can't use encryption keys from one Amazon
        /// Web Services Region in another Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// If you copy an unencrypted cluster snapshot and specify a value for the <c>KmsKeyId</c>
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
        /// The URL that contains a Signature Version 4 signed request for the<c>CopyDBClusterSnapshot</c>
        /// API action in the Amazon Web Services Region that contains the source cluster snapshot
        /// to copy. You must use the <c>PreSignedUrl</c> parameter when copying a cluster snapshot
        /// from another Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// If you are using an Amazon Web Services SDK tool or the CLI, you can specify <c>SourceRegion</c>
        /// (or <c>--source-region</c> for the CLI) instead of specifying <c>PreSignedUrl</c>
        /// manually. Specifying <c>SourceRegion</c> autogenerates a pre-signed URL that is a
        /// valid request for the operation that can be executed in the source Amazon Web Services
        /// Region.
        /// </para>
        ///  
        /// <para>
        /// The presigned URL must be a valid request for the <c>CopyDBClusterSnapshot</c> API
        /// action that can be executed in the source Amazon Web Services Region that contains
        /// the cluster snapshot to be copied. The presigned URL request must contain the following
        /// parameter values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SourceRegion</c> - The ID of the region that contains the snapshot to be copied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SourceDBClusterSnapshotIdentifier</c> - The identifier for the the encrypted cluster
        /// snapshot to be copied. This identifier must be in the Amazon Resource Name (ARN) format
        /// for the source Amazon Web Services Region. For example, if you are copying an encrypted
        /// cluster snapshot from the us-east-1 Amazon Web Services Region, then your <c>SourceDBClusterSnapshotIdentifier</c>
        /// looks something like the following: <c>arn:aws:rds:us-east-1:12345678012:sample-cluster:sample-cluster-snapshot</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TargetDBClusterSnapshotIdentifier</c> - The identifier for the new cluster snapshot
        /// to be created. This parameter isn't case sensitive.
        /// </para>
        ///  </li> </ul>
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
        /// The identifier of the cluster snapshot to copy. This parameter is not case sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must specify a valid system snapshot in the <i>available</i> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source snapshot is in the same Amazon Web Services Region as the copy, specify
        /// a valid snapshot identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source snapshot is in a different Amazon Web Services Region than the copy,
        /// specify a valid cluster snapshot ARN.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>my-cluster-snapshot1</c> 
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
        /// The tags to be assigned to the cluster snapshot.
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
        /// Gets and sets the property TargetDBClusterSnapshotIdentifier. 
        /// <para>
        /// The identifier of the new cluster snapshot to create from the source cluster snapshot.
        /// This parameter is not case sensitive.
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
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>my-cluster-snapshot2</c> 
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