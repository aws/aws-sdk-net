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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
    ///  
    /// <para>
    /// You can also use this operation to create a snapshot of an instance's system volume.
    /// You might want to do this, for example, to recover data from the system volume of
    /// a botched instance or to create a backup of the system volume like you would for a
    /// block storage disk. To create a snapshot of a system volume, just define the <code>instance
    /// name</code> parameter when issuing the snapshot command, and a snapshot of the defined
    /// instance's system volume will be created. After the snapshot is available, you can
    /// create a block storage disk from the snapshot and attach it to a running instance
    /// to access the data on the disk.
    /// </para>
    ///  
    /// <para>
    /// The <code>create disk snapshot</code> operation supports tag-based access control
    /// via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateDiskSnapshotRequest : AmazonLightsailRequest
    {
        private string _diskName;
        private string _diskSnapshotName;
        private string _instanceName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DiskName. 
        /// <para>
        /// The unique name of the source disk (e.g., <code>Disk-Virginia-1</code>).
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter cannot be defined together with the <code>instance name</code> parameter.
        /// The <code>disk name</code> and <code>instance name</code> parameters are mutually
        /// exclusive.
        /// </para>
        ///  </note>
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
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The unique name of the source instance (e.g., <code>Amazon_Linux-512MB-Virginia-1</code>).
        /// When this is defined, a snapshot of the instance's system volume is created.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter cannot be defined together with the <code>disk name</code> parameter.
        /// The <code>instance name</code> and <code>disk name</code> parameters are mutually
        /// exclusive.
        /// </para>
        ///  </note>
        /// </summary>
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the resource during create.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>TagResource</code> action to tag a resource after it's created.
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

    }
}