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
    /// Container for the parameters to the CreateDiskSnapshot operation.
    /// Creates a snapshot of a block storage disk. You can use snapshots for backups, to
    /// make copies of disks, and to save data before shutting down a Lightsail instance.
    /// 
    ///  
    /// <para>
    /// You can take a snapshot of an attached disk that is in use; however, snapshots only
    /// capture data that has been written to your disk at the time the snapshot command is
    /// issued. This may exclude any data that has been cached by any applications or the
    /// operating system. If you can pause any file systems on the disk long enough to take
    /// a snapshot, your snapshot should be complete. Nevertheless, if you cannot pause all
    /// file writes to the disk, you should unmount the disk from within the Lightsail instance,
    /// issue the create disk snapshot command, and then remount the disk to ensure a consistent
    /// and complete snapshot. You may remount and use your disk while the snapshot status
    /// is pending.
    /// </para>
    /// </summary>
    public partial class CreateDiskSnapshotRequest : AmazonLightsailRequest
    {
        private string _diskName;
        private string _diskSnapshotName;

        /// <summary>
        /// Gets and sets the property DiskName. 
        /// <para>
        /// The unique name of the source disk (e.g., <code>my-source-disk</code>).
        /// </para>
        /// </summary>
        public string DiskName
        {
            get { return this._diskName; }
            set { this._diskName = value; }
        }

        // Check to see if DiskName property is set
        internal bool IsSetDiskName()
        {
            return this._diskName != null;
        }

        /// <summary>
        /// Gets and sets the property DiskSnapshotName. 
        /// <para>
        /// The name of the destination disk snapshot (e.g., <code>my-disk-snapshot</code>) based
        /// on the source disk.
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