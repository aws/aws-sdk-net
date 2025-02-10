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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
        private bool? _booleanValue;
        private double? _doubleValue;
        private int? _integerValue;
        private PropertyValueNullValue _nullValue;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// Asset property data of type Boolean (true or false).
        /// </para>
        /// </summary>
        public bool? BooleanValue
        {
            get { return this._booleanValue; }
            set { this._booleanValue = value; }
        }

        // Check to see if BooleanValue property is set
        internal bool IsSetBooleanValue()
        {
            return this._booleanValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        ///  Asset property data of type double (floating point number). The min value is -10^10.
        /// The max value is 10^10. Double.NaN is allowed. 
        /// </para>
        /// </summary>
        public double? DoubleValue
        {
            get { return this._doubleValue; }
            set { this._doubleValue = value; }
        }

        // Check to see if DoubleValue property is set
        internal bool IsSetDoubleValue()
        {
            return this._doubleValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntegerValue. 
        /// <para>
        /// Asset property data of type integer (whole number).
        /// </para>
        /// </summary>
        public int? IntegerValue
        {
            get { return this._integerValue; }
            set { this._integerValue = value; }
        }

        // Check to see if IntegerValue property is set
        internal bool IsSetIntegerValue()
        {
            return this._integerValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NullValue. 
        /// <para>
        /// The type of null asset property data with BAD and UNCERTAIN qualities.
        /// </para>
        /// </summary>
        public PropertyValueNullValue NullValue
        {
            get { return this._nullValue; }
            set { this._nullValue = value; }
        }

        // Check to see if NullValue property is set
        internal bool IsSetNullValue()
        {
            return this._nullValue != null;
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        ///  Asset property data of type string (sequence of characters). The allowed pattern:
        /// "^$|[^\u0000-\u001F\u007F]+". The max length is 1024. 
        /// </para>
        /// </summary>
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

    }
}