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
    /// Container for the parameters to the StartFlowFlush operation.
    /// Begins the flushing of traffic from the firewall, according to the filters you define.
    /// When the operation starts, impacted flows are temporarily marked as timed out before
    /// the Suricata engine prunes, or flushes, the flows from the firewall table.
    /// 
    ///  <important> 
    /// <para>
    /// While the flush completes, impacted flows are processed as midstream traffic. This
    /// may result in a temporary increase in midstream traffic metrics. We recommend that
    /// you double check your stream exception policy before you perform a flush operation.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class StartFlowFlushRequest : AmazonNetworkFirewallRequest
    {
        private string _availabilityZone;
        private string _firewallArn;
        private List<FlowFilter> _flowFilters = AWSConfigs.InitializeCollections ? new List<FlowFilter>() : null;
        private int? _minimumFlowAgeInSeconds;
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
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property FlowFilters. 
        /// <para>
        /// Defines the scope a flow operation. You can use up to 20 filters to configure a single
        /// flow operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FlowFilter> FlowFilters
        {
            get { return this._flowFilters; }
            set { this._flowFilters = value; }
        }

        // Check to see if FlowFilters property is set
        internal bool IsSetFlowFilters()
        {
            return this._flowFilters != null && (this._flowFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MinimumFlowAgeInSeconds. 
        /// <para>
        /// The reqested <c>FlowOperation</c> ignores flows with an age (in seconds) lower than
        /// <c>MinimumFlowAgeInSeconds</c>. You provide this for start commands.
        /// </para>
        /// </summary>
        public int? MinimumFlowAgeInSeconds
        {
            get { return this._minimumFlowAgeInSeconds; }
            set { this._minimumFlowAgeInSeconds = value; }
        }

        // Check to see if MinimumFlowAgeInSeconds property is set
        internal bool IsSetMinimumFlowAgeInSeconds()
        {
            return this._minimumFlowAgeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a VPC endpoint association.
        /// </para>
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
        /// <para>
        /// A unique identifier for the primary endpoint associated with a firewall.
        /// </para>
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