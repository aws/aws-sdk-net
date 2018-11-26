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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// A list of Amazon Resource Names (ARNs) of agents to use for a Network File System
    /// (NFS) location.
    /// </summary>
    public partial class OnPremConfig
    {
        private List<string> _agentArns = new List<string>();

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// ARNs)of the agents to use for an NFS location.
        /// </para>
        /// </summary>
        public List<string> AgentArns
        {
            get { return this._agentArns; }
            set { this._agentArns = value; }
        }

        // Check to see if AgentArns property is set
        internal bool IsSetAgentArns()
        {
            return this._agentArns != null && this._agentArns.Count > 0; 
        }

    }
}