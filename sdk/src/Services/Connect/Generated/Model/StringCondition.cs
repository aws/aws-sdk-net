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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// A leaf node condition which can be used to specify a string condition.
    /// </summary>
    public partial class StringCondition
    {
        private StringComparisonType _comparisonType;
        private string _fieldName;
        private string _value;

        /// <summary>
        /// Gets and sets the property ComparisonType. 
        /// <para>
        /// The type of comparison to be made when evaluating the string condition.
        /// </para>
        /// </summary>
        public StringComparisonType ComparisonType
        {
            get { return this._comparisonType; }
            set { this._comparisonType = value; }
        }

        // Check to see if ComparisonType property is set
        internal bool IsSetComparisonType()
        {
            return this._comparisonType != null;
        }

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// The name of the field in the string condition.
        /// </para>
        /// </summary>
        public string FieldName
        {
            get { return this._fieldName; }
            set { this._fieldName = value; }
        }

        // Check to see if FieldName property is set
        internal bool IsSetFieldName()
        {
            return this._fieldName != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the string.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}