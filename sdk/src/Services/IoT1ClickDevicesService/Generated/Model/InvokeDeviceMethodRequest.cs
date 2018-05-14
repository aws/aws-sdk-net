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
    /// Container for the parameters to the InvokeDeviceMethod operation.
    /// Given a device ID, issues a request to invoke a named device method (with possible
    /// parameters). See the "Example POST" code snippet below.
    /// </summary>
    public partial class InvokeDeviceMethodRequest : AmazonIoT1ClickDevicesServiceRequest
    {
        private string _deviceId;
        private DeviceMethod _deviceMethod;
        private string _deviceMethodParameters;

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
        /// Gets and sets the property DeviceMethod. 
        /// <para>
        /// The device method to invoke.
        /// </para>
        /// </summary>
        public DeviceMethod DeviceMethod
        {
            get { return this._deviceMethod; }
            set { this._deviceMethod = value; }
        }

        // Check to see if DeviceMethod property is set
        internal bool IsSetDeviceMethod()
        {
            return this._deviceMethod != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceMethodParameters. 
        /// <para>
        /// A JSON encoded string containing the device method request parameters.
        /// </para>
        /// </summary>
        public string DeviceMethodParameters
        {
            get { return this._deviceMethodParameters; }
            set { this._deviceMethodParameters = value; }
        }

        // Check to see if DeviceMethodParameters property is set
        internal bool IsSetDeviceMethodParameters()
        {
            return this._deviceMethodParameters != null;
        }

    }
}