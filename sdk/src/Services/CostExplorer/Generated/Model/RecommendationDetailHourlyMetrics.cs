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
    /// Contains the hourly metrics for the given recommendation over the lookback period.
    /// </summary>
    public partial class RecommendationDetailHourlyMetrics
    {
        private string _currentCoverage;
        private string _estimatedCoverage;
        private string _estimatedNewCommitmentUtilization;
        private string _estimatedOnDemandCost;
        private string _startTime;

        /// <summary>
        /// Gets and sets the property CurrentCoverage. 
        /// <para>
        /// The current amount of Savings Plans eligible usage that the Savings Plan covered.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CurrentCoverage
        {
            get { return this._currentCoverage; }
            set { this._currentCoverage = value; }
        }

        // Check to see if CurrentCoverage property is set
        internal bool IsSetCurrentCoverage()
        {
            return this._currentCoverage != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedCoverage. 
        /// <para>
        /// The estimated coverage amount based on the recommended Savings Plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedCoverage
        {
            get { return this._estimatedCoverage; }
            set { this._estimatedCoverage = value; }
        }

        // Check to see if EstimatedCoverage property is set
        internal bool IsSetEstimatedCoverage()
        {
            return this._estimatedCoverage != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedNewCommitmentUtilization. 
        /// <para>
        /// The estimated utilization for the recommended Savings Plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedNewCommitmentUtilization
        {
            get { return this._estimatedNewCommitmentUtilization; }
            set { this._estimatedNewCommitmentUtilization = value; }
        }

        // Check to see if EstimatedNewCommitmentUtilization property is set
        internal bool IsSetEstimatedNewCommitmentUtilization()
        {
            return this._estimatedNewCommitmentUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedOnDemandCost. 
        /// <para>
        /// The remaining On-Demand cost estimated to not be covered by the recommended Savings
        /// Plan, over the length of the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedOnDemandCost
        {
            get { return this._estimatedOnDemandCost; }
            set { this._estimatedOnDemandCost = value; }
        }

        // Check to see if EstimatedOnDemandCost property is set
        internal bool IsSetEstimatedOnDemandCost()
        {
            return this._estimatedOnDemandCost != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime.
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

    }
}