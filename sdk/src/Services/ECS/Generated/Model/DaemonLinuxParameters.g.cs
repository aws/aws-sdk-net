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
    /// The Linux-specific options that are applied to the daemon container, such as Linux
    /// kernel capabilities.
    /// </summary>
    public partial class DaemonLinuxParameters
    {
        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The Linux capabilities for the container that are added to or dropped from the default
        /// configuration provided by Docker.
        /// </para>
        /// </summary>
        public KernelCapabilities Capabilities { get; set; }

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null;

        /// <summary>
        /// Gets and sets the property Devices. 
        /// <para>
        /// Any host devices to expose to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Device> Devices { get; set; } = AWSConfigs.InitializeCollections ? new List<Device>() : null;

        /// <summary>
        /// Checks to see if the Devices property is set.
        /// </summary>
        internal bool IsSetDevices() => this.Devices != null && (this.Devices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InitProcessEnabled. 
        /// <para>
        /// Run an <c>init</c> process inside the container that forwards signals and reaps processes.
        /// </para>
        /// </summary>
        public bool? InitProcessEnabled { get; set; }

        /// <summary>
        /// Checks to see if the InitProcessEnabled property is set.
        /// </summary>
        internal bool IsSetInitProcessEnabled() => this.InitProcessEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Tmpfs. 
        /// <para>
        /// The container path, mount options, and size (in MiB) of the tmpfs mount.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tmpfs> Tmpfs { get; set; } = AWSConfigs.InitializeCollections ? new List<Tmpfs>() : null;

        /// <summary>
        /// Checks to see if the Tmpfs property is set.
        /// </summary>
        internal bool IsSetTmpfs() => this.Tmpfs != null && (this.Tmpfs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
