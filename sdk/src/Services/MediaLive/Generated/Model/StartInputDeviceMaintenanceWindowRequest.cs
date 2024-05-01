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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the StartInputDeviceMaintenanceWindow operation.
    /// Start a maintenance window for the specified input device. Starting a maintenance
    /// window will give the device up to two hours to install software. If the device was
    /// streaming prior to the maintenance, it will resume streaming when the software is
    /// fully installed. Devices automatically install updates while they are powered on and
    /// their MediaLive channels are stopped. A maintenance window allows you to update a
    /// device without having to stop MediaLive channels that use the device. The device must
    /// remain powered on and connected to the internet for the duration of the maintenance.
    /// </summary>
    public partial class StartInputDeviceMaintenanceWindowRequest : AmazonMediaLiveRequest
    {
        private string _inputDeviceId;

        /// <summary>
        /// Gets and sets the property InputDeviceId. The unique ID of the input device to start
        /// a maintenance window for. For example, hd-123456789abcdef.
        /// </summary>
        [AWSProperty(Required=true)]
        public string InputDeviceId
        {
            get { return this._inputDeviceId; }
            set { this._inputDeviceId = value; }
        }

        // Check to see if InputDeviceId property is set
        internal bool IsSetInputDeviceId()
        {
            return this._inputDeviceId != null;
        }

    }
}