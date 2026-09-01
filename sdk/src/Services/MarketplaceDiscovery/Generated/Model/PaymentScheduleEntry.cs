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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
        private string _chargeDateOffset;
        private string _chargePercentage;
        private int? _dayOfMonth;

        /// <summary>
        /// Gets and sets the property ChargeDateOffset. 
        /// <para>
        /// The relative offset from the renewal agreement start date when this installment is
        /// due, in ISO 8601 duration format. The offset uses months only or days only (for example,
        /// P1M or P30D); mixed units are not supported, and every offset in a schedule uses the
        /// same unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string ChargeDateOffset
        {
            get { return this._chargeDateOffset; }
            set { this._chargeDateOffset = value; }
        }

        // Check to see if ChargeDateOffset property is set
        internal bool IsSetChargeDateOffset()
        {
            return this._chargeDateOffset != null;
        }

        /// <summary>
        /// Gets and sets the property ChargePercentage. 
        /// <para>
        /// The percentage of the increased TCV to charge in this installment. All entries in
        /// a schedule sum to 100.00.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string ChargePercentage
        {
            get { return this._chargePercentage; }
            set { this._chargePercentage = value; }
        }

        // Check to see if ChargePercentage property is set
        internal bool IsSetChargePercentage()
        {
            return this._chargePercentage != null;
        }

        /// <summary>
        /// Gets and sets the property DayOfMonth. 
        /// <para>
        /// The optional calendar day of month on which the charge occurs. When absent, the charge
        /// day is derived from <c>chargeDateOffset</c>, and this field does not apply when <c>chargeDateOffset</c>
        /// is expressed in days. For months with fewer days than the specified day, the charge
        /// occurs on the last day of the month. For example, if <c>dayOfMonth</c> is 31, the
        /// charge in April occurs on April 30.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=31)]
        public int? DayOfMonth
        {
            get { return this._dayOfMonth; }
            set { this._dayOfMonth = value; }
        }

        // Check to see if DayOfMonth property is set
        internal bool IsSetDayOfMonth()
        {
            return this._dayOfMonth.HasValue; 
        }

    }
}