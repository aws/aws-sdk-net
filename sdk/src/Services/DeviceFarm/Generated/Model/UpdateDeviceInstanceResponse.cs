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
    /// This is the response object from the UpdateDeviceInstance operation.
    /// </summary>
    public partial class UpdateDeviceInstanceResponse : AmazonWebServiceResponse
    {
        private DeviceInstance _deviceInstance;

        /// <summary>
        /// Gets and sets the property DeviceInstance. 
        /// <para>
        /// An object containing information about your device instance.
        /// </para>
        /// </summary>
        public DeviceInstance DeviceInstance
        {
            get { return this._deviceInstance; }
            set { this._deviceInstance = value; }
        }

        // Check to see if DeviceInstance property is set
        internal bool IsSetDeviceInstance()
        {
            return this._deviceInstance != null;
        }

    }
}