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
    /// An investment with a fixed value that is disbursed on a schedule. This corresponds
    /// to the <c>MILESTONE_BASED</c> investment type.
    /// </summary>
    public partial class MilestoneBasedInvestment
    {
        /// <summary>
        /// Gets and sets the property InvestmentDisbursedAt. 
        /// <para>
        /// The date on which the investment is disbursed to the investment accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? InvestmentDisbursedAt { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentDisbursedAt property is set.
        /// </summary>
        internal bool IsSetInvestmentDisbursedAt() => this.InvestmentDisbursedAt.HasValue;

        /// <summary>
        /// Gets and sets the property InvestmentId. 
        /// <para>
        /// The identifier of the investment, as returned by <c>ListContractualInvestments</c>.
        /// This value is 1–36 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string InvestmentId { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentId property is set.
        /// </summary>
        internal bool IsSetInvestmentId() => this.InvestmentId != null;

        /// <summary>
        /// Gets and sets the property InvestmentValue. 
        /// <para>
        /// The total value of the investment, including its currency and amount.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amount InvestmentValue { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentValue property is set.
        /// </summary>
        internal bool IsSetInvestmentValue() => this.InvestmentValue != null;
    }
}
