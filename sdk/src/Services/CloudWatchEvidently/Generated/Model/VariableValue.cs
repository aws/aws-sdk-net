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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// The value assigned to a feature variation. This structure must contain exactly one
    /// field. It can be <c>boolValue</c>, <c>doubleValue</c>, <c>longValue</c>, or <c>stringValue</c>.
    /// </summary>
    public partial class VariableValue
    {
        private bool? _boolValue;
        private double? _doubleValue;
        private long? _longValue;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property BoolValue. 
        /// <para>
        /// If this feature uses the Boolean variation type, this field contains the Boolean value
        /// of this variation.
        /// </para>
        /// </summary>
        public bool? BoolValue
        {
            get { return this._boolValue; }
            set { this._boolValue = value; }
        }

        // Check to see if BoolValue property is set
        internal bool IsSetBoolValue()
        {
            return this._boolValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// If this feature uses the double integer variation type, this field contains the double
        /// integer value of this variation.
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
        /// Gets and sets the property LongValue. 
        /// <para>
        /// If this feature uses the long variation type, this field contains the long value of
        /// this variation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-9007199254740991, Max=9007199254740991)]
        public long? LongValue
        {
            get { return this._longValue; }
            set { this._longValue = value; }
        }

        // Check to see if LongValue property is set
        internal bool IsSetLongValue()
        {
            return this._longValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// If this feature uses the string variation type, this field contains the string value
        /// of this variation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
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