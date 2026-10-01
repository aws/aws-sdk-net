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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// >Linux-specific modifications that are applied to the container, such as Linux kernel
    /// capabilities.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails
    {
        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The Linux capabilities for the container that are added to or dropped from the default
        /// configuration provided by Docker.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersCapabilitiesDetails Capabilities { get; set; }

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null;

        /// <summary>
        /// Gets and sets the property Devices. 
        /// <para>
        /// The host devices to expose to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDevicesDetails> Devices { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDevicesDetails>() : null;

        /// <summary>
        /// Checks to see if the Devices property is set.
        /// </summary>
        internal bool IsSetDevices() => this.Devices != null && (this.Devices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InitProcessEnabled. 
        /// <para>
        /// Whether to run an <c>init</c> process inside the container that forwards signals and
        /// reaps processes. 
        /// </para>
        /// </summary>
        public bool? InitProcessEnabled { get; set; }

        /// <summary>
        /// Checks to see if the InitProcessEnabled property is set.
        /// </summary>
        internal bool IsSetInitProcessEnabled() => this.InitProcessEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property MaxSwap. 
        /// <para>
        /// The total amount of swap memory (in MiB) that a container can use.
        /// </para>
        /// </summary>
        public int? MaxSwap { get; set; }

        /// <summary>
        /// Checks to see if the MaxSwap property is set.
        /// </summary>
        internal bool IsSetMaxSwap() => this.MaxSwap.HasValue;

        /// <summary>
        /// Gets and sets the property SharedMemorySize. 
        /// <para>
        /// The value for the size (in MiB) of the <b>/dev/shm</b> volume.
        /// </para>
        /// </summary>
        public int? SharedMemorySize { get; set; }

        /// <summary>
        /// Checks to see if the SharedMemorySize property is set.
        /// </summary>
        internal bool IsSetSharedMemorySize() => this.SharedMemorySize.HasValue;

        /// <summary>
        /// Gets and sets the property Swappiness. 
        /// <para>
        /// Configures the container's memory swappiness behavior. Determines how aggressively
        /// pages are swapped. The higher the value, the more aggressive the swappiness. The default
        /// is 60.
        /// </para>
        /// </summary>
        public int? Swappiness { get; set; }

        /// <summary>
        /// Checks to see if the Swappiness property is set.
        /// </summary>
        internal bool IsSetSwappiness() => this.Swappiness.HasValue;

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
        public List<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetails> Tmpfs { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetails>() : null;

        /// <summary>
        /// Checks to see if the Tmpfs property is set.
        /// </summary>
        internal bool IsSetTmpfs() => this.Tmpfs != null && (this.Tmpfs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
