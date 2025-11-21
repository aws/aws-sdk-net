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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
    /// Contains the filter to apply when retrieving metrics.
    /// </summary>
    public partial class Filters
    {
        private List<string> _agentStatuses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _channels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _queues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _routingProfiles = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _routingStepExpressions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AgentStatuses. 
        /// <para>
        /// A list of up to 50 agent status IDs or ARNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AgentStatuses
        {
            get { return this._agentStatuses; }
            set { this._agentStatuses = value; }
        }

        // Check to see if AgentStatuses property is set
        internal bool IsSetAgentStatuses()
        {
            return this._agentStatuses != null && (this._agentStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// The channel to use to filter the metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=4)]
        public List<string> Channels
        {
            get { return this._channels; }
            set { this._channels = value; }
        }

        // Check to see if Channels property is set
        internal bool IsSetChannels()
        {
            return this._channels != null && (this._channels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Queues. 
        /// <para>
        /// The queues to use to filter the metrics. You should specify at least one queue, and
        /// can specify up to 100 queues per request. The <c>GetCurrentMetricsData</c> API in
        /// particular requires a queue when you include a <c>Filter</c> in your request. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Queues
        {
            get { return this._queues; }
            set { this._queues = value; }
        }

        // Check to see if Queues property is set
        internal bool IsSetQueues()
        {
            return this._queues != null && (this._queues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoutingProfiles. 
        /// <para>
        /// A list of up to 100 routing profile IDs or ARNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> RoutingProfiles
        {
            get { return this._routingProfiles; }
            set { this._routingProfiles = value; }
        }

        // Check to see if RoutingProfiles property is set
        internal bool IsSetRoutingProfiles()
        {
            return this._routingProfiles != null && (this._routingProfiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoutingStepExpressions. 
        /// <para>
        /// A list of expressions as a filter, in which an expression is an object of a step in
        /// a routing criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> RoutingStepExpressions
        {
            get { return this._routingStepExpressions; }
            set { this._routingStepExpressions = value; }
        }

        // Check to see if RoutingStepExpressions property is set
        internal bool IsSetRoutingStepExpressions()
        {
            return this._routingStepExpressions != null && (this._routingStepExpressions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}