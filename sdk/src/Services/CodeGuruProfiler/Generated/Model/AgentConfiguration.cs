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

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// The response of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ConfigureAgent.html">
    /// <code>ConfigureAgent</code> </a> that specifies if an agent profiles or not and for
    /// how long to return profiling data.
    /// </summary>
    public partial class AgentConfiguration
    {
        private Dictionary<string, string> _agentParameters = new Dictionary<string, string>();
        private int? _periodInSeconds;
        private bool? _shouldProfile;

        /// <summary>
        /// Gets and sets the property AgentParameters. 
        /// <para>
        ///  Parameters used by the profiler. The valid parameters are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>MaxStackDepth</code> - The maximum depth of the stacks in the code that is
        /// represented in the profile. For example, if CodeGuru Profiler finds a method <code>A</code>,
        /// which calls method <code>B</code>, which calls method <code>C</code>, which calls
        /// method <code>D</code>, then the depth is 4. If the <code>maxDepth</code> is set to
        /// 2, then the profiler evaluates <code>A</code> and <code>B</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MemoryUsageLimitPercent</code> - The percentage of memory that is used by the
        /// profiler.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MinimumTimeForReportingInMilliseconds</code> - The minimum time in milliseconds
        /// between sending reports. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReportingIntervalInMilliseconds</code> - The reporting interval in milliseconds
        /// used to report profiles. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SamplingIntervalInMilliseconds</code> - The sampling interval in milliseconds
        /// that is used to profile samples. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, string> AgentParameters
        {
            get { return this._agentParameters; }
            set { this._agentParameters = value; }
        }

        // Check to see if AgentParameters property is set
        internal bool IsSetAgentParameters()
        {
            return this._agentParameters != null && this._agentParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PeriodInSeconds. 
        /// <para>
        ///  How long a profiling agent should send profiling data using <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ConfigureAgent.html">
        /// <code>ConfigureAgent</code> </a>. For example, if this is set to 300, the profiling
        /// agent calls <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ConfigureAgent.html">
        /// <code>ConfigureAgent</code> </a> every 5 minutes to submit the profiled data collected
        /// during that period. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int PeriodInSeconds
        {
            get { return this._periodInSeconds.GetValueOrDefault(); }
            set { this._periodInSeconds = value; }
        }

        // Check to see if PeriodInSeconds property is set
        internal bool IsSetPeriodInSeconds()
        {
            return this._periodInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShouldProfile. 
        /// <para>
        ///  A <code>Boolean</code> that specifies whether the profiling agent collects profiling
        /// data or not. Set to <code>true</code> to enable profiling. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool ShouldProfile
        {
            get { return this._shouldProfile.GetValueOrDefault(); }
            set { this._shouldProfile = value; }
        }

        // Check to see if ShouldProfile property is set
        internal bool IsSetShouldProfile()
        {
            return this._shouldProfile.HasValue; 
        }

    }
}