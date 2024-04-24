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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Creates a subset of items within an attribute that are modified. For example, you
    /// can use this operation to create a subset of items that cost $5 or less. To do this,
    /// you specify <c>"AttributeName": "price"</c>, <c>"AttributeValue": "5"</c>, and <c>"Condition":
    /// "LESS_THAN"</c>. Pair this operation with the <a>Action</a> operation within the <a>CreateWhatIfForecastRequest$TimeSeriesTransformations</a>
    /// operation to define how the attribute is modified.
    /// </summary>
    public partial class TimeSeriesCondition
    {
        private string _attributeName;
        private string _attributeValue;
        private Condition _condition;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The item_id, dimension name, IM name, or timestamp that you are modifying.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// The value that is applied for the chosen <c>Condition</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string AttributeValue
        {
            get { return this._attributeValue; }
            set { this._attributeValue = value; }
        }

        // Check to see if AttributeValue property is set
        internal bool IsSetAttributeValue()
        {
            return this._attributeValue != null;
        }

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The condition to apply. Valid values are <c>EQUALS</c>, <c>NOT_EQUALS</c>, <c>LESS_THAN</c>
        /// and <c>GREATER_THAN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Condition Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

    }
}