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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// The toll price.
    /// </summary>
    public partial class RouteTollPrice
    {
        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// Currency code corresponding to the price. This is the same as Currency specified in
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 3)]
        public string Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property Estimate. 
        /// <para>
        /// If the price is an estimate or an exact value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public bool? Estimate { get; set; }

        /// <summary>
        /// Checks to see if the Estimate property is set.
        /// </summary>
        internal bool IsSetEstimate() => this.Estimate.HasValue;

        /// <summary>
        /// Gets and sets the property PerDuration. 
        /// <para>
        /// Duration for which the price corresponds to.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? PerDuration { get; set; }

        /// <summary>
        /// Checks to see if the PerDuration property is set.
        /// </summary>
        internal bool IsSetPerDuration() => this.PerDuration.HasValue;

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// If the price is a range or an exact value. If any of the toll fares making up the
        /// route is a range, the overall price is also a range.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public bool? Range { get; set; }

        /// <summary>
        /// Checks to see if the Range property is set.
        /// </summary>
        internal bool IsSetRange() => this.Range.HasValue;

        /// <summary>
        /// Gets and sets the property RangeValue. 
        /// <para>
        /// Price range with a minimum and maximum value, if a range.
        /// </para>
        /// </summary>
        public RouteTollPriceValueRange RangeValue { get; set; }

        /// <summary>
        /// Checks to see if the RangeValue property is set.
        /// </summary>
        internal bool IsSetRangeValue() => this.RangeValue != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Exact price, if not a range.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0)]
        public double? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
