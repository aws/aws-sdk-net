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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// A single installment in a payment schedule template. Because the start date of the
    /// renewed agreement isn't known when the offer is created, the charge date of each installment
    /// is expressed as an offset from that start date rather than as an absolute date.
    /// </summary>
    public partial class PaymentScheduleEntry
    {
        private string _chargeDateOffset;
        private string _chargePercentage;
        private int? _dayOfMonth;

        /// <summary>
        /// Gets and sets the property ChargeDateOffset. 
        /// <para>
        /// The time between the start date of the renewed agreement and the date this installment
        /// is charged. The duration is represented in the ISO 8601 format in either whole months
        /// or whole days (for example, <c>P1M</c> for 1 month or <c>P30D</c> for 30 days). All
        /// installments in a schedule use the same unit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=6)]
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
        /// The percentage of the total contract value of the renewed agreement that is charged
        /// in this installment. Valid values range from <c>0.01</c> to <c>100.00</c>, with up
        /// to two decimal places.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
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
        /// The day of the month on which this installment is charged, from <c>1</c> to <c>31</c>.
        /// Use this field to anchor the charge to a specific calendar day within the month identified
        /// by <c>ChargeDateOffset</c>. This field is supported only when <c>ChargeDateOffset</c>
        /// is expressed in months.
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