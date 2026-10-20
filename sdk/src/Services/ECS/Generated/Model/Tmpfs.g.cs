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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The container path, mount options, and size of the tmpfs mount.
    /// </summary>
    public partial class Tmpfs
    {
        /// <summary>
        /// Gets and sets the property ContainerPath. 
        /// <para>
        /// The absolute file path where the tmpfs volume is to be mounted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContainerPath { get; set; }

        /// <summary>
        /// Checks to see if the ContainerPath property is set.
        /// </summary>
        internal bool IsSetContainerPath() => this.ContainerPath != null;

        /// <summary>
        /// Gets and sets the property MountOptions. 
        /// <para>
        /// The list of tmpfs volume mount options.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>"defaults" | "ro" | "rw" | "suid" | "nosuid" | "dev" | "nodev" |
        /// "exec" | "noexec" | "sync" | "async" | "dirsync" | "remount" | "mand" | "nomand" |
        /// "atime" | "noatime" | "diratime" | "nodiratime" | "bind" | "rbind" | "unbindable"
        /// | "runbindable" | "private" | "rprivate" | "shared" | "rshared" | "slave" | "rslave"
        /// | "relatime" | "norelatime" | "strictatime" | "nostrictatime" | "mode" | "uid" | "gid"
        /// | "nr_inodes" | "nr_blocks" | "mpol"</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MountOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MountOptions property is set.
        /// </summary>
        internal bool IsSetMountOptions() => this.MountOptions != null && (this.MountOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The maximum size (in MiB) of the tmpfs volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;
    }
}
