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
    /// Activates an DataSync agent that you've deployed in your storage environment. The
    /// activation process associates the agent with your Amazon Web Services account.
    /// 
    ///  
    /// <para>
    /// If you haven't deployed an agent yet, see the following topics to learn more:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/agent-requirements.html">Agent
    /// requirements</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-agent.html">Create
    /// an agent</a> 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// If you're transferring between Amazon Web Services storage services, you don't need
    /// a DataSync agent. 
    /// </para>
    ///  </note>
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
        /// Specifies your DataSync agent's activation key. If you don't have an activation key,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/activate-agent.html">Activate
        /// your agent</a>.
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
        /// Specifies a name for your agent. You can see this name in the DataSync console.
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
        /// Specifies the Amazon Resource Name (ARN) of the security group that protects your
        /// task's <a href="https://docs.aws.amazon.com/datasync/latest/userguide/datasync-network.html#required-network-interfaces">network
        /// interfaces</a> when <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choose-service-endpoint.html#choose-service-endpoint-vpc">using
        /// a virtual private cloud (VPC) endpoint</a>.
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
        /// Specifies the ARN of the subnet where you want to run your DataSync task when using
        /// a VPC endpoint. This is the subnet where DataSync creates and manages the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/datasync-network.html#required-network-interfaces">network
        /// interfaces</a> for your transfer.
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
        /// Specifies labels that help you categorize, filter, and search for your Amazon Web
        /// Services resources. We recommend creating at least one tag for your agent.
        /// </para>
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
        /// Specifies the ID of the VPC endpoint that you want your agent to connect to. For example,
        /// a VPC endpoint ID looks like <code>vpce-01234d5aff67890e1</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The VPC endpoint you use must include the DataSync service name (for example, <code>com.amazonaws.us-east-2.datasync</code>).
        /// </para>
        ///  </important>
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