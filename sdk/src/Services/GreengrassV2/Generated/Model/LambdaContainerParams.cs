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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a container in which Lambda functions run on Greengrass
    /// core devices.
    /// </summary>
    public partial class LambdaContainerParams
    {
        private List<LambdaDeviceMount> _devices = AWSConfigs.InitializeCollections ? new List<LambdaDeviceMount>() : null;
        private int? _memorySizeInKB;
        private bool? _mountroSysfs;
        private List<LambdaVolumeMount> _volumes = AWSConfigs.InitializeCollections ? new List<LambdaVolumeMount>() : null;

        /// <summary>
        /// Gets and sets the property Devices. 
        /// <para>
        /// The list of system devices that the container can access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LambdaDeviceMount> Devices
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
        /// Gets and sets the property MemorySizeInKB. 
        /// <para>
        /// The memory size of the container, expressed in kilobytes.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>16384</c> (16 MB)
        /// </para>
        /// </summary>
        public int? MemorySizeInKB
        {
            get { return this._memorySizeInKB; }
            set { this._memorySizeInKB = value; }
        }

        // Check to see if MemorySizeInKB property is set
        internal bool IsSetMemorySizeInKB()
        {
            return this._memorySizeInKB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MountROSysfs. 
        /// <para>
        /// Whether or not the container can read information from the device's <c>/sys</c> folder.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? MountROSysfs
        {
            get { return this._mountroSysfs; }
            set { this._mountroSysfs = value; }
        }

        // Check to see if MountROSysfs property is set
        internal bool IsSetMountROSysfs()
        {
            return this._mountroSysfs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// The list of volumes that the container can access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LambdaVolumeMount> Volumes
        {
            get { return this._volumes; }
            set { this._volumes = value; }
        }

        // Check to see if Volumes property is set
        internal bool IsSetVolumes()
        {
            return this._volumes != null && (this._volumes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}