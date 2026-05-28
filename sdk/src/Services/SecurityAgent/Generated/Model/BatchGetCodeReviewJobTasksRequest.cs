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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetCodeReviewJobTasks operation.
    /// Retrieves information about one or more tasks within a code review job.
    /// </summary>
    public partial class BatchGetCodeReviewJobTasksRequest : AmazonSecurityAgentRequest
    {
        private string _agentSpaceId;
        private List<string> _codeReviewJobTaskIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space that contains the tasks.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentSpaceId
        {
            get { return this._agentSpaceId; }
            set { this._agentSpaceId = value; }
        }

        // Check to see if AgentSpaceId property is set
        internal bool IsSetAgentSpaceId()
        {
            return this._agentSpaceId != null;
        }

        /// <summary>
        /// Gets and sets the property CodeReviewJobTaskIds. 
        /// <para>
        /// The list of task identifiers to retrieve.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> CodeReviewJobTaskIds
        {
            get { return this._codeReviewJobTaskIds; }
            set { this._codeReviewJobTaskIds = value; }
        }

        // Check to see if CodeReviewJobTaskIds property is set
        internal bool IsSetCodeReviewJobTaskIds()
        {
            return this._codeReviewJobTaskIds != null && (this._codeReviewJobTaskIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}