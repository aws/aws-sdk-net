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
    /// Configuration to orchestrate agents to create and report agent profiles of the profiling
    /// group. Agents are orchestrated if they follow the agent orchestration protocol.
    /// </summary>
    public partial class AgentOrchestrationConfig
    {
        private bool? _profilingEnabled;

        /// <summary>
        /// Gets and sets the property ProfilingEnabled. 
        /// <para>
        /// If the agents should be enabled to create and report profiles.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool ProfilingEnabled
        {
            get { return this._profilingEnabled.GetValueOrDefault(); }
            set { this._profilingEnabled = value; }
        }

        // Check to see if ProfilingEnabled property is set
        internal bool IsSetProfilingEnabled()
        {
            return this._profilingEnabled.HasValue; 
        }

    }
}