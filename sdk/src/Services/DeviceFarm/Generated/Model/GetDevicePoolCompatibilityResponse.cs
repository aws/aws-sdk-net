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
    /// Represents the result of describe device pool compatibility request.
    /// </summary>
    public partial class GetDevicePoolCompatibilityResponse : AmazonWebServiceResponse
    {
        private List<DevicePoolCompatibilityResult> _compatibleDevices = new List<DevicePoolCompatibilityResult>();
        private List<DevicePoolCompatibilityResult> _incompatibleDevices = new List<DevicePoolCompatibilityResult>();

        /// <summary>
        /// Gets and sets the property CompatibleDevices. 
        /// <para>
        /// Information about compatible devices.
        /// </para>
        /// </summary>
        public List<DevicePoolCompatibilityResult> CompatibleDevices
        {
            get { return this._compatibleDevices; }
            set { this._compatibleDevices = value; }
        }

        // Check to see if CompatibleDevices property is set
        internal bool IsSetCompatibleDevices()
        {
            return this._compatibleDevices != null && this._compatibleDevices.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncompatibleDevices. 
        /// <para>
        /// Information about incompatible devices.
        /// </para>
        /// </summary>
        public List<DevicePoolCompatibilityResult> IncompatibleDevices
        {
            get { return this._incompatibleDevices; }
            set { this._incompatibleDevices = value; }
        }

        // Check to see if IncompatibleDevices property is set
        internal bool IsSetIncompatibleDevices()
        {
            return this._incompatibleDevices != null && this._incompatibleDevices.Count > 0; 
        }

    }
}