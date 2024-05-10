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
        /// The rule's stringified attribute. For example, specify the value as <c>"\"abc\""</c>.
        /// </para>
        ///  
        /// <para>
        /// The supported operators for each attribute are provided in the following list.
        /// </para>
        ///  <dl> <dt>APPIUM_VERSION</dt> <dd> 
        /// <para>
        /// The Appium version for the test.
        /// </para>
        ///  
        /// <para>
        /// Supported operators: <c>CONTAINS</c> 
        /// </para>
        ///  </dd> <dt>ARN</dt> <dd> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device (for example, <c>arn:aws:devicefarm:us-west-2::device:12345Example</c>.
        /// </para>
        ///  
        /// <para>
        /// Supported operators: <c>EQUALS</c>, <c>IN</c>, <c>NOT_IN</c> 
        /// </para>
        ///  </dd> <dt>AVAILABILITY</dt> <dd> 
        /// <para>
        /// The current availability of the device. Valid values are AVAILABLE, HIGHLY_AVAILABLE,
        /// BUSY, or TEMPORARY_NOT_AVAILABLE.
        /// </para>
        ///  
        /// <para>
        /// Supported operators: <c>EQUALS</c> 
        /// </para>
        ///  </dd> <dt>FLEET_TYPE</dt> <dd> 
        /// <para>
        /// The fleet type. Valid values are PUBLIC or PRIVATE.
        /// </para>
        ///  
        /// <para>
        /// Supported operators: <c>EQUALS</c> 
        /// </para>
        ///  </dd> <dt>FORM_FACTOR</dt> <dd> 
        /// <para>
        /// The device form factor. Valid values are PHONE or TABLET.
        /// </para>
        ///  
        /// <para>
        /// Supported operators: <c>EQUALS</c>, <c>IN</c>, <c>NOT_IN</c> 
        /// </para>
        ///  </dd> <dt>INSTANCE_ARN</dt> <dd> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device instance.
        /// </para>
        ///  
        /// <para>
        /// Supported operators: <c>IN</c>, <c>NOT_IN</c> 
        /// </para>
        ///  </dd> <dt>INSTANCE_LABELS</dt> <dd> 
        /// <para>
        /// The label of the device instance.
        /// </para>
        ///  
        /// <para>
        /// Supported operators: <c>CONTAINS</c> 
        /// </para>
        ///  </dd> <dt>MANUFACTURER</dt> <dd> 
        /// <para>
        /// The device manufacturer (for example, Apple).
        /// </para>
        ///  
        /// <para>
        /// Supported operators: <c>EQUALS</c>, <c>IN</c>, <c>NOT_IN</c> 
        /// </para>
        ///  </dd> <dt>MODEL</dt> <dd> 
        /// <para>
        /// The device model, such as Apple iPad Air 2 or Google Pixel.
        /// </para>
        ///  
        /// <para>
        /// Supported operators: <c>CONTAINS</c>, <c>EQUALS</c>, <c>IN</c>, <c>NOT_IN</c> 
        /// </para>
        ///  </dd> <dt>OS_VERSION</dt> <dd> 
        /// <para>
        /// The operating system version (for example, 10.3.2).
        /// </para>
        ///  
        /// <para>
        /// Supported operators: <c>EQUALS</c>, <c>GREATER_THAN</c>, <c>GREATER_THAN_OR_EQUALS</c>,
        /// <c>IN</c>, <c>LESS_THAN</c>, <c>LESS_THAN_OR_EQUALS</c>, <c>NOT_IN</c> 
        /// </para>
        ///  </dd> <dt>PLATFORM</dt> <dd> 
        /// <para>
        /// The device platform. Valid values are ANDROID or IOS.
        /// </para>
        ///  
        /// <para>
        /// Supported operators: <c>EQUALS</c>, <c>IN</c>, <c>NOT_IN</c> 
        /// </para>
        ///  </dd> <dt>REMOTE_ACCESS_ENABLED</dt> <dd> 
        /// <para>
        /// Whether the device is enabled for remote access. Valid values are TRUE or FALSE.
        /// </para>
        ///  
        /// <para>
        /// Supported operators: <c>EQUALS</c> 
        /// </para>
        ///  </dd> <dt>REMOTE_DEBUG_ENABLED</dt> <dd> 
        /// <para>
        /// Whether the device is enabled for remote debugging. Valid values are TRUE or FALSE.
        /// </para>
        ///  
        /// <para>
        /// Supported operators: <c>EQUALS</c> 
        /// </para>
        ///  
        /// <para>
        /// Because remote debugging is <a href="https://docs.aws.amazon.com/devicefarm/latest/developerguide/history.html">no
        /// longer supported</a>, this filter is ignored.
        /// </para>
        ///  </dd> </dl>
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
        /// Specifies how Device Farm compares the rule's attribute to the value. For the operators
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