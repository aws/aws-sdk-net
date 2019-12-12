/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// The status of profiling of a profiling group.
    /// </summary>
    public partial class ProfilingStatus
    {
        private DateTime? _latestAgentOrchestratedAt;
        private DateTime? _latestAgentProfileReportedAt;
        private AggregatedProfileTime _latestAggregatedProfile;

        /// <summary>
        /// Gets and sets the property LatestAgentOrchestratedAt. 
        /// <para>
        /// Timestamp of when the last interaction of the agent with configureAgent API for orchestration.
        /// </para>
        /// </summary>
        public DateTime LatestAgentOrchestratedAt
        {
            get { return this._latestAgentOrchestratedAt.GetValueOrDefault(); }
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
        /// Timestamp of when the latest agent profile was successfully reported.
        /// </para>
        /// </summary>
        public DateTime LatestAgentProfileReportedAt
        {
            get { return this._latestAgentProfileReportedAt.GetValueOrDefault(); }
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
        /// The time range of latest aggregated profile available.
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