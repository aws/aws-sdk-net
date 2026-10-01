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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// A tier-level charge within a Business Support pricing plan. Business Support uses
    /// tiered pricing where different percentage rates apply to different ranges of Support-eligible
    /// spend.
    /// </summary>
    public partial class BusinessSupportTierCharge
    {
        private DateTime? _chargePeriodEndDate;
        private DateTime? _chargePeriodStartDate;
        private string _tierCharge;
        private string _tierDescription;
        private string _tierRate;
        private string _usageSlice;

        /// <summary>
        /// Gets and sets the property ChargePeriodEndDate. 
        /// <para>
        /// The end date of the charge period for this tier charge.
        /// </para>
        /// </summary>
        public DateTime? ChargePeriodEndDate
        {
            get { return this._chargePeriodEndDate; }
            set { this._chargePeriodEndDate = value; }
        }

        // Check to see if ChargePeriodEndDate property is set
        internal bool IsSetChargePeriodEndDate()
        {
            return this._chargePeriodEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChargePeriodStartDate. 
        /// <para>
        /// The start date of the charge period for this tier charge.
        /// </para>
        /// </summary>
        public DateTime? ChargePeriodStartDate
        {
            get { return this._chargePeriodStartDate; }
            set { this._chargePeriodStartDate = value; }
        }

        // Check to see if ChargePeriodStartDate property is set
        internal bool IsSetChargePeriodStartDate()
        {
            return this._chargePeriodStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TierCharge. 
        /// <para>
        /// The Business Support charge amount calculated for this pricing tier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TierCharge
        {
            get { return this._tierCharge; }
            set { this._tierCharge = value; }
        }

        // Check to see if TierCharge property is set
        internal bool IsSetTierCharge()
        {
            return this._tierCharge != null;
        }

        /// <summary>
        /// Gets and sets the property TierDescription. 
        /// <para>
        /// A human-readable description of the pricing tier, including the spend range and percentage
        /// rate applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TierDescription
        {
            get { return this._tierDescription; }
            set { this._tierDescription = value; }
        }

        // Check to see if TierDescription property is set
        internal bool IsSetTierDescription()
        {
            return this._tierDescription != null;
        }

        /// <summary>
        /// Gets and sets the property TierRate. 
        /// <para>
        /// The percentage rate applied to Support-eligible spend within this pricing tier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TierRate
        {
            get { return this._tierRate; }
            set { this._tierRate = value; }
        }

        // Check to see if TierRate property is set
        internal bool IsSetTierRate()
        {
            return this._tierRate != null;
        }

        /// <summary>
        /// Gets and sets the property UsageSlice. 
        /// <para>
        /// The amount of Support-eligible spend that falls within this pricing tier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UsageSlice
        {
            get { return this._usageSlice; }
            set { this._usageSlice = value; }
        }

        // Check to see if UsageSlice property is set
        internal bool IsSetUsageSlice()
        {
            return this._usageSlice != null;
        }

    }
}