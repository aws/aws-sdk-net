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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure containing an SLO budget report that you have requested.
    /// </summary>
    public partial class ServiceLevelObjectiveBudgetReport
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the SLO that this report is for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Attainment. 
        /// <para>
        /// A number between 0 and 100 that represents the success percentage of your application
        /// compared to the goal set by the SLO.
        /// </para>
        ///  
        /// <para>
        /// If this is a period-based SLO, the number is the percentage of time periods that the
        /// service has attained the SLO's attainment goal, as of the time of the request.
        /// </para>
        ///  
        /// <para>
        /// If this is a request-based SLO, the number is the number of successful requests divided
        /// by the number of total requests, multiplied by 100, during the time range that you
        /// specified in your request.
        /// </para>
        /// </summary>
        public double? Attainment { get; set; }

        /// <summary>
        /// Checks to see if the Attainment property is set.
        /// </summary>
        internal bool IsSetAttainment() => this.Attainment.HasValue;

        /// <summary>
        /// Gets and sets the property BudgetRequestsRemaining. 
        /// <para>
        /// This field is displayed only for request-based SLOs. It displays the number of failed
        /// requests that can be tolerated before any more successful requests occur, and still
        /// have the application meet its SLO goal.
        /// </para>
        ///  
        /// <para>
        /// This number can go up and down between different reports, based on both how many successful
        /// requests and how many failed requests occur in that time.
        /// </para>
        /// </summary>
        public int? BudgetRequestsRemaining { get; set; }

        /// <summary>
        /// Checks to see if the BudgetRequestsRemaining property is set.
        /// </summary>
        internal bool IsSetBudgetRequestsRemaining() => this.BudgetRequestsRemaining.HasValue;

        /// <summary>
        /// Gets and sets the property BudgetSecondsRemaining. 
        /// <para>
        /// The budget amount remaining before the SLO status becomes <c>BREACHING</c>, at the
        /// time specified in the <c>Timestemp</c> parameter of the request. If this value is
        /// negative, then the SLO is already in <c>BREACHING</c> status.
        /// </para>
        ///  
        /// <para>
        ///  This field is included only if the SLO is a period-based SLO.
        /// </para>
        /// </summary>
        public int? BudgetSecondsRemaining { get; set; }

        /// <summary>
        /// Checks to see if the BudgetSecondsRemaining property is set.
        /// </summary>
        internal bool IsSetBudgetSecondsRemaining() => this.BudgetSecondsRemaining.HasValue;

        /// <summary>
        /// Gets and sets the property BudgetStatus. 
        /// <para>
        /// The status of this SLO, as it relates to the error budget for the entire time interval.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OK</c> means that the SLO had remaining budget above the warning threshold, as
        /// of the time that you specified in <c>TimeStamp</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WARNING</c> means that the SLO's remaining budget was below the warning threshold,
        /// as of the time that you specified in <c>TimeStamp</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BREACHED</c> means that the SLO's budget was exhausted, as of the time that you
        /// specified in <c>TimeStamp</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_DATA</c> means that the specified start and end times were before
        /// the SLO was created, or that attainment data is missing.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceLevelObjectiveBudgetStatus BudgetStatus { get; set; }

        /// <summary>
        /// Checks to see if the BudgetStatus property is set.
        /// </summary>
        internal bool IsSetBudgetStatus() => this.BudgetStatus != null;

        /// <summary>
        /// Gets and sets the property EvaluationType. 
        /// <para>
        /// Displays whether this budget report is for a period-based SLO or a request-based SLO.
        /// </para>
        /// </summary>
        public EvaluationType EvaluationType { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationType property is set.
        /// </summary>
        internal bool IsSetEvaluationType() => this.EvaluationType != null;

        /// <summary>
        /// Gets and sets the property Goal.
        /// </summary>
        public Goal Goal { get; set; }

        /// <summary>
        /// Checks to see if the Goal property is set.
        /// </summary>
        internal bool IsSetGoal() => this.Goal != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SLO that this report is for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequestBasedSli.
        /// </summary>
        public RequestBasedServiceLevelIndicator RequestBasedSli { get; set; }

        /// <summary>
        /// Checks to see if the RequestBasedSli property is set.
        /// </summary>
        internal bool IsSetRequestBasedSli() => this.RequestBasedSli != null;

        /// <summary>
        /// Gets and sets the property Sli. 
        /// <para>
        /// A structure that contains information about the performance metric that this SLO monitors.
        /// </para>
        /// </summary>
        public ServiceLevelIndicator Sli { get; set; }

        /// <summary>
        /// Checks to see if the Sli property is set.
        /// </summary>
        internal bool IsSetSli() => this.Sli != null;

        /// <summary>
        /// Gets and sets the property TotalBudgetRequests. 
        /// <para>
        /// This field is displayed only for request-based SLOs. It displays the total number
        /// of failed requests that can be tolerated during the time range between the start of
        /// the interval and the time stamp supplied in the budget report request. It is based
        /// on the total number of requests that occurred, and the percentage specified in the
        /// attainment goal. If the number of failed requests matches this number or is higher,
        /// then this SLO is currently breaching.
        /// </para>
        ///  
        /// <para>
        /// This number can go up and down between reports with different time stamps, based on
        /// both how many total requests occur.
        /// </para>
        /// </summary>
        public int? TotalBudgetRequests { get; set; }

        /// <summary>
        /// Checks to see if the TotalBudgetRequests property is set.
        /// </summary>
        internal bool IsSetTotalBudgetRequests() => this.TotalBudgetRequests.HasValue;

        /// <summary>
        /// Gets and sets the property TotalBudgetSeconds. 
        /// <para>
        /// The total number of seconds in the error budget for the interval. This field is included
        /// only if the SLO is a period-based SLO.
        /// </para>
        /// </summary>
        public int? TotalBudgetSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TotalBudgetSeconds property is set.
        /// </summary>
        internal bool IsSetTotalBudgetSeconds() => this.TotalBudgetSeconds.HasValue;
    }
}
