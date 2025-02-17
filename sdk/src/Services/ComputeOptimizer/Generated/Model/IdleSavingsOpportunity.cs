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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the savings opportunity for idle resource recommendations.
    /// </summary>
    public partial class IdleSavingsOpportunity
    {
        private IdleEstimatedMonthlySavings _estimatedMonthlySavings;
        private double? _savingsOpportunityPercentage;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings. 
        /// <para>
        /// The estimated monthly savings possible by adopting Compute Optimizer's idle resource
        /// recommendations.
        /// </para>
        /// </summary>
        public IdleEstimatedMonthlySavings EstimatedMonthlySavings
        {
            get { return this._estimatedMonthlySavings; }
            set { this._estimatedMonthlySavings = value; }
        }

        // Check to see if EstimatedMonthlySavings property is set
        internal bool IsSetEstimatedMonthlySavings()
        {
            return this._estimatedMonthlySavings != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsOpportunityPercentage. 
        /// <para>
        /// The estimated monthly savings possible as a percentage of monthly cost by adopting
        /// Compute Optimizer's idle resource recommendations.
        /// </para>
        /// </summary>
        public double SavingsOpportunityPercentage
        {
            get { return this._savingsOpportunityPercentage.GetValueOrDefault(); }
            set { this._savingsOpportunityPercentage = value; }
        }

        // Check to see if SavingsOpportunityPercentage property is set
        internal bool IsSetSavingsOpportunityPercentage()
        {
            return this._savingsOpportunityPercentage.HasValue; 
        }

    }
}