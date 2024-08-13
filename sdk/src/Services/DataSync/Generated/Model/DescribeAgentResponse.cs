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

#pragma warning disable CS0612,CS0618,CS1570
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
        private Platform _platform;
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
        /// The time that the agent was <a href="https://docs.aws.amazon.com/datasync/latest/userguide/activate-agent.html">activated</a>.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
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
        /// The type of <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choose-service-endpoint.html">service
        /// endpoint</a> that your agent is connected to.
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
        /// The last time that the agent was communicating with the DataSync service.
        /// </para>
        /// </summary>
        public DateTime? LastConnectionTime
        {
            get { return this._lastConnectionTime; }
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
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform-related details about the agent, such as the version number.
        /// </para>
        /// </summary>
        public Platform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateLinkConfig. 
        /// <para>
        /// The network configuration that the agent uses when connecting to a <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choose-service-endpoint.html#choose-service-endpoint-vpc">VPC
        /// service endpoint</a>.
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
        /// The status of the agent.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the status is <c>ONLINE</c>, the agent is configured properly and ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the status is <c>OFFLINE</c>, the agent has been out of contact with DataSync for
        /// five minutes or longer. This can happen for a few reasons. For more information, see
        /// <a href="https://docs.aws.amazon.com/datasync/latest/userguide/troubleshooting-datasync-agents.html#troubleshoot-agent-offline">What
        /// do I do if my agent is offline?</a> 
        /// </para>
        ///  </li> </ul>
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