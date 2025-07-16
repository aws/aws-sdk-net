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
    /// Container for the parameters to the CreateAgentRuntimeEndpoint operation.
    /// Creates an Amazon Secure AgentEndpoint.
    /// </summary>
    public partial class CreateAgentRuntimeEndpointRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _agentRuntimeId;
        private string _agentRuntimeVersion;
        private string _clientToken;
        private string _description;
        private string _name;

        /// <summary>
        /// Gets and sets the property AgentRuntimeId. 
        /// <para>
        /// The unique identifier of the agent runtime to create an endpoint for.
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
        /// Gets and sets the property AgentRuntimeVersion. 
        /// <para>
        /// The version of the agent runtime to use for the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the agent runtime endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the agent runtime endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}