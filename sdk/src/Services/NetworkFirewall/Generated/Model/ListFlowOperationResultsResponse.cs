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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
    /// This is the response object from the ListFlowOperationResults operation.
    /// </summary>
    public partial class ListFlowOperationResultsResponse : AmazonWebServiceResponse
    {
        private string _availabilityZone;
        private string _firewallArn;
        private string _flowOperationId;
        private FlowOperationStatus _flowOperationStatus;
        private DateTime? _flowRequestTimestamp;
        private List<Flow> _flows = AWSConfigs.InitializeCollections ? new List<Flow>() : null;
        private string _nextToken;
        private string _statusMessage;
        private string _vpcEndpointAssociationArn;
        private string _vpcEndpointId;

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
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string FirewallArn
        {
            get { return this._firewallArn; }
            set { this._firewallArn = value; }
        }

        // Check to see if FirewallArn property is set
        internal bool IsSetFirewallArn()
        {
            return this._firewallArn != null;
        }

        /// <summary>
        /// Gets and sets the property FlowOperationId. 
        /// <para>
        /// A unique identifier for the flow operation. This ID is returned in the responses to
        /// start and list commands. You provide to describe commands.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string FlowOperationId
        {
            get { return this._flowOperationId; }
            set { this._flowOperationId = value; }
        }

        // Check to see if FlowOperationId property is set
        internal bool IsSetFlowOperationId()
        {
            return this._flowOperationId != null;
        }

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
        public FlowOperationStatus FlowOperationStatus
        {
            get { return this._flowOperationStatus; }
            set { this._flowOperationStatus = value; }
        }

        // Check to see if FlowOperationStatus property is set
        internal bool IsSetFlowOperationStatus()
        {
            return this._flowOperationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FlowRequestTimestamp. 
        /// <para>
        /// A timestamp indicating when the Suricata engine identified flows impacted by an operation.
        /// 
        /// </para>
        /// </summary>
        public DateTime? FlowRequestTimestamp
        {
            get { return this._flowRequestTimestamp; }
            set { this._flowRequestTimestamp = value; }
        }

        // Check to see if FlowRequestTimestamp property is set
        internal bool IsSetFlowRequestTimestamp()
        {
            return this._flowRequestTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Flows. 
        /// <para>
        /// Any number of arrays, where each array is a single flow identified in the scope of
        /// the operation. If multiple flows were in the scope of the operation, multiple <c>Flows</c>
        /// arrays are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Flow> Flows
        {
            get { return this._flows; }
            set { this._flows = value; }
        }

        // Check to see if Flows property is set
        internal bool IsSetFlows()
        {
            return this._flows != null && (this._flows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When you request a list of objects with a <c>MaxResults</c> setting, if the number
        /// of objects that are still available for retrieval exceeds the maximum you requested,
        /// Network Firewall returns a <c>NextToken</c> value in the response. To retrieve the
        /// next batch of objects, use the token returned from the prior request in your next
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// If the asynchronous operation fails, Network Firewall populates this with the reason
        /// for the error or failure. Options include <c>Flow operation error</c> and <c>Flow
        /// timeout</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointAssociationArn.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string VpcEndpointAssociationArn
        {
            get { return this._vpcEndpointAssociationArn; }
            set { this._vpcEndpointAssociationArn = value; }
        }

        // Check to see if VpcEndpointAssociationArn property is set
        internal bool IsSetVpcEndpointAssociationArn()
        {
            return this._vpcEndpointAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId.
        /// </summary>
        [AWSProperty(Min=5, Max=256)]
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