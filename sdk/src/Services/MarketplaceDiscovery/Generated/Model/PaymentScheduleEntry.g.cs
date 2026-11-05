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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A single installment entry in the renewal payment schedule.
    /// </summary>
    public partial class PaymentScheduleEntry
    {
        /// <summary>
        /// Gets and sets the property ChargeDateOffset. 
        /// <para>
        /// The relative offset from the renewal agreement start date when this installment is
        /// due, represented in ISO 8601 duration format (for example, P1M or P30D).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string ChargeDateOffset { get; set; }

        /// <summary>
        /// Checks to see if the ChargeDateOffset property is set.
        /// </summary>
        internal bool IsSetChargeDateOffset() => this.ChargeDateOffset != null;

        /// <summary>
        /// Gets and sets the property ChargePercentage. 
        /// <para>
        /// The percentage of the increased Total Contract Value (TCV) to charge in this installment.
        /// All entries in a schedule sum to 100.00.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string ChargePercentage { get; set; }

        /// <summary>
        /// Checks to see if the ChargePercentage property is set.
        /// </summary>
        internal bool IsSetChargePercentage() => this.ChargePercentage != null;

        /// <summary>
        /// Gets and sets the property DayOfMonth. 
        /// <para>
        /// The optional calendar day of month on which the charge occurs. When absent, the charge
        /// day is derived from <c>chargeDateOffset</c>. For months with fewer days than the specified
        /// day, the charge occurs on the last day of the month. For example, if <c>dayOfMonth</c>
        /// is 31, the charge in April occurs on April 30.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 31)]
        public int? DayOfMonth { get; set; }

        /// <summary>
        /// Checks to see if the DayOfMonth property is set.
        /// </summary>
        internal bool IsSetDayOfMonth() => this.DayOfMonth.HasValue;
    }
}
