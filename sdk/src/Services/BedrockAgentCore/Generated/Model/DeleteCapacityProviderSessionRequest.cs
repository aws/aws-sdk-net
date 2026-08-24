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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCapacityProviderSession operation.
    /// Deletes a session associated with a capacity provider in Amazon Bedrock AgentCore
    /// and makes the session unavailable for further use. To delete a capacity provider session,
    /// specify both the capacity provider identifier and the session ID. After you delete
    /// a session, you cannot restart it.
    /// </summary>
    public partial class DeleteCapacityProviderSessionRequest : AmazonBedrockAgentCoreRequest
    {
        private string _capacityProviderId;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property CapacityProviderId. 
        /// <para>
        /// The unique identifier of the capacity provider associated with the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=59)]
        public string CapacityProviderId
        {
            get { return this._capacityProviderId; }
            set { this._capacityProviderId = value; }
        }

        // Check to see if CapacityProviderId property is set
        internal bool IsSetCapacityProviderId()
        {
            return this._capacityProviderId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the capacity provider session to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}