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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Aggregation for attributes.
    /// </summary>
    public partial class AttributeAggregationFunction
    {
        private SimpleAttributeAggregationFunction _simpleAttributeAggregation;
        private string _valueForMultipleValues;

        /// <summary>
        /// Gets and sets the property SimpleAttributeAggregation. 
        /// <para>
        /// The built-in aggregation functions for attributes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>UNIQUE_VALUE</c>: Returns the unique value for a field, aggregated by the dimension
        /// fields.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SimpleAttributeAggregationFunction SimpleAttributeAggregation
        {
            get { return this._simpleAttributeAggregation; }
            set { this._simpleAttributeAggregation = value; }
        }

        // Check to see if SimpleAttributeAggregation property is set
        internal bool IsSetSimpleAttributeAggregation()
        {
            return this._simpleAttributeAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property ValueForMultipleValues. 
        /// <para>
        /// Used by the <c>UNIQUE_VALUE</c> aggregation function. If there are multiple values
        /// for the field used by the aggregation, the value for this property will be returned
        /// instead. Defaults to '*'.
        /// </para>
        /// </summary>
        public string ValueForMultipleValues
        {
            get { return this._valueForMultipleValues; }
            set { this._valueForMultipleValues = value; }
        }

        // Check to see if ValueForMultipleValues property is set
        internal bool IsSetValueForMultipleValues()
        {
            return this._valueForMultipleValues != null;
        }

    }
}