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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterAgent operation. <note> <para> For use
    /// by AWS Ground Station Agent and shouldn't be called directly. </para> </note> <para>
    /// Registers a new agent with AWS Ground Station. </para>
    /// </summary>
    public partial class RegisterAgentRequest : AmazonGroundStationRequest
    {
        /// <summary>
        /// Gets and sets the property AgentDetails. 
        /// <para>
        /// Detailed information about the agent being registered.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentDetails AgentDetails { get; set; }

        /// <summary>
        /// Checks to see if the AgentDetails property is set.
        /// </summary>
        internal bool IsSetAgentDetails() => this.AgentDetails != null;

        /// <summary>
        /// Gets and sets the property DiscoveryData. 
        /// <para>
        /// Data for associating an agent with the capabilities it is managing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DiscoveryData DiscoveryData { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveryData property is set.
        /// </summary>
        internal bool IsSetDiscoveryData() => this.DiscoveryData != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to an <c>Agent</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
