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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// An object representing the agent or data collector that failed to delete, each containing
    /// agentId, errorMessage, and errorCode.
    /// </summary>
    public partial class BatchDeleteAgentError
    {
        private string _agentId;
        private DeleteAgentErrorCode _errorCode;
        private string _errorMessage;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        ///  The ID of the agent or data collector to delete. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=20)]
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
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  The type of error that occurred for the delete failed agent. Valid status are: AGENT_IN_USE
        /// | NOT_FOUND | INTERNAL_SERVER_ERROR. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeleteAgentErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        ///  The description of the error that occurred for the delete failed agent. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10000)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

    }
}