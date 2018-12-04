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
    /// Represents the device filters used in a test run as well as the maximum number of
    /// devices to be included in the run. It is passed in as the deviceSelectionConfiguration
    /// request parameter in <a>ScheduleRun</a>.
    /// </summary>
    public partial class DeviceSelectionConfiguration
    {
        private List<DeviceFilter> _filters = new List<DeviceFilter>();
        private int? _maxDevices;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Used to dynamically select a set of devices for a test run. A filter is made up of
        /// an attribute, an operator, and one or more values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Attribute: The aspect of a device such as platform or model used as the selection
        /// criteria in a device filter.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ARN: The Amazon Resource Name (ARN) of the device. For example, "arn:aws:devicefarm:us-west-2::device:12345Example".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PLATFORM: The device platform. Valid values are "ANDROID" or "IOS".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OS_VERSION: The operating system version. For example, "10.3.2".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MODEL: The device model. For example, "iPad 5th Gen".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AVAILABILITY: The current availability of the device. Valid values are "AVAILABLE",
        /// "HIGHLY_AVAILABLE", "BUSY", or "TEMPORARY_NOT_AVAILABLE".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FORM_FACTOR: The device form factor. Valid values are "PHONE" or "TABLET".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MANUFACTURER: The device manufacturer. For example, "Apple".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REMOTE_ACCESS_ENABLED: Whether the device is enabled for remote access.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REMOTE_DEBUG_ENABLED: Whether the device is enabled for remote debugging.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE_ARN: The Amazon Resource Name (ARN) of the device instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE_LABELS: The label of the device instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_TYPE: The fleet type. Valid values are "PUBLIC" or "PRIVATE".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Operator: The filter operator.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The EQUALS operator is available for every attribute except INSTANCE_LABELS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The CONTAINS operator is available for the INSTANCE_LABELS and MODEL attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IN and NOT_IN operators are available for the ARN, OS_VERSION, MODEL, MANUFACTURER,
        /// and INSTANCE_ARN attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The LESS_THAN, GREATER_THAN, LESS_THAN_OR_EQUALS, and GREATER_THAN_OR_EQUALS operators
        /// are also available for the OS_VERSION attribute.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Values: An array of one or more filter values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The IN and NOT operators can take a values array that has more than one element.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The other operators require an array with a single element.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In a request, the AVAILABILITY attribute takes "AVAILABLE", "HIGHLY_AVAILABLE", "BUSY",
        /// or "TEMPORARY_NOT_AVAILABLE" as values.
        /// </para>
        ///  </li> </ul> </li> </ul>
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
        /// Gets and sets the property MaxDevices. 
        /// <para>
        /// The maximum number of devices to be included in a test run.
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