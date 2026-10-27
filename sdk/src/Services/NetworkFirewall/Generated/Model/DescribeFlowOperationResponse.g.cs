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
    /// This is the response object from the DescribeFlowOperation operation.
    /// </summary>
    public partial class DescribeFlowOperationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone where the firewall is located. For example, <c>us-east-2a</c>.
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
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone where the firewall is located. For example, <c>use2-az1</c>.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FirewallArn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallArn property is set.
        /// </summary>
        internal bool IsSetFirewallArn() => this.FirewallArn != null;

        /// <summary>
        /// Gets and sets the property FlowOperation. 
        /// <para>
        /// Returns key information about a flow operation, such as related statuses, unique identifiers,
        /// and all filters defined in the operation.
        /// </para>
        /// </summary>
        public FlowOperation FlowOperation { get; set; }

        /// <summary>
        /// Checks to see if the FlowOperation property is set.
        /// </summary>
        internal bool IsSetFlowOperation() => this.FlowOperation != null;

        /// <summary>
        /// Gets and sets the property FlowOperationId. 
        /// <para>
        /// A unique identifier for the flow operation. This ID is returned in the responses to
        /// start and list commands. You provide to describe commands.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string FlowOperationId { get; set; }

        /// <summary>
        /// Checks to see if the FlowOperationId property is set.
        /// </summary>
        internal bool IsSetFlowOperationId() => this.FlowOperationId != null;

        /// <summary>
        /// Gets and sets the property FlowOperationStatus. 
        /// <para>
        /// Returns the status of the flow operation. This string is returned in the responses
        /// to start, list, and describe commands.
        /// </para>
        ///  
        /// <para>
        /// If the status is <c>COMPLETED_WITH_ERRORS</c>, results may be returned with any number
        /// of <c>Flows</c> missing from the response. If the status is <c>FAILED</c>, <c>Flows</c>
        /// returned will be empty.
        /// </para>
        /// </summary>
        public FlowOperationStatus FlowOperationStatus { get; set; }

        /// <summary>
        /// Checks to see if the FlowOperationStatus property is set.
        /// </summary>
        internal bool IsSetFlowOperationStatus() => this.FlowOperationStatus != null;

        /// <summary>
        /// Gets and sets the property FlowOperationType. 
        /// <para>
        /// Defines the type of <c>FlowOperation</c>.
        /// </para>
        /// </summary>
        public FlowOperationType FlowOperationType { get; set; }

        /// <summary>
        /// Checks to see if the FlowOperationType property is set.
        /// </summary>
        internal bool IsSetFlowOperationType() => this.FlowOperationType != null;

        /// <summary>
        /// Gets and sets the property FlowRequestTimestamp. 
        /// <para>
        /// A timestamp indicating when the Suricata engine identified flows impacted by an operation.
        /// 
        /// </para>
        /// </summary>
        public DateTime? FlowRequestTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the FlowRequestTimestamp property is set.
        /// </summary>
        internal bool IsSetFlowRequestTimestamp() => this.FlowRequestTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// If the asynchronous operation fails, Network Firewall populates this with the reason
        /// for the error or failure. Options include <c>Flow operation error</c> and <c>Flow
        /// timeout</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

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
