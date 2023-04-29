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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// An estimate that's associated with a time period.
    /// </summary>
    public partial class EstimateByTime
    {
        private Currency _currency;
        private PricingUnit _pricingUnit;
        private TimePeriod _timePeriod;
        private double? _unit;
        private double? _usageCost;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency of the estimate in USD.
        /// </para>
        /// </summary>
        public Currency Currency
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
        /// Gets and sets the property PricingUnit. 
        /// <para>
        /// The unit of measurement that's used for the cost estimate.
        /// </para>
        /// </summary>
        public PricingUnit PricingUnit
        {
            get { return this._pricingUnit; }
            set { this._pricingUnit = value; }
        }

        // Check to see if PricingUnit property is set
        internal bool IsSetPricingUnit()
        {
            return this._pricingUnit != null;
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The period of time, in days, that an estimate covers. The period has a start date
        /// and an end date. The start date must come before the end date.
        /// </para>
        /// </summary>
        public TimePeriod TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The number of pricing units used to calculate the total number of hours. For example,
        /// 1 unit equals 1 hour.
        /// </para>
        /// </summary>
        public double Unit
        {
            get { return this._unit.GetValueOrDefault(); }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsageCost. 
        /// <para>
        /// The amount of cost or usage that's measured for the cost estimate.
        /// </para>
        /// </summary>
        public double UsageCost
        {
            get { return this._usageCost.GetValueOrDefault(); }
            set { this._usageCost = value; }
        }

        // Check to see if UsageCost property is set
        internal bool IsSetUsageCost()
        {
            return this._usageCost.HasValue; 
        }

    }
}