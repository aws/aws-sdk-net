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
    /// Container for the parameters to the StartCodeReviewJob operation.
    /// Starts a new code review job for a code review configuration. The job executes the
    /// security-focused code analysis defined in the code review.
    /// </summary>
    public partial class StartCodeReviewJobRequest : AmazonSecurityAgentRequest
    {
        private string _agentSpaceId;
        private string _codeReviewId;
        private DiffSource _diffSource;

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
        /// Gets and sets the property CodeReviewId. 
        /// <para>
        /// The unique identifier of the code review to start a job for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CodeReviewId
        {
            get { return this._codeReviewId; }
            set { this._codeReviewId = value; }
        }

        // Check to see if CodeReviewId property is set
        internal bool IsSetCodeReviewId()
        {
            return this._codeReviewId != null;
        }

        /// <summary>
        /// Gets and sets the property DiffSource. 
        /// <para>
        /// Source of the diff for a differential scan. When present, the job analyzes only the
        /// changed lines instead of performing a full scan.
        /// </para>
        /// </summary>
        public DiffSource DiffSource
        {
            get { return this._diffSource; }
            set { this._diffSource = value; }
        }

        // Check to see if DiffSource property is set
        internal bool IsSetDiffSource()
        {
            return this._diffSource != null;
        }

    }
}