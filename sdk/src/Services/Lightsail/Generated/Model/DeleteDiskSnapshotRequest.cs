/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDiskSnapshot operation.
    /// Deletes the specified disk snapshot.
    /// 
    ///  
    /// <para>
    /// When you make periodic snapshots of a disk, the snapshots are incremental, and only
    /// the blocks on the device that have changed since your last snapshot are saved in the
    /// new snapshot. When you delete a snapshot, only the data not needed for any other snapshot
    /// is removed. So regardless of which prior snapshots have been deleted, all active snapshots
    /// will have access to all the information needed to restore the disk.
    /// </para>
    /// </summary>
    public partial class DeleteDiskSnapshotRequest : AmazonLightsailRequest
    {
        private string _diskSnapshotName;

        /// <summary>
        /// Gets and sets the property DiskSnapshotName. 
        /// <para>
        /// The name of the disk snapshot you want to delete (e.g., <code>my-disk-snapshot</code>).
        /// </para>
        /// </summary>
        public string DiskSnapshotName
        {
            get { return this._diskSnapshotName; }
            set { this._diskSnapshotName = value; }
        }

        // Check to see if DiskSnapshotName property is set
        internal bool IsSetDiskSnapshotName()
        {
            return this._diskSnapshotName != null;
        }

    }
}