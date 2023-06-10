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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// DescribeAgentResponse
    /// </summary>
    public partial class DescribeAgentResponse : AmazonWebServiceResponse
    {
        private string _agentArn;
        private DateTime? _creationTime;
        private EndpointType _endpointType;
        private DateTime? _lastConnectionTime;
        private string _name;
        private PrivateLinkConfig _privateLinkConfig;
        private AgentStatus _status;

        /// <summary>
        /// Gets and sets the property AgentArn. 
        /// <para>
        /// The ARN of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string AgentArn
        {
            get { return this._agentArn; }
            set { this._agentArn = value; }
        }

        // Check to see if AgentArn property is set
        internal bool IsSetAgentArn()
        {
            return this._agentArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the agent was activated (that is, created in your account).
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint that your agent is connected to. If the endpoint is a VPC endpoint,
        /// the agent is not accessible over the public internet. 
        /// </para>
        /// </summary>
        public EndpointType EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property LastConnectionTime. 
        /// <para>
        /// The time that the agent last connected to DataSync.
        /// </para>
        /// </summary>
        public DateTime LastConnectionTime
        {
            get { return this._lastConnectionTime.GetValueOrDefault(); }
            set { this._lastConnectionTime = value; }
        }

        // Check to see if LastConnectionTime property is set
        internal bool IsSetLastConnectionTime()
        {
            return this._lastConnectionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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

        /// <summary>
        /// Gets and sets the property PrivateLinkConfig. 
        /// <para>
        /// The subnet and the security group that DataSync used to access a VPC endpoint.
        /// </para>
        /// </summary>
        public PrivateLinkConfig PrivateLinkConfig
        {
            get { return this._privateLinkConfig; }
            set { this._privateLinkConfig = value; }
        }

        // Check to see if PrivateLinkConfig property is set
        internal bool IsSetPrivateLinkConfig()
        {
            return this._privateLinkConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the agent. If the status is ONLINE, then the agent is configured properly
        /// and is available to use. The Running status is the normal running status for an agent.
        /// If the status is OFFLINE, the agent's VM is turned off or the agent is in an unhealthy
        /// state. When the issue that caused the unhealthy state is resolved, the agent returns
        /// to ONLINE status.
        /// </para>
        /// </summary>
        public AgentStatus Status
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