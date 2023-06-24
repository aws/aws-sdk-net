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
    /// Formatting configuration for <code>DateTime</code> fields.
    /// </summary>
    public partial class DateTimeFormatConfiguration
    {
        private string _dateTimeFormat;
        private NullValueFormatConfiguration _nullValueFormatConfiguration;
        private NumericFormatConfiguration _numericFormatConfiguration;

        /// <summary>
        /// Gets and sets the property DateTimeFormat. 
        /// <para>
        /// Determines the <code>DateTime</code> format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DateTimeFormat
        {
            get { return this._dateTimeFormat; }
            set { this._dateTimeFormat = value; }
        }

        // Check to see if DateTimeFormat property is set
        internal bool IsSetDateTimeFormat()
        {
            return this._dateTimeFormat != null;
        }

        /// <summary>
        /// Gets and sets the property NullValueFormatConfiguration. 
        /// <para>
        /// The options that determine the null value format configuration.
        /// </para>
        /// </summary>
        public NullValueFormatConfiguration NullValueFormatConfiguration
        {
            get { return this._nullValueFormatConfiguration; }
            set { this._nullValueFormatConfiguration = value; }
        }

        // Check to see if NullValueFormatConfiguration property is set
        internal bool IsSetNullValueFormatConfiguration()
        {
            return this._nullValueFormatConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NumericFormatConfiguration. 
        /// <para>
        /// The formatting configuration for numeric <code>DateTime</code> fields.
        /// </para>
        /// </summary>
        public NumericFormatConfiguration NumericFormatConfiguration
        {
            get { return this._numericFormatConfiguration; }
            set { this._numericFormatConfiguration = value; }
        }

        // Check to see if NumericFormatConfiguration property is set
        internal bool IsSetNumericFormatConfiguration()
        {
            return this._numericFormatConfiguration != null;
        }

    }
}