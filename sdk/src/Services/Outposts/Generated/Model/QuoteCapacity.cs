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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// A capacity requirement for a quote. Specifies the type of capacity, the unit, and
    /// the quantity.
    /// </summary>
    public partial class QuoteCapacity
    {
        private float? _quantity;
        private QuoteCapacityType _quoteCapacityType;
        private string _unit;

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The quantity of the specified capacity unit. For Amazon EC2, this is the number of
        /// additional instances to add to the Outpost. For Amazon EBS and Amazon S3, this is
        /// the total desired end-state capacity of the Outpost.
        /// </para>
        /// </summary>
        public float? Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QuoteCapacityType. 
        /// <para>
        /// The type of capacity. Valid values are <c>EC2</c>, <c>EBS</c>, and <c>S3</c>.
        /// </para>
        /// </summary>
        public QuoteCapacityType QuoteCapacityType
        {
            get { return this._quoteCapacityType; }
            set { this._quoteCapacityType = value; }
        }

        // Check to see if QuoteCapacityType property is set
        internal bool IsSetQuoteCapacityType()
        {
            return this._quoteCapacityType != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measurement for the capacity. For Amazon EC2, this is the instance type
        /// (for example, <c>c5.24xlarge</c>). For Amazon EBS and Amazon S3, this is the storage
        /// unit (for example, <c>TiB</c> for tebibytes).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}