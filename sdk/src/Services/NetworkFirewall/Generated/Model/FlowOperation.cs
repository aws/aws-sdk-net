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
    /// Contains information about a flow operation, such as related statuses, unique identifiers,
    /// and all filters defined in the operation.
    /// 
    ///  
    /// <para>
    /// Flow operations let you manage the flows tracked in the flow table, also known as
    /// the firewall table.
    /// </para>
    ///  
    /// <para>
    /// A flow is network traffic that is monitored by a firewall, either by stateful or stateless
    /// rules. For traffic to be considered part of a flow, it must share Destination, DestinationPort,
    /// Direction, Protocol, Source, and SourcePort. 
    /// </para>
    /// </summary>
    public partial class FlowOperation
    {
        private List<FlowFilter> _flowFilters = AWSConfigs.InitializeCollections ? new List<FlowFilter>() : null;
        private int? _minimumFlowAgeInSeconds;

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

    }
}