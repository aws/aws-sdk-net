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
    /// Profiling status includes information about the last time a profile agent pinged
    /// back, the last time a profile was received, and the aggregation period and start time
    /// for the most recent aggregated profile.
    /// </summary>
    public partial class ProfilingStatus
    {
        private DateTime? _latestAgentOrchestratedAt;
        private DateTime? _latestAgentProfileReportedAt;
        private AggregatedProfileTime _latestAggregatedProfile;

        /// <summary>
        /// Gets and sets the property LatestAgentOrchestratedAt. 
        /// <para>
        /// The date and time when the profiling agent most recently pinged back. Specify using
        /// the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond
        /// past June 1, 2020 1:15:02 PM UTC.
        /// </para>
        /// </summary>
        public DateTime? LatestAgentOrchestratedAt
        {
            get { return this._latestAgentOrchestratedAt; }
            set { this._latestAgentOrchestratedAt = value; }
        }

        // Check to see if LatestAgentOrchestratedAt property is set
        internal bool IsSetLatestAgentOrchestratedAt()
        {
            return this._latestAgentOrchestratedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestAgentProfileReportedAt. 
        /// <para>
        /// The date and time when the most recent profile was received. Specify using the ISO
        /// 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond past June
        /// 1, 2020 1:15:02 PM UTC.
        /// </para>
        /// </summary>
        public DateTime? LatestAgentProfileReportedAt
        {
            get { return this._latestAgentProfileReportedAt; }
            set { this._latestAgentProfileReportedAt = value; }
        }

        // Check to see if LatestAgentProfileReportedAt property is set
        internal bool IsSetLatestAgentProfileReportedAt()
        {
            return this._latestAgentProfileReportedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestAggregatedProfile. 
        /// <para>
        ///  An <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_AggregatedProfileTime.html">
        /// <c>AggregatedProfileTime</c> </a> object that contains the aggregation period and
        /// start time for an aggregated profile. 
        /// </para>
        /// </summary>
        public AggregatedProfileTime LatestAggregatedProfile
        {
            get { return this._latestAggregatedProfile; }
            set { this._latestAggregatedProfile = value; }
        }

        // Check to see if LatestAggregatedProfile property is set
        internal bool IsSetLatestAggregatedProfile()
        {
            return this._latestAggregatedProfile != null;
        }

    }
}