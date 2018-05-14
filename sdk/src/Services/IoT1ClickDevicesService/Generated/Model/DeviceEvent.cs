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
    public partial class DeviceEvent
    {
        private Device _device;
        private string _stdEvent;

        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// An object representing the device associated with the event.
        /// </para>
        /// </summary>
        public Device Device
        {
            get { return this._device; }
            set { this._device = value; }
        }

        // Check to see if Device property is set
        internal bool IsSetDevice()
        {
            return this._device != null;
        }

        /// <summary>
        /// Gets and sets the property StdEvent. 
        /// <para>
        /// A serialized JSON object representing the device-type specific event.
        /// </para>
        /// </summary>
        public string StdEvent
        {
            get { return this._stdEvent; }
            set { this._stdEvent = value; }
        }

        // Check to see if StdEvent property is set
        internal bool IsSetStdEvent()
        {
            return this._stdEvent != null;
        }

    }
}