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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
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
namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Specifies the aggregation period and aggregation start time for an aggregated profile.
    /// An aggregated profile is used to collect posted agent profiles during an aggregation
    /// period. There are three possible aggregation periods (1 day, 1 hour, or 5 minutes).
    /// </summary>
    public partial class AggregatedProfileTime
    {
        private AggregationPeriod _period;
        private DateTime? _start;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        ///  The aggregation period. This indicates the period during which an aggregation profile
        /// collects posted agent profiles for a profiling group. Use one of three valid durations
        /// that are specified using the ISO 8601 format. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>P1D</c> — 1 day 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PT1H</c> — 1 hour 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PT5M</c> — 5 minutes 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AggregationPeriod Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period != null;
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        ///  The time that aggregation of posted agent profiles for a profiling group starts.
        /// The aggregation profile contains profiles posted by the agent starting at this time
        /// for an aggregation period specified by the <c>period</c> property of the <c>AggregatedProfileTime</c>
        /// object. 
        /// </para>
        ///  
        /// <para>
        ///  Specify <c>start</c> using the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z
        /// represents 1 millisecond past June 1, 2020 1:15:02 PM UTC. 
        /// </para>
        /// </summary>
        public DateTime? Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

    }
}