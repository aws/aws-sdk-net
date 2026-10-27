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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A summary of AI bot monetization revenue, including total revenue, revenue by verification
    /// tier, and request counts.
    /// </summary>
    public partial class RevenueBreakdown
    {
        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency of the revenue amounts.
        /// </para>
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property TotalAmount. 
        /// <para>
        /// The total revenue amount in the specified currency.
        /// </para>
        /// </summary>
        public string TotalAmount { get; set; }

        /// <summary>
        /// Checks to see if the TotalAmount property is set.
        /// </summary>
        internal bool IsSetTotalAmount() => this.TotalAmount != null;

        /// <summary>
        /// Gets and sets the property TotalMonetizeServed. 
        /// <para>
        /// The total number of HTTP 402 Payment Required responses served to AI agents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalMonetizeServed { get; set; }

        /// <summary>
        /// Checks to see if the TotalMonetizeServed property is set.
        /// </summary>
        internal bool IsSetTotalMonetizeServed() => this.TotalMonetizeServed.HasValue;

        /// <summary>
        /// Gets and sets the property TotalSettled. 
        /// <para>
        /// The total number of successfully settled payment transactions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalSettled { get; set; }

        /// <summary>
        /// Checks to see if the TotalSettled property is set.
        /// </summary>
        internal bool IsSetTotalSettled() => this.TotalSettled.HasValue;

        /// <summary>
        /// Gets and sets the property UnverifiedAmount. 
        /// <para>
        /// The revenue amount from unverified AI bots.
        /// </para>
        /// </summary>
        public string UnverifiedAmount { get; set; }

        /// <summary>
        /// Checks to see if the UnverifiedAmount property is set.
        /// </summary>
        internal bool IsSetUnverifiedAmount() => this.UnverifiedAmount != null;

        /// <summary>
        /// Gets and sets the property VerifiedAmount. 
        /// <para>
        /// The revenue amount from verified AI bots.
        /// </para>
        /// </summary>
        public string VerifiedAmount { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAmount property is set.
        /// </summary>
        internal bool IsSetVerifiedAmount() => this.VerifiedAmount != null;
    }
}
