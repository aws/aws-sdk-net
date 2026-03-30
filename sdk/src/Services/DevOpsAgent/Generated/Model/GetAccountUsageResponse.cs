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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
        private UsageMetric _monthlyAccountEvaluationHours;
        private UsageMetric _monthlyAccountInvestigationHours;
        private UsageMetric _monthlyAccountSystemLearningHours;
        private DateTime? _usagePeriodEndTime;
        private DateTime? _usagePeriodStartTime;

        /// <summary>
        /// Gets and sets the property MonthlyAccountEvaluationHours. 
        /// <para>
        /// Monthly evaluation hours usage and limit for an account
        /// </para>
        /// </summary>
        public UsageMetric MonthlyAccountEvaluationHours
        {
            get { return this._monthlyAccountEvaluationHours; }
            set { this._monthlyAccountEvaluationHours = value; }
        }

        // Check to see if MonthlyAccountEvaluationHours property is set
        internal bool IsSetMonthlyAccountEvaluationHours()
        {
            return this._monthlyAccountEvaluationHours != null;
        }

        /// <summary>
        /// Gets and sets the property MonthlyAccountInvestigationHours. 
        /// <para>
        /// Monthly investigation hours usage and limit for an account
        /// </para>
        /// </summary>
        public UsageMetric MonthlyAccountInvestigationHours
        {
            get { return this._monthlyAccountInvestigationHours; }
            set { this._monthlyAccountInvestigationHours = value; }
        }

        // Check to see if MonthlyAccountInvestigationHours property is set
        internal bool IsSetMonthlyAccountInvestigationHours()
        {
            return this._monthlyAccountInvestigationHours != null;
        }

        /// <summary>
        /// Gets and sets the property MonthlyAccountSystemLearningHours. 
        /// <para>
        /// Monthly system learning hours usage and limit for an account
        /// </para>
        /// </summary>
        public UsageMetric MonthlyAccountSystemLearningHours
        {
            get { return this._monthlyAccountSystemLearningHours; }
            set { this._monthlyAccountSystemLearningHours = value; }
        }

        // Check to see if MonthlyAccountSystemLearningHours property is set
        internal bool IsSetMonthlyAccountSystemLearningHours()
        {
            return this._monthlyAccountSystemLearningHours != null;
        }

        /// <summary>
        /// Gets and sets the property UsagePeriodEndTime. 
        /// <para>
        /// The end time of the usage tracking period
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UsagePeriodEndTime
        {
            get { return this._usagePeriodEndTime; }
            set { this._usagePeriodEndTime = value; }
        }

        // Check to see if UsagePeriodEndTime property is set
        internal bool IsSetUsagePeriodEndTime()
        {
            return this._usagePeriodEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsagePeriodStartTime. 
        /// <para>
        /// The start time of the usage tracking period
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UsagePeriodStartTime
        {
            get { return this._usagePeriodStartTime; }
            set { this._usagePeriodStartTime = value; }
        }

        // Check to see if UsagePeriodStartTime property is set
        internal bool IsSetUsagePeriodStartTime()
        {
            return this._usagePeriodStartTime.HasValue; 
        }

    }
}