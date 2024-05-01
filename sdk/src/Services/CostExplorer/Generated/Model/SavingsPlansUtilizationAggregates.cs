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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
    /// The aggregated utilization metrics for your Savings Plans usage.
    /// </summary>
    public partial class SavingsPlansUtilizationAggregates
    {
        private SavingsPlansAmortizedCommitment _amortizedCommitment;
        private SavingsPlansSavings _savings;
        private SavingsPlansUtilization _utilization;

        /// <summary>
        /// Gets and sets the property AmortizedCommitment. 
        /// <para>
        /// The total amortized commitment for a Savings Plans. This includes the sum of the upfront
        /// and recurring Savings Plans fees.
        /// </para>
        /// </summary>
        public SavingsPlansAmortizedCommitment AmortizedCommitment
        {
            get { return this._amortizedCommitment; }
            set { this._amortizedCommitment = value; }
        }

        // Check to see if AmortizedCommitment property is set
        internal bool IsSetAmortizedCommitment()
        {
            return this._amortizedCommitment != null;
        }

        /// <summary>
        /// Gets and sets the property Savings. 
        /// <para>
        /// The amount that's saved by using existing Savings Plans. Savings returns both net
        /// savings from Savings Plans and also the <c>onDemandCostEquivalent</c> of the Savings
        /// Plans when considering the utilization rate.
        /// </para>
        /// </summary>
        public SavingsPlansSavings Savings
        {
            get { return this._savings; }
            set { this._savings = value; }
        }

        // Check to see if Savings property is set
        internal bool IsSetSavings()
        {
            return this._savings != null;
        }

        /// <summary>
        /// Gets and sets the property Utilization. 
        /// <para>
        /// A ratio of your effectiveness of using existing Savings Plans to apply to workloads
        /// that are Savings Plans eligible.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SavingsPlansUtilization Utilization
        {
            get { return this._utilization; }
            set { this._utilization = value; }
        }

        // Check to see if Utilization property is set
        internal bool IsSetUtilization()
        {
            return this._utilization != null;
        }

    }
}