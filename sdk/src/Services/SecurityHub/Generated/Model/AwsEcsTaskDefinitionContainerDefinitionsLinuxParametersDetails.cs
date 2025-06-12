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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// &gt;Linux-specific modifications that are applied to the container, such as Linux
    /// kernel capabilities.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails
    {
        private AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersCapabilitiesDetails _capabilities;
        private List<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDevicesDetails> _devices = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDevicesDetails>() : null;
        private bool? _initProcessEnabled;
        private int? _maxSwap;
        private int? _sharedMemorySize;
        private int? _swappiness;
        private List<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetails> _tmpfs = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetails>() : null;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The Linux capabilities for the container that are added to or dropped from the default
        /// configuration provided by Docker.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersCapabilitiesDetails Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null;
        }

        /// <summary>
        /// Gets and sets the property Devices. 
        /// <para>
        /// The host devices to expose to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDevicesDetails> Devices
        {
            get { return this._devices; }
            set { this._devices = value; }
        }

        // Check to see if Devices property is set
        internal bool IsSetDevices()
        {
            return this._devices != null && (this._devices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InitProcessEnabled. 
        /// <para>
        /// Whether to run an <c>init</c> process inside the container that forwards signals and
        /// reaps processes. 
        /// </para>
        /// </summary>
        public bool? InitProcessEnabled
        {
            get { return this._initProcessEnabled; }
            set { this._initProcessEnabled = value; }
        }

        // Check to see if InitProcessEnabled property is set
        internal bool IsSetInitProcessEnabled()
        {
            return this._initProcessEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSwap. 
        /// <para>
        /// The total amount of swap memory (in MiB) that a container can use.
        /// </para>
        /// </summary>
        public int? MaxSwap
        {
            get { return this._maxSwap; }
            set { this._maxSwap = value; }
        }

        // Check to see if MaxSwap property is set
        internal bool IsSetMaxSwap()
        {
            return this._maxSwap.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SharedMemorySize. 
        /// <para>
        /// The value for the size (in MiB) of the <b>/dev/shm</b> volume.
        /// </para>
        /// </summary>
        public int? SharedMemorySize
        {
            get { return this._sharedMemorySize; }
            set { this._sharedMemorySize = value; }
        }

        // Check to see if SharedMemorySize property is set
        internal bool IsSetSharedMemorySize()
        {
            return this._sharedMemorySize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Swappiness. 
        /// <para>
        /// Configures the container's memory swappiness behavior. Determines how aggressively
        /// pages are swapped. The higher the value, the more aggressive the swappiness. The default
        /// is 60.
        /// </para>
        /// </summary>
        public int? Swappiness
        {
            get { return this._swappiness; }
            set { this._swappiness = value; }
        }

        // Check to see if Swappiness property is set
        internal bool IsSetSwappiness()
        {
            return this._swappiness.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tmpfs. 
        /// <para>
        /// The container path, mount options, and size (in MiB) of the tmpfs mount.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetails> Tmpfs
        {
            get { return this._tmpfs; }
            set { this._tmpfs = value; }
        }

        // Check to see if Tmpfs property is set
        internal bool IsSetTmpfs()
        {
            return this._tmpfs != null && (this._tmpfs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}