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
    /// Contains the run results requested by the device selection configuration as well as
    /// how many devices were returned. For an example of the JSON response syntax, see <a>ScheduleRun</a>.
    /// </summary>
    public partial class DeviceSelectionResult
    {
        private List<DeviceFilter> _filters = new List<DeviceFilter>();
        private int? _matchedDevicesCount;
        private int? _maxDevices;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters in a device selection result.
        /// </para>
        /// </summary>
        public List<DeviceFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MatchedDevicesCount. 
        /// <para>
        /// The number of devices that matched the device filter selection criteria.
        /// </para>
        /// </summary>
        public int MatchedDevicesCount
        {
            get { return this._matchedDevicesCount.GetValueOrDefault(); }
            set { this._matchedDevicesCount = value; }
        }

        // Check to see if MatchedDevicesCount property is set
        internal bool IsSetMatchedDevicesCount()
        {
            return this._matchedDevicesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxDevices. 
        /// <para>
        /// The maximum number of devices to be selected by a device filter and included in a
        /// test run.
        /// </para>
        /// </summary>
        public int MaxDevices
        {
            get { return this._maxDevices.GetValueOrDefault(); }
            set { this._maxDevices = value; }
        }

        // Check to see if MaxDevices property is set
        internal bool IsSetMaxDevices()
        {
            return this._maxDevices.HasValue; 
        }

    }
}