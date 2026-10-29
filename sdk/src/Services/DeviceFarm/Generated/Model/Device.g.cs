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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents a device type that an app is tested against.
    /// </summary>
    public partial class Device
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The device's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Availability. 
        /// <para>
        /// Indicates how likely a device is available for a test run. Currently available in
        /// the <a>ListDevices</a> and GetDevice API methods.
        /// </para>
        /// </summary>
        public DeviceAvailability Availability { get; set; }

        /// <summary>
        /// Checks to see if the Availability property is set.
        /// </summary>
        internal bool IsSetAvailability() => this.Availability != null;

        /// <summary>
        /// Gets and sets the property Carrier. 
        /// <para>
        /// The device's carrier.
        /// </para>
        /// </summary>
        public string Carrier { get; set; }

        /// <summary>
        /// Checks to see if the Carrier property is set.
        /// </summary>
        internal bool IsSetCarrier() => this.Carrier != null;

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// Information about the device's CPU.
        /// </para>
        /// </summary>
        public CPU Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu != null;

        /// <summary>
        /// Gets and sets the property FleetName. 
        /// <para>
        /// The name of the fleet to which this device belongs.
        /// </para>
        /// </summary>
        public string FleetName { get; set; }

        /// <summary>
        /// Checks to see if the FleetName property is set.
        /// </summary>
        internal bool IsSetFleetName() => this.FleetName != null;

        /// <summary>
        /// Gets and sets the property FleetType. 
        /// <para>
        /// The type of fleet to which this device belongs. Possible values are PRIVATE and PUBLIC.
        /// </para>
        /// </summary>
        public string FleetType { get; set; }

        /// <summary>
        /// Checks to see if the FleetType property is set.
        /// </summary>
        internal bool IsSetFleetType() => this.FleetType != null;

        /// <summary>
        /// Gets and sets the property FormFactor. 
        /// <para>
        /// The device's form factor.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PHONE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TABLET
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeviceFormFactor FormFactor { get; set; }

        /// <summary>
        /// Checks to see if the FormFactor property is set.
        /// </summary>
        internal bool IsSetFormFactor() => this.FormFactor != null;

        /// <summary>
        /// Gets and sets the property HeapSize. 
        /// <para>
        /// The device's heap size, expressed in bytes.
        /// </para>
        /// </summary>
        public long? HeapSize { get; set; }

        /// <summary>
        /// Checks to see if the HeapSize property is set.
        /// </summary>
        internal bool IsSetHeapSize() => this.HeapSize.HasValue;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The device's image name.
        /// </para>
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The instances that belong to this device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeviceInstance> Instances { get; set; } = AWSConfigs.InitializeCollections ? new List<DeviceInstance>() : null;

        /// <summary>
        /// Checks to see if the Instances property is set.
        /// </summary>
        internal bool IsSetInstances() => this.Instances != null && (this.Instances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Manufacturer. 
        /// <para>
        /// The device's manufacturer name.
        /// </para>
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Checks to see if the Manufacturer property is set.
        /// </summary>
        internal bool IsSetManufacturer() => this.Manufacturer != null;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The device's total memory size, expressed in bytes.
        /// </para>
        /// </summary>
        public long? Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory.HasValue;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The device's model name.
        /// </para>
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The device's model ID.
        /// </para>
        /// </summary>
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The device's display name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Os. 
        /// <para>
        /// The device's operating system type.
        /// </para>
        /// </summary>
        public string Os { get; set; }

        /// <summary>
        /// Checks to see if the Os property is set.
        /// </summary>
        internal bool IsSetOs() => this.Os != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The device's platform.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ANDROID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IOS
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DevicePlatform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Radio. 
        /// <para>
        /// The device's radio.
        /// </para>
        /// </summary>
        public string Radio { get; set; }

        /// <summary>
        /// Checks to see if the Radio property is set.
        /// </summary>
        internal bool IsSetRadio() => this.Radio != null;

        /// <summary>
        /// Gets and sets the property RemoteAccessEnabled. 
        /// <para>
        /// Specifies whether remote access has been enabled for the specified device.
        /// </para>
        /// </summary>
        public bool? RemoteAccessEnabled { get; set; }

        /// <summary>
        /// Checks to see if the RemoteAccessEnabled property is set.
        /// </summary>
        internal bool IsSetRemoteAccessEnabled() => this.RemoteAccessEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property RemoteDebugEnabled. 
        /// <para>
        /// This flag is set to <c>true</c> if remote debugging is enabled for the device.
        /// </para>
        ///  
        /// <para>
        /// Remote debugging is <a href="https://docs.aws.amazon.com/devicefarm/latest/developerguide/history.html">no
        /// longer supported</a>.
        /// </para>
        /// </summary>
        [Obsolete("Direct Device Access is no longer available.")]
        public bool? RemoteDebugEnabled { get; set; }

        /// <summary>
        /// Checks to see if the RemoteDebugEnabled property is set.
        /// </summary>
        internal bool IsSetRemoteDebugEnabled() => this.RemoteDebugEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Resolution. 
        /// <para>
        /// The resolution of the device.
        /// </para>
        /// </summary>
        public Resolution Resolution { get; set; }

        /// <summary>
        /// Checks to see if the Resolution property is set.
        /// </summary>
        internal bool IsSetResolution() => this.Resolution != null;
    }
}
