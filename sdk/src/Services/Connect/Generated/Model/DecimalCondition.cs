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
    /// A decimal search condition for Search APIs.
    /// </summary>
    public partial class DecimalCondition
    {
        private DecimalComparisonType _comparisonType;
        private string _fieldName;
        private double? _maxValue;
        private double? _minValue;

        /// <summary>
        /// Gets and sets the property ComparisonType. 
        /// <para>
        /// The type of comparison to be made when evaluating the decimal condition.
        /// </para>
        /// </summary>
        public DecimalComparisonType ComparisonType
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
        /// A name of the decimal property to be searched.
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
        /// A maximum value of the decimal property.
        /// </para>
        /// </summary>
        public double MaxValue
        {
            get { return this._maxValue.GetValueOrDefault(); }
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
        /// A minimum value of the decimal property.
        /// </para>
        /// </summary>
        public double MinValue
        {
            get { return this._minValue.GetValueOrDefault(); }
            set { this._minValue = value; }
        }

        // Check to see if MinValue property is set
        internal bool IsSetMinValue()
        {
            return this._minValue.HasValue; 
        }

    }
}