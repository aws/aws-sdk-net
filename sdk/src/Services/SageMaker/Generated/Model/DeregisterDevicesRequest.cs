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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterDevices operation.
    /// Deregisters the specified devices. After you deregister a device, you will need to
    /// re-register the devices.
    /// </summary>
    public partial class DeregisterDevicesRequest : AmazonSageMakerRequest
    {
        private string _deviceFleetName;
        private List<string> _deviceNames = new List<string>();

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// The name of the fleet the devices belong to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string DeviceFleetName
        {
            get { return this._deviceFleetName; }
            set { this._deviceFleetName = value; }
        }

        // Check to see if DeviceFleetName property is set
        internal bool IsSetDeviceFleetName()
        {
            return this._deviceFleetName != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceNames. 
        /// <para>
        /// The unique IDs of the devices.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DeviceNames
        {
            get { return this._deviceNames; }
            set { this._deviceNames = value; }
        }

        // Check to see if DeviceNames property is set
        internal bool IsSetDeviceNames()
        {
            return this._deviceNames != null && this._deviceNames.Count > 0; 
        }

    }
}