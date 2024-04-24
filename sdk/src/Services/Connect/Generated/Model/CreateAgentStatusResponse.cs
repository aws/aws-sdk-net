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
    /// This is the response object from the CreateAgentStatus operation.
    /// </summary>
    public partial class CreateAgentStatusResponse : AmazonWebServiceResponse
    {
        private string _agentStatusARN;
        private string _agentStatusId;

        /// <summary>
        /// Gets and sets the property AgentStatusARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent status.
        /// </para>
        /// </summary>
        public string AgentStatusARN
        {
            get { return this._agentStatusARN; }
            set { this._agentStatusARN = value; }
        }

        // Check to see if AgentStatusARN property is set
        internal bool IsSetAgentStatusARN()
        {
            return this._agentStatusARN != null;
        }

        /// <summary>
        /// Gets and sets the property AgentStatusId. 
        /// <para>
        /// The identifier of the agent status.
        /// </para>
        /// </summary>
        public string AgentStatusId
        {
            get { return this._agentStatusId; }
            set { this._agentStatusId = value; }
        }

        // Check to see if AgentStatusId property is set
        internal bool IsSetAgentStatusId()
        {
            return this._agentStatusId != null;
        }

    }
}