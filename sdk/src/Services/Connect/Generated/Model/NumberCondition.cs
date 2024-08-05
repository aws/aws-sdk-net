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
    /// A leaf node condition which can be used to specify a numeric condition.
    /// 
    ///  <note> 
    /// <para>
    /// The currently supported value for <c>FieldName</c> is <c>limit</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class NumberCondition
    {
        private NumberComparisonType _comparisonType;
        private string _fieldName;
        private int? _maxValue;
        private int? _minValue;

        /// <summary>
        /// Gets and sets the property ComparisonType. 
        /// <para>
        /// The type of comparison to be made when evaluating the number condition.
        /// </para>
        /// </summary>
        public NumberComparisonType ComparisonType
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
        /// The name of the field in the number condition.
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
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The maxValue to be used while evaluating the number condition.
        /// </para>
        /// </summary>
        public int? MaxValue
        {
            get { return this._maxValue; }
            set { this._maxValue = value; }
        }

        // Check to see if MaxValue property is set
        internal bool IsSetMaxValue()
        {
            return this._maxValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// The minValue to be used while evaluating the number condition.
        /// </para>
        /// </summary>
        public int? MinValue
        {
            get { return this._minValue; }
            set { this._minValue = value; }
        }

        // Check to see if MinValue property is set
        internal bool IsSetMinValue()
        {
            return this._minValue.HasValue; 
        }

    }
}