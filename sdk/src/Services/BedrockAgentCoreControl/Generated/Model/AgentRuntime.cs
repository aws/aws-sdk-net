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
    /// Contains information about an agent runtime. An agent runtime is the execution environment
    /// for a Amazon Bedrock Agent.
    /// </summary>
    public partial class AgentRuntime
    {
        private string _agentRuntimeArn;
        private string _agentRuntimeId;
        private string _agentRuntimeName;
        private string _agentRuntimeVersion;
        private string _description;
        private DateTime? _lastUpdatedAt;
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
        /// Gets and sets the property AgentRuntimeId. 
        /// <para>
        /// The unique identifier of the agent runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentRuntimeId
        {
            get { return this._agentRuntimeId; }
            set { this._agentRuntimeId = value; }
        }

        // Check to see if AgentRuntimeId property is set
        internal bool IsSetAgentRuntimeId()
        {
            return this._agentRuntimeId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentRuntimeName. 
        /// <para>
        /// The name of the agent runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentRuntimeName
        {
            get { return this._agentRuntimeName; }
            set { this._agentRuntimeName = value; }
        }

        // Check to see if AgentRuntimeName property is set
        internal bool IsSetAgentRuntimeName()
        {
            return this._agentRuntimeName != null;
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the agent runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4096)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the agent runtime was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the agent runtime.
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