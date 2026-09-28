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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Represents the data for a typed attribute. You can set one, and only one, of the elements.
    /// Each attribute in an item is a name-value pair. Attributes have a single value.
    /// </summary>
    public partial class TypedAttributeValue
    {
        /// <summary>
        /// Gets and sets the property BinaryValue. 
        /// <para>
        /// A binary data value.
        /// </para>
        /// </summary>
        public MemoryStream BinaryValue { get; set; }

        /// <summary>
        /// Checks to see if the BinaryValue property is set.
        /// </summary>
        internal bool IsSetBinaryValue() => this.BinaryValue != null;

        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// A Boolean data value.
        /// </para>
        /// </summary>
        public bool? BooleanValue { get; set; }

        /// <summary>
        /// Checks to see if the BooleanValue property is set.
        /// </summary>
        internal bool IsSetBooleanValue() => this.BooleanValue.HasValue;

        /// <summary>
        /// Gets and sets the property DatetimeValue. 
        /// <para>
        /// A date and time value.
        /// </para>
        /// </summary>
        public DateTime? DatetimeValue { get; set; }

        /// <summary>
        /// Checks to see if the DatetimeValue property is set.
        /// </summary>
        internal bool IsSetDatetimeValue() => this.DatetimeValue.HasValue;

        /// <summary>
        /// Gets and sets the property NumberValue. 
        /// <para>
        /// A number data value.
        /// </para>
        /// </summary>
        public string NumberValue { get; set; }

        /// <summary>
        /// Checks to see if the NumberValue property is set.
        /// </summary>
        internal bool IsSetNumberValue() => this.NumberValue != null;

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A string data value.
        /// </para>
        /// </summary>
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}
