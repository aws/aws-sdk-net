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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// A tier-level charge within a Business Support pricing plan. Business Support uses
    /// tiered pricing where different percentage rates apply to different ranges of Support-eligible
    /// spend.
    /// </summary>
    public partial class BusinessSupportTierCharge
    {
        /// <summary>
        /// Gets and sets the property ChargePeriodEndDate. 
        /// <para>
        /// The end date of the charge period for this tier charge.
        /// </para>
        /// </summary>
        public DateTime? ChargePeriodEndDate { get; set; }

        /// <summary>
        /// Checks to see if the ChargePeriodEndDate property is set.
        /// </summary>
        internal bool IsSetChargePeriodEndDate() => this.ChargePeriodEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property ChargePeriodStartDate. 
        /// <para>
        /// The start date of the charge period for this tier charge.
        /// </para>
        /// </summary>
        public DateTime? ChargePeriodStartDate { get; set; }

        /// <summary>
        /// Checks to see if the ChargePeriodStartDate property is set.
        /// </summary>
        internal bool IsSetChargePeriodStartDate() => this.ChargePeriodStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property TierCharge. 
        /// <para>
        /// The Business Support charge amount calculated for this pricing tier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TierCharge { get; set; }

        /// <summary>
        /// Checks to see if the TierCharge property is set.
        /// </summary>
        internal bool IsSetTierCharge() => this.TierCharge != null;

        /// <summary>
        /// Gets and sets the property TierDescription. 
        /// <para>
        /// A human-readable description of the pricing tier, including the spend range and percentage
        /// rate applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TierDescription { get; set; }

        /// <summary>
        /// Checks to see if the TierDescription property is set.
        /// </summary>
        internal bool IsSetTierDescription() => this.TierDescription != null;

        /// <summary>
        /// Gets and sets the property TierRate. 
        /// <para>
        /// The percentage rate applied to Support-eligible spend within this pricing tier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TierRate { get; set; }

        /// <summary>
        /// Checks to see if the TierRate property is set.
        /// </summary>
        internal bool IsSetTierRate() => this.TierRate != null;

        /// <summary>
        /// Gets and sets the property UsageSlice. 
        /// <para>
        /// The amount of Support-eligible spend that falls within this pricing tier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UsageSlice { get; set; }

        /// <summary>
        /// Checks to see if the UsageSlice property is set.
        /// </summary>
        internal bool IsSetUsageSlice() => this.UsageSlice != null;
    }
}
