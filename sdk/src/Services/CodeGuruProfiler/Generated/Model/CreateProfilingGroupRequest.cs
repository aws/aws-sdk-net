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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProfilingGroup operation.
    /// Creates a profiling group.
    /// </summary>
    public partial class CreateProfilingGroupRequest : AmazonCodeGuruProfilerRequest
    {
        private AgentOrchestrationConfig _agentOrchestrationConfig;
        private string _clientToken;
        private string _profilingGroupName;

        /// <summary>
        /// Gets and sets the property AgentOrchestrationConfig. 
        /// <para>
        /// The agent orchestration configuration.
        /// </para>
        /// </summary>
        public AgentOrchestrationConfig AgentOrchestrationConfig
        {
            get { return this._agentOrchestrationConfig; }
            set { this._agentOrchestrationConfig = value; }
        }

        // Check to see if AgentOrchestrationConfig property is set
        internal bool IsSetAgentOrchestrationConfig()
        {
            return this._agentOrchestrationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        ///  
        /// <para>
        /// This parameter specifies a unique identifier for the new profiling group that helps
        /// ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        /// The name of the profiling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProfilingGroupName
        {
            get { return this._profilingGroupName; }
            set { this._profilingGroupName = value; }
        }

        // Check to see if ProfilingGroupName property is set
        internal bool IsSetProfilingGroupName()
        {
            return this._profilingGroupName != null;
        }

    }
}