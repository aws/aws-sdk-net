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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The container path, mount options, and size of the <code>tmpfs</code> mount.
    /// 
    ///  <note> 
    /// <para>
    /// This object isn't applicable to jobs that are running on Fargate resources.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Tmpfs
    {
        private string _containerPath;
        private List<string> _mountOptions = new List<string>();
        private int? _size;

        /// <summary>
        /// Gets and sets the property ContainerPath. 
        /// <para>
        /// The absolute file path in the container where the <code>tmpfs</code> volume is mounted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContainerPath
        {
            get { return this._containerPath; }
            set { this._containerPath = value; }
        }

        // Check to see if ContainerPath property is set
        internal bool IsSetContainerPath()
        {
            return this._containerPath != null;
        }

        /// <summary>
        /// Gets and sets the property MountOptions. 
        /// <para>
        /// The list of <code>tmpfs</code> volume mount options.
        /// </para>
        ///  
        /// <para>
        /// Valid values: "<code>defaults</code>" | "<code>ro</code>" | "<code>rw</code>" | "<code>suid</code>"
        /// | "<code>nosuid</code>" | "<code>dev</code>" | "<code>nodev</code>" | "<code>exec</code>"
        /// | "<code>noexec</code>" | "<code>sync</code>" | "<code>async</code>" | "<code>dirsync</code>"
        /// | "<code>remount</code>" | "<code>mand</code>" | "<code>nomand</code>" | "<code>atime</code>"
        /// | "<code>noatime</code>" | "<code>diratime</code>" | "<code>nodiratime</code>" | "<code>bind</code>"
        /// | "<code>rbind" | "unbindable" | "runbindable" | "private" | "rprivate" | "shared"
        /// | "rshared" | "slave" | "rslave" | "relatime</code>" | "<code>norelatime</code>" |
        /// "<code>strictatime</code>" | "<code>nostrictatime</code>" | "<code>mode</code>" |
        /// "<code>uid</code>" | "<code>gid</code>" | "<code>nr_inodes</code>" | "<code>nr_blocks</code>"
        /// | "<code>mpol</code>"
        /// </para>
        /// </summary>
        public List<string> MountOptions
        {
            get { return this._mountOptions; }
            set { this._mountOptions = value; }
        }

        // Check to see if MountOptions property is set
        internal bool IsSetMountOptions()
        {
            return this._mountOptions != null && this._mountOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size (in MiB) of the <code>tmpfs</code> volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

    }
}