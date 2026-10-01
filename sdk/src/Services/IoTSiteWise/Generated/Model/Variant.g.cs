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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains an asset property value (of a single type only).
    /// </summary>
    public partial class Variant
    {
        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// Asset property data of type Boolean (true or false).
        /// </para>
        /// </summary>
        public bool? BooleanValue { get; set; }

        /// <summary>
        /// Checks to see if the BooleanValue property is set.
        /// </summary>
        internal bool IsSetBooleanValue() => this.BooleanValue.HasValue;

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        ///  Asset property data of type double (floating point number). The min value is -10^10.
        /// The max value is 10^10. Double.NaN is allowed. 
        /// </para>
        /// </summary>
        public double? DoubleValue { get; set; }

        /// <summary>
        /// Checks to see if the DoubleValue property is set.
        /// </summary>
        internal bool IsSetDoubleValue() => this.DoubleValue.HasValue;

        /// <summary>
        /// Gets and sets the property IntegerValue. 
        /// <para>
        /// Asset property data of type integer (whole number).
        /// </para>
        /// </summary>
        public int? IntegerValue { get; set; }

        /// <summary>
        /// Checks to see if the IntegerValue property is set.
        /// </summary>
        internal bool IsSetIntegerValue() => this.IntegerValue.HasValue;

        /// <summary>
        /// Gets and sets the property NullValue. 
        /// <para>
        /// The type of null asset property data with BAD and UNCERTAIN qualities.
        /// </para>
        /// </summary>
        public PropertyValueNullValue NullValue { get; set; }

        /// <summary>
        /// Checks to see if the NullValue property is set.
        /// </summary>
        internal bool IsSetNullValue() => this.NullValue != null;

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        ///  Asset property data of type string (sequence of characters). The allowed pattern:
        /// "^$|[^\u0000-\u001F\u007F]+". The max length is 1024. 
        /// </para>
        /// </summary>
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}
