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
    /// Represents a device filter used to select a set of devices to be included in a test
    /// run. This data structure is passed in as the <code>deviceSelectionConfiguration</code>
    /// parameter to ScheduleRun. For an example of the JSON request syntax, see <a>ScheduleRun</a>.
    /// 
    ///  
    /// <para>
    /// It is also passed in as the <code>filters</code> parameter to ListDevices. For an
    /// example of the JSON request syntax, see <a>ListDevices</a>.
    /// </para>
    /// </summary>
    public partial class DeviceFilter
    {
        private DeviceFilterAttribute _attribute;
        private RuleOperator _operator;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The aspect of a device such as platform or model used as the selection criteria in
        /// a device filter.
        /// </para>
        ///  
        /// <para>
        /// The supported operators for each attribute are provided in the following list.
        /// </para>
        ///  <dl> <dt>ARN</dt> <dd> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device. For example, "arn:aws:devicefarm:us-west-2::device:12345Example".
        /// </para>
        ///  
        /// <para>
        ///  <i>Supported operators</i>: <code>EQUALS</code>, <code>IN</code>, <code>NOT_IN</code>
        /// 
        /// </para>
        ///  </dd> <dt>PLATFORM</dt> <dd> 
        /// <para>
        /// The device platform. Valid values are "ANDROID" or "IOS".
        /// </para>
        ///  
        /// <para>
        ///  <i>Supported operators</i>: <code>EQUALS</code> 
        /// </para>
        ///  </dd> <dt>OS_VERSION</dt> <dd> 
        /// <para>
        /// The operating system version. For example, "10.3.2".
        /// </para>
        ///  
        /// <para>
        ///  <i>Supported operators</i>: <code>EQUALS</code>, <code>GREATER_THAN</code>, <code>GREATER_THAN_OR_EQUALS</code>,
        /// <code>IN</code>, <code>LESS_THAN</code>, <code>LESS_THAN_OR_EQUALS</code>, <code>NOT_IN</code>
        /// 
        /// </para>
        ///  </dd> <dt>MODEL</dt> <dd> 
        /// <para>
        /// The device model. For example, "iPad 5th Gen".
        /// </para>
        ///  
        /// <para>
        ///  <i>Supported operators</i>: <code>CONTAINS</code>, <code>EQUALS</code>, <code>IN</code>,
        /// <code>NOT_IN</code> 
        /// </para>
        ///  </dd> <dt>AVAILABILITY</dt> <dd> 
        /// <para>
        /// The current availability of the device. Valid values are "AVAILABLE", "HIGHLY_AVAILABLE",
        /// "BUSY", or "TEMPORARY_NOT_AVAILABLE".
        /// </para>
        ///  
        /// <para>
        ///  <i>Supported operators</i>: <code>EQUALS</code> 
        /// </para>
        ///  </dd> <dt>FORM_FACTOR</dt> <dd> 
        /// <para>
        /// The device form factor. Valid values are "PHONE" or "TABLET".
        /// </para>
        ///  
        /// <para>
        ///  <i>Supported operators</i>: <code>EQUALS</code> 
        /// </para>
        ///  </dd> <dt>MANUFACTURER</dt> <dd> 
        /// <para>
        /// The device manufacturer. For example, "Apple".
        /// </para>
        ///  
        /// <para>
        ///  <i>Supported operators</i>: <code>EQUALS</code>, <code>IN</code>, <code>NOT_IN</code>
        /// 
        /// </para>
        ///  </dd> <dt>REMOTE_ACCESS_ENABLED</dt> <dd> 
        /// <para>
        /// Whether the device is enabled for remote access. Valid values are "TRUE" or "FALSE".
        /// </para>
        ///  
        /// <para>
        ///  <i>Supported operators</i>: <code>EQUALS</code> 
        /// </para>
        ///  </dd> <dt>REMOTE_DEBUG_ENABLED</dt> <dd> 
        /// <para>
        /// Whether the device is enabled for remote debugging. Valid values are "TRUE" or "FALSE".
        /// </para>
        ///  
        /// <para>
        ///  <i>Supported operators</i>: <code>EQUALS</code> 
        /// </para>
        ///  </dd> <dt>INSTANCE_ARN</dt> <dd> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device instance.
        /// </para>
        ///  
        /// <para>
        ///  <i>Supported operators</i>: <code>EQUALS</code>, <code>IN</code>, <code>NOT_IN</code>
        /// 
        /// </para>
        ///  </dd> <dt>INSTANCE_LABELS</dt> <dd> 
        /// <para>
        /// The label of the device instance.
        /// </para>
        ///  
        /// <para>
        ///  <i>Supported operators</i>: <code>CONTAINS</code> 
        /// </para>
        ///  </dd> <dt>FLEET_TYPE</dt> <dd> 
        /// <para>
        /// The fleet type. Valid values are "PUBLIC" or "PRIVATE".
        /// </para>
        ///  
        /// <para>
        ///  <i>Supported operators</i>: <code>EQUALS</code> 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public DeviceFilterAttribute Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// Specifies how Device Farm compares the filter's attribute to the value. For the operators
        /// that are supported by each attribute, see the attribute descriptions.
        /// </para>
        /// </summary>
        public RuleOperator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// An array of one or more filter values used in a device filter.
        /// </para>
        ///  <p class="title"> <b>Operator Values</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The IN and NOT_IN operators can take a values array that has more than one element.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The other operators require an array with a single element.
        /// </para>
        ///  </li> </ul> <p class="title"> <b>Attribute Values</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The PLATFORM attribute can be set to "ANDROID" or "IOS".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The AVAILABILITY attribute can be set to "AVAILABLE", "HIGHLY_AVAILABLE", "BUSY",
        /// or "TEMPORARY_NOT_AVAILABLE".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The FORM_FACTOR attribute can be set to "PHONE" or "TABLET".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The FLEET_TYPE attribute can be set to "PUBLIC" or "PRIVATE".
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}