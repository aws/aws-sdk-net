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
    /// Container for the parameters to the CreateAgent operation.
    /// Activates an DataSync agent that you deploy in your storage environment. The activation
    /// process associates the agent with your Amazon Web Services account.
    /// 
    ///  
    /// <para>
    /// If you haven't deployed an agent yet, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/do-i-need-datasync-agent.html">Do
    /// I need a DataSync agent?</a> 
    /// </para>
    /// </summary>
    public partial class CreateAgentRequest : AmazonDataSyncRequest
    {
        private string _activationKey;
        private string _agentName;
        private List<string> _securityGroupArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<TagListEntry> _tags = AWSConfigs.InitializeCollections ? new List<TagListEntry>() : null;
        private string _vpcEndpointId;

        /// <summary>
        /// Gets and sets the property ActivationKey. 
        /// <para>
        /// Specifies your DataSync agent's activation key. If you don't have an activation key,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/activate-agent.html">Activating
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
        /// Specifies a name for your agent. We recommend specifying a name that you can remember.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Specifies the Amazon Resource Name (ARN) of the security group that allows traffic
        /// between your agent and VPC service endpoint. You can only specify one ARN.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._securityGroupArns != null && (this._securityGroupArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetArns. 
        /// <para>
        /// Specifies the ARN of the subnet where your VPC service endpoint is located. You can
        /// only specify one ARN.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._subnetArns != null && (this._subnetArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies labels that help you categorize, filter, and search for your Amazon Web
        /// Services resources. We recommend creating at least one tag for your agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// Specifies the ID of the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choose-service-endpoint.html#datasync-in-vpc">VPC
        /// service endpoint</a> that you're using. For example, a VPC endpoint ID looks like
        /// <c>vpce-01234d5aff67890e1</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The VPC service endpoint you use must include the DataSync service name (for example,
        /// <c>com.amazonaws.us-east-2.datasync</c>).
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