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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifySnapshotTier operation.
    /// Archives an Amazon EBS snapshot. When you archive a snapshot, it is converted to a
    /// full snapshot that includes all of the blocks of data that were written to the volume
    /// at the time the snapshot was created, and moved from the standard tier to the archive
    /// tier. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshot-archive.html">Archive
    /// Amazon EBS snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </summary>
    public partial class ModifySnapshotTierRequest : AmazonEC2Request
    {
        private string _snapshotId;
        private TargetStorageTier _storageTier;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property StorageTier. 
        /// <para>
        /// The name of the storage tier. You must specify <code>archive</code>.
        /// </para>
        /// </summary>
        public TargetStorageTier StorageTier
        {
            get { return this._storageTier; }
            set { this._storageTier = value; }
        }

        // Check to see if StorageTier property is set
        internal bool IsSetStorageTier()
        {
            return this._storageTier != null;
        }

    }
}