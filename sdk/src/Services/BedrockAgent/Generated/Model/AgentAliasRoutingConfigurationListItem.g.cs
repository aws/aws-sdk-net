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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains details about the routing configuration of the alias.
    /// </summary>
    public partial class AgentAliasRoutingConfigurationListItem
    {
        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version of the agent with which the alias is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentVersion property is set.
        /// </summary>
        internal bool IsSetAgentVersion() => this.AgentVersion != null;

        /// <summary>
        /// Gets and sets the property ProvisionedThroughput. 
        /// <para>
        /// Information on the Provisioned Throughput assigned to an agent alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ProvisionedThroughput { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedThroughput property is set.
        /// </summary>
        internal bool IsSetProvisionedThroughput() => this.ProvisionedThroughput != null;
    }
}
