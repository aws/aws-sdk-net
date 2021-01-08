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
    /// Container for the parameters to the CreateAgent operation.
    /// Activates an AWS DataSync agent that you have deployed on your host. The activation
    /// process associates your agent with your account. In the activation process, you specify
    /// information such as the AWS Region that you want to activate the agent in. You activate
    /// the agent in the AWS Region where your target locations (in Amazon S3 or Amazon EFS)
    /// reside. Your tasks are created in this AWS Region.
    /// 
    ///  
    /// <para>
    /// You can activate the agent in a VPC (virtual private cloud) or provide the agent access
    /// to a VPC endpoint so you can run tasks without going over the public internet.
    /// </para>
    ///  
    /// <para>
    /// You can use an agent for more than one location. If a task uses multiple agents, all
    /// of them need to have status AVAILABLE for the task to run. If you use multiple agents
    /// for a source location, the status of all the agents must be AVAILABLE for the task
    /// to run. 
    /// </para>
    ///  
    /// <para>
    /// Agents are automatically updated by AWS on a regular basis, using a mechanism that
    /// ensures minimal interruption to your tasks.
    /// </para>
    /// </summary>
    public partial class CreateAgentRequest : AmazonDataSyncRequest
    {
        private string _activationKey;
        private string _agentName;
        private List<string> _securityGroupArns = new List<string>();
        private List<string> _subnetArns = new List<string>();
        private List<TagListEntry> _tags = new List<TagListEntry>();
        private string _vpcEndpointId;

        /// <summary>
        /// Gets and sets the property ActivationKey. 
        /// <para>
        /// Your agent activation key. You can get the activation key either by sending an HTTP
        /// GET request with redirects that enable you to get the agent IP address (port 80).
        /// Alternatively, you can get it from the AWS DataSync console.
        /// </para>
        ///  
        /// <para>
        /// The redirect URL returned in the response provides you the activation key for your
        /// agent in the query string parameter <code>activationKey</code>. It might also include
        /// other activation-related parameters; however, these are merely defaults. The arguments
        /// you pass to this API call determine the actual configuration of your agent.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Activating an Agent in the <i>AWS DataSync User Guide.</i>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=29)]
        public string ActivationKey
        {
            get { return this._activationKey; }
            set { this._activationKey = value; }
        }

        // Check to see if ActivationKey property is set
        internal bool IsSetActivationKey()
        {
            return this._activationKey != null;
        }

        /// <summary>
        /// Gets and sets the property AgentName. 
        /// <para>
        /// The name you configured for your agent. This value is a text reference that is used
        /// to identify the agent in the console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AgentName
        {
            get { return this._agentName; }
            set { this._agentName = value; }
        }

        // Check to see if AgentName property is set
        internal bool IsSetAgentName()
        {
            return this._agentName != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupArns. 
        /// <para>
        /// The ARNs of the security groups used to protect your data transfer task subnets. See
        /// <a>CreateAgentRequest$SubnetArns</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> SecurityGroupArns
        {
            get { return this._securityGroupArns; }
            set { this._securityGroupArns = value; }
        }

        // Check to see if SecurityGroupArns property is set
        internal bool IsSetSecurityGroupArns()
        {
            return this._securityGroupArns != null && this._securityGroupArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the subnets in which DataSync will create elastic
        /// network interfaces for each data transfer task. The agent that runs a task must be
        /// private. When you start a task that is associated with an agent created in a VPC,
        /// or one that has access to an IP address in a VPC, then the task is also private. In
        /// this case, DataSync creates four network interfaces for each task in your subnet.
        /// For a data transfer to work, the agent must be able to route to all these four network
        /// interfaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> SubnetArns
        {
            get { return this._subnetArns; }
            set { this._subnetArns = value; }
        }

        // Check to see if SubnetArns property is set
        internal bool IsSetSubnetArns()
        {
            return this._subnetArns != null && this._subnetArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pair that represents the tag that you want to associate with the agent.
        /// The value can be an empty string. This value helps you manage, filter, and search
        /// for your agents.
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid characters for key and value are letters, spaces, and numbers representable
        /// in UTF-8 format, and the following special characters: + - = . _ : / @. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TagListEntry> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC (virtual private cloud) endpoint that the agent has access to. This
        /// is the client-side VPC endpoint, also called a PrivateLink. If you don't have a PrivateLink
        /// VPC endpoint, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/endpoint-service.html#create-endpoint-service">Creating
        /// a VPC Endpoint Service Configuration</a> in the Amazon VPC User Guide.
        /// </para>
        ///  
        /// <para>
        /// VPC endpoint ID looks like this: <code>vpce-01234d5aff67890e1</code>.
        /// </para>
        /// </summary>
        public string VpcEndpointId
        {
            get { return this._vpcEndpointId; }
            set { this._vpcEndpointId = value; }
        }

        // Check to see if VpcEndpointId property is set
        internal bool IsSetVpcEndpointId()
        {
            return this._vpcEndpointId != null;
        }

    }
}