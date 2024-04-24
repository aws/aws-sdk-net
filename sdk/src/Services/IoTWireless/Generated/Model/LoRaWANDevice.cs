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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// LoRaWAN object for create functions.
    /// </summary>
    public partial class LoRaWANDevice
    {
        private AbpV1_0_x _abpV1_0_x;
        private AbpV1_1 _abpV1_1;
        private string _devEui;
        private string _deviceProfileId;
        private FPorts _fPorts;
        private OtaaV1_0_x _otaaV1_0_x;
        private OtaaV1_1 _otaaV1_1;
        private string _serviceProfileId;

        /// <summary>
        /// Gets and sets the property AbpV1_0_x. 
        /// <para>
        /// LoRaWAN object for create APIs
        /// </para>
        /// </summary>
        public AbpV1_0_x AbpV1_0_x
        {
            get { return this._abpV1_0_x; }
            set { this._abpV1_0_x = value; }
        }

        // Check to see if AbpV1_0_x property is set
        internal bool IsSetAbpV1_0_x()
        {
            return this._abpV1_0_x != null;
        }

        /// <summary>
        /// Gets and sets the property AbpV1_1. 
        /// <para>
        /// ABP device object for create APIs for v1.1
        /// </para>
        /// </summary>
        public AbpV1_1 AbpV1_1
        {
            get { return this._abpV1_1; }
            set { this._abpV1_1 = value; }
        }

        // Check to see if AbpV1_1 property is set
        internal bool IsSetAbpV1_1()
        {
            return this._abpV1_1 != null;
        }

        /// <summary>
        /// Gets and sets the property DevEui. 
        /// <para>
        /// The DevEUI value.
        /// </para>
        /// </summary>
        public string DevEui
        {
            get { return this._devEui; }
            set { this._devEui = value; }
        }

        // Check to see if DevEui property is set
        internal bool IsSetDevEui()
        {
            return this._devEui != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceProfileId. 
        /// <para>
        /// The ID of the device profile for the new wireless device.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DeviceProfileId
        {
            get { return this._deviceProfileId; }
            set { this._deviceProfileId = value; }
        }

        // Check to see if DeviceProfileId property is set
        internal bool IsSetDeviceProfileId()
        {
            return this._deviceProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property FPorts.
        /// </summary>
        public FPorts FPorts
        {
            get { return this._fPorts; }
            set { this._fPorts = value; }
        }

        // Check to see if FPorts property is set
        internal bool IsSetFPorts()
        {
            return this._fPorts != null;
        }

        /// <summary>
        /// Gets and sets the property OtaaV1_0_x. 
        /// <para>
        /// OTAA device object for create APIs for v1.0.x
        /// </para>
        /// </summary>
        public OtaaV1_0_x OtaaV1_0_x
        {
            get { return this._otaaV1_0_x; }
            set { this._otaaV1_0_x = value; }
        }

        // Check to see if OtaaV1_0_x property is set
        internal bool IsSetOtaaV1_0_x()
        {
            return this._otaaV1_0_x != null;
        }

        /// <summary>
        /// Gets and sets the property OtaaV1_1. 
        /// <para>
        /// OTAA device object for v1.1 for create APIs
        /// </para>
        /// </summary>
        public OtaaV1_1 OtaaV1_1
        {
            get { return this._otaaV1_1; }
            set { this._otaaV1_1 = value; }
        }

        // Check to see if OtaaV1_1 property is set
        internal bool IsSetOtaaV1_1()
        {
            return this._otaaV1_1 != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceProfileId. 
        /// <para>
        /// The ID of the service profile.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ServiceProfileId
        {
            get { return this._serviceProfileId; }
            set { this._serviceProfileId = value; }
        }

        // Check to see if ServiceProfileId property is set
        internal bool IsSetServiceProfileId()
        {
            return this._serviceProfileId != null;
        }

    }
}