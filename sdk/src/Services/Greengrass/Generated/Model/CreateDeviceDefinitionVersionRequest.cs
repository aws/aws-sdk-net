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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeviceDefinitionVersion operation.
    /// Creates a version of a device definition that has already been defined.
    /// </summary>
    public partial class CreateDeviceDefinitionVersionRequest : AmazonGreengrassRequest
    {
        private string _amznClientToken;
        private string _deviceDefinitionId;
        private List<Device> _devices = new List<Device>();

        /// <summary>
        /// Gets and sets the property AmznClientToken. The client token used to request idempotent
        /// operations.
        /// </summary>
        public string AmznClientToken
        {
            get { return this._amznClientToken; }
            set { this._amznClientToken = value; }
        }

        // Check to see if AmznClientToken property is set
        internal bool IsSetAmznClientToken()
        {
            return this._amznClientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceDefinitionId. device definition Id
        /// </summary>
        public string DeviceDefinitionId
        {
            get { return this._deviceDefinitionId; }
            set { this._deviceDefinitionId = value; }
        }

        // Check to see if DeviceDefinitionId property is set
        internal bool IsSetDeviceDefinitionId()
        {
            return this._deviceDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property Devices. Devices in the definition version.
        /// </summary>
        public List<Device> Devices
        {
            get { return this._devices; }
            set { this._devices = value; }
        }

        // Check to see if Devices property is set
        internal bool IsSetDevices()
        {
            return this._devices != null && this._devices.Count > 0; 
        }

    }
}