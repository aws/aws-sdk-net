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

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProfilingGroup operation. Updates a profiling
    /// group.
    /// </summary>
    public partial class UpdateProfilingGroupRequest : AmazonCodeGuruProfilerRequest
    {
        /// <summary>
        /// Gets and sets the property AgentOrchestrationConfig. 
        /// <para>
        ///  Specifies whether profiling is enabled or disabled for a profiling group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentOrchestrationConfig AgentOrchestrationConfig { get; set; }

        /// <summary>
        /// Checks to see if the AgentOrchestrationConfig property is set.
        /// </summary>
        internal bool IsSetAgentOrchestrationConfig() => this.AgentOrchestrationConfig != null;

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        /// The name of the profiling group to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ProfilingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ProfilingGroupName property is set.
        /// </summary>
        internal bool IsSetProfilingGroupName() => this.ProfilingGroupName != null;
    }
}
