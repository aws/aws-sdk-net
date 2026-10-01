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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// This is the response object from the GetAccountUsage operation.
    /// </summary>
    public partial class GetAccountUsageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property MonthlyAccountEvaluationHours. 
        /// <para>
        /// Monthly evaluation hours usage and limit for an account
        /// </para>
        /// </summary>
        public UsageMetric MonthlyAccountEvaluationHours { get; set; }

        /// <summary>
        /// Checks to see if the MonthlyAccountEvaluationHours property is set.
        /// </summary>
        internal bool IsSetMonthlyAccountEvaluationHours() => this.MonthlyAccountEvaluationHours != null;

        /// <summary>
        /// Gets and sets the property MonthlyAccountInvestigationHours. 
        /// <para>
        /// Monthly investigation hours usage and limit for an account
        /// </para>
        /// </summary>
        public UsageMetric MonthlyAccountInvestigationHours { get; set; }

        /// <summary>
        /// Checks to see if the MonthlyAccountInvestigationHours property is set.
        /// </summary>
        internal bool IsSetMonthlyAccountInvestigationHours() => this.MonthlyAccountInvestigationHours != null;

        /// <summary>
        /// Gets and sets the property MonthlyAccountOnDemandHours. 
        /// <para>
        /// Monthly on-demand hours usage and limit for an account
        /// </para>
        /// </summary>
        public UsageMetric MonthlyAccountOnDemandHours { get; set; }

        /// <summary>
        /// Checks to see if the MonthlyAccountOnDemandHours property is set.
        /// </summary>
        internal bool IsSetMonthlyAccountOnDemandHours() => this.MonthlyAccountOnDemandHours != null;

        /// <summary>
        /// Gets and sets the property MonthlyAccountSystemLearningHours. 
        /// <para>
        /// Monthly system learning hours usage and limit for an account
        /// </para>
        /// </summary>
        public UsageMetric MonthlyAccountSystemLearningHours { get; set; }

        /// <summary>
        /// Checks to see if the MonthlyAccountSystemLearningHours property is set.
        /// </summary>
        internal bool IsSetMonthlyAccountSystemLearningHours() => this.MonthlyAccountSystemLearningHours != null;

        /// <summary>
        /// Gets and sets the property UsagePeriodEndTime. 
        /// <para>
        /// The end time of the usage tracking period
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UsagePeriodEndTime { get; set; }

        /// <summary>
        /// Checks to see if the UsagePeriodEndTime property is set.
        /// </summary>
        internal bool IsSetUsagePeriodEndTime() => this.UsagePeriodEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property UsagePeriodStartTime. 
        /// <para>
        /// The start time of the usage tracking period
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UsagePeriodStartTime { get; set; }

        /// <summary>
        /// Checks to see if the UsagePeriodStartTime property is set.
        /// </summary>
        internal bool IsSetUsagePeriodStartTime() => this.UsagePeriodStartTime.HasValue;
    }
}
