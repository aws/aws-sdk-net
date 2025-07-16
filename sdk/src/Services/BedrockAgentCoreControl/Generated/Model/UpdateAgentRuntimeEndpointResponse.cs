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
    /// This is the response object from the UpdateAgentRuntimeEndpoint operation.
    /// </summary>
    public partial class UpdateAgentRuntimeEndpointResponse : AmazonWebServiceResponse
    {
        private string _agentRuntimeArn;
        private string _agentRuntimeEndpointArn;
        private DateTime? _createdAt;
        private DateTime? _lastUpdatedAt;
        private string _liveVersion;
        private AgentEndpointStatus _status;
        private string _targetVersion;

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
        /// Gets and sets the property AgentRuntimeEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent runtime endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentRuntimeEndpointArn
        {
            get { return this._agentRuntimeEndpointArn; }
            set { this._agentRuntimeEndpointArn = value; }
        }

        // Check to see if AgentRuntimeEndpointArn property is set
        internal bool IsSetAgentRuntimeEndpointArn()
        {
            return this._agentRuntimeEndpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the agent runtime endpoint was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the agent runtime endpoint was last updated.
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
        /// Gets and sets the property LiveVersion. 
        /// <para>
        /// The currently deployed version of the agent runtime on the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string LiveVersion
        {
            get { return this._liveVersion; }
            set { this._liveVersion = value; }
        }

        // Check to see if LiveVersion property is set
        internal bool IsSetLiveVersion()
        {
            return this._liveVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the updated agent runtime endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentEndpointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVersion. 
        /// <para>
        /// The target version of the agent runtime for the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string TargetVersion
        {
            get { return this._targetVersion; }
            set { this._targetVersion = value; }
        }

        // Check to see if TargetVersion property is set
        internal bool IsSetTargetVersion()
        {
            return this._targetVersion != null;
        }

    }
}