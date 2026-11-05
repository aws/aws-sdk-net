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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// An estimate that's associated with a time period.
    /// </summary>
    public partial class EstimateByTime
    {
        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency of the estimate in USD.
        /// </para>
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property PricingUnit. 
        /// <para>
        /// The unit of measurement that's used for the cost estimate.
        /// </para>
        /// </summary>
        public PricingUnit PricingUnit { get; set; }

        /// <summary>
        /// Checks to see if the PricingUnit property is set.
        /// </summary>
        internal bool IsSetPricingUnit() => this.PricingUnit != null;

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The period of time, in days, that an estimate covers. The period has a start date
        /// and an end date. The start date must come before the end date.
        /// </para>
        /// </summary>
        public TimePeriod TimePeriod { get; set; }

        /// <summary>
        /// Checks to see if the TimePeriod property is set.
        /// </summary>
        internal bool IsSetTimePeriod() => this.TimePeriod != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The number of pricing units used to calculate the total number of hours. For example,
        /// 1 unit equals 1 hour.
        /// </para>
        /// </summary>
        public double? Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit.HasValue;

        /// <summary>
        /// Gets and sets the property UsageCost. 
        /// <para>
        /// The amount of cost or usage that's measured for the cost estimate.
        /// </para>
        /// </summary>
        public double? UsageCost { get; set; }

        /// <summary>
        /// Checks to see if the UsageCost property is set.
        /// </summary>
        internal bool IsSetUsageCost() => this.UsageCost.HasValue;
    }
}
