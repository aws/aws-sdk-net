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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The amortized amount of Savings Plans purchased in a specific account during a specific
    /// time interval.
    /// </summary>
    public partial class SavingsPlansAmortizedCommitment
    {
        /// <summary>
        /// Gets and sets the property AmortizedRecurringCommitment. 
        /// <para>
        /// The amortized amount of your Savings Plans commitment that was purchased with either
        /// a <c>Partial</c> or a <c>NoUpfront</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AmortizedRecurringCommitment { get; set; }

        /// <summary>
        /// Checks to see if the AmortizedRecurringCommitment property is set.
        /// </summary>
        internal bool IsSetAmortizedRecurringCommitment() => this.AmortizedRecurringCommitment != null;

        /// <summary>
        /// Gets and sets the property AmortizedUpfrontCommitment. 
        /// <para>
        /// The amortized amount of your Savings Plans commitment that was purchased with an <c>Upfront</c>
        /// or <c>PartialUpfront</c> Savings Plans.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AmortizedUpfrontCommitment { get; set; }

        /// <summary>
        /// Checks to see if the AmortizedUpfrontCommitment property is set.
        /// </summary>
        internal bool IsSetAmortizedUpfrontCommitment() => this.AmortizedUpfrontCommitment != null;

        /// <summary>
        /// Gets and sets the property TotalAmortizedCommitment. 
        /// <para>
        /// The total amortized amount of your Savings Plans commitment, regardless of your Savings
        /// Plans purchase method. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TotalAmortizedCommitment { get; set; }

        /// <summary>
        /// Checks to see if the TotalAmortizedCommitment property is set.
        /// </summary>
        internal bool IsSetTotalAmortizedCommitment() => this.TotalAmortizedCommitment != null;
    }
}
