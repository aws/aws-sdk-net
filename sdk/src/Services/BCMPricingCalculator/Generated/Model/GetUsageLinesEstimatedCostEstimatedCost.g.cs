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

namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Represents the estimated cost of the usage amount for a usage line.
    /// </summary>
    public partial class GetUsageLinesEstimatedCostEstimatedCost
    {
        /// <summary>
        /// Gets and sets the property Cost. 
        /// <para>
        ///  The estimated cost for the given usage amount. 
        /// </para>
        /// </summary>
        public double? Cost { get; set; }

        /// <summary>
        /// Checks to see if the Cost property is set.
        /// </summary>
        internal bool IsSetCost() => this.Cost.HasValue;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        ///  The currency of the estimated cost. 
        /// </para>
        /// </summary>
        public CurrencyCode Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property UsageAmount. 
        /// <para>
        ///  The usage amount that was priced. 
        /// </para>
        /// </summary>
        public double? UsageAmount { get; set; }

        /// <summary>
        /// Checks to see if the UsageAmount property is set.
        /// </summary>
        internal bool IsSetUsageAmount() => this.UsageAmount.HasValue;

        /// <summary>
        /// Gets and sets the property UsageUnit. 
        /// <para>
        ///  The unit of the usage amount, for example <c>Hrs</c> or <c>GB-Mo</c>. 
        /// </para>
        /// </summary>
        public string UsageUnit { get; set; }

        /// <summary>
        /// Checks to see if the UsageUnit property is set.
        /// </summary>
        internal bool IsSetUsageUnit() => this.UsageUnit != null;
    }
}
