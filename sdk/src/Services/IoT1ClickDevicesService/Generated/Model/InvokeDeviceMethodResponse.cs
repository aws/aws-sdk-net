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
    /// This is the response object from the InvokeDeviceMethod operation.
    /// </summary>
    public partial class InvokeDeviceMethodResponse : AmazonWebServiceResponse
    {
        private string _deviceMethodResponse;

        /// <summary>
        /// Gets and sets the property DeviceMethodResponse. 
        /// <para>
        /// A JSON encoded string containing the device method response.
        /// </para>
        /// </summary>
        public string DeviceMethodResponse
        {
            get { return this._deviceMethodResponse; }
            set { this._deviceMethodResponse = value; }
        }

        // Check to see if DeviceMethodResponse property is set
        internal bool IsSetDeviceMethodResponse()
        {
            return this._deviceMethodResponse != null;
        }

    }
}