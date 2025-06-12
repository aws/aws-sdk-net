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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Contains information about an Amazon Inspector agent. This data type is used as a
    /// request parameter in the <a>ListAssessmentRunAgents</a> action.
    /// </summary>
    public partial class AgentFilter
    {
        private List<string> _agentHealthCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _agentHealths = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AgentHealthCodes. 
        /// <para>
        /// The detailed health state of the agent. Values can be set to <b>IDLE</b>, <b>RUNNING</b>,
        /// <b>SHUTDOWN</b>, <b>UNHEALTHY</b>, <b>THROTTLED</b>, and <b>UNKNOWN</b>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<string> AgentHealthCodes
        {
            get { return this._agentHealthCodes; }
            set { this._agentHealthCodes = value; }
        }

        // Check to see if AgentHealthCodes property is set
        internal bool IsSetAgentHealthCodes()
        {
            return this._agentHealthCodes != null && (this._agentHealthCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AgentHealths. 
        /// <para>
        /// The current health state of the agent. Values can be set to <b>HEALTHY</b> or <b>UNHEALTHY</b>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<string> AgentHealths
        {
            get { return this._agentHealths; }
            set { this._agentHealths = value; }
        }

        // Check to see if AgentHealths property is set
        internal bool IsSetAgentHealths()
        {
            return this._agentHealths != null && (this._agentHealths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}