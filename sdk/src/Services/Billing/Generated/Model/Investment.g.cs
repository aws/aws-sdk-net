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
    /// An investment within an investment summary. This is a union in which exactly one member
    /// is set. The <c>milestoneBasedInvestment</c> member represents a fixed, scheduled investment.
    /// The <c>outcomeBasedInvestment</c> member represents an attestable investment awarded
    /// upon completion of a defined outcome. Check which member is present to determine the
    /// investment type.
    /// </summary>
    public partial class Investment
    {
        /// <summary>
        /// Gets and sets the property MilestoneBasedInvestment. 
        /// <para>
        /// An investment with a fixed value that is disbursed on a schedule. This member is set
        /// for a milestone-based investment and corresponds to the <c>MILESTONE_BASED</c> investment
        /// type.
        /// </para>
        /// </summary>
        public MilestoneBasedInvestment MilestoneBasedInvestment { get; set; }

        /// <summary>
        /// Checks to see if the MilestoneBasedInvestment property is set.
        /// </summary>
        internal bool IsSetMilestoneBasedInvestment() => this.MilestoneBasedInvestment != null;

        /// <summary>
        /// Gets and sets the property OutcomeBasedInvestment. 
        /// <para>
        /// An investment that is awarded upon completion of a defined outcome. This member is
        /// set for an outcome-based (attestable) investment and corresponds to the <c>OUTCOME_BASED</c>
        /// investment type.
        /// </para>
        /// </summary>
        public OutcomeBasedInvestment OutcomeBasedInvestment { get; set; }

        /// <summary>
        /// Checks to see if the OutcomeBasedInvestment property is set.
        /// </summary>
        internal bool IsSetOutcomeBasedInvestment() => this.OutcomeBasedInvestment != null;
    }
}
