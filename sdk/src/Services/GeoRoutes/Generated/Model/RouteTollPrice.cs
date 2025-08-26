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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
        private string _currency;
        private bool? _estimate;
        private long? _perDuration;
        private bool? _range;
        private RouteTollPriceValueRange _rangeValue;
        private double? _value;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// Currency code corresponding to the price. This is the same as Currency specified in
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=3)]
        public string Currency
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

        // Check to see if Currency property is set
        internal bool IsSetCurrency()
        {
            return this._currency != null;
        }

        /// <summary>
        /// Gets and sets the property Estimate. 
        /// <para>
        /// If the price is an estimate or an exact value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public bool? Estimate
        {
            get { return this._estimate; }
            set { this._estimate = value; }
        }

        // Check to see if Estimate property is set
        internal bool IsSetEstimate()
        {
            return this._estimate.HasValue; 
        }

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
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? PerDuration
        {
            get { return this._perDuration; }
            set { this._perDuration = value; }
        }

        // Check to see if PerDuration property is set
        internal bool IsSetPerDuration()
        {
            return this._perDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// If the price is a range or an exact value. If any of the toll fares making up the
        /// route is a range, the overall price is also a range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public bool? Range
        {
            get { return this._range; }
            set { this._range = value; }
        }

        // Check to see if Range property is set
        internal bool IsSetRange()
        {
            return this._range.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RangeValue. 
        /// <para>
        /// Price range with a minimum and maximum value, if a range.
        /// </para>
        /// </summary>
        public RouteTollPriceValueRange RangeValue
        {
            get { return this._rangeValue; }
            set { this._rangeValue = value; }
        }

        // Check to see if RangeValue property is set
        internal bool IsSetRangeValue()
        {
            return this._rangeValue != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Exact price, if not a range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0)]
        public double? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}