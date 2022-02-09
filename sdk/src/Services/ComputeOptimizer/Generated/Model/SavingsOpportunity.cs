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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the savings opportunity for recommendations of a given resource type or
    /// for the recommendation option of an individual resource.
    /// 
    ///  
    /// <para>
    /// Savings opportunity represents the estimated monthly savings you can achieve by implementing
    /// a given Compute Optimizer recommendation.
    /// </para>
    ///  <important> 
    /// <para>
    /// Savings opportunity data requires that you opt in to Cost Explorer, as well as activate
    /// <b>Receive Amazon EC2 resource recommendations</b> in the Cost Explorer preferences
    /// page. That creates a connection between Cost Explorer and Compute Optimizer. With
    /// this connection, Cost Explorer generates savings estimates considering the price of
    /// existing resources, the price of recommended resources, and historical usage data.
    /// Estimated monthly savings reflects the projected dollar savings associated with each
    /// of the recommendations generated. For more information, see <a href="https://docs.aws.amazon.com/cost-management/latest/userguide/ce-enable.html">Enabling
    /// Cost Explorer</a> and <a href="https://docs.aws.amazon.com/cost-management/latest/userguide/ce-rightsizing.html">Optimizing
    /// your cost with Rightsizing Recommendations</a> in the <i>Cost Management User Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class SavingsOpportunity
    {
        private EstimatedMonthlySavings _estimatedMonthlySavings;
        private double? _savingsOpportunityPercentage;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings. 
        /// <para>
        /// An object that describes the estimated monthly savings amount possible, based on On-Demand
        /// instance pricing, by adopting Compute Optimizer recommendations for a given resource.
        /// </para>
        /// </summary>
        public EstimatedMonthlySavings EstimatedMonthlySavings
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
        /// Compute Optimizer recommendations for a given resource.
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