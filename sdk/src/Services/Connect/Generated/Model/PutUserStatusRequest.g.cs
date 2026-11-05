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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the PutUserStatus operation. Changes the current status
    /// of a user or agent in Connect Customer. If the agent is currently handling a contact,
    /// this sets the agent's next status. <para> For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-agent-status.html">Agent
    /// status</a> and <a href="https://docs.aws.amazon.com/connect/latest/adminguide/set-next-status.html">Set
    /// your next status</a> in the <i>Connect Customer Administrator Guide</i>. </para>
    /// </summary>
    public partial class PutUserStatusRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AgentStatusId. 
        /// <para>
        /// The identifier of the agent status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentStatusId { get; set; }

        /// <summary>
        /// Checks to see if the AgentStatusId property is set.
        /// </summary>
        internal bool IsSetAgentStatusId() => this.AgentStatusId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
