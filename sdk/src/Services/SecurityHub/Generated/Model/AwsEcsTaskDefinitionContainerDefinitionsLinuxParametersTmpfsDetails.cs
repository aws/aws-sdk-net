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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The container path, mount options, and size (in MiB) of a tmpfs mount.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetails
    {
        private string _containerPath;
        private List<string> _mountOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _size;

        /// <summary>
        /// Gets and sets the property ContainerPath. 
        /// <para>
        /// The absolute file path where the tmpfs volume is to be mounted.
        /// </para>
        /// </summary>
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
        /// The list of tmpfs volume mount options.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>"defaults"</c> | <c>"ro"</c> | <c>"rw"</c> | <c>"suid"</c> | <c>"nosuid"</c>
        /// | <c>"dev"</c> | <c>"nodev"</c> |<c> "exec"</c> | <c>"noexec"</c> | <c>"sync"</c>
        /// | <c>"async"</c> | <c>"dirsync"</c> | <c>"remount"</c> | <c>"mand"</c> | <c>"nomand"</c>
        /// | <c>"atime"</c> | <c>"noatime"</c> | <c>"diratime"</c> | <c>"nodiratime"</c> | <c>"bind"</c>
        /// | <c>"rbind"</c> | <c>"unbindable"</c> | <c>"runbindable"</c> | <c>"private"</c> |
        /// <c>"rprivate"</c> | <c>"shared"</c> | <c>"rshared"</c> | <c>"slave"</c> | <c>"rslave"</c>
        /// | <c>"relatime"</c> | <c>"norelatime"</c> | <c>"strictatime"</c> | <c>"nostrictatime"</c>
        /// |<c> "mode"</c> | <c>"uid"</c> | <c>"gid"</c> | <c>"nr_inodes"</c> |<c> "nr_blocks"</c>
        /// | <c>"mpol"</c> 
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
            return this._mountOptions != null && (this._mountOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The maximum size (in MiB) of the tmpfs volume.
        /// </para>
        /// </summary>
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