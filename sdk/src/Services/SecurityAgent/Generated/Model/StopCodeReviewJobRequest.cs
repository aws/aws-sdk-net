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
    /// Container for the parameters to the StopCodeReviewJob operation.
    /// Stops a running code review job. The job transitions to a stopping state and then
    /// to stopped after cleanup completes.
    /// </summary>
    public partial class StopCodeReviewJobRequest : AmazonSecurityAgentRequest
    {
        private string _agentSpaceId;
        private string _codeReviewJobId;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space.
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
        /// Gets and sets the property CodeReviewJobId. 
        /// <para>
        /// The unique identifier of the code review job to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CodeReviewJobId
        {
            get { return this._codeReviewJobId; }
            set { this._codeReviewJobId = value; }
        }

        // Check to see if CodeReviewJobId property is set
        internal bool IsSetCodeReviewJobId()
        {
            return this._codeReviewJobId != null;
        }

    }
}