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
    /// Specifies whether profiling is enabled or disabled for a profiling group. It is used
    /// by <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ConfigureAgent.html">
    /// <c>ConfigureAgent</c> </a> to enable or disable profiling for a profiling group.
    /// </summary>
    public partial class AgentOrchestrationConfig
    {
        private bool? _profilingEnabled;

        /// <summary>
        /// Gets and sets the property ProfilingEnabled. 
        /// <para>
        ///  A <c>Boolean</c> that specifies whether the profiling agent collects profiling data
        /// or not. Set to <c>true</c> to enable profiling. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ProfilingEnabled
        {
            get { return this._profilingEnabled; }
            set { this._profilingEnabled = value; }
        }

        // Check to see if ProfilingEnabled property is set
        internal bool IsSetProfilingEnabled()
        {
            return this._profilingEnabled.HasValue; 
        }

    }
}