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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The relative time period over which data is included in the aggregation.
    /// </summary>
    public partial class Range
    {
        private string _timestampFormat;
        private string _timestampSource;
        private Unit _unit;
        private int? _value;
        private ValueRange _valueRange;

        /// <summary>
        /// Gets and sets the property TimestampFormat. 
        /// <para>
        /// The format the timestamp field in your JSON object is specified. This value should
        /// be one of EPOCHMILLI (for Unix epoch timestamps with second/millisecond level precision)
        /// or ISO_8601 (following ISO_8601 format with second/millisecond level precision, with
        /// an optional offset of Z or in the format HH:MM or HHMM.). E.g. if your object type
        /// is MyType and source JSON is {"generatedAt": {"timestamp": "2001-07-04T12:08:56.235-0700"}},
        /// then TimestampFormat should be "ISO_8601".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TimestampFormat
        {
            get { return this._timestampFormat; }
            set { this._timestampFormat = value; }
        }

        // Check to see if TimestampFormat property is set
        internal bool IsSetTimestampFormat()
        {
            return this._timestampFormat != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampSource. 
        /// <para>
        /// An expression specifying the field in your JSON object from which the date should
        /// be parsed. The expression should follow the structure of \"{ObjectTypeName.&lt;Location
        /// of timestamp field in JSON pointer format&gt;}\". E.g. if your object type is MyType
        /// and source JSON is {"generatedAt": {"timestamp": "1737587945945"}}, then TimestampSource
        /// should be "{MyType.generatedAt.timestamp}".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TimestampSource
        {
            get { return this._timestampSource; }
            set { this._timestampSource = value; }
        }

        // Check to see if TimestampSource property is set
        internal bool IsSetTimestampSource()
        {
            return this._timestampSource != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of time.
        /// </para>
        /// </summary>
        public Unit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The amount of time of the specified unit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValueRange. 
        /// <para>
        /// A structure letting customers specify a relative time window over which over which
        /// data is included in the Calculated Attribute. Use positive numbers to indicate that
        /// the endpoint is in the past, and negative numbers to indicate it is in the future.
        /// ValueRange overrides Value.
        /// </para>
        /// </summary>
        public ValueRange ValueRange
        {
            get { return this._valueRange; }
            set { this._valueRange = value; }
        }

        // Check to see if ValueRange property is set
        internal bool IsSetValueRange()
        {
            return this._valueRange != null;
        }

    }
}