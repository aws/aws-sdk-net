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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Batch.Model
{
    /// <summary>
    /// The container path, mount options, and size of the <c>tmpfs</c> mount.
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
        private List<string> _mountOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _size;

        /// <summary>
        /// Gets and sets the property ContainerPath. 
        /// <para>
        /// The absolute file path in the container where the <c>tmpfs</c> volume is mounted.
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
        /// The list of <c>tmpfs</c> volume mount options.
        /// </para>
        ///  
        /// <para>
        /// Valid values: "<c>defaults</c>" | "<c>ro</c>" | "<c>rw</c>" | "<c>suid</c>" | "<c>nosuid</c>"
        /// | "<c>dev</c>" | "<c>nodev</c>" | "<c>exec</c>" | "<c>noexec</c>" | "<c>sync</c>"
        /// | "<c>async</c>" | "<c>dirsync</c>" | "<c>remount</c>" | "<c>mand</c>" | "<c>nomand</c>"
        /// | "<c>atime</c>" | "<c>noatime</c>" | "<c>diratime</c>" | "<c>nodiratime</c>" | "<c>bind</c>"
        /// | "<c>rbind" | "unbindable" | "runbindable" | "private" | "rprivate" | "shared" |
        /// "rshared" | "slave" | "rslave" | "relatime</c>" | "<c>norelatime</c>" | "<c>strictatime</c>"
        /// | "<c>nostrictatime</c>" | "<c>mode</c>" | "<c>uid</c>" | "<c>gid</c>" | "<c>nr_inodes</c>"
        /// | "<c>nr_blocks</c>" | "<c>mpol</c>"
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MountOptions
        {
            get { return this._mountOptions; }
            set { this._mountOptions = value; }
        }

        // Check to see if MountOptions property is set
        internal bool IsSetMountOptions()
        {
            return this._mountOptions != null && (this._mountOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size (in MiB) of the <c>tmpfs</c> volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

    }
}