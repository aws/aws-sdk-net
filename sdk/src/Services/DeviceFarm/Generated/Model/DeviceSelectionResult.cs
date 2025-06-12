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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Contains the run results requested by the device selection configuration and how many
    /// devices were returned. For an example of the JSON response syntax, see <a>ScheduleRun</a>.
    /// </summary>
    public partial class DeviceSelectionResult
    {
        private List<DeviceFilter> _filters = AWSConfigs.InitializeCollections ? new List<DeviceFilter>() : null;
        private int? _matchedDevicesCount;
        private int? _maxDevices;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters in a device selection result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeviceFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MatchedDevicesCount. 
        /// <para>
        /// The number of devices that matched the device filter selection criteria.
        /// </para>
        /// </summary>
        public int? MatchedDevicesCount
        {
            get { return this._matchedDevicesCount; }
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
        public int? MaxDevices
        {
            get { return this._maxDevices; }
            set { this._maxDevices = value; }
        }

        // Check to see if MaxDevices property is set
        internal bool IsSetMaxDevices()
        {
            return this._maxDevices.HasValue; 
        }

    }
}