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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Status of devices.
    /// </summary>
    public partial class DeviceStats
    {
        private long? _connectedDeviceCount;
        private long? _registeredDeviceCount;

        /// <summary>
        /// Gets and sets the property ConnectedDeviceCount. 
        /// <para>
        /// The number of devices connected with a heartbeat.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? ConnectedDeviceCount
        {
            get { return this._connectedDeviceCount; }
            set { this._connectedDeviceCount = value; }
        }

        // Check to see if ConnectedDeviceCount property is set
        internal bool IsSetConnectedDeviceCount()
        {
            return this._connectedDeviceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegisteredDeviceCount. 
        /// <para>
        /// The number of registered devices.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? RegisteredDeviceCount
        {
            get { return this._registeredDeviceCount; }
            set { this._registeredDeviceCount = value; }
        }

        // Check to see if RegisteredDeviceCount property is set
        internal bool IsSetRegisteredDeviceCount()
        {
            return this._registeredDeviceCount.HasValue; 
        }

    }
}