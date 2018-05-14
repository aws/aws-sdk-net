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
 * Do not modify this file. This file is generated from the iot1click-projects-2018-05-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT1ClickProjects.Model
{
    /// <summary>
    /// An object representing a device for a placement template (see <a>PlacementTemplate</a>).
    /// </summary>
    public partial class DeviceTemplate
    {
        private Dictionary<string, string> _callbackOverrides = new Dictionary<string, string>();
        private string _deviceType;

        /// <summary>
        /// Gets and sets the property CallbackOverrides. 
        /// <para>
        /// An optional Lambda function to invoke instead of the default Lambda function provided
        /// by the placement template.
        /// </para>
        /// </summary>
        public Dictionary<string, string> CallbackOverrides
        {
            get { return this._callbackOverrides; }
            set { this._callbackOverrides = value; }
        }

        // Check to see if CallbackOverrides property is set
        internal bool IsSetCallbackOverrides()
        {
            return this._callbackOverrides != null && this._callbackOverrides.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// The device type, which currently must be <code>"button"</code>.
        /// </para>
        /// </summary>
        public string DeviceType
        {
            get { return this._deviceType; }
            set { this._deviceType = value; }
        }

        // Check to see if DeviceType property is set
        internal bool IsSetDeviceType()
        {
            return this._deviceType != null;
        }

    }
}