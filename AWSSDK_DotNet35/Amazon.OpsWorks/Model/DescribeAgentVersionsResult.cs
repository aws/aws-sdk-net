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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeAgentVersions</code> request.
    /// </summary>
    public partial class DescribeAgentVersionsResult : AmazonWebServiceResponse
    {
        private List<AgentVersion> _agentVersions = new List<AgentVersion>();

        /// <summary>
        /// Gets and sets the property AgentVersions. 
        /// <para>
        /// The agent versions for the specified stack or configuration manager. Note that this
        /// value is the complete version number, not the abbreviated number used by the console.
        /// </para>
        /// </summary>
        public List<AgentVersion> AgentVersions
        {
            get { return this._agentVersions; }
            set { this._agentVersions = value; }
        }

        // Check to see if AgentVersions property is set
        internal bool IsSetAgentVersions()
        {
            return this._agentVersions != null && this._agentVersions.Count > 0; 
        }

    }
}