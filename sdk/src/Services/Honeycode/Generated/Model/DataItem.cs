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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// The data in a particular data cell defined on the screen.
    /// </summary>
    public partial class DataItem
    {
        private string _formattedValue;
        private Format _overrideFormat;
        private string _rawValue;

        /// <summary>
        /// Gets and sets the property FormattedValue. 
        /// <para>
        /// The formatted value of the data. e.g. John Smith.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string FormattedValue
        {
            get { return this._formattedValue; }
            set { this._formattedValue = value; }
        }

        // Check to see if FormattedValue property is set
        internal bool IsSetFormattedValue()
        {
            return this._formattedValue != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideFormat. 
        /// <para>
        ///  The overrideFormat is optional and is specified only if a particular row of data
        /// has a different format for the data than the default format defined on the screen
        /// or the table. 
        /// </para>
        /// </summary>
        public Format OverrideFormat
        {
            get { return this._overrideFormat; }
            set { this._overrideFormat = value; }
        }

        // Check to see if OverrideFormat property is set
        internal bool IsSetOverrideFormat()
        {
            return this._overrideFormat != null;
        }

        /// <summary>
        /// Gets and sets the property RawValue. 
        /// <para>
        /// The raw value of the data. e.g. jsmith@example.com
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32767)]
        public string RawValue
        {
            get { return this._rawValue; }
            set { this._rawValue = value; }
        }

        // Check to see if RawValue property is set
        internal bool IsSetRawValue()
        {
            return this._rawValue != null;
        }

    }
}