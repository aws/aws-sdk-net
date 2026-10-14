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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFlowOperation operation. Returns key information
    /// about a specific flow operation.
    /// </summary>
    public partial class DescribeFlowOperationRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The ID of the Availability Zone where the firewall is located. For example, <c>us-east-2a</c>.
        /// </para>
        ///  
        /// <para>
        /// Defines the scope a flow operation. You can use up to 20 filters to configure a single
        /// flow operation.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string FirewallArn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallArn property is set.
        /// </summary>
        internal bool IsSetFirewallArn() => this.FirewallArn != null;

        /// <summary>
        /// Gets and sets the property FlowOperationId. 
        /// <para>
        /// A unique identifier for the flow operation. This ID is returned in the responses to
        /// start and list commands. You provide to describe commands.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string FlowOperationId { get; set; }

        /// <summary>
        /// Checks to see if the FlowOperationId property is set.
        /// </summary>
        internal bool IsSetFlowOperationId() => this.FlowOperationId != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a VPC endpoint association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string VpcEndpointAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointAssociationArn property is set.
        /// </summary>
        internal bool IsSetVpcEndpointAssociationArn() => this.VpcEndpointAssociationArn != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// A unique identifier for the primary endpoint associated with a firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 256)]
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;
    }
}
