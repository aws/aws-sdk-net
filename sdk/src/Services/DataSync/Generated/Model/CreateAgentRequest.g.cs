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
    /// Container for the parameters to the CreateAgent operation. Activates an DataSync agent
    /// that you deploy in your storage environment. The activation process associates the
    /// agent with your Amazon Web Services account. <para> If you haven't deployed an agent
    /// yet, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/do-i-need-datasync-agent.html">Do
    /// I need a DataSync agent?</a> </para>
    /// </summary>
    public partial class CreateAgentRequest : AmazonDataSyncRequest
    {
        /// <summary>
        /// Gets and sets the property ActivationKey. 
        /// <para>
        /// Specifies your DataSync agent's activation key. If you don't have an activation key,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/activate-agent.html">Activating
        /// your agent</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 29)]
        public string ActivationKey { get; set; }

        /// <summary>
        /// Checks to see if the ActivationKey property is set.
        /// </summary>
        internal bool IsSetActivationKey() => this.ActivationKey != null;

        /// <summary>
        /// Gets and sets the property AgentName. 
        /// <para>
        /// Specifies a name for your agent. We recommend specifying a name that you can remember.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AgentName { get; set; }

        /// <summary>
        /// Checks to see if the AgentName property is set.
        /// </summary>
        internal bool IsSetAgentName() => this.AgentName != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupArns. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the security group that allows traffic
        /// between your agent and VPC service endpoint. You can only specify one ARN.
        /// </para>
        ///  
        /// <para>
        /// The ARN must specify your own account, even when the security group was shared with
        /// you from the account that owns the VPC. The security group must belong to the same
        /// VPC as the subnet that you specify in <c>SubnetArns</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> SecurityGroupArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupArns property is set.
        /// </summary>
        internal bool IsSetSecurityGroupArns() => this.SecurityGroupArns != null && (this.SecurityGroupArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetArns. 
        /// <para>
        /// Specifies the ARN of the subnet where DataSync creates the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/required-network-interfaces.html">network
        /// interfaces</a> that handle data transfer traffic for your tasks. You can only specify
        /// one ARN.
        /// </para>
        ///  
        /// <para>
        /// The subnet doesn't have to be the subnet that contains your VPC service endpoint.
        /// The subnet can be one that another Amazon Web Services account shared with you through
        /// <a href="https://docs.aws.amazon.com/ram/latest/userguide/what-is.html">RAM</a>, in
        /// which case the ARN must specify the account that owns the subnet. For more information,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choose-service-endpoint.html#vpc-endpoint-multiple-subnets">Using
        /// a single VPC service endpoint across multiple subnets</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> SubnetArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetArns property is set.
        /// </summary>
        internal bool IsSetSubnetArns() => this.SubnetArns != null && (this.SubnetArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies labels that help you categorize, filter, and search for your Amazon Web
        /// Services resources. We recommend creating at least one tag for your agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<TagListEntry> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<TagListEntry>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// <para>
        /// The endpoint ID is informational. DataSync doesn't verify it or use it to connect
        /// to your agent. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choose-service-endpoint.html#vpc-endpoint-multiple-subnets">Using
        /// a single VPC service endpoint across multiple subnets</a>.
        /// </para>
        /// </summary>
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;
    }
}
