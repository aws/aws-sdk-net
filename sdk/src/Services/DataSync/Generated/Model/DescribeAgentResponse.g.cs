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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// This is the response object from the DescribeAgent operation.
    /// </summary>
    public partial class DescribeAgentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentArn. 
        /// <para>
        /// The ARN of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string AgentArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentArn property is set.
        /// </summary>
        internal bool IsSetAgentArn() => this.AgentArn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the agent was <a href="https://docs.aws.amazon.com/datasync/latest/userguide/activate-agent.html">activated</a>.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choose-service-endpoint.html">service
        /// endpoint</a> that your agent is connected to.
        /// </para>
        /// </summary>
        public EndpointType EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property LastConnectionTime. 
        /// <para>
        /// The last time that the agent was communicating with the DataSync service.
        /// </para>
        /// </summary>
        public DateTime? LastConnectionTime { get; set; }

        /// <summary>
        /// Checks to see if the LastConnectionTime property is set.
        /// </summary>
        internal bool IsSetLastConnectionTime() => this.LastConnectionTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform-related details about the agent, such as the version number.
        /// </para>
        /// </summary>
        public Platform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property PrivateLinkConfig. 
        /// <para>
        /// The network configuration that the agent uses when connecting to a <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choose-service-endpoint.html#choose-service-endpoint-vpc">VPC
        /// service endpoint</a>.
        /// </para>
        /// </summary>
        public PrivateLinkConfig PrivateLinkConfig { get; set; }

        /// <summary>
        /// Checks to see if the PrivateLinkConfig property is set.
        /// </summary>
        internal bool IsSetPrivateLinkConfig() => this.PrivateLinkConfig != null;

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
        public AgentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
