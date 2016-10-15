/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents a device type that an app is tested against.
    /// </summary>
    public partial class Device
    {
        private string _arn;
        private string _carrier;
        private CPU _cpu;
        private string _fleetName;
        private string _fleetType;
        private DeviceFormFactor _formFactor;
        private long? _heapSize;
        private string _image;
        private string _manufacturer;
        private long? _memory;
        private string _model;
        private string _name;
        private string _os;
        private DevicePlatform _platform;
        private string _radio;
        private bool? _remoteAccessEnabled;
        private Resolution _resolution;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The device's ARN.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Carrier. 
        /// <para>
        /// The device's carrier.
        /// </para>
        /// </summary>
        public string Carrier
        {
            get { return this._carrier; }
            set { this._carrier = value; }
        }

        // Check to see if Carrier property is set
        internal bool IsSetCarrier()
        {
            return this._carrier != null;
        }

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// Information about the device's CPU.
        /// </para>
        /// </summary>
        public CPU Cpu
        {
            get { return this._cpu; }
            set { this._cpu = value; }
        }

        // Check to see if Cpu property is set
        internal bool IsSetCpu()
        {
            return this._cpu != null;
        }

        /// <summary>
        /// Gets and sets the property FleetName. 
        /// <para>
        /// The name of the fleet to which this device belongs.
        /// </para>
        /// </summary>
        public string FleetName
        {
            get { return this._fleetName; }
            set { this._fleetName = value; }
        }

        // Check to see if FleetName property is set
        internal bool IsSetFleetName()
        {
            return this._fleetName != null;
        }

        /// <summary>
        /// Gets and sets the property FleetType. 
        /// <para>
        /// The type of fleet to which this device belongs. Possible values for fleet type are
        /// PRIVATE and PUBLIC.
        /// </para>
        /// </summary>
        public string FleetType
        {
            get { return this._fleetType; }
            set { this._fleetType = value; }
        }

        // Check to see if FleetType property is set
        internal bool IsSetFleetType()
        {
            return this._fleetType != null;
        }

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
        /// PHONE: The phone form factor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TABLET: The tablet form factor.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeviceFormFactor FormFactor
        {
            get { return this._formFactor; }
            set { this._formFactor = value; }
        }

        // Check to see if FormFactor property is set
        internal bool IsSetFormFactor()
        {
            return this._formFactor != null;
        }

        /// <summary>
        /// Gets and sets the property HeapSize. 
        /// <para>
        /// The device's heap size, expressed in bytes.
        /// </para>
        /// </summary>
        public long HeapSize
        {
            get { return this._heapSize.GetValueOrDefault(); }
            set { this._heapSize = value; }
        }

        // Check to see if HeapSize property is set
        internal bool IsSetHeapSize()
        {
            return this._heapSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The device's image name.
        /// </para>
        /// </summary>
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property Manufacturer. 
        /// <para>
        /// The device's manufacturer name.
        /// </para>
        /// </summary>
        public string Manufacturer
        {
            get { return this._manufacturer; }
            set { this._manufacturer = value; }
        }

        // Check to see if Manufacturer property is set
        internal bool IsSetManufacturer()
        {
            return this._manufacturer != null;
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The device's total memory size, expressed in bytes.
        /// </para>
        /// </summary>
        public long Memory
        {
            get { return this._memory.GetValueOrDefault(); }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The device's model name.
        /// </para>
        /// </summary>
        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The device's display name.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Os. 
        /// <para>
        /// The device's operating system type.
        /// </para>
        /// </summary>
        public string Os
        {
            get { return this._os; }
            set { this._os = value; }
        }

        // Check to see if Os property is set
        internal bool IsSetOs()
        {
            return this._os != null;
        }

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
        /// ANDROID: The Android platform.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IOS: The iOS platform.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DevicePlatform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property Radio. 
        /// <para>
        /// The device's radio.
        /// </para>
        /// </summary>
        public string Radio
        {
            get { return this._radio; }
            set { this._radio = value; }
        }

        // Check to see if Radio property is set
        internal bool IsSetRadio()
        {
            return this._radio != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteAccessEnabled. 
        /// <para>
        /// Specifies whether remote access has been enabled for the specified device.
        /// </para>
        /// </summary>
        public bool RemoteAccessEnabled
        {
            get { return this._remoteAccessEnabled.GetValueOrDefault(); }
            set { this._remoteAccessEnabled = value; }
        }

        // Check to see if RemoteAccessEnabled property is set
        internal bool IsSetRemoteAccessEnabled()
        {
            return this._remoteAccessEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Resolution.
        /// </summary>
        public Resolution Resolution
        {
            get { return this._resolution; }
            set { this._resolution = value; }
        }

        // Check to see if Resolution property is set
        internal bool IsSetResolution()
        {
            return this._resolution != null;
        }

    }
}