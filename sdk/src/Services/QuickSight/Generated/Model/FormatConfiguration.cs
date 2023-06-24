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
    /// The formatting configuration for all types of field.
    /// </summary>
    public partial class FormatConfiguration
    {
        private DateTimeFormatConfiguration _dateTimeFormatConfiguration;
        private NumberFormatConfiguration _numberFormatConfiguration;
        private StringFormatConfiguration _stringFormatConfiguration;

        /// <summary>
        /// Gets and sets the property DateTimeFormatConfiguration. 
        /// <para>
        /// Formatting configuration for <code>DateTime</code> fields.
        /// </para>
        /// </summary>
        public DateTimeFormatConfiguration DateTimeFormatConfiguration
        {
            get { return this._dateTimeFormatConfiguration; }
            set { this._dateTimeFormatConfiguration = value; }
        }

        // Check to see if DateTimeFormatConfiguration property is set
        internal bool IsSetDateTimeFormatConfiguration()
        {
            return this._dateTimeFormatConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NumberFormatConfiguration. 
        /// <para>
        /// Formatting configuration for number fields.
        /// </para>
        /// </summary>
        public NumberFormatConfiguration NumberFormatConfiguration
        {
            get { return this._numberFormatConfiguration; }
            set { this._numberFormatConfiguration = value; }
        }

        // Check to see if NumberFormatConfiguration property is set
        internal bool IsSetNumberFormatConfiguration()
        {
            return this._numberFormatConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StringFormatConfiguration. 
        /// <para>
        /// Formatting configuration for string fields.
        /// </para>
        /// </summary>
        public StringFormatConfiguration StringFormatConfiguration
        {
            get { return this._stringFormatConfiguration; }
            set { this._stringFormatConfiguration = value; }
        }

        // Check to see if StringFormatConfiguration property is set
        internal bool IsSetStringFormatConfiguration()
        {
            return this._stringFormatConfiguration != null;
        }

    }
}