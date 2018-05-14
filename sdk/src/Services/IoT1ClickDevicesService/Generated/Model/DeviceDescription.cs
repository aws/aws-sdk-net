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
 * Do not modify this file. This file is generated from the iot1click-devices-2018-05-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT1ClickDevicesService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DeviceDescription
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _deviceId;
        private bool? _enabled;
        private double? _remainingLife;
        private string _type;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// An array of zero or more elements of DeviceAttribute objects providing user specified
        /// device attributes.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The unique identifier of the device.
        /// </para>
        /// </summary>
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// A Boolean value indicating whether or not the device is enabled.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemainingLife. 
        /// <para>
        /// A value between 0 and 1 inclusive, representing the fraction of life remaining for
        /// the device.
        /// </para>
        /// </summary>
        public double RemainingLife
        {
            get { return this._remainingLife.GetValueOrDefault(); }
            set { this._remainingLife = value; }
        }

        // Check to see if RemainingLife property is set
        internal bool IsSetRemainingLife()
        {
            return this._remainingLife.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the device, such as "button".
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}