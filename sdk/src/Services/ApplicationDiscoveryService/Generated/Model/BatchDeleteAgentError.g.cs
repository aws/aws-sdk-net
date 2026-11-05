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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// An object representing the agent or data collector that failed to delete, each containing
    /// agentId, errorMessage, and errorCode.
    /// </summary>
    public partial class BatchDeleteAgentError
    {
        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        ///  The ID of the agent or data collector to delete. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 20)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  The type of error that occurred for the delete failed agent. Valid status are: AGENT_IN_USE
        /// | NOT_FOUND | INTERNAL_SERVER_ERROR. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeleteAgentErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        ///  The description of the error that occurred for the delete failed agent. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10000)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;
    }
}
