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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The customized parameter values.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class CustomParameterValues
    {
        private List<DateTime> _dateTimeValues = new List<DateTime>();
        private List<double> _decimalValues = new List<double>();
        private List<long> _integerValues = new List<long>();
        private List<string> _stringValues = new List<string>();

        /// <summary>
        /// Gets and sets the property DateTimeValues. 
        /// <para>
        /// A list of datetime-type parameter values.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50000)]
        public List<DateTime> DateTimeValues
        {
            get { return this._dateTimeValues; }
            set { this._dateTimeValues = value; }
        }

        // Check to see if DateTimeValues property is set
        internal bool IsSetDateTimeValues()
        {
            return this._dateTimeValues != null && this._dateTimeValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DecimalValues. 
        /// <para>
        /// A list of decimal-type parameter values.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50000)]
        public List<double> DecimalValues
        {
            get { return this._decimalValues; }
            set { this._decimalValues = value; }
        }

        // Check to see if DecimalValues property is set
        internal bool IsSetDecimalValues()
        {
            return this._decimalValues != null && this._decimalValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IntegerValues. 
        /// <para>
        /// A list of integer-type parameter values.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50000)]
        public List<long> IntegerValues
        {
            get { return this._integerValues; }
            set { this._integerValues = value; }
        }

        // Check to see if IntegerValues property is set
        internal bool IsSetIntegerValues()
        {
            return this._integerValues != null && this._integerValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StringValues. 
        /// <para>
        /// A list of string-type parameter values.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50000)]
        public List<string> StringValues
        {
            get { return this._stringValues; }
            set { this._stringValues = value; }
        }

        // Check to see if StringValues property is set
        internal bool IsSetStringValues()
        {
            return this._stringValues != null && this._stringValues.Count > 0; 
        }

    }
}