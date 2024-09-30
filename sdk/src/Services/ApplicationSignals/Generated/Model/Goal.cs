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
    /// This structure contains the attributes that determine the goal of an SLO. This includes
    /// the time period for evaluation and the attainment threshold.
    /// </summary>
    public partial class Goal
    {
        private double? _attainmentGoal;
        private Interval _interval;
        private double? _warningThreshold;

        /// <summary>
        /// Gets and sets the property AttainmentGoal. 
        /// <para>
        /// The threshold that determines if the goal is being met.
        /// </para>
        ///  
        /// <para>
        /// If this is a period-based SLO, the attainment goal is the percentage of good periods
        /// that meet the threshold requirements to the total periods within the interval. For
        /// example, an attainment goal of 99.9% means that within your interval, you are targeting
        /// 99.9% of the periods to be in healthy state.
        /// </para>
        ///  
        /// <para>
        /// If this is a request-based SLO, the attainment goal is the percentage of requests
        /// that must be successful to meet the attainment goal.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, 99 is used to represent 99% as the attainment goal.
        /// </para>
        /// </summary>
        public double? AttainmentGoal
        {
            get { return this._attainmentGoal; }
            set { this._attainmentGoal = value; }
        }

        // Check to see if AttainmentGoal property is set
        internal bool IsSetAttainmentGoal()
        {
            return this._attainmentGoal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The time period used to evaluate the SLO. It can be either a calendar interval or
        /// rolling interval.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, a rolling interval of 7 days is used.
        /// </para>
        /// </summary>
        public Interval Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval != null;
        }

        /// <summary>
        /// Gets and sets the property WarningThreshold. 
        /// <para>
        /// The percentage of remaining budget over total budget that you want to get warnings
        /// for. If you omit this parameter, the default of 50.0 is used. 
        /// </para>
        /// </summary>
        public double? WarningThreshold
        {
            get { return this._warningThreshold; }
            set { this._warningThreshold = value; }
        }

        // Check to see if WarningThreshold property is set
        internal bool IsSetWarningThreshold()
        {
            return this._warningThreshold.HasValue; 
        }

    }
}