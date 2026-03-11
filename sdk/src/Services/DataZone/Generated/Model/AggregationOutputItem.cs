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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// An aggregation output item.
    /// </summary>
    public partial class AggregationOutputItem
    {
        private int? _count;
        private string _displayValue;
        private string _value;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The count of the aggregation output item.
        /// </para>
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayValue. 
        /// <para>
        /// The display value of the aggregation. If the attribute being aggregated corresponds
        /// to the id of a public resource, the service automatically resolves the id to the provided
        /// display value.
        /// </para>
        /// </summary>
        public string DisplayValue
        {
            get { return this._displayValue; }
            set { this._displayValue = value; }
        }

        // Check to see if DisplayValue property is set
        internal bool IsSetDisplayValue()
        {
            return this._displayValue != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The attribute value of the aggregation output item.
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