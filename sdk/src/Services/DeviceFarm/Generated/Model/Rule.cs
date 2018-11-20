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
    /// Represents a condition for a device pool.
    /// </summary>
    public partial class Rule
    {
        private DeviceAttribute _attribute;
        private RuleOperator _operator;
        private string _value;

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The rule's stringified attribute. For example, specify the value as <code>"\"abc\""</code>.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ARN: The ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FORM_FACTOR: The form factor (for example, phone or tablet).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MANUFACTURER: The manufacturer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PLATFORM: The platform (for example, Android or iOS).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REMOTE_ACCESS_ENABLED: Whether the device is enabled for remote access.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_VERSION: The Appium version for the test.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE_ARN: The Amazon Resource Name (ARN) of the device instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE_LABELS: The label of the device instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeviceAttribute Attribute
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
        /// The rule's operator.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// EQUALS: The equals operator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GREATER_THAN: The greater-than operator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IN: The in operator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LESS_THAN: The less-than operator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NOT_IN: The not-in operator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CONTAINS: The contains operator.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The rule's value.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}