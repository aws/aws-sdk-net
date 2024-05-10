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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// A single product view aggregation value/count pair, containing metadata about each
    /// product to which the calling user has access.
    /// </summary>
    public partial class ProductViewAggregationValue
    {
        private int? _approximateCount;
        private string _value;

        /// <summary>
        /// Gets and sets the property ApproximateCount. 
        /// <para>
        /// An approximate count of the products that match the value.
        /// </para>
        /// </summary>
        public int? ApproximateCount
        {
            get { return this._approximateCount; }
            set { this._approximateCount = value; }
        }

        // Check to see if ApproximateCount property is set
        internal bool IsSetApproximateCount()
        {
            return this._approximateCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the product view aggregation.
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