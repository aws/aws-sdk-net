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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
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
namespace Amazon.DocDBElastic.Model
{
    /// <summary>
    /// Container for the parameters to the CopyClusterSnapshot operation.
    /// Copies a snapshot of an elastic cluster.
    /// </summary>
    public partial class CopyClusterSnapshotRequest : AmazonDocDBElasticRequest
    {
        private bool? _copyTags;
        private string _kmsKeyId;
        private string _snapshotArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _targetSnapshotName;

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// Set to <c>true</c> to copy all tags from the source cluster snapshot to the target
        /// elastic cluster snapshot. The default is <c>false</c>.
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
        /// The Amazon Web Services KMS key ID for an encrypted elastic cluster snapshot. The
        /// Amazon Web Services KMS key ID is the Amazon Resource Name (ARN), Amazon Web Services
        /// KMS key identifier, or the Amazon Web Services KMS key alias for the Amazon Web Services
        /// KMS encryption key.
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted elastic cluster snapshot from your Amazon Web Services account,
        /// you can specify a value for <c>KmsKeyId</c> to encrypt the copy with a new Amazon
        /// Web ServicesS KMS encryption key. If you don't specify a value for <c>KmsKeyId</c>,
        /// then the copy of the elastic cluster snapshot is encrypted with the same <c>AWS</c>
        /// KMS key as the source elastic cluster snapshot.
        /// </para>
        ///  
        /// <para>
        /// To copy an encrypted elastic cluster snapshot to another Amazon Web Services region,
        /// set <c>KmsKeyId</c> to the Amazon Web Services KMS key ID that you want to use to
        /// encrypt the copy of the elastic cluster snapshot in the destination region. Amazon
        /// Web Services KMS encryption keys are specific to the Amazon Web Services region that
        /// they are created in, and you can't use encryption keys from one Amazon Web Services
        /// region in another Amazon Web Services region.
        /// </para>
        ///  
        /// <para>
        /// If you copy an unencrypted elastic cluster snapshot and specify a value for the <c>KmsKeyId</c>
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
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) identifier of the elastic cluster snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotArn
        {
            get { return this._snapshotArn; }
            set { this._snapshotArn = value; }
        }

        // Check to see if SnapshotArn property is set
        internal bool IsSetSnapshotArn()
        {
            return this._snapshotArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be assigned to the elastic cluster snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property TargetSnapshotName. 
        /// <para>
        /// The identifier of the new elastic cluster snapshot to create from the source cluster
        /// snapshot. This parameter is not case sensitive.
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
        /// Example: <c>elastic-cluster-snapshot-5</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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