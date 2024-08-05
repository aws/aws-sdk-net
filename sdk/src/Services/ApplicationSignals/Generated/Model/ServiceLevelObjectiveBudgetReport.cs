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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
        private string _arn;
        private double? _attainment;
        private int? _budgetSecondsRemaining;
        private ServiceLevelObjectiveBudgetStatus _budgetStatus;
        private Goal _goal;
        private string _name;
        private ServiceLevelIndicator _sli;
        private int? _totalBudgetSeconds;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the SLO that this report is for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Attainment. 
        /// <para>
        /// A number between 0 and 100 that represents the percentage of time periods that the
        /// service has attained the SLO's attainment goal, as of the time of the request.
        /// </para>
        /// </summary>
        public double? Attainment
        {
            get { return this._attainment; }
            set { this._attainment = value; }
        }

        // Check to see if Attainment property is set
        internal bool IsSetAttainment()
        {
            return this._attainment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BudgetSecondsRemaining. 
        /// <para>
        /// The budget amount remaining before the SLO status becomes <c>BREACHING</c>, at the
        /// time specified in the <c>Timestemp</c> parameter of the request. If this value is
        /// negative, then the SLO is already in <c>BREACHING</c> status.
        /// </para>
        /// </summary>
        public int? BudgetSecondsRemaining
        {
            get { return this._budgetSecondsRemaining; }
            set { this._budgetSecondsRemaining = value; }
        }

        // Check to see if BudgetSecondsRemaining property is set
        internal bool IsSetBudgetSecondsRemaining()
        {
            return this._budgetSecondsRemaining.HasValue; 
        }

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
        ///  <c>INSUFFICIENT_DATA</c> means that the specifed start and end times were before
        /// the SLO was created, or that attainment data is missing.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceLevelObjectiveBudgetStatus BudgetStatus
        {
            get { return this._budgetStatus; }
            set { this._budgetStatus = value; }
        }

        // Check to see if BudgetStatus property is set
        internal bool IsSetBudgetStatus()
        {
            return this._budgetStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Goal.
        /// </summary>
        public Goal Goal
        {
            get { return this._goal; }
            set { this._goal = value; }
        }

        // Check to see if Goal property is set
        internal bool IsSetGoal()
        {
            return this._goal != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SLO that this report is for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Sli. 
        /// <para>
        /// A structure that contains information about the performance metric that this SLO monitors.
        /// </para>
        /// </summary>
        public ServiceLevelIndicator Sli
        {
            get { return this._sli; }
            set { this._sli = value; }
        }

        // Check to see if Sli property is set
        internal bool IsSetSli()
        {
            return this._sli != null;
        }

        /// <summary>
        /// Gets and sets the property TotalBudgetSeconds. 
        /// <para>
        /// The total number of seconds in the error budget for the interval.
        /// </para>
        /// </summary>
        public int? TotalBudgetSeconds
        {
            get { return this._totalBudgetSeconds; }
            set { this._totalBudgetSeconds = value; }
        }

        // Check to see if TotalBudgetSeconds property is set
        internal bool IsSetTotalBudgetSeconds()
        {
            return this._totalBudgetSeconds.HasValue; 
        }

    }
}