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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Resiliency score of each scoring component. For more information about scoring component,
    /// see <a href="https://docs.aws.amazon.com/resilience-hub/latest/userguide/calculate-score.html">Calculating
    /// resiliency score</a>.
    /// </summary>
    public partial class ScoringComponentResiliencyScore
    {
        /// <summary>
        /// Gets and sets the property ExcludedCount. 
        /// <para>
        /// Number of recommendations that were excluded from the assessment.
        /// </para>
        ///  
        /// <para>
        /// For example, if the <c>excludedCount</c> for Alarms coverage scoring component is
        /// 7, it indicates that 7 Amazon CloudWatch alarms are excluded from the assessment.
        /// </para>
        /// </summary>
        public long? ExcludedCount { get; set; }

        /// <summary>
        /// Checks to see if the ExcludedCount property is set.
        /// </summary>
        internal bool IsSetExcludedCount() => this.ExcludedCount.HasValue;

        /// <summary>
        /// Gets and sets the property OutstandingCount. 
        /// <para>
        /// Number of recommendations that must be implemented to obtain the maximum possible
        /// score for the scoring component. For SOPs, alarms, and tests, these are the number
        /// of recommendations that must be implemented. For compliance, these are the number
        /// of Application Components that have breached the resiliency policy.
        /// </para>
        ///  
        /// <para>
        /// For example, if the <c>outstandingCount</c> for Alarms coverage scoring component
        /// is 5, it indicates that 5 Amazon CloudWatch alarms need to be implemented to achieve
        /// the maximum possible score.
        /// </para>
        /// </summary>
        public long? OutstandingCount { get; set; }

        /// <summary>
        /// Checks to see if the OutstandingCount property is set.
        /// </summary>
        internal bool IsSetOutstandingCount() => this.OutstandingCount.HasValue;

        /// <summary>
        /// Gets and sets the property PossibleScore. 
        /// <para>
        /// Maximum possible score that can be obtained for the scoring component. 
        /// </para>
        ///  
        /// <para>
        /// For example, if the <c>possibleScore</c> is 20 points, it indicates the maximum possible
        /// score you can achieve for the scoring component when you run a new assessment after
        /// implementing all the Resilience Hub recommendations.
        /// </para>
        /// </summary>
        public double? PossibleScore { get; set; }

        /// <summary>
        /// Checks to see if the PossibleScore property is set.
        /// </summary>
        internal bool IsSetPossibleScore() => this.PossibleScore.HasValue;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// Resiliency score points given for the scoring component. The score is always less
        /// than or equal to the <c>possibleScore</c>.
        /// </para>
        /// </summary>
        public double? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;
    }
}
