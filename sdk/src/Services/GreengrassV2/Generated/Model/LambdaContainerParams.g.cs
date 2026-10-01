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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a container in which Lambda functions run on Greengrass
    /// core devices.
    /// </summary>
    public partial class LambdaContainerParams
    {
        /// <summary>
        /// Gets and sets the property Devices. 
        /// <para>
        /// The list of system devices that the container can access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LambdaDeviceMount> Devices { get; set; } = AWSConfigs.InitializeCollections ? new List<LambdaDeviceMount>() : null;

        /// <summary>
        /// Checks to see if the Devices property is set.
        /// </summary>
        internal bool IsSetDevices() => this.Devices != null && (this.Devices.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public int? MemorySizeInKB { get; set; }

        /// <summary>
        /// Checks to see if the MemorySizeInKB property is set.
        /// </summary>
        internal bool IsSetMemorySizeInKB() => this.MemorySizeInKB.HasValue;

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
        public bool? MountROSysfs { get; set; }

        /// <summary>
        /// Checks to see if the MountROSysfs property is set.
        /// </summary>
        internal bool IsSetMountROSysfs() => this.MountROSysfs.HasValue;

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// The list of volumes that the container can access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LambdaVolumeMount> Volumes { get; set; } = AWSConfigs.InitializeCollections ? new List<LambdaVolumeMount>() : null;

        /// <summary>
        /// Checks to see if the Volumes property is set.
        /// </summary>
        internal bool IsSetVolumes() => this.Volumes != null && (this.Volumes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
