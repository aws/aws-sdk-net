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
    /// A container of data for all resource types.
    /// </summary>
    public partial class ResourceDataContainer
    {
        private LocalDeviceResourceData _localDeviceResourceData;
        private LocalVolumeResourceData _localVolumeResourceData;

        /// <summary>
        /// Gets and sets the property LocalDeviceResourceData. Attributes that define the Local
        /// Device Resource.
        /// </summary>
        public LocalDeviceResourceData LocalDeviceResourceData
        {
            get { return this._localDeviceResourceData; }
            set { this._localDeviceResourceData = value; }
        }

        // Check to see if LocalDeviceResourceData property is set
        internal bool IsSetLocalDeviceResourceData()
        {
            return this._localDeviceResourceData != null;
        }

        /// <summary>
        /// Gets and sets the property LocalVolumeResourceData. Attributes that define the Local
        /// Volume Resource.
        /// </summary>
        public LocalVolumeResourceData LocalVolumeResourceData
        {
            get { return this._localVolumeResourceData; }
            set { this._localVolumeResourceData = value; }
        }

        // Check to see if LocalVolumeResourceData property is set
        internal bool IsSetLocalVolumeResourceData()
        {
            return this._localVolumeResourceData != null;
        }

    }
}