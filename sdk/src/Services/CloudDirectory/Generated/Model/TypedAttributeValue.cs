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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Represents the data for a typed attribute. You can set one, and only one, of the elements.
    /// Each attribute in an item is a name-value pair. Attributes have a single value.
    /// </summary>
    public partial class TypedAttributeValue
    {
        private MemoryStream _binaryValue;
        private bool? _booleanValue;
        private DateTime? _datetimeValue;
        private string _numberValue;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property BinaryValue. 
        /// <para>
        /// A binary data value.
        /// </para>
        /// </summary>
        public MemoryStream BinaryValue
        {
            get { return this._binaryValue; }
            set { this._binaryValue = value; }
        }

        // Check to see if BinaryValue property is set
        internal bool IsSetBinaryValue()
        {
            return this._binaryValue != null;
        }

        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// A Boolean data value.
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
        /// Gets and sets the property DatetimeValue. 
        /// <para>
        /// A date and time value.
        /// </para>
        /// </summary>
        public DateTime? DatetimeValue
        {
            get { return this._datetimeValue; }
            set { this._datetimeValue = value; }
        }

        // Check to see if DatetimeValue property is set
        internal bool IsSetDatetimeValue()
        {
            return this._datetimeValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberValue. 
        /// <para>
        /// A number data value.
        /// </para>
        /// </summary>
        public string NumberValue
        {
            get { return this._numberValue; }
            set { this._numberValue = value; }
        }

        // Check to see if NumberValue property is set
        internal bool IsSetNumberValue()
        {
            return this._numberValue != null;
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A string data value.
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