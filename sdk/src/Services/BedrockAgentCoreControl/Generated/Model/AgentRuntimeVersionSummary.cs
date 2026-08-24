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
    /// Summary information about an agent runtime version associated with a capacity provider.
    /// This is returned by <c>ListAgentRuntimeVersionsByCapacityProvider</c>.
    /// </summary>
    public partial class AgentRuntimeVersionSummary
    {
        private string _agentRuntimeArn;
        private string _agentRuntimeVersion;
        private AgentRuntimeStatus _status;

        /// <summary>
        /// Gets and sets the property AgentRuntimeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentRuntimeArn
        {
            get { return this._agentRuntimeArn; }
            set { this._agentRuntimeArn = value; }
        }

        // Check to see if AgentRuntimeArn property is set
        internal bool IsSetAgentRuntimeArn()
        {
            return this._agentRuntimeArn != null;
        }

        /// <summary>
        /// Gets and sets the property AgentRuntimeVersion. 
        /// <para>
        /// The version of the agent runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string AgentRuntimeVersion
        {
            get { return this._agentRuntimeVersion; }
            set { this._agentRuntimeVersion = value; }
        }

        // Check to see if AgentRuntimeVersion property is set
        internal bool IsSetAgentRuntimeVersion()
        {
            return this._agentRuntimeVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the agent runtime version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentRuntimeStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}