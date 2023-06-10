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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// This is the response object from the GetAgentConfiguration operation.
    /// </summary>
    public partial class GetAgentConfigurationResponse : AmazonWebServiceResponse
    {
        private string _agentId;
        private string _taskingDocument;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// UUID of agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property TaskingDocument. 
        /// <para>
        /// Tasking document for agent.
        /// </para>
        /// </summary>
        public string TaskingDocument
        {
            get { return this._taskingDocument; }
            set { this._taskingDocument = value; }
        }

        // Check to see if TaskingDocument property is set
        internal bool IsSetTaskingDocument()
        {
            return this._taskingDocument != null;
        }

    }
}