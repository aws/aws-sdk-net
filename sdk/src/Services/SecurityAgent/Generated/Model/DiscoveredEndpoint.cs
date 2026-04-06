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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Represents a discovered endpoint during pentest execution
    /// </summary>
    public partial class DiscoveredEndpoint
    {
        private string _agentSpaceId;
        private string _description;
        private string _evidence;
        private string _operation;
        private string _pentestJobId;
        private string _taskId;
        private string _uri;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// Identifier of the agent space where the endpoint was discovered
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentSpaceId
        {
            get { return this._agentSpaceId; }
            set { this._agentSpaceId = value; }
        }

        // Check to see if AgentSpaceId property is set
        internal bool IsSetAgentSpaceId()
        {
            return this._agentSpaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Additional description of the endpoint
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Evidence. 
        /// <para>
        /// Optional evidence or additional information about the endpoint
        /// </para>
        /// </summary>
        public string Evidence
        {
            get { return this._evidence; }
            set { this._evidence = value; }
        }

        // Check to see if Evidence property is set
        internal bool IsSetEvidence()
        {
            return this._evidence != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// Operation or action associated with the endpoint
        /// </para>
        /// </summary>
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property PentestJobId. 
        /// <para>
        /// Identifier of the pentest job that discovered this endpoint
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PentestJobId
        {
            get { return this._pentestJobId; }
            set { this._pentestJobId = value; }
        }

        // Check to see if PentestJobId property is set
        internal bool IsSetPentestJobId()
        {
            return this._pentestJobId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// Identifier of the task that discovered this endpoint
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The URI of the discovered endpoint
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}