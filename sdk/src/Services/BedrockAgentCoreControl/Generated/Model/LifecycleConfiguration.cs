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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// LifecycleConfiguration lets you manage the lifecycle of runtime sessions and resources
    /// in AgentCore Runtime. This configuration helps optimize resource utilization by automatically
    /// cleaning up idle sessions and preventing long-running instances from consuming resources
    /// indefinitely.
    /// </summary>
    public partial class LifecycleConfiguration
    {
        private int? _idleRuntimeSessionTimeout;
        private int? _maxLifetime;

        /// <summary>
        /// Gets and sets the property IdleRuntimeSessionTimeout. 
        /// <para>
        /// Timeout in seconds for idle runtime sessions. When a session remains idle for this
        /// duration, it will be automatically terminated. Default: 900 seconds (15 minutes).
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=28800)]
        public int? IdleRuntimeSessionTimeout
        {
            get { return this._idleRuntimeSessionTimeout; }
            set { this._idleRuntimeSessionTimeout = value; }
        }

        // Check to see if IdleRuntimeSessionTimeout property is set
        internal bool IsSetIdleRuntimeSessionTimeout()
        {
            return this._idleRuntimeSessionTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxLifetime. 
        /// <para>
        /// Maximum lifetime for the instance in seconds. Once reached, instances will be automatically
        /// terminated and replaced. Default: 28800 seconds (8 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=28800)]
        public int? MaxLifetime
        {
            get { return this._maxLifetime; }
            set { this._maxLifetime = value; }
        }

        // Check to see if MaxLifetime property is set
        internal bool IsSetMaxLifetime()
        {
            return this._maxLifetime.HasValue; 
        }

    }
}