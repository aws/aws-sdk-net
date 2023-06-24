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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Defines the modifications that you are making to an attribute for a what-if forecast.
    /// For example, you can use this operation to create a what-if forecast that investigates
    /// a 10% off sale on all shoes. To do this, you specify <code>"AttributeName": "shoes"</code>,
    /// <code>"Operation": "MULTIPLY"</code>, and <code>"Value": "0.90"</code>. Pair this
    /// operation with the <a>TimeSeriesCondition</a> operation within the <a>CreateWhatIfForecastRequest$TimeSeriesTransformations</a>
    /// operation to define a subset of attribute items that are modified.
    /// </summary>
    public partial class Action
    {
        private string _attributeName;
        private Operation _operation;
        private double? _value;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The related time series that you are modifying. This value is case insensitive.
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
        /// Gets and sets the property Operation. 
        /// <para>
        /// The operation that is applied to the provided attribute. Operations include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ADD</code> - adds <code>Value</code> to all rows of <code>AttributeName</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUBTRACT</code> - subtracts <code>Value</code> from all rows of <code>AttributeName</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MULTIPLY</code> - multiplies all rows of <code>AttributeName</code> by <code>Value</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DIVIDE</code> - divides all rows of <code>AttributeName</code> by <code>Value</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Operation Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value that is applied for the chosen <code>Operation</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}