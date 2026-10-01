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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// An object that contains information about a value for a time series property.
    /// </summary>
    public partial class PropertyValue
    {
        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// ISO8601 DateTime of a value for a time series property.
        /// </para>
        ///  
        /// <para>
        /// The time for when the property value was recorded in ISO 8601 format: <i>YYYY-MM-DDThh:mm:ss[.SSSSSSSSS][Z/±HH:mm]</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>[YYYY]</i>: year
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>[MM]</i>: month
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>[DD]</i>: day
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>[hh]</i>: hour
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>[mm]</i>: minute
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>[ss]</i>: seconds
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>[.SSSSSSSSS]</i>: additional precision, where precedence is maintained. For example:
        /// [.573123] is equal to 573123000 nanoseconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Z</i>: default timezone UTC
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>± HH:mm</i>: time zone offset in Hours and Minutes.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <i>Required sub-fields</i>: YYYY-MM-DDThh:mm:ss and [Z/±HH:mm]
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 35)]
        public string Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of a value for a time series property.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated and will throw an error in the future. Use time instead.")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// An object that specifies a value for a time series property.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
