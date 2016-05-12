/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Information about agents that were instructed to start collecting data. Information
    /// includes the agent ID, a description of the operation, and whether or not the agent
    /// configuration was updated.
    /// </summary>
    public partial class AgentConfigStatus
    {
        private string _agentId;
        private bool? _configUpdated;
        private string _description;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The agent ID.
        /// </para>
        /// </summary>
        public string AgentId
        {
            get { return this._agentId; }
            set { this._agentId = value; }
        }

        // Check to see if AgentId property is set
        internal bool IsSetAgentId()
        {
            return this._agentId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigUpdated. 
        /// <para>
        /// Information about whether or not the agent configuration was updated.
        /// </para>
        /// </summary>
        public bool ConfigUpdated
        {
            get { return this._configUpdated.GetValueOrDefault(); }
            set { this._configUpdated = value; }
        }

        // Check to see if ConfigUpdated property is set
        internal bool IsSetConfigUpdated()
        {
            return this._configUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the operation performed.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

    }
}