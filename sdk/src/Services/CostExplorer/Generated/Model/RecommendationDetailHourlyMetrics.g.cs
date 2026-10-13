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
    /// Contains the hourly metrics for the given recommendation over the lookback period.
    /// </summary>
    public partial class RecommendationDetailHourlyMetrics
    {
        /// <summary>
        /// Gets and sets the property CurrentCoverage. 
        /// <para>
        /// The current amount of Savings Plans eligible usage that the Savings Plan covered.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CurrentCoverage { get; set; }

        /// <summary>
        /// Checks to see if the CurrentCoverage property is set.
        /// </summary>
        internal bool IsSetCurrentCoverage() => this.CurrentCoverage != null;

        /// <summary>
        /// Gets and sets the property EstimatedCoverage. 
        /// <para>
        /// The estimated coverage amount based on the recommended Savings Plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedCoverage { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedCoverage property is set.
        /// </summary>
        internal bool IsSetEstimatedCoverage() => this.EstimatedCoverage != null;

        /// <summary>
        /// Gets and sets the property EstimatedNewCommitmentUtilization. 
        /// <para>
        /// The estimated utilization for the recommended Savings Plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedNewCommitmentUtilization { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedNewCommitmentUtilization property is set.
        /// </summary>
        internal bool IsSetEstimatedNewCommitmentUtilization() => this.EstimatedNewCommitmentUtilization != null;

        /// <summary>
        /// Gets and sets the property EstimatedOnDemandCost. 
        /// <para>
        /// The remaining On-Demand cost estimated to not be covered by the recommended Savings
        /// Plan, over the length of the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedOnDemandCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedOnDemandCost property is set.
        /// </summary>
        internal bool IsSetEstimatedOnDemandCost() => this.EstimatedOnDemandCost != null;

        /// <summary>
        /// Gets and sets the property StartTime.
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;
    }
}
